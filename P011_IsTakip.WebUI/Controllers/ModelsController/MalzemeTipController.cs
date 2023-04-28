using Microsoft.AspNetCore.Mvc;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class MalzemeTipController : Controller
    {

        private readonly IMalzemeTipService _malzemeTipService;


        public MalzemeTipController(IMalzemeTipService malzemeTipService)
        {
            _malzemeTipService = malzemeTipService;

        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _malzemeTipService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(MalzemeTip model)
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
            await _malzemeTipService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _malzemeTipService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(MalzemeTip model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _malzemeTipService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.Tanim = model.Tanim;
            data.Aciklama = model.Aciklama;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;

            _malzemeTipService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _malzemeTipService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _malzemeTipService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(MalzemeTip model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _malzemeTipService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;


            _malzemeTipService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }

    }
}
