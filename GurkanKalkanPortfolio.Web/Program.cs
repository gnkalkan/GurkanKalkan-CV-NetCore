using Business;
using Core.Abstracts.IServices;

var builder = WebApplication.CreateBuilder(args);
//Builder Alaný: Hazýrladýðýmýz uygulamanýn baþlamadan önce yapýlandýrýlmasý için kullanýlýr. Bu alanda servisleri ekleyebilir, yapýlandýrma ayarlarýný yapabilir ve diðer baþlangýç iþlemlerini gerçekleþtirebiliriz. Kýsaca uygulama yapýlandýrýlýr.

builder.Services.AddDataAccessDependencies(builder.Configuration); //IOC sýnýfýnda tanýmladýðýmýz AddDataAccessDependencies metodunu çaðýrarak, uygulamanýn ihtiyaç duyduðu servisleri ve baðýmlýlýklarý ekliyoruz. Bu, uygulamanýn çalýþmasý için gerekli olan bileþenlerin yapýlandýrýlmasýný saðlar. Bu bileþenler arasýnda veritabaný baðlamý, hizmetler ve diðer baðýmlýlýklar bulunur. Bu sayede uygulama, ihtiyaç duyduðu kaynaklara eriþebilir ve iþlevselliðini yerine getirebilir.

var app = builder.Build(); //Build metodu, yapýlandýrýlmýþ uygulama nesnesi oluþturur. Bu nesne, uygulamanýn çalýþmasý için gerekli tüm bileþenleri içerir ve uygulamanýn baþlatýlmasýný saðlar.

// App Alaný: Uygulamanýn kendisini temsil eder. Bu alanda middleware (ara yazýlýmlar) ekleyebilir, yönlenmdirme iþlemlerini tanýmlayabilir ve uygulamanýn çalýþma zamanýndaki davranýþýný belirleyebiliriz. app.Run() komutuna kadar baþarýyla ulaþmaya çalýþýrýz. Ziyaretçiden gelen istek app.Run()'a ulaþmazsa hata döner.

app.MapGet("/", async (IPersonalService service) => await service.GetAllAsync());

app.Run();
