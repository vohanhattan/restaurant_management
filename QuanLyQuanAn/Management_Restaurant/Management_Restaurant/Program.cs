using Management_Restaurant.GUI;
using Management_Restaurant.GUI.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Restaurant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string absolute = Path.GetFullPath(baseDirectory);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 loginForm = new Form1();
            DialogResult dr = loginForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (checkPermission())
                {
                    Application.Run(new frm_Main());
                }
                else
                {
                    Application.Run(new frm_MainUser());
                }
            }
        }
        private static bool checkPermission()
        {
            bool isManager = false;
            foreach (DAL.EmployeeDepartment employeeDepartment in GlobalData.EMPLOYEE.EmployeeDepartments)
            {
                if (employeeDepartment.DepartmentID == 1)
                    isManager = true;
            }

            return isManager;
        }
    }
}
