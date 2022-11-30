using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            }
            catch (System.Net.WebException ex)
            {
                Application.Exit();
            }
            catch (ArgumentNullException ex)
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
