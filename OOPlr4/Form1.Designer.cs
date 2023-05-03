namespace OOPlr4
{
    partial class Form1
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
            this.checkBox_CTRL = new System.Windows.Forms.CheckBox();
            this.checkBox_Multiple = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_CTRL
            // 
            this.checkBox_CTRL.AutoSize = true;
            this.checkBox_CTRL.Location = new System.Drawing.Point(42, 12);
            this.checkBox_CTRL.Name = "checkBox_CTRL";
            this.checkBox_CTRL.Size = new System.Drawing.Size(130, 20);
            this.checkBox_CTRL.TabIndex = 0;
            this.checkBox_CTRL.Text = "checkBox_CTRL";
            this.checkBox_CTRL.UseVisualStyleBackColor = true;
            // 
            // checkBox_Multiple
            // 
            this.checkBox_Multiple.AutoSize = true;
            this.checkBox_Multiple.Location = new System.Drawing.Point(243, 12);
            this.checkBox_Multiple.Name = "checkBox_Multiple";
            this.checkBox_Multiple.Size = new System.Drawing.Size(141, 20);
            this.checkBox_Multiple.TabIndex = 1;
            this.checkBox_Multiple.Text = "checkBox_Multiple";
            this.checkBox_Multiple.UseVisualStyleBackColor = true;
            this.checkBox_Multiple.CheckedChanged += new System.EventHandler(this.checkBox_Multiple_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(42, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 453);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox_Multiple);
            this.Controls.Add(this.checkBox_CTRL);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_CTRL;
        private System.Windows.Forms.CheckBox checkBox_Multiple;
        private System.Windows.Forms.PictureBox panel1;
    }
}

