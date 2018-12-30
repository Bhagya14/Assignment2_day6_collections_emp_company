using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Employee_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Company pathfront = new Company("Pathfron","JP Nagar,BGL");
            Console.WriteLine(pathfront.PCompanyName + " " + pathfront.PCompanyAddress);
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1-Add,2-Search,3-Remove,4-Show,5-Request Leave,6-Exit");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Employee Name :");
                            string EmployeeName = Console.ReadLine();
                            Console.WriteLine("Enter Employee City :");
                            string EmployeeCity = Console.ReadLine();
                            Employee obj = new Employee(EmployeeName, EmployeeCity);
                            pathfront.AddEmployee(obj);
                            Console.WriteLine("Your Employee ID :" + obj.PEmployeeId);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Employee ID :");
                            int ID = Convert.ToInt32(Console.ReadLine());
                            Employee obj = pathfront.SearchEmployee(ID);
                            if(obj!=null)
                            {
                                Console.WriteLine("Employee Details");
                                Console.WriteLine(obj.PEmployeeId + " " + obj.PEmployeeName + " " + obj.PEmployeeCity);
                            }
                            else
                            {
                                Console.WriteLine("Employee Not Found");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Employee ID :");
                            int ID = Convert.ToInt32(Console.ReadLine());
                            bool status = pathfront.RemoveEmployee(ID);
                            if(status==true)
                            {
                                Console.WriteLine("Employee Removed");
                            }
                            else
                            {
                                Console.WriteLine("Employee Not Found");
                            }
                            break;
                        }
                    case 4:
                        {
                            pathfront.ShowAll();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter Employee ID :");
                            int ID = Convert.ToInt32(Console.ReadLine());
                            Employee obj = pathfront.SearchEmployee(ID);
                            if(obj!=null)
                            {
                                Console.WriteLine("Enter Reason");
                                string Reason = Console.ReadLine();
                                obj.LeaveRequest(Reason);
                            }
                            else
                            {
                                Console.WriteLine("Wrong Employee ID");
                            }
                            break;
                        }
                    case 6:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You have Entered a Wrong Option");
                            break;
                        }
                 
                }
            }
            Console.ReadLine();

        }
    }
}
