using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.BusinessLayer.EmployeeBL
{
    public class EmployeeBiz
    {
        public List<Employees> GetEmployee()
        {
            using (var db = new NorthwindEntities())
            {
                return db.Employees.ToList();
            }
        }
    }
}