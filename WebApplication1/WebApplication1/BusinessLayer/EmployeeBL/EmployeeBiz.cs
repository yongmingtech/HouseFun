using System.Collections.Generic;
using Microsoft.Practices.Unity;
using WebApplication1.DataAccessLayer.Interface;
using WebApplication1.Models;

namespace WebApplication1.BusinessLayer.EmployeeBL
{
    public class EmployeeBiz
    {
        [Dependency]
        public IEmployeeAccess ServiceImpl { get; set; }

        public List<Employees> GetEmployee()
        {
            return ServiceImpl.GetEmployee();
        }
    }
}