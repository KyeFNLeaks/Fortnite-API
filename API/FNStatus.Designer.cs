namespace KyeBase
{
    partial class FNStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNStatus));
            this.StatusrichTextBox = new System.Windows.Forms.RichTextBox();
            this.Statusbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusrichTextBox
            // 
            this.StatusrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.StatusrichTextBox.Name = "StatusrichTextBox";
            this.StatusrichTextBox.ReadOnly = true;
            this.StatusrichTextBox.Size = new System.Drawing.Size(849, 281);
            this.StatusrichTextBox.TabIndex = 0;
            this.StatusrichTextBox.Text = "";
            // 
            // Statusbutton
            // 
            this.Statusbutton.Location = new System.Drawing.Point(786, 299);
            this.Statusbutton.Name = "Statusbutton";
            this.Statusbutton.Size = new System.Drawing.Size(75, 23);
            this.Statusbutton.TabIndex = 1;
            this.Statusbutton.Text = "FN Status";
            this.Statusbutton.UseVisualStyleBackColor = true;
            this.Statusbutton.Click += new System.EventHandler(this.Statusbutton_Click);
            // 
            // FNStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 334);
            this.Controls.Add(this.Statusbutton);
            this.Controls.Add(this.StatusrichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FNStatus";
            this.Text = "FNStatus";
            this.Load += new System.EventHandler(this.FNStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox StatusrichTextBox;
        private System.Windows.Forms.Button Statusbutton;
    }
}