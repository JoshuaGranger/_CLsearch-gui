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
    public partial class Form_results : Form
    {
        List<string> output = new List<string>();
        string file = "";

        public Form_results()
        {
            InitializeComponent();
        }

        private void Populate()
        {
            foreach (string line in output)
                textBox_results.AppendText(line + "\n");
        }

        public void Pass(List<string> o, string f)
        {
            output = o;
            file = f;
            Populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(file, false))
            {
                for (int x = 0; x < output.Count; x++)
                {
                    if (x != (output.Count - 1))
                    {
                        sw.WriteLine(output[x]);
                    }
                    else
                    {
                        sw.Write(output[x]);
                    }
                }
            }
            MessageBox.Show("The file '_CLsearch.txt' has been saved in the following location:\n" + file, "_CLsearch-gui  ::  File saved!");
        }
    }
}
