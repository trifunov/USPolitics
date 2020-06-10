using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using USPolitics.Service.DTOs;
using USPolitics.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace USPolitics.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateManager _candidateManager;

        public CandidateController(ICandidateManager candidateManager)
        {
            _candidateManager = candidateManager;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_candidateManager.GetAll());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_candidateManager.GetById(id));
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]CandidateDTO candidateDto)
        {
            _candidateManager.Add(candidateDto);
            return Ok();
        }

        // PUT api/<controller>
        [HttpPut]
        public IActionResult Put([FromBody]CandidateDTO candidateDto)
        {
            _candidateManager.Update(candidateDto);
            return Ok();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _candidateManager.Delete(id);
            return Ok();
        }
    }
}
