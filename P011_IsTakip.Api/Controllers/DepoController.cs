using Microsoft.AspNetCore.Mvc;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Api.Controllers
{

    [ApiController]
        [Route("Api/[controller]")]
        public class DepoController : ControllerBase
        {
        private readonly IDepoService _service;

        public DepoController(IDepoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Depo>> GetAsync()
        {
            return await _service.GetListAsync(t => t.Aktif && !t.Silindi, null, "");
        }


        [HttpGet("{id}")]
        public async Task<Depo> GetAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }


        [HttpPost]
        public async Task PostAsync([FromBody] Depo value)
        {
            await _service.AddAsync(value);
            await _service.SaveAsync();
        }


        [HttpPut]
        public async Task PutAsync([FromBody] Depo value)
        {
            _service.Update(value);
            await _service.SaveAsync();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var kayit = _service.GetById(id);
            if (kayit == null)
            {
                return NotFound();
            }
            _service.Delete(kayit);
            await _service.SaveAsync();
            return Ok();
        }
    }
}


