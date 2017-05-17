using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDemo.Dal;
using WebAppDemo.Model;

namespace WebAppDemo.Bll
{
    public class EmployeeLogic : IDisposable
    {
        private NorthWindContext _db;

        public EmployeeLogic()
        {
            _db = new NorthWindContext();
        }

        /// <summary>
        /// 取得
        /// </summary>
        /// <returns></returns>
        public IQueryable<Employee> GetAll()
        {
            return _db.Employees;
        }

        /// <summary>
        /// 取得 by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Employee> GetAllAsync(int id)
        {
            return await _db.Employees.FindAsync(id);
        }


        /// <summary>
        /// 儲存與更新
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public async Task<Employee> SaveAsync(Employee model)
        {
            // 如果(PK)不為0，代表為更新
            if (model.EmployeeID != 0)
            {
                //更新
                _db.Entry(model).State = System.Data.Entity.EntityState.Modified;

            }
            else
            {
                //新增
                _db.Employees.Add(model);
            }

            try
            {
                await _db.SaveChangesAsync();
                return model;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntityExists(model.EmployeeID))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Employee> DeleteAsync(int id)
        {
            var entity = await _db.Employees.FindAsync(id);
            if (entity == null)
            {
                return null;
            }
            _db.Employees.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;

        }

        private bool EntityExists(int id)
        {
             return _db.Employees.Count(e => e.EmployeeID == id) > 0;
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
