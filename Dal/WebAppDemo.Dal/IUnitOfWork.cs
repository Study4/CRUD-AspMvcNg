using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppDemo.Dal
{
    public interface IUnitOfWork
    {
        void Dispose();
        void Save();
        IRepository<T> Repository<T>() where T : class;
    }
}
