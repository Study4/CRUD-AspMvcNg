using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDemo.Api.Models.Dtos;
using WebAppDemo.Bll;
using WebAppDemo.Model;

namespace WebAppDemo.Api.Services
{
    public class EmployeesService : IDisposable
    {
        private EmployeeLogic _logic;

        public EmployeesService()
        {
            _logic = new EmployeeLogic();
        }

        /// <summary>
        /// 取得
        /// </summary>
        /// <returns></returns>
        public IQueryable<EmployeeDto> GetAll()
        {
            return _logic.GetAll().ProjectTo<EmployeeDto>();
        }

        /// <summary>
        /// 取得 by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<EmployeeDto> GetAllAsync(int id)
        {
            return Mapper.Map<EmployeeDto>(await _logic.GetAllAsync(id));
        }


        /// <summary>
        /// 儲存與更新
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public async Task<EmployeeDto> SaveAsync(EmployeeDto dto)
        {
            var model = Mapper.Map<Employee>(dto);
            return Mapper.Map<EmployeeDto>(await _logic.SaveAsync(model));
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<EmployeeDto> DeleteAsync(int id)
        {
            return Mapper.Map<EmployeeDto>(await _logic.DeleteAsync(id));
        }

        public void Dispose()
        {
            _logic.Dispose();
        }
    }
}
