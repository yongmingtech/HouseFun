using System.Collections.Generic;
using System.Linq;
using WebApplication1.DataAccessLayer.Base;
using WebApplication1.DataAccessLayer.Interface;
using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer
{
    public class EmployeeAccess : BaseAccess, IEmployeeAccess
    {
        public List<Employees> GetEmployee()
        {
            return DB.Employees.ToList();
        }
    }
}