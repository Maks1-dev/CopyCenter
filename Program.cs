using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyCenter
{
    static class Program
    {
<<<<<<< HEAD
        public static Сopy_centerEntities4 wftDb = new Сopy_centerEntities4();
=======
        public static ITWebNetEntities3 wftDb = new ITWebNetEntities3();
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FormMenu());
=======
            Application.Run(new FormAuthorization());
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
        }
    }
}
