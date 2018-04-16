using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer.Base
{
    public class BaseAccess
    {
        protected BaseAccess()
        {
            DB = new NorthwindEntities();
        }

        protected NorthwindEntities DB { get; }
    }
}