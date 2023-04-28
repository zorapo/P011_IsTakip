using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.Business.Concrete.ModelsManager;
using P011_IsTakip.Business.Mapping;
using P011_IsTakip.Business.Validations.ModelsValidator;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.DataAccess.Concrete;
using P011_IsTakip.DataAccess.Concrete.EntityFramework.ModelsRepository;
using P011_IsTakip.DataAccess.Context;
using P011_IsTakip.Entities.Classes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddControllersWithViews();
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


builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
