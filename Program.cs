using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Template {
        public string ime;
        public string[] attr = new string[7]; // skola, razred, tip mature, jezik, predmet1, predmet2, predmet3

        public Template() {
        }

        public Template( string csvText ) {
            string[] parsovan = csvText.Split(';');
            this.ime = parsovan[0];
            for ( int i = 1; i < 8; i++ )
                this.attr[i - 1] = parsovan[i] == "null" ? "" : parsovan[i];
        }

        public override string ToString() {
            string output = "";
            output += (ime + ";");
            foreach ( string s in attr )
                output += (s + ";");
            
            return output;
        }
    }

}
