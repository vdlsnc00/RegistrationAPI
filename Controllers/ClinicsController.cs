using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RegistrationAPI.Entities;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using RegistrationAPI.Filters;
using System;

namespace RegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private readonly ILogger<ClinicsController> _logger;

        public ClinicsController(ILogger<ClinicsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Clinic>>> Get()
        {
            _logger.LogInformation("Getting all the clinics");
            return new List<Clinic>() {new Clinic(){Id=1,Name="Urology"}};
        }

        [HttpGet("{id:int}")]
        public ActionResult<Clinic> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Clinic clinic)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Clinic clinic)
        {
            throw new NotImplementedException();     
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}