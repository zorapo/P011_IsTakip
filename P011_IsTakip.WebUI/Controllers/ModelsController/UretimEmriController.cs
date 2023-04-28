using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class UretimEmriController : Controller
    {
        private readonly IUretimEmriService _uretimEmriService;


        public UretimEmriController(IUretimEmriService uretimEmriService)
        {
            _uretimEmriService = uretimEmriService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _uretimEmriService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Is = new SelectList(_uretimEmriService.GetSelectList(), "IsId");


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(UretimEmri model)
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
            await _uretimEmriService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _uretimEmriService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            ViewBag.Is = new SelectList(_uretimEmriService.GetSelectList(), "IsId");


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UretimEmri model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _uretimEmriService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.IsId = model.IsId;
            data.IsEmriTarihi = model.IsEmriTarihi;
            data.ToplamDurusSuresi = model.ToplamDurusSuresi;
            data.UretimBaslamaTarihi = model.UretimBaslamaTarihi;
            data.UretimTamamlanmaTarihi = model.UretimTamamlanmaTarihi;
            data.UretimDurum = model.UretimDurum;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;

            _uretimEmriService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _uretimEmriService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _uretimEmriService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(UretimEmri model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _uretimEmriService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;


            _uretimEmriService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }
    }
}
