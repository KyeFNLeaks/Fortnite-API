namespace KyeBase
{
    partial class eventflags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eventflags));
            this.EFrichTextBox = new System.Windows.Forms.RichTextBox();
            this.EFbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EFrichTextBox
            // 
            this.EFrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.EFrichTextBox.Name = "EFrichTextBox";
            this.EFrichTextBox.ReadOnly = true;
            this.EFrichTextBox.Size = new System.Drawing.Size(853, 282);
            this.EFrichTextBox.TabIndex = 0;
            this.EFrichTextBox.Text = "";
            // 
            // EFbutton
            // 
            this.EFbutton.Location = new System.Drawing.Point(757, 300);
            this.EFbutton.Name = "EFbutton";
            this.EFbutton.Size = new System.Drawing.Size(108, 23);
            this.EFbutton.TabIndex = 1;
            this.EFbutton.Text = "Load Event Flags";
            this.EFbutton.UseVisualStyleBackColor = true;
            this.EFbutton.Click += new System.EventHandler(this.EFbutton_Click);
            // 
            // eventflags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 335);
            this.Controls.Add(this.EFbutton);
            this.Controls.Add(this.EFrichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eventflags";
            this.Text = "eventflags";
            this.Load += new System.EventHandler(this.eventflags_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox EFrichTextBox;
        private System.Windows.Forms.Button EFbutton;
    }
}