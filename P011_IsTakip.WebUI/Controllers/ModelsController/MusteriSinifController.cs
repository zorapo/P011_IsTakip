using Microsoft.AspNetCore.Mvc;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class MusteriSinifController : Controller
    {

        private readonly IMusteriSinifService _musteriSinifService;

        public MusteriSinifController(IMusteriSinifService musteriSinifService)
        {
            _musteriSinifService = musteriSinifService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _musteriSinifService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(MusteriSinif model)
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
            await _musteriSinifService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _musteriSinifService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(MusteriSinif model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _musteriSinifService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.Tanim = model.Tanim;
            data.Aciklama = model.Aciklama;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;

            _musteriSinifService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _musteriSinifService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _musteriSinifService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(MusteriSinif model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _musteriSinifService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;


            _musteriSinifService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }

    }
}
