namespace AnnoyingButtonForm
{
    partial class AnnoyingButton
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
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Button.Location = new System.Drawing.Point(204, 217);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 25);
            this.Button.TabIndex = 0;
            this.Button.Text = "Push me!";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // AnnoyingButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Button);
            this.MinimumSize = new System.Drawing.Size(114, 66);
            this.Name = "AnnoyingButton";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnnoyingButton";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnnoyingButton_MouseMove);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button;
    }
}

