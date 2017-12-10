namespace _CLsearch_gui
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cldir = new System.Windows.Forms.TextBox();
            this.textBox_terms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_seldir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CL File Directory";
            // 
            // textBox_cldir
            // 
            this.textBox_cldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cldir.Location = new System.Drawing.Point(95, 12);
            this.textBox_cldir.Name = "textBox_cldir";
            this.textBox_cldir.Size = new System.Drawing.Size(311, 21);
            this.textBox_cldir.TabIndex = 1;
            this.textBox_cldir.TextChanged += new System.EventHandler(this.textBox_cldir_TextChanged);
            // 
            // textBox_terms
            // 
            this.textBox_terms.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, System.Drawing.FontStyle.Italic);
            this.textBox_terms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBox_terms.Location = new System.Drawing.Point(95, 43);
            this.textBox_terms.Name = "textBox_terms";
            this.textBox_terms.Size = new System.Drawing.Size(233, 21);
            this.textBox_terms.TabIndex = 3;
            this.textBox_terms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_terms_MouseClick);
            this.textBox_terms.TextChanged += new System.EventHandler(this.textBox_terms_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Terms";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(385, 42);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(51, 23);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_seldir
            // 
            this.button_seldir.Location = new System.Drawing.Point(410, 11);
            this.button_seldir.Name = "button_seldir";
            this.button_seldir.Size = new System.Drawing.Size(26, 23);
            this.button_seldir.TabIndex = 2;
            this.button_seldir.Text = "...";
            this.button_seldir.UseVisualStyleBackColor = true;
            this.button_seldir.Click += new System.EventHandler(this.button_seldir_Click);
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(333, 42);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(47, 23);
            this.button_help.TabIndex = 4;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 73);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_seldir);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_terms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cldir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(463, 112);
            this.MinimumSize = new System.Drawing.Size(463, 112);
            this.Name = "Form_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_CLsearch-gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cldir;
        private System.Windows.Forms.TextBox textBox_terms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_seldir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_help;
    }
}

