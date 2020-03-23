namespace SPLR2
{
    partial class FFind
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
            this.Find = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.WordEnter = new System.Windows.Forms.RichTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Find.Enabled = false;
            this.Find.Location = new System.Drawing.Point(617, 12);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(136, 69);
            this.Find.TabIndex = 1;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(154, 12);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(136, 69);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Close";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // WordEnter
            // 
            this.WordEnter.HideSelection = false;
            this.WordEnter.Location = new System.Drawing.Point(12, 87);
            this.WordEnter.Name = "WordEnter";
            this.WordEnter.Size = new System.Drawing.Size(741, 387);
            this.WordEnter.TabIndex = 7;
            this.WordEnter.Text = "";
            this.WordEnter.TextChanged += new System.EventHandler(this.WordEnter_TextChanged);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(136, 69);
            this.Open.TabIndex = 11;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Clean
            // 
            this.Clean.Enabled = false;
            this.Clean.Location = new System.Drawing.Point(475, 12);
            this.Clean.Name = "Clean";
            this.Clean.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Clean.Size = new System.Drawing.Size(136, 69);
            this.Clean.TabIndex = 12;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // FFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 483);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.WordEnter);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Find);
            this.Name = "FFind";
            this.Text = "FIND";
            this.Load += new System.EventHandler(this.FFind_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RichTextBox WordEnter;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Clean;
    }
}

