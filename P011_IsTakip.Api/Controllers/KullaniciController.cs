using Microsoft.AspNetCore.Mvc;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciService _service;

        public KullaniciController(IKullaniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Kullanici>> GetAsync()
        {
            return await _service.GetListAsync(t => t.Aktif && !t.Silindi, null, "");
        }

 
        [HttpGet("{id}")]
        public async Task<Kullanici> GetAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

   
        [HttpPost]
        public async Task PostAsync([FromBody] Kullanici value)
        {
            await _service.AddAsync(value);
            await _service.SaveAsync();
        }

  
        [HttpPut]
        public async Task PutAsync([FromBody] Kullanici value)
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

