// (C) Copyright 2011 Ivan Neeson
// Use, modification and distribution are subject to the 
// Boost Software License, Version 1.0. (See accompanying file 
// LICENSE_1_0.txt or copy at http://www.boost.org/LICENSE_1_0.txt)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace HQ2xTestUI
{
    public partial class MainForm : Form
    {
        private Bitmap m_BeforeBitmap;
        private Bitmap m_AfterBitmap;
        private int m_DisplayScale = 0;
        private HqxOptions m_HqxOptions = new HqxOptions();

        public Bitmap BeforeBitmap
        {
            get { return m_BeforeBitmap; }
            set
            {
                m_BeforeBitmap = value;
                Refilter();
            }
        }

        public int DisplayScale
        {
            get { return m_DisplayScale; }
            set
            {
                if (value >= -1 && value < 4)
                {
                    m_DisplayScale = value;
                    Refilter();
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            MouseWheel += new MouseEventHandler(MainForm_MouseWheel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_PropertyGrid.SelectedObject = m_HqxOptions;
            Refilter();
        }

        private void Refilter()
        {
            if (m_BeforeBitmap != null)
            {
                HQ2x.ILerp lerp;
                HQ2x.IThreshold threshold;

                switch (m_HqxOptions.Mode)
                {
                    default:
                    case HQ2xMode.ColorOnly:
                        lerp = new HQ2x.ColorOnlyLerp();
                        threshold = new HQ2x.ColorOnlyThreshold(m_HqxOptions.YThreshold, m_HqxOptions.UThreshold, m_HqxOptions.VThreshold);
                        break;
                    case HQ2xMode.ColorSimpleAlpha:
                        lerp = new HQ2x.ColorSimpleAlphaLerp();
                        threshold = new HQ2x.ColorSimpleAlphaThreshold(m_HqxOptions.YThreshold, m_HqxOptions.UThreshold, m_HqxOptions.VThreshold, m_HqxOptions.AThreshold);
                        break;
                    case HQ2xMode.ColorAlpha:
                        lerp = new HQ2x.ColorAlphaLerp();
                        threshold = new HQ2x.ColorAlphaThreshold(m_HqxOptions.YThreshold, m_HqxOptions.UThreshold, m_HqxOptions.VThreshold, m_HqxOptions.AThreshold);
                        break;
                }

                HQ2x.Engine engine = new HQ2x.Engine(lerp, threshold);

                m_AfterBitmap = engine.Process(m_BeforeBitmap);

                m_BeforeView.Bitmap = m_BeforeBitmap;
                m_BeforeView.BitmapScale = (float)(2 * Math.Pow(2, m_DisplayScale));

                m_AfterView.Bitmap = m_AfterBitmap;
                m_AfterView.BitmapScale = (float)(Math.Pow(2, m_DisplayScale));
            }
            else
            {
                m_BeforeBitmap = null;
                m_AfterBitmap = null;
                m_BeforeView.Bitmap = null;
                m_AfterView.Bitmap = null;
            }

            m_ZoomLabel.Text = string.Format("{0}%", (int)(100 * Math.Pow(2, m_DisplayScale)));
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            Array fileArray = e.Data.GetData(DataFormats.FileDrop) as Array;

            if (fileArray != null && fileArray.Length > 0)
            {
                string filePath = fileArray.GetValue(0).ToString();
                BeginInvoke((Action)delegate()
                {
                    OpenFile(filePath);
                }
                );
            }
        }

        private void MainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                DisplayScale = DisplayScale + 1;
            else if (e.Delta < 0)
                DisplayScale = DisplayScale - 1;
        }

        private void OpenFile(string filePath)
        {
            try
            {
                Bitmap bitmap = Bitmap.FromFile(filePath) as Bitmap;

                if (bitmap != null)
                    BeforeBitmap = bitmap;
            }
            catch (Exception)
            {
            }
        }

        private void m_PropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Refilter();
        }

        private void m_SaveAsButton_Click(object sender, EventArgs e)
        {
            if (m_AfterBitmap != null)
            {
                DialogResult r = m_SaveFileDialog.ShowDialog();

                if (r == DialogResult.OK)
                {
                    using (Stream s = m_SaveFileDialog.OpenFile())
                    {
                        m_AfterBitmap.Save(s, ImageFormat.Png);
                    }
                }
            }
        }
    }
}
