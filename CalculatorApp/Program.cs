using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLibrary;

namespace CalculatorApp
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
            CentralConfig.AddLinkInstance();
            CalculatorLibrary.InterfaceModel.IArithmenticOperation objCal = CentralConfig.ILinks;
            CalculatorLibrary.InterfaceModel.IUnitatryOperation unitObjCal = CentralConfig.IUnitatryLinks;

            //Injecting objCal into the form (Dependence injection)
            Application.Run(new frmCaculator(objCal, unitObjCal));

            //Remove ILinks instance by setting it to null
            CentralConfig.RemoveLinkInstance();
        }
    }
}
