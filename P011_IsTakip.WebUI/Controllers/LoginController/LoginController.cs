using Microsoft.AspNetCore.Mvc;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Entities.Classes;
using P011_IsTakip.Entities.Dtos;

namespace P011_IsTakip.WebUI.Controllers.LoginController
{
    public class LoginController : Controller
	{

		private readonly IKullaniciService _kullaniciService;
		public LoginController(IKullaniciService kullaniciService)
		{
			_kullaniciService = kullaniciService;	
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(LoginDto model)
		{
			try
			{
				if (!ModelState.IsValid)
					return View(model);

				var kullanici = _kullaniciService.Get(t => t.KullaniciKodu == model.KullaniciKodu && t.KullaniciSifre == model.KullaniciSifre && t.Aktif && !t.Silindi, "");

				if (kullanici is null)
				{
					ModelState.AddModelError(nameof(model.KullaniciSifre), "Kullanıcı Kodu veya şifre hatalı veya kullanıcı aktif değil.");			
				    return View(model);

                }

            }
			catch (Exception)
			{

				ModelState.AddModelError("", "Hata Oluştu");

			}

			//return RedirectToAction("Index",
			//new RouteValueDictionary(
			//new { controller = "Main", action = "Index" }));

			return RedirectToAction("Index", "Main");

      
        }

		[Route("Logout")]
		public IActionResult Logout()
		{
		
			return RedirectToAction("Index", "Home");
		}
	}
}
