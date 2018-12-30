using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Employee_Company
{
    class Company
    {
        public void LeaveNotify(int EID, string Reason)
        {
            Console.WriteLine("College is being informed regarding the leave request :" + EID + " , " + Reason);
        }
        private string CompanyName;
        private string CompanyAddress;
        private List<Employee> employeelist = new List<Employee>();
        public Company(string CompanyName,string CompanyAddress)
        {
            this.CompanyName = CompanyName;
            this.CompanyAddress = CompanyAddress;
        }
        public string PCompanyName
        {
            get
            {
                return this.CompanyName;
            }
        }
        public string PCompanyAddress
        {
            get
            {
                return this.CompanyAddress;
            }
        }
        public void AddEmployee(Employee obj)
        {
            employeelist.Add(obj);
            obj.evt_leaves += new Employee.DelLeaves(this.LeaveNotify);
            Console.WriteLine("Employee Added Successfully....");
        }
        public Employee SearchEmployee(int ID)
        {
            foreach(Employee e in this.employeelist)
            {
                if(e.PEmployeeId==ID)
                {
                    return e;
                }
            }
            return null;
        }
        public bool RemoveEmployee(int ID)
        {
            foreach(Employee e in this.employeelist)
            {
                if(e.PEmployeeId==ID)
                {
                    this.employeelist.Remove(e);
                    return true;
                }
            }
            return false;
        }
        public void ShowAll()
        {
            foreach(Employee e in this.employeelist)
            {
                Console.WriteLine(e.PEmployeeId + "  " + e.PEmployeeName);
            }
        }
           
    }
}
