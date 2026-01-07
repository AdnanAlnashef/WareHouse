using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Design;
using WareHouse.Infrastructure.Session;
using WareHouse.Infrastructure.Storage;
using WareHouse.Interfaces.IRepository;

namespace WareHouse
{
    internal static class Program
    {
        public static IUnitOfWork unitOfWork = new UnitOfWork();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WareHouseWallet.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new log_in(unitOfWork));
        }
    }
}
