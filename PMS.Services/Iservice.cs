using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Services.Models;

namespace PMS.Services
{
    public interface Iservice
    {
        List<EmployeeServiceModel> getAllData();

    }
}
