using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;

namespace QLCHXe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienRepo repo;
        public NhanVienController(INhanVienRepo nhanvienRepo)
        {
            repo = nhanvienRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<NhanVienDTO>>> GetAll()
        {
            try
            {
                return await repo.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> GetById(Guid id)
        {
            try
            {
                return await repo.Delete(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<NhanVienDTO>> Insert(NhanVien obj)
         {
             try
            {
                return await repo.Insert(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }

         }
    }
}