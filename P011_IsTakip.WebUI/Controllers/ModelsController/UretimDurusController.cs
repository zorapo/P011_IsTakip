using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class UretimDurusController : Controller
    {
        private readonly IUretimDurusService _uretimDurusService;

        public UretimDurusController(IUretimDurusService uretimDurusService)
        {
            _uretimDurusService = uretimDurusService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _uretimDurusService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.UretimEmri = new SelectList(_uretimDurusService.GetSelectUretimEmri(), "UretimEmriId");
            ViewBag.DurusTip = new SelectList(_uretimDurusService.GetSelectDurusTip(), "DurusTipId");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(UretimDurus model)
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
            await _uretimDurusService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _uretimDurusService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            ViewBag.UretimEmri = new SelectList(_uretimDurusService.GetSelectUretimEmri(), "UretimEmriId");
            ViewBag.DurusTip = new SelectList(_uretimDurusService.GetSelectDurusTip(), "DurusTipId");


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UretimDurus model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _uretimDurusService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.UretimEmriId = model.UretimEmriId;
            data.DurusSuresi = model.DurusSuresi;
            data.DurusTipId = model.DurusTipId;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;

            _uretimDurusService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _uretimDurusService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _uretimDurusService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(UretimDurus model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _uretimDurusService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;


            _uretimDurusService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }
    }
}
