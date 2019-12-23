namespace KyeBase.API
{
    partial class Cosmetics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cosmetics));
            this.Loadbutton = new System.Windows.Forms.Button();
            this.CosmeticsrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Loadbutton
            // 
            this.Loadbutton.Location = new System.Drawing.Point(799, 301);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(75, 23);
            this.Loadbutton.TabIndex = 1;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = true;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // CosmeticsrichTextBox
            // 
            this.CosmeticsrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.CosmeticsrichTextBox.Name = "CosmeticsrichTextBox";
            this.CosmeticsrichTextBox.ReadOnly = true;
            this.CosmeticsrichTextBox.Size = new System.Drawing.Size(862, 268);
            this.CosmeticsrichTextBox.TabIndex = 2;
            this.CosmeticsrichTextBox.Text = "";
            // 
            // Cosmetics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 336);
            this.Controls.Add(this.CosmeticsrichTextBox);
            this.Controls.Add(this.Loadbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cosmetics";
            this.Text = "Cosmetics";
            this.Load += new System.EventHandler(this.Cosmetics_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.RichTextBox CosmeticsrichTextBox;
    }
}