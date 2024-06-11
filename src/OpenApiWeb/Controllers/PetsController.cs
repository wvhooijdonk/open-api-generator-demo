using Microsoft.AspNetCore.Mvc;
using OpenApiLib.Controllers;
using OpenApiLib.Models;
using System.ComponentModel.DataAnnotations;

namespace OpenApiGeneratorDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : PetsApiController
    {
        public override IActionResult CreatePets([FromBody] Pet pet)
        {
            throw new NotImplementedException();
        }

        public override IActionResult ListPets([FromQuery(Name = "limit")] int? limit)
        {
            return new JsonResult(new Pet[] { new Pet { Id = 1, Name = "Dog", Tag = "123" } });
        }

        public override IActionResult ShowPetById([FromRoute(Name = "petId"), Required] string petId)
        {
            throw new NotImplementedException();
        }
    }
}
