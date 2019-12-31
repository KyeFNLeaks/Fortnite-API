namespace KyeBase.API
{
    partial class SP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SP));
            this.SPbutton = new System.Windows.Forms.Button();
            this.SPrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SPbutton
            // 
            this.SPbutton.Location = new System.Drawing.Point(867, 357);
            this.SPbutton.Name = "SPbutton";
            this.SPbutton.Size = new System.Drawing.Size(75, 23);
            this.SPbutton.TabIndex = 0;
            this.SPbutton.Text = "Load";
            this.SPbutton.UseVisualStyleBackColor = true;
            this.SPbutton.Click += new System.EventHandler(this.SPbutton_Click);
            // 
            // SPrichTextBox
            // 
            this.SPrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.SPrichTextBox.Name = "SPrichTextBox";
            this.SPrichTextBox.ReadOnly = true;
            this.SPrichTextBox.Size = new System.Drawing.Size(930, 339);
            this.SPrichTextBox.TabIndex = 1;
            this.SPrichTextBox.Text = "";
            // 
            // SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 392);
            this.Controls.Add(this.SPrichTextBox);
            this.Controls.Add(this.SPbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SP";
            this.Text = "Starter Packs";
            this.Load += new System.EventHandler(this.SP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SPbutton;
        private System.Windows.Forms.RichTextBox SPrichTextBox;
    }
}