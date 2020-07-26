// (C) Copyright 2011 Ivan Neeson
// Use, modification and distribution are subject to the 
// Boost Software License, Version 1.0. (See accompanying file 
// LICENSE_1_0.txt or copy at http://www.boost.org/LICENSE_1_0.txt)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HQ2xTestUI
{
    public partial class BitmapView : UserControl
    {
        private Bitmap m_BackgroundBitmap;
        private Bitmap m_Bitmap;
        private float m_BitmapScale = 1.0f;

        public Bitmap BackgroundBitmap
        {
            get { return m_BackgroundBitmap; }
            set
            {
                m_BackgroundBitmap = value;
                Invalidate();
            }
        }

        public Bitmap Bitmap
        {
            get { return m_Bitmap; }
            set
            {
                m_Bitmap = value;
                Invalidate();
            }
        }

        public float BitmapScale
        {
            get { return m_BitmapScale; }
            set
            {
                m_BitmapScale = value;
                Invalidate();
            }
        }

        public BitmapView()
        {
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (m_BackgroundBitmap != null)
            {
                TextureBrush brush = new TextureBrush(m_BackgroundBitmap, WrapMode.Tile);
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
            else
            {
                e.Graphics.Clear(Color.Black);
            }

            if (m_Bitmap != null)
            {
                Size scaleSize = m_Bitmap.Size;
                scaleSize.Width = (int)Math.Floor(scaleSize.Width * m_BitmapScale);
                scaleSize.Height = (int)Math.Floor(scaleSize.Height * m_BitmapScale);

                Rectangle rect = new Rectangle();
                rect.X = (Width - scaleSize.Width) / 2;
                rect.Y = (Height - scaleSize.Height) / 2;
                rect.Width = scaleSize.Width;
                rect.Height = scaleSize.Height;

                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.DrawImage(m_Bitmap, rect);
            }
        }
    }
}
