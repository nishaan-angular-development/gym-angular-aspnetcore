using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nishaan.Gym.Interface;
using Nishaan.Gym.ViewModel;

namespace Nishaan.Gym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateRecepitController : ControllerBase
    {
        private readonly IGenerateRecepit _generateRecepit;
        public GenerateRecepitController(IGenerateRecepit generateRecepit)
        {
            _generateRecepit = generateRecepit;
        }
       

        // POST: api/GenerateRecepit
        [HttpPost]
        public GenerateRecepitViewModel Post([FromBody] GenerateRecepitRequestModel generateRecepitRequestModel)
        {
            try
            {
                return _generateRecepit.Generate(generateRecepitRequestModel.PaymentId);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
