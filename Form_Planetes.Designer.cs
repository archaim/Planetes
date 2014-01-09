namespace Planetes
{
    partial class Form_Planetes
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
            this.glControl = new OpenTK.GLControl();
            this.trackBar_levelOfDetail = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_levelOfDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl
            // 
            this.glControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(12, 12);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(544, 490);
            this.glControl.TabIndex = 0;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.Resize += new System.EventHandler(this.glControl_Resize);
            // 
            // trackBar_levelOfDetail
            // 
            this.trackBar_levelOfDetail.Location = new System.Drawing.Point(562, 12);
            this.trackBar_levelOfDetail.Maximum = 7;
            this.trackBar_levelOfDetail.Name = "trackBar_levelOfDetail";
            this.trackBar_levelOfDetail.Size = new System.Drawing.Size(248, 45);
            this.trackBar_levelOfDetail.TabIndex = 1;
            this.trackBar_levelOfDetail.ValueChanged += new System.EventHandler(this.trackBar_levelOfDetail_ValueChanged);
            // 
            // Form_Planetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 514);
            this.Controls.Add(this.trackBar_levelOfDetail);
            this.Controls.Add(this.glControl);
            this.Name = "Form_Planetes";
            this.Text = "PLANETES";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_levelOfDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl;
        private System.Windows.Forms.TrackBar trackBar_levelOfDetail;
    }
}

