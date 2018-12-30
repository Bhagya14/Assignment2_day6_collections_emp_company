using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Employee_Company
{
    class Employee
    {
        public delegate void DelLeaves(int id, string Reason);
        public event DelLeaves evt_leaves;
        private int EmployeeId;
        private string EmployeeName;
        private string EmployeeCity;
        public static int count = 1000;
        public Employee(string EmployeeName,string EmployeeCity)
        {
            this.EmployeeId = ++Employee.count;
            this.EmployeeName = EmployeeName;
            this.EmployeeCity = EmployeeCity;
        }
        public int PEmployeeId
        {
            get
            {
                return this.EmployeeId;
            }
        }
        public string PEmployeeName
        {
            get
            {
                return this.EmployeeName;
            }
        }
        public string PEmployeeCity
        {
            get
            {
                return this.EmployeeCity;
            }
            set
            {
                this.EmployeeCity = value;
            }
        }
        public void LeaveRequest(string Reason)
        {
            if(this.evt_leaves!=null)
            {
                this.evt_leaves(this.EmployeeId, Reason);
            }
            Console.WriteLine("Leave Request : EmployeeID :" + this.EmployeeId + ", Reason :" + Reason);
        }

    }
}
