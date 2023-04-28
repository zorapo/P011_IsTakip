using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;
using System.Text.Json;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
   
    public class KullaniciController : Controller
    {
        private readonly IKullaniciService _kullaniciService;
        private readonly ILogger<KullaniciController> _logger;

        public KullaniciController(IKullaniciService kullaniciService, ILogger<KullaniciController> logger)
        {
            _kullaniciService = kullaniciService;
            _logger = logger;

        }

        public async Task<IActionResult> Index()
        {
            var model = await _kullaniciService.GetListAsync(t => t.Aktif && !t.Silindi, null, "");
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Musteri = new SelectList(_kullaniciService.GetSelectList(), "Musteri");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Kullanici model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            model.OlusturmaTarihi = DateTime.Now;
            model.OlusturanKullaniciId = model.Id;
            model.Aktif = true;
            model.Silindi = false;
            await _kullaniciService.AddAsync(model);
            await _kullaniciService.SaveAsync();

            var options = new JsonSerializerOptions { WriteIndented = true };
            var serializedData = JsonSerializer.Serialize(model, options);
            _logger.LogInformation(serializedData);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {

            var model = _kullaniciService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(Index));


            ViewBag.Musteri = new SelectList(_kullaniciService.GetSelectList(), "MusteriId");
  


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Kullanici model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(Index));

            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            var serializedData = JsonSerializer.Serialize(model, options);
            _logger.LogInformation(serializedData);

            var data = _kullaniciService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(Index));

            }

            data.Ad = model.Ad;
            data.Soyad = model.Soyad;
            data.MusteriId = model.MusteriId;
            data.KullaniciKodu = model.KullaniciKodu;
            data.KullaniciSifre = model.KullaniciSifre;
            data.MailBildirim = model.MailBildirim;
            data.RolTanim = model.RolTanim;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;

            _kullaniciService.Update(data);
            _kullaniciService.Save();

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Detail(int id)
        {

            var data = _kullaniciService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(Index));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _kullaniciService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(Index));


            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(Kullanici model)
        {
            if (model is null)
                return RedirectToAction(nameof(Index));


            var data = _kullaniciService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(Index));

            var options = new JsonSerializerOptions { WriteIndented = true };
            var serializedData = JsonSerializer.Serialize(model, options);
            _logger.LogInformation(serializedData);

            data.Silindi = true;

            _kullaniciService.Delete(data);
            _kullaniciService.Save();

            return RedirectToAction(nameof(Index));

        }
    }
}
