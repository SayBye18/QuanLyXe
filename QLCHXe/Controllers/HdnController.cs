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
    public class HdnController: ControllerBase
    {
        private readonly IHdnRepo repo;
        public HdnController(IHdnRepo HdnRepo)
        {
            repo = HdnRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<HdnDTO>>> GetAll()
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
        public async Task<ActionResult<HdnDTO>> GetById(Guid id)
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
        public async Task<ActionResult<HdnDTO>> Insert(Hdn obj)
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
        public async Task<ActionResult<bool>> Update(Hdn obj)
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