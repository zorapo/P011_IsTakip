using Microsoft.AspNetCore.Mvc;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class KalinlikController : Controller
    {
        private readonly IKalinlikService _kalinlikService;


        public KalinlikController(IKalinlikService kalinlikService)
        {
            _kalinlikService = kalinlikService;

        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _kalinlikService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Kalinlik model)
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
            await _kalinlikService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _kalinlikService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Kalinlik model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _kalinlikService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.Tanim = model.Tanim;
            data.Aciklama = model.Aciklama;

            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;


            _kalinlikService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _kalinlikService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _kalinlikService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(Kalinlik model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _kalinlikService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;

            _kalinlikService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }
    }
}
