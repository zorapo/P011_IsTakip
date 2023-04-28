using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class DepoEnvanterController : Controller
    {
        private readonly IDepoEnvanterService _depoEnvanterService;


        public DepoEnvanterController(IDepoEnvanterService depoEnvanterService)
        {
            _depoEnvanterService = depoEnvanterService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _depoEnvanterService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.DepoId = new SelectList(_depoEnvanterService.GetSelectDepoId(), "DepoId");
            ViewBag.DepoRafId = new SelectList(_depoEnvanterService.GetSelectDepoRafId(), "DepoRafId");
            ViewBag.KalinlikId = new SelectList(_depoEnvanterService.GetSelectKalinlikId(), "KalinlikId");
            ViewBag.MalzemeTipId = new SelectList(_depoEnvanterService.GetSelectMalzemeTipId(), "MalzemeTipId");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(DepoEnvanter model)
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
            await _depoEnvanterService.AddAsync(model);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Edit(int id)
        {

            var model = _depoEnvanterService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            ViewBag.DepoId = new SelectList(_depoEnvanterService.GetSelectDepoId(), "DepoId");
            ViewBag.DepoRafId = new SelectList(_depoEnvanterService.GetSelectDepoRafId(), "DepoRafId");
            ViewBag.KalinlikId = new SelectList(_depoEnvanterService.GetSelectKalinlikId(), "KalinlikId");
            ViewBag.MalzemeTipId = new SelectList(_depoEnvanterService.GetSelectMalzemeTipId(), "MalzemeTipId");

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(DepoEnvanter model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _depoEnvanterService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(IndexAsync));
            }

            data.DepoId = model.DepoId;
            data.DepoRafId = model.DepoRafId;
            data.MalzemeTipId = model.MalzemeTipId;
            data.KalinlikId = model.KalinlikId;
            data.En = model.En;
            data.Boy = model.Boy;
            data.Adet = model.Adet;
            data.Agirlik = model.Agirlik;
            data.Aciklama = model.Aciklama;
            data.MusteriId = model.MusteriId;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;

            _depoEnvanterService.Update(data);

            return RedirectToAction(nameof(IndexAsync));
        }

        public IActionResult Detail(int id)
        {

            var data = _depoEnvanterService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _depoEnvanterService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(DepoEnvanter model)
        {
            if (model is null)
                return RedirectToAction(nameof(IndexAsync));

            var data = _depoEnvanterService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(IndexAsync));

            data.Silindi = true;

            _depoEnvanterService.Delete(data);

            return RedirectToAction(nameof(IndexAsync));
        }

    }
}
