/* Created By:       Joshua Granger
* Date Created:     October 22, 2017
* 
* Instructions for use:
*   1. Open the application
*   2. Using the "..." button, navigate to the directory that contains .CL files
*   3. Enter the terms you wish to search for, separated by commas
*   4. Press search, and a new window will appear
*   5. Click "Write to file" to write a file named "_CLsearch.txt"
*       -- The file will be created within the directory that contains the .CL files
*   6. Click "Close" to go back to the main window
*   7. Search again, or exit the application
*       
* Example input:
*   C:\Users\Joshua\Desktop\CLDIRECTORY
*   20BLSOL 21BLSOL
*   
* Example output:
*   "20BLSOL"
*       FILE: 20BLSOL.CL    LINE: 8
*       FILE: 20BLSOL.CL    LINE: 60
*       FILE: 20BLSOL.CL    LINE: 78
*          
*   "21BLSOL"
*       FILE: 21BLSOL.CL    LINE: 8
*       FILE: 21BLSOL.CL    LINE: 60
*       FILE: 21BLSOL.CL    LINE: 78
*          
* Note:
*   The results of this search can be logged into a file named _CLsearch.txt
*       _CLsearch.txt is created in the same directory as _CLsearch.exe
*       _CLsearch.txt is OVERWRITTEN every time this application is executed*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CLsearch_gui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_main());
        }
    }
}
