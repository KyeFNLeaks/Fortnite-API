namespace KyeBase
{
    partial class AES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AES));
            this.AESbutton = new System.Windows.Forms.Button();
            this.AESrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AESbutton
            // 
            this.AESbutton.Location = new System.Drawing.Point(798, 301);
            this.AESbutton.Name = "AESbutton";
            this.AESbutton.Size = new System.Drawing.Size(75, 23);
            this.AESbutton.TabIndex = 1;
            this.AESbutton.Text = "Grab AES";
            this.AESbutton.UseVisualStyleBackColor = true;
            this.AESbutton.Click += new System.EventHandler(this.AESbutton_Click);
            // 
            // AESrichTextBox
            // 
            this.AESrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.AESrichTextBox.Name = "AESrichTextBox";
            this.AESrichTextBox.ReadOnly = true;
            this.AESrichTextBox.Size = new System.Drawing.Size(861, 283);
            this.AESrichTextBox.TabIndex = 2;
            this.AESrichTextBox.Text = "";
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 336);
            this.Controls.Add(this.AESrichTextBox);
            this.Controls.Add(this.AESbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AES";
            this.Text = "AES";
            this.Load += new System.EventHandler(this.AES_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AESbutton;
        private System.Windows.Forms.RichTextBox AESrichTextBox;
    }
}