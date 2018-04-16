using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer.Interface
{
    public interface IEmployeeAccess
    {
        List<Employees> GetEmployee();
    }
}
