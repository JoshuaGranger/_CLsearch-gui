using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CLsearch_gui
{
    public partial class Form_main : Form
    {
        string term_start_text = "TAG1, TAG2, TAG3, etc.";

        public Form_main()
        {
            InitializeComponent();

            // Preliminary Setup
            //textBox_cldir.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            textBox_cldir.Text = Application.StartupPath;

            folderBrowserDialog1.SelectedPath = textBox_cldir.Text;
            textBox_terms.Text = term_start_text;
            button_seldir.Select();
        }

        private void button_seldir_Click(object sender, EventArgs e)
        {
            // Allow the user to select ".CL" file directory
            string temp = textBox_cldir.Text;
            if (Directory.Exists(temp))
            {
                folderBrowserDialog1.SelectedPath = temp;
            }
            folderBrowserDialog1.ShowDialog();
            textBox_cldir.Text = folderBrowserDialog1.SelectedPath;
            if (textBox_cldir.Text == "")
            {
                textBox_cldir.Text = temp;
            }
        }

        private void textBox_terms_MouseClick(object sender, MouseEventArgs e)
        {
            // If the user clicks in the terms box and the text is still the original
            // "TAG1, TAG2, TAG3, ...", then delete the text and change the font
            textBox_terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, 
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox_terms.ForeColor = System.Drawing.Color.Black;

            if(textBox_terms.Text == term_start_text)
                textBox_terms.Text = "";
        }

        private void textBox_terms_TextChanged(object sender, EventArgs e)
        {
            // If the user changes the text without clicking inside the textbox (i.e. using tabs),
            // we still need to fix the font back to normal
            if (textBox_terms.Text != term_start_text)
            {
                textBox_terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox_terms.ForeColor = System.Drawing.Color.Black;
            }
        }

        private bool clFilesPresent(string path)
        {
            // Check to see if the selected directory has .CL files
            string[] files = Directory.GetFiles(path);
            foreach(string file in files)
            {
                if (file.ToUpper().Contains(".CL"))
                {
                    return true;
                }
            }
            return false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            List<string> output = new List<string>();
            textBox_cldir.Text = folderBrowserDialog1.SelectedPath;
            
            // Did the user provide tags?
            if ((textBox_terms.Text == "") || (textBox_terms.Text == term_start_text))
            {
                output.Add("Search not completed: no tags to search for.");
                MessageBox.Show("Search not completed: no tags to search for.", "_CLsearch-gui  ::  Oops!");
            }
            // Are there .CL files in the selected directory?
            else if (!clFilesPresent(folderBrowserDialog1.SelectedPath))
            {
                output.Add("Search not completed: no \".CL\" files are present in this directory.");
                MessageBox.Show("Search not completed: no \".CL\" files are present in this directory.", "_CLsearch-gui  ::  Oops!");
            }
            // If all is good, continue to search
            else
            {
                string[] tags = textBox_terms.Text.Replace(", ", ",").Split(',');
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                foreach (string tag in tags)
                {
                    if ((tag != "") && (tag != " "))
                    {
                        // First, write the tag
                        output.Add(string.Format("\"{0}\"", tag.ToUpper()));
                        foreach (string file in files)
                        {
                            // Find the next ".CL" file and open
                            if (file.ToUpper().Contains(".CL"))
                            {
                                string temp = "";
                                List<string> lines = new List<string>();
                                using (StreamReader fs = new StreamReader(file))
                                {
                                    while ((temp = fs.ReadLine()) != null)
                                        lines.Add(temp);
                                }
                                // Check to see if our tag is in the file
                                int line_num = 1;
                                foreach (string line in lines)
                                {
                                    if (line.ToUpper().Contains(tag.ToUpper()))
                                    {
                                        output.Add("\tFILE: " + (file.Replace(folderBrowserDialog1.SelectedPath + "\\", "") +
                                            "                ").Substring(0, 16) +
                                            "\tLINE: " + line_num.ToString());
                                    }
                                    line_num++;
                                }
                            }
                        }


                        // If we get to the end of our files and no new lines were added, 
                        // then we did not find the tag
                        if (output[output.Count - 1].Contains("\"" + tag.ToUpper() + "\""))
                        {
                            output.Add("\t**No matches found**");
                        }

                        output.Add("");
                    }
                }

                // Show dialog window with results
                Form_results ResultsForm = new Form_results();
                ResultsForm.Pass(output, folderBrowserDialog1.SelectedPath + "\\_CLsearch.txt");
                ResultsForm.ShowDialog();
            }
        }

        private void textBox_cldir_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_cldir.Text))
                folderBrowserDialog1.SelectedPath = textBox_cldir.Text;
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            Form_help HelpForm = new Form_help();
            HelpForm.ShowDialog();
        }
    }
}
