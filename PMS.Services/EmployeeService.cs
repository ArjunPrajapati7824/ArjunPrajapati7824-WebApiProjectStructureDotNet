using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Services.Models;

namespace PMS.Services
{
    public class EmployeeService : Iservice
    {
       //public Iservice _iEmployee;
        List<EmployeeServiceModel> empList;
        public EmployeeService()
        {

            //_iEmployee = StructureMapConfiguration.GetInstance<Iservice>();
          empList = new List<EmployeeServiceModel>();
        }

        public List<EmployeeServiceModel> getAllData<T>()
        {
            
            empList.Add(new EmployeeServiceModel() { EmployeeId = 1, FullName = "Arjun Prajapati" });
            return empList;
        }



        public T getById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeServiceModel> getAllData()
        {
            throw new NotImplementedException();
        }
    }
}

