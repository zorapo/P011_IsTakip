using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class IsDosyaController : Controller
    {
        private readonly IIsDosyaService _isDosyaService;



        public IsDosyaController(IIsDosyaService isDosyaService)
        {
            _isDosyaService = isDosyaService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _isDosyaService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.IsId = new SelectList(_isDosyaService.GetSelectList(), "IsId");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(IsDosya model)
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
            await _isDosyaService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _isDosyaService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(IsDosya model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _isDosyaService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.DosyaAdi = model.DosyaAdi;
            data.IsId = model.IsId;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;


            _isDosyaService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _isDosyaService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _isDosyaService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(IsDosya model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _isDosyaService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;

            _isDosyaService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }
    }
}
