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
    public class BaoHanhController: ControllerBase
    {
        private readonly IBaoHanhRepo repo;
        public BaoHanhController(IBaoHanhRepo baohanhRepo)
        {
            repo = baohanhRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<BaoHanhDTO>>> GetAll()
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

        [HttpGet("{id}")]
        public async Task<ActionResult<BaoHanhDTO>> GetById(Guid id)
        {
            try
            {
                return await repo.GetById(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id)
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
        public async Task<ActionResult<BaoHanhDTO>> Insert(BaoHanh obj)
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
        [HttpPut]
        public async Task<ActionResult<bool>> Update(BaoHanh obj)
         {
             try
            {
                return await repo.Update(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}