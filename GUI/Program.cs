using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            LoadNativeAssemblies();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 startForm = new Form1();
            frmLogin startForm = new frmLogin();
            startForm.Show();
            Application.Run();
        }
        static void LoadNativeAssemblies()
        {
            try
            {
                string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SqlServerTypes.dll");
                if (File.Exists(assemblyPath))
                {
                    SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
                }
                else
                {
                    //MessageBox.Show("Native assembly not found: SqlServerTypes.dll");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error loading native assemblies: " + ex.Message);
            }
        }
    }
}
