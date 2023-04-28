using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class IsController : Controller
    {
        private readonly IIsService _isService;


        public IsController(IIsService isService)
        {
            _isService = isService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _isService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.MusteriId = new SelectList(_isService.GetSelectMusteriId(), "MusteriId");
            ViewBag.KalinlikId = new SelectList(_isService.GetSelectKalinlikId(), "KalinlikId");
            ViewBag.MalzemeTipId = new SelectList(_isService.GetSelectMalzemeTipId(), "MalzemeTipId");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Is model)
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
            await _isService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _isService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            ViewBag.MusteriId = new SelectList(_isService.GetSelectMusteriId(), "MusteriId");
            ViewBag.KalinlikId = new SelectList(_isService.GetSelectKalinlikId(), "KalinlikId");
            ViewBag.MalzemeTipId = new SelectList(_isService.GetSelectMalzemeTipId(), "MalzemeTipId");

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Is model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _isService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.MusteriId = model.MusteriId;
            data.Teklifli = model.Teklifli;
            data.TeklifNo = model.TeklifNo;
            data.Fiyat = model.Fiyat;
            data.IsBitimindeBildir = model.IsBitimindeBildir;
            data.Termin = model.Termin;
            data.IsOnceligi = model.IsOnceligi;
            data.MusteriSiparisNo = model.MusteriSiparisNo;
            data.IsNotu = model.IsNotu;
            data.MalzemeTipId = model.MalzemeTipId;
            data.KalinlikId = model.KalinlikId;
            data.Iscilik = model.Iscilik;
            data.MalzemeNotu = model.MalzemeNotu;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;


            _isService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _isService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _isService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(IsDosya model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _isService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;

            _isService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }
    }
}
