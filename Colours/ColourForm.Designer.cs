namespace ColoursForm
{
    partial class ColourForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel panel1;
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.ColourBox = new System.Windows.Forms.PictureBox();
            this.toolTipColour = new System.Windows.Forms.ToolTip(this.components);
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(this.label3);
            panel1.Controls.Add(this.label2);
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.trackBarRed);
            panel1.Controls.Add(this.trackBarBlue);
            panel1.Controls.Add(this.trackBarGreen);
            panel1.Location = new System.Drawing.Point(347, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(430, 162);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red:";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(116, 3);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(306, 45);
            this.trackBarRed.TabIndex = 0;
            this.toolTipColour.SetToolTip(this.trackBarRed, "125");
            this.trackBarRed.Value = 125;
            this.trackBarRed.Scroll += new System.EventHandler(this.labelRed_Click);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(116, 105);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(306, 45);
            this.trackBarBlue.TabIndex = 2;
            this.toolTipColour.SetToolTip(this.trackBarBlue, "125");
            this.trackBarBlue.Value = 125;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.labelBlue_Click);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(116, 54);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(306, 45);
            this.trackBarGreen.TabIndex = 1;
            this.toolTipColour.SetToolTip(this.trackBarGreen, "125");
            this.trackBarGreen.Value = 125;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.labelGreen_Click);
            // 
            // ColourBox
            // 
            this.ColourBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColourBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColourBox.Location = new System.Drawing.Point(13, 13);
            this.ColourBox.Name = "ColourBox";
            this.ColourBox.Size = new System.Drawing.Size(325, 166);
            this.ColourBox.TabIndex = 4;
            this.ColourBox.TabStop = false;
            this.toolTipColour.SetToolTip(this.ColourBox, "#7D7D7D");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 191);
            this.Controls.Add(this.ColourBox);
            this.Controls.Add(panel1);
            this.MinimumSize = new System.Drawing.Size(805, 230);
            this.Name = "Form1";
            this.Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.PictureBox ColourBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipColour;
    }
}

