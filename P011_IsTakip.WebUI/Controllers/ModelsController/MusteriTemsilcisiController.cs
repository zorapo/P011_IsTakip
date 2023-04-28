using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class MusteriTemsilcisiController : Controller
    {
        private readonly IMusteriTemsilcisiService _musteriTemsilcisiService;

        public MusteriTemsilcisiController(IMusteriTemsilcisiService musteriTemsilcisiService)
        {
            _musteriTemsilcisiService = musteriTemsilcisiService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _musteriTemsilcisiService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Musteri = new SelectList(_musteriTemsilcisiService.GetSelectList(), "MusteriId");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(MusteriTemsilcisi model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            model.OlusturmaTarihi = DateTime.Now;
            model.OlusturanKullaniciId = model.Id;
            model.Aktif = true;
            model.Silindi = false;
            await _musteriTemsilcisiService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _musteriTemsilcisiService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            ViewBag.Musteri = new SelectList(_musteriTemsilcisiService.GetSelectList(), "MusteriId");


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(MusteriTemsilcisi model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _musteriTemsilcisiService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.Ad = model.Ad;
            data.Soyad = model.Soyad;
            data.MusteriId = model.MusteriId;
            data.TelefonNumarasi = model.TelefonNumarasi; ;
            data.Email = model.Email;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;

            _musteriTemsilcisiService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _musteriTemsilcisiService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _musteriTemsilcisiService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(MusteriTemsilcisi model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _musteriTemsilcisiService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;


            _musteriTemsilcisiService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }
    }
}
