using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Panel
{
    class Details
    {
        public static Employee Employee = new Employee();
        List<int> ID = new List<int>();
        List<int> Barcode = new List<int>();
        public static List<Employee> EmployeeList = new List<Employee>();
        public static Loading Load = new Loading();
        public static string File;
        public static List<Team> Teams = new List<Team>();
        public static  DataSet1 data = new DataSet1();
    }
}
