using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDemo.Model;

namespace WebAppDemo.Dal.Extension
{
    public static class EmployeeRepositoryExtension
    {
        public static IQueryable<Employee> GetByIDUseSP(this IRepository<Employee> rep, int id)
        {
            var idParameter = new SqlParameter("OnBehalfPerson", id);

            var result = (rep as GenericRepository<Employee>).context.Database.SqlQuery<Employee>(
                "spGetCustomers @idParameter", idParameter);

            return result.AsQueryable();
        }

    }
}
