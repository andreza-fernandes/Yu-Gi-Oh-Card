using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yu_Gi_Oh_Card.Domain.Entities;
using Yu_Gi_Oh_Card.Domain.Interfaces;
using Yu_Gi_Oh_Card.Service.Validators;

namespace Yu_Gi_Oh_Card.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : Controller
    {
        private IBaseService<Cards> _baseCardsService;

        public CardsController(IBaseService<Cards> baseCardsService)
        {
            _baseCardsService = baseCardsService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Cards cards)
        {
            if (cards == null)
                return NotFound();

            return Execute(() => _baseCardsService.Add<CardsValidator>(cards).Id);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Cards cards)
        {
            if (cards == null)
                return NotFound();

            return Execute(() => _baseCardsService.Update<CardsValidator>(cards));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _baseCardsService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _baseCardsService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseCardsService.GetById(id));
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
