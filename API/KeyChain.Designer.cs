namespace KyeBase.API
{
    partial class KeyChain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyChain));
            this.KeyrichTextBox = new System.Windows.Forms.RichTextBox();
            this.Loadbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyrichTextBox
            // 
            this.KeyrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.KeyrichTextBox.Name = "KeyrichTextBox";
            this.KeyrichTextBox.Size = new System.Drawing.Size(864, 257);
            this.KeyrichTextBox.TabIndex = 0;
            this.KeyrichTextBox.Text = "";
            // 
            // Loadbutton
            // 
            this.Loadbutton.Location = new System.Drawing.Point(801, 299);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(75, 23);
            this.Loadbutton.TabIndex = 1;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = true;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // KeyChain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 334);
            this.Controls.Add(this.Loadbutton);
            this.Controls.Add(this.KeyrichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeyChain";
            this.Text = "KeyChain";
            this.Load += new System.EventHandler(this.KeyChain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox KeyrichTextBox;
        private System.Windows.Forms.Button Loadbutton;
    }
}