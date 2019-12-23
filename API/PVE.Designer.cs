namespace KyeBase
{
    partial class PVE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVE));
            this.PVErichTextBox = new System.Windows.Forms.RichTextBox();
            this.PVEbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PVErichTextBox
            // 
            this.PVErichTextBox.Location = new System.Drawing.Point(12, 12);
            this.PVErichTextBox.Name = "PVErichTextBox";
            this.PVErichTextBox.ReadOnly = true;
            this.PVErichTextBox.Size = new System.Drawing.Size(860, 275);
            this.PVErichTextBox.TabIndex = 0;
            this.PVErichTextBox.Text = "";
            // 
            // PVEbutton
            // 
            this.PVEbutton.Location = new System.Drawing.Point(797, 293);
            this.PVEbutton.Name = "PVEbutton";
            this.PVEbutton.Size = new System.Drawing.Size(75, 23);
            this.PVEbutton.TabIndex = 1;
            this.PVEbutton.Text = "PVE Info";
            this.PVEbutton.UseVisualStyleBackColor = true;
            this.PVEbutton.Click += new System.EventHandler(this.PVEbutton_Click);
            // 
            // PVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 328);
            this.Controls.Add(this.PVEbutton);
            this.Controls.Add(this.PVErichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PVE";
            this.Text = "PVE";
            this.Load += new System.EventHandler(this.PVE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox PVErichTextBox;
        private System.Windows.Forms.Button PVEbutton;
    }
}