using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            String mutex_name = "Mutex";
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, mutex_name);
            bool has_handle = false;
            try
            {
                try
                {
                    has_handle = mutex.WaitOne(0, false);
                }
                catch (System.Threading.AbandonedMutexException)
                {
                    has_handle = true;
                }
                if(has_handle == false)
                {
                    MessageBox.Show("既に起動しています");
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            finally
            {
                if (has_handle)
                {
                    mutex.ReleaseMutex();
                }
                mutex.Close();
            }          
        }
    }
}
