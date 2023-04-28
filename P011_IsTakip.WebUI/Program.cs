using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Business.Concrete.ModelsManager;
using P011_IsTakip.Business.Mapping;
using P011_IsTakip.Business.Validations.ModelsValidator;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.DataAccess.Concrete.EntityFramework.ModelsRepository;
using P011_IsTakip.DataAccess.Context;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
builder.Services.AddAuthorization();

builder.Services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<KullaniciValidator>());

builder.Services.AddScoped<IAjandaRepository, AjandaRepository>();
builder.Services.AddScoped<IDepoEnvanterRepository, DepoEnvanterRepository>();
builder.Services.AddScoped<IDepoRafRepository, DepoRafRepository>();
builder.Services.AddScoped<IDepoRepository, DepoRepository>();
builder.Services.AddScoped<IDurusTipRepository, DurusTipRepository>();
builder.Services.AddScoped<IIsDosyaRepository, IsDosyaRepository>();
builder.Services.AddScoped<IIsRepository, IsRepository>();
builder.Services.AddScoped<IKalinlikRepository, KalinlikRepository>();
builder.Services.AddScoped<IKullaniciRepository, KullaniciRepository>();
builder.Services.AddScoped<IMailParametreleriRepository, MailParametreleriRepository>();
builder.Services.AddScoped<IMalzemeTipRepository, MalzemeTipRepository>();
builder.Services.AddScoped<IMusteriKisitlamaRepository, MusteriKisitlamaRepository>();
builder.Services.AddScoped<IMusteriRepository, MusteriRepository>();
builder.Services.AddScoped<IMusteriSinifRepository, MusteriSinifRepository>();
builder.Services.AddScoped<IMusteriTemsilcisiRepository, MusteriTemsilcisiRepository>();
builder.Services.AddScoped<ITedarikciRepository, TedarikciRepository>();
builder.Services.AddScoped<IUretimDurusRepository, UretimDurusRepository>();
builder.Services.AddScoped<IUretimEmriRepository, UretimEmriRepository>();


builder.Services.AddScoped<IAjandaService, AjandaManager>();
builder.Services.AddScoped<IDepoEnvanterService, DepoEnvanterManager>();
builder.Services.AddScoped<IDepoRafService, DepoRafManager>();
builder.Services.AddScoped<IDepoService, DepoManager>();
builder.Services.AddScoped<IDurusTipService, DurusTipManager>();
builder.Services.AddScoped<IIsDosyaService, IsDosyaManager>();
builder.Services.AddScoped<IIsService, IsManager>();
builder.Services.AddScoped<IKalinlikService, KalinlikManager>();
builder.Services.AddScoped<IKullaniciService, KullaniciManager>();
builder.Services.AddScoped<IMailParametreleriService, MailParametreleriManager>();
builder.Services.AddScoped<IMalzemeTipService, MalzemeTipManager>();
builder.Services.AddScoped<IMusteriKisitlamaService, MusteriKisitlamaManager>();
builder.Services.AddScoped<IMusteriService, MusteriManager>();
builder.Services.AddScoped<IMusteriSinifService, MusteriSinifManager>();
builder.Services.AddScoped<IMusteriTemsilcisiService, MusteriTemsilcisiManager>();
builder.Services.AddScoped<ITedarikciService, TedarikciManager>();
builder.Services.AddScoped<IUretimDurusService, UretimDurusManager>();
builder.Services.AddScoped<IUretimEmriService, UretimEmriManager>();


builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<DataContext>();

var logger = new LoggerConfiguration()
	.ReadFrom.Configuration(builder.Configuration)
	.Enrich.FromLogContext()
	.CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);
//builder.Logging.AddConsole();

var app = builder.Build();

//Son migration yapýlmamýþsa otomatik yapar.
using (var scope = app.Services.CreateScope())
{
var db = scope.ServiceProvider.GetRequiredService<DataContext>();
db.Database.Migrate();
}

//Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication(); // oturum açma
app.UseAuthorization(); // yetkilendirme




app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
