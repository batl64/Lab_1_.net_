namespace WindowsFormsApp1
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
            this.intervalTrackBarControl1 = new WindowsFormsControlLibrary2.IntervalTrackBarControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intervalTrackBarControl1
            // 
            this.intervalTrackBarControl1.Location = new System.Drawing.Point(65, 29);
            this.intervalTrackBarControl1.Maximum = 100;
            this.intervalTrackBarControl1.Minimum = 0;
            this.intervalTrackBarControl1.Name = "intervalTrackBarControl1";
            this.intervalTrackBarControl1.Size = new System.Drawing.Size(325, 172);
            this.intervalTrackBarControl1.TabIndex = 0;
            this.intervalTrackBarControl1.ValueMax = 100;
            this.intervalTrackBarControl1.ValueMin = 0;
            this.intervalTrackBarControl1.Load += new System.EventHandler(this.intervalTrackBarControl1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalTrackBarControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary2.IntervalTrackBarControl intervalTrackBarControl1;
        private System.Windows.Forms.Label label1;
    }
}

