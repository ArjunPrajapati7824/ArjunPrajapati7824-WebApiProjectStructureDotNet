using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using PMS.Repositories;
using PMS.Data;

namespace PMS.Services
{
    public static class StructureMapConfiguration
    {
        public static Container container=new Container();

        public static void configuration()
        {

            container = new Container();

            container.Configure(x =>
            {
                x.For<IRepository<Employee>>().Use(new Repository<Employee>());
                x.For<Iservice>().Use(new EmployeeService());
            });

        }


        public static T GetInstance<T>()
        {

            configuration();
            return container.GetInstance<T>();
        }

    }

}
