namespace KyeBase.API
{
    partial class Blog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blog));
            this.Loadbutton = new System.Windows.Forms.Button();
            this.BlogrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Loadbutton
            // 
            this.Loadbutton.Location = new System.Drawing.Point(804, 303);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(75, 23);
            this.Loadbutton.TabIndex = 0;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = true;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // BlogrichTextBox
            // 
            this.BlogrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.BlogrichTextBox.Name = "BlogrichTextBox";
            this.BlogrichTextBox.ReadOnly = true;
            this.BlogrichTextBox.Size = new System.Drawing.Size(867, 285);
            this.BlogrichTextBox.TabIndex = 1;
            this.BlogrichTextBox.Text = "";
            // 
            // Blog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 338);
            this.Controls.Add(this.BlogrichTextBox);
            this.Controls.Add(this.Loadbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Blog";
            this.Text = "Blog";
            this.Load += new System.EventHandler(this.Blog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.RichTextBox BlogrichTextBox;
    }
}