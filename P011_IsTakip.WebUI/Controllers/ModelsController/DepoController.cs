using Microsoft.AspNetCore.Mvc;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.WebUI.Controllers.ModelsController
{
    public class DepoController : Controller
    {
        private readonly IDepoService _depoService;



        public DepoController(IDepoService depoService)
        {
            _depoService = depoService;

        }

        public async Task<IActionResult> Index()
        {
            var model = await _depoService.GetListAsync();
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Depo model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            model.OlusturmaTarihi = DateTime.Now;
            model.OlusturanKullaniciId = model.Id;
            model.Aktif = true;
            model.Silindi = false;
            await _depoService.AddAsync(model);
            await _depoService.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {

            var model = _depoService.GetById(id);

            if (model is null)
                return RedirectToAction(nameof(Index));


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Depo model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = _depoService.GetById(model.Id);

            if (data == null)
            {
                return RedirectToAction(nameof(Index));
            }

            data.Tanim = model.Tanim;
            data.Aciklama = model.Aciklama;
            data.Yetkili = model.Yetkili;
            data.YetkiliTelefon = model.YetkiliTelefon;
            data.GuncellemeTarihi = DateTime.Now;
            data.GuncelleyenKullaniciId = model.Id;


            _depoService.Update(data);
            _depoService.Save();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int id)
        {

            var data = _depoService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(Index));

            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = _depoService.GetById(id);
            if (data is null)
                return RedirectToAction(nameof(Index));

            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(DepoEnvanter model)
        {
            if (model is null)
                return RedirectToAction(nameof(Index));

            var data = _depoService.GetById(model.Id);
            if (data is null)
                return RedirectToAction(nameof(Index));

            data.Silindi = true;

            _depoService.Delete(data);
            _depoService.Save();


            return RedirectToAction(nameof(Index));
        }
    }
}
