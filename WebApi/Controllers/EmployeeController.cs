using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using PMS.Services;
using PMS.Services.Models;


namespace WebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        private Iservice _iservice;

        public EmployeeController()
        {
            _iservice = StructureMapConfiguration.GetInstance<Iservice>();
        }


        [HttpGet]
        public List<EmployeeServiceModel> getAlldata<T>()
        {

            return _iservice.getAllData();


        }


    }
}