namespace HQ2xTestUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.m_PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.m_ZoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_SaveAsButton = new System.Windows.Forms.Button();
            this.m_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.m_AfterView = new HQ2xTestUI.BitmapView();
            this.m_BeforeView = new HQ2xTestUI.BitmapView();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.m_PropertyGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_AfterView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.m_BeforeView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_SaveAsButton, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 715);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // m_PropertyGrid
            // 
            this.m_PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_PropertyGrid.Location = new System.Drawing.Point(3, 3);
            this.m_PropertyGrid.Name = "m_PropertyGrid";
            this.tableLayoutPanel1.SetRowSpan(this.m_PropertyGrid, 3);
            this.m_PropertyGrid.Size = new System.Drawing.Size(244, 709);
            this.m_PropertyGrid.TabIndex = 1;
            this.m_PropertyGrid.TabStop = false;
            this.m_PropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.m_PropertyGrid_PropertyValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ZoomLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 718);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(712, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "m_ZoomLabel";
            // 
            // m_ZoomLabel
            // 
            this.m_ZoomLabel.Name = "m_ZoomLabel";
            this.m_ZoomLabel.Size = new System.Drawing.Size(83, 17);
            this.m_ZoomLabel.Text = "m_ZoomLabel";
            // 
            // m_SaveAsButton
            // 
            this.m_SaveAsButton.Location = new System.Drawing.Point(253, 689);
            this.m_SaveAsButton.Name = "m_SaveAsButton";
            this.m_SaveAsButton.Size = new System.Drawing.Size(75, 23);
            this.m_SaveAsButton.TabIndex = 4;
            this.m_SaveAsButton.Text = "Save As...";
            this.m_SaveAsButton.UseVisualStyleBackColor = true;
            this.m_SaveAsButton.Click += new System.EventHandler(this.m_SaveAsButton_Click);
            // 
            // m_SaveFileDialog
            // 
            this.m_SaveFileDialog.DefaultExt = "png";
            this.m_SaveFileDialog.Filter = "PNG File|*.png|All Files|*.*";
            // 
            // m_AfterView
            // 
            this.m_AfterView.BackgroundBitmap = global::HQ2xTestUI.Properties.Resources.TransparentBackground;
            this.m_AfterView.Bitmap = null;
            this.m_AfterView.BitmapScale = 1F;
            this.m_AfterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_AfterView.Location = new System.Drawing.Point(253, 346);
            this.m_AfterView.Name = "m_AfterView";
            this.m_AfterView.Size = new System.Drawing.Size(456, 337);
            this.m_AfterView.TabIndex = 3;
            this.m_AfterView.TabStop = false;
            // 
            // m_BeforeView
            // 
            this.m_BeforeView.BackgroundBitmap = global::HQ2xTestUI.Properties.Resources.TransparentBackground;
            this.m_BeforeView.Bitmap = null;
            this.m_BeforeView.BitmapScale = 1F;
            this.m_BeforeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_BeforeView.Location = new System.Drawing.Point(253, 3);
            this.m_BeforeView.Name = "m_BeforeView";
            this.m_BeforeView.Size = new System.Drawing.Size(456, 337);
            this.m_BeforeView.TabIndex = 2;
            this.m_BeforeView.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 740);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "HQX Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PropertyGrid m_PropertyGrid;
        private BitmapView m_BeforeView;
        private BitmapView m_AfterView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel m_ZoomLabel;
        private System.Windows.Forms.Button m_SaveAsButton;
        private System.Windows.Forms.SaveFileDialog m_SaveFileDialog;


    }
}

