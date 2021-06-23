using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Q1
{
    class EmployeeList
    {
        private List<Employee> listEmp;

        public EmployeeList()
        {
            listEmp = new List<Employee>();
        }

        public void ReadFromFile(string filename)
        {
            try
            {
                using (var streamReader = new StreamReader(filename))
                {
                    string line;
                    while((line = streamReader.ReadLine()) != null)
                    {
                        Employee employee = new Employee();
                        employee.ReadFromString(line);
                        listEmp.Add(employee);
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Display()
        {
            Console.WriteLine("Number Of Employees in the input file = {0}", listEmp.Count);
            foreach(Employee emp in listEmp)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
