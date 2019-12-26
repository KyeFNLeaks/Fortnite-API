namespace KyeBase.API
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Mainbutton = new System.Windows.Forms.Button();
            this.MainrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Mainbutton
            // 
            this.Mainbutton.Location = new System.Drawing.Point(834, 341);
            this.Mainbutton.Name = "Mainbutton";
            this.Mainbutton.Size = new System.Drawing.Size(75, 23);
            this.Mainbutton.TabIndex = 0;
            this.Mainbutton.Text = "Load";
            this.Mainbutton.UseVisualStyleBackColor = true;
            this.Mainbutton.Click += new System.EventHandler(this.Mainbutton_Click);
            // 
            // MainrichTextBox
            // 
            this.MainrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.MainrichTextBox.Name = "MainrichTextBox";
            this.MainrichTextBox.ReadOnly = true;
            this.MainrichTextBox.Size = new System.Drawing.Size(897, 323);
            this.MainrichTextBox.TabIndex = 1;
            this.MainrichTextBox.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 376);
            this.Controls.Add(this.MainrichTextBox);
            this.Controls.Add(this.Mainbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main Key";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mainbutton;
        private System.Windows.Forms.RichTextBox MainrichTextBox;
    }
}