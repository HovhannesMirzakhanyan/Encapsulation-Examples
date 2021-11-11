using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department();
            d1.SetName("Socal");
            string printable=d1.GetName();
            Console.WriteLine(printable);

            Department1 d2 = new Department1();
            d2.DepartmentName = "Cultural";
            string culturalDepartment = d2.DepartmentName;
            Console.WriteLine(culturalDepartment);


            ReadDepartment readOnly = new ReadDepartment("Economic");
            string readOnlyName=readOnly.DepartmentName;
            Console.WriteLine(readOnlyName);

        }
    }

    /// <summary>
    /// Encapsulation with Getter and Setter Methods
    /// </summary>
    public class Department
    {
        private string _departmentName;
        public string GetName()
        {
            return _departmentName;
        }

        //using setter Method to set value to field
        public void SetName(string name)
        {
            _departmentName = name;
        }


    }

    /// <summary>
    /// Encapsulation using Property
    /// </summary>
    public class Department1
    {
        private string _departmentName;
        public string DepartmentName
        {
            get
            {
                return _departmentName;
            }
            set
            {
                _departmentName = value;
            }
        }
    } 

    /// <summary>
    /// Read only notation of encapsulaion
    /// </summary>
    public class ReadDepartment
    {
        private string _departmentName;
        public ReadDepartment(string name)
        {
            _departmentName = name;
        }
        public string DepartmentName
        {
            get
            {
                return _departmentName;
            }
        }

    }
    
}
