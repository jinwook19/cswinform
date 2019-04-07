namespace WindowsFormsApp1
{
    partial class NameChange
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
            this.beforeText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.afterText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // beforeText
            // 
            this.beforeText.Location = new System.Drawing.Point(22, 12);
            this.beforeText.Name = "beforeText";
            this.beforeText.Size = new System.Drawing.Size(100, 25);
            this.beforeText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // afterText
            // 
            this.afterText.Location = new System.Drawing.Point(22, 59);
            this.afterText.Name = "afterText";
            this.afterText.Size = new System.Drawing.Size(100, 25);
            this.afterText.TabIndex = 2;
            // 
            // NameChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.afterText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.beforeText);
            this.Name = "NameChange";
            this.Text = "NameChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox beforeText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox afterText;
    }
}