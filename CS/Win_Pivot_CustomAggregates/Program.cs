using FirstValueAggregate;
using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPivot_CustomFunctions {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CriteriaOperator.RegisterCustomFunction(new FirstValueAggregateFunction());
            Application.Run(new Form1());
        }
    }
}
