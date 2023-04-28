using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class MusteriController : Controller
    {

        private readonly IMusteriService _musteriService;

        public MusteriController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _musteriService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Musteri = new SelectList(_musteriService.GetSelectList(), "MusteriId");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Musteri model)
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
            await _musteriService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _musteriService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            ViewBag.Musteri = new SelectList(_musteriService.GetSelectList(), "MusteriId");

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Musteri model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _musteriService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.Tanim = model.Tanim;
            data.Aciklama = model.Aciklama;
            data.MusteriSinifId = model.MusteriSinifId;
            data.Adres = model.Adres;
            data.Telefon = model.Telefon;
            data.Email = model.Email;
            data.VergiDairesi = model.VergiDairesi;
            data.VergiNumarasi = model.VergiNumarasi;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;

            _musteriService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _musteriService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _musteriService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(Musteri model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _musteriService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;


            _musteriService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }

    }
}
