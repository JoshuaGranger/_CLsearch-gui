namespace _CLsearch_gui
{
    partial class Form_results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_results));
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_results = new System.Windows.Forms.TextBox();
            this.button_write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(249, 503);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_results
            // 
            this.textBox_results.Location = new System.Drawing.Point(13, 13);
            this.textBox_results.Multiline = true;
            this.textBox_results.Name = "textBox_results";
            this.textBox_results.ReadOnly = true;
            this.textBox_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_results.Size = new System.Drawing.Size(311, 484);
            this.textBox_results.TabIndex = 1;
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(168, 503);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(75, 23);
            this.button_write.TabIndex = 2;
            this.button_write.Text = "Write to file";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 538);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.textBox_results);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_results";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_results;
        private System.Windows.Forms.Button button_write;
    }
}