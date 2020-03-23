namespace SPLR2
{
    partial class FMask
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
            this.Start = new System.Windows.Forms.RadioButton();
            this.Cursor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MaskEnter = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Location = new System.Drawing.Point(22, 82);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 24);
            this.Start.TabIndex = 3;
            this.Start.TabStop = true;
            this.Start.Text = "from the start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.CheckedChanged += new System.EventHandler(this.Start_CheckedChanged);
            // 
            // Cursor
            // 
            this.Cursor.AutoSize = true;
            this.Cursor.Location = new System.Drawing.Point(157, 82);
            this.Cursor.Name = "Cursor";
            this.Cursor.Size = new System.Drawing.Size(141, 24);
            this.Cursor.TabIndex = 4;
            this.Cursor.TabStop = true;
            this.Cursor.Text = "from the cursor";
            this.Cursor.UseVisualStyleBackColor = true;
            this.Cursor.CheckedChanged += new System.EventHandler(this.Cursor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "MASK";
            // 
            // MaskEnter
            // 
            this.MaskEnter.Location = new System.Drawing.Point(88, 28);
            this.MaskEnter.Name = "MaskEnter";
            this.MaskEnter.Size = new System.Drawing.Size(210, 26);
            this.MaskEnter.TabIndex = 6;
            this.MaskEnter.TextChanged += new System.EventHandler(this.MaskEnter_TextChanged);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(458, 28);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(114, 78);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(320, 28);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(114, 80);
            this.Next.TabIndex = 10;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // FMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 126);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.MaskEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cursor);
            this.Controls.Add(this.Start);
            this.Name = "FMask";
            this.Text = "MASK";
            this.Load += new System.EventHandler(this.FMask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton Start;
        private System.Windows.Forms.RadioButton Cursor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaskEnter;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Next;
    }
}