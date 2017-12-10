using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CLsearch_gui
{
    public partial class Form_help : Form
    {
        public Form_help()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_help_Load(object sender, EventArgs e)
        {
            richTextBox_help.Text =
                " Created By:       Joshua Granger\n" + 
                " Date Created:     October 19, 2017\n" +
                "\n" +
                " Instructions for use:\n" +
                "   1. Gather .CL files into an accessible directory\n" +
                "   2. Click the \"...\" button and select the directory that contains the .CL files\n" +
                "   3. Type the tags you wish to search for, separated by commas (i.e. TAG1, TAG2)\n" +
                "   4. Click \"Search\"\n" +
                "\n" +
                " Example input:\n" +
                "   CL File Directory    C:\\Users\\Joshua\\Desktop\\CLDIRECTORY\n" +
                "   Search Terms         20BLSOL, 21BLSOL\n" +
                "\n" +
                " Example output:\n" +
                "   \"20BLSOL\"\n" +
                " 	     FILE: 20BLSOL.CL      	LINE: 8\n" +
                " 	     FILE: 20BLSOL.CL      	LINE: 60\n" +
                " 	     FILE: 20BLSOL.CL      	LINE: 78\n" +
                "\n" +
                "   \"21BLSOL\"\n" +
                " 	     FILE: 21BLSOL.CL      	LINE: 8\n" +
                " 	     FILE: 21BLSOL.CL      	LINE: 60\n" +
                " 	     FILE: 21BLSOL.CL      	LINE: 78\n" +
                "\n" +
                " Note:\n" +
                "   If you wish to save the results of the search, click \"Write to file\" on the\n" +
                "   results screen. A dialog box will appear stating that the file _CLsearch.txt\n" +
                "   has been saved in the CL File Directory.\n";
            richTextBox_help.Select(richTextBox_help.Text.Length - 1, 0);
        }
    }
}
