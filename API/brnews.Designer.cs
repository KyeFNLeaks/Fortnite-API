namespace KyeBase
{
    partial class brnews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(brnews));
            this.BRrichTextBox = new System.Windows.Forms.RichTextBox();
            this.brnewsbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BRrichTextBox
            // 
            this.BRrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.BRrichTextBox.Name = "BRrichTextBox";
            this.BRrichTextBox.ReadOnly = true;
            this.BRrichTextBox.Size = new System.Drawing.Size(861, 275);
            this.BRrichTextBox.TabIndex = 0;
            this.BRrichTextBox.Text = "";
            // 
            // brnewsbutton
            // 
            this.brnewsbutton.Location = new System.Drawing.Point(763, 293);
            this.brnewsbutton.Name = "brnewsbutton";
            this.brnewsbutton.Size = new System.Drawing.Size(110, 32);
            this.brnewsbutton.TabIndex = 1;
            this.brnewsbutton.Text = "Load BR news";
            this.brnewsbutton.UseVisualStyleBackColor = true;
            this.brnewsbutton.Click += new System.EventHandler(this.brnewsbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load STW news";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brnews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brnewsbutton);
            this.Controls.Add(this.BRrichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "brnews";
            this.Text = "FN News";
            this.Load += new System.EventHandler(this.brnews_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox BRrichTextBox;
        private System.Windows.Forms.Button brnewsbutton;
        private System.Windows.Forms.Button button1;
    }
}