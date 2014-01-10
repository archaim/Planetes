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
            this.groupBox_LevelOfDetail = new System.Windows.Forms.GroupBox();
            this.label_LevelOfDetailMin = new System.Windows.Forms.Label();
            this.label_LevelOfDetailMax = new System.Windows.Forms.Label();
            this.groupBox_Rotation = new System.Windows.Forms.GroupBox();
            this.trackBar_Rotation = new System.Windows.Forms.TrackBar();
            this.label_RotationMin = new System.Windows.Forms.Label();
            this.label_RotationMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_levelOfDetail)).BeginInit();
            this.groupBox_LevelOfDetail.SuspendLayout();
            this.groupBox_Rotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rotation)).BeginInit();
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
            this.trackBar_levelOfDetail.Location = new System.Drawing.Point(6, 19);
            this.trackBar_levelOfDetail.Maximum = 7;
            this.trackBar_levelOfDetail.Name = "trackBar_levelOfDetail";
            this.trackBar_levelOfDetail.Size = new System.Drawing.Size(236, 45);
            this.trackBar_levelOfDetail.TabIndex = 1;
            this.trackBar_levelOfDetail.ValueChanged += new System.EventHandler(this.trackBar_levelOfDetail_ValueChanged);
            // 
            // groupBox_LevelOfDetail
            // 
            this.groupBox_LevelOfDetail.Controls.Add(this.label_LevelOfDetailMax);
            this.groupBox_LevelOfDetail.Controls.Add(this.label_LevelOfDetailMin);
            this.groupBox_LevelOfDetail.Controls.Add(this.trackBar_levelOfDetail);
            this.groupBox_LevelOfDetail.Location = new System.Drawing.Point(562, 12);
            this.groupBox_LevelOfDetail.Name = "groupBox_LevelOfDetail";
            this.groupBox_LevelOfDetail.Size = new System.Drawing.Size(248, 72);
            this.groupBox_LevelOfDetail.TabIndex = 2;
            this.groupBox_LevelOfDetail.TabStop = false;
            this.groupBox_LevelOfDetail.Text = "Уровень детализации";
            // 
            // label_LevelOfDetailMin
            // 
            this.label_LevelOfDetailMin.AutoSize = true;
            this.label_LevelOfDetailMin.Location = new System.Drawing.Point(13, 51);
            this.label_LevelOfDetailMin.Name = "label_LevelOfDetailMin";
            this.label_LevelOfDetailMin.Size = new System.Drawing.Size(13, 13);
            this.label_LevelOfDetailMin.TabIndex = 2;
            this.label_LevelOfDetailMin.Text = "0";
            // 
            // label_LevelOfDetailMax
            // 
            this.label_LevelOfDetailMax.AutoSize = true;
            this.label_LevelOfDetailMax.Location = new System.Drawing.Point(223, 51);
            this.label_LevelOfDetailMax.Name = "label_LevelOfDetailMax";
            this.label_LevelOfDetailMax.Size = new System.Drawing.Size(13, 13);
            this.label_LevelOfDetailMax.TabIndex = 3;
            this.label_LevelOfDetailMax.Text = "7";
            // 
            // groupBox_Rotation
            // 
            this.groupBox_Rotation.Controls.Add(this.label_RotationMax);
            this.groupBox_Rotation.Controls.Add(this.label_RotationMin);
            this.groupBox_Rotation.Controls.Add(this.trackBar_Rotation);
            this.groupBox_Rotation.Location = new System.Drawing.Point(562, 90);
            this.groupBox_Rotation.Name = "groupBox_Rotation";
            this.groupBox_Rotation.Size = new System.Drawing.Size(248, 72);
            this.groupBox_Rotation.TabIndex = 3;
            this.groupBox_Rotation.TabStop = false;
            this.groupBox_Rotation.Text = "Вращение";
            // 
            // trackBar_Rotation
            // 
            this.trackBar_Rotation.LargeChange = 10;
            this.trackBar_Rotation.Location = new System.Drawing.Point(6, 19);
            this.trackBar_Rotation.Maximum = 360;
            this.trackBar_Rotation.Name = "trackBar_Rotation";
            this.trackBar_Rotation.Size = new System.Drawing.Size(236, 45);
            this.trackBar_Rotation.TabIndex = 0;
            this.trackBar_Rotation.TickFrequency = 10;
            this.trackBar_Rotation.ValueChanged += new System.EventHandler(this.trackBar_Rotation_ValueChanged);
            // 
            // label_RotationMin
            // 
            this.label_RotationMin.AutoSize = true;
            this.label_RotationMin.Location = new System.Drawing.Point(13, 51);
            this.label_RotationMin.Name = "label_RotationMin";
            this.label_RotationMin.Size = new System.Drawing.Size(13, 13);
            this.label_RotationMin.TabIndex = 1;
            this.label_RotationMin.Text = "0";
            // 
            // label_RotationMax
            // 
            this.label_RotationMax.AutoSize = true;
            this.label_RotationMax.Location = new System.Drawing.Point(217, 51);
            this.label_RotationMax.Name = "label_RotationMax";
            this.label_RotationMax.Size = new System.Drawing.Size(25, 13);
            this.label_RotationMax.TabIndex = 2;
            this.label_RotationMax.Text = "360";
            // 
            // Form_Planetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 514);
            this.Controls.Add(this.groupBox_Rotation);
            this.Controls.Add(this.groupBox_LevelOfDetail);
            this.Controls.Add(this.glControl);
            this.Name = "Form_Planetes";
            this.Text = "PLANETES";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_levelOfDetail)).EndInit();
            this.groupBox_LevelOfDetail.ResumeLayout(false);
            this.groupBox_LevelOfDetail.PerformLayout();
            this.groupBox_Rotation.ResumeLayout(false);
            this.groupBox_Rotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rotation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl;
        private System.Windows.Forms.TrackBar trackBar_levelOfDetail;
        private System.Windows.Forms.GroupBox groupBox_LevelOfDetail;
        private System.Windows.Forms.Label label_LevelOfDetailMax;
        private System.Windows.Forms.Label label_LevelOfDetailMin;
        private System.Windows.Forms.GroupBox groupBox_Rotation;
        private System.Windows.Forms.Label label_RotationMax;
        private System.Windows.Forms.Label label_RotationMin;
        private System.Windows.Forms.TrackBar trackBar_Rotation;
    }
}

