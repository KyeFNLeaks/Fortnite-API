namespace KyeBase
{
    partial class LTM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LTM));
            this.LTMrichTextBox = new System.Windows.Forms.RichTextBox();
            this.LTMbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTMrichTextBox
            // 
            this.LTMrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.LTMrichTextBox.Name = "LTMrichTextBox";
            this.LTMrichTextBox.ReadOnly = true;
            this.LTMrichTextBox.Size = new System.Drawing.Size(862, 285);
            this.LTMrichTextBox.TabIndex = 0;
            this.LTMrichTextBox.Text = "";
            // 
            // LTMbutton
            // 
            this.LTMbutton.Location = new System.Drawing.Point(799, 303);
            this.LTMbutton.Name = "LTMbutton";
            this.LTMbutton.Size = new System.Drawing.Size(75, 23);
            this.LTMbutton.TabIndex = 1;
            this.LTMbutton.Text = "Grab LTM";
            this.LTMbutton.UseVisualStyleBackColor = true;
            this.LTMbutton.Click += new System.EventHandler(this.LTMbutton_Click);
            // 
            // LTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 338);
            this.Controls.Add(this.LTMbutton);
            this.Controls.Add(this.LTMrichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LTM";
            this.Text = "LTM";
            this.Load += new System.EventHandler(this.LTM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LTMrichTextBox;
        private System.Windows.Forms.Button LTMbutton;
    }
}