# 🧑‍💻 Gürkan N. Kalkan — Kişisel Portfolyo & CV

.NET 10, N-Tier mimari ve Bootstrap 5 kullanılarak sıfırdan geliştirilmiş, SQLite destekli dinamik kişisel portfolyo ve CV projesi.

---

## 🚀 Teknolojiler

| Katman | Teknoloji |
|---|---|
| Backend | .NET 10, ASP.NET Core MVC |
| ORM | Entity Framework Core |
| Veritabanı | SQLite |
| Mimari | N-Tier (Repository + Unit of Work + IoC) |
| Mapping | AutoMapper |
| GitHub Entegrasyonu | Octokit.NET |
| Frontend | Bootstrap 5.3, Bootstrap Icons |

---

## 🏗️ Proje Yapısı

```
├── Core/           → Entity'ler, DTO'lar, Interface'ler (IRepository, IService, IUnitOfWork)
├── Business/       → Servis implementasyonları, AutoMapper profilleri, IoC kaydı
├── Data/           → Repository implementasyonları, UnitOfWork, EF Core DbContext
├── Utilities/      → Generic repository base, Result pattern, sabitler
└── Web/            → ASP.NET Core MVC (Controllers, Views, wwwroot)
```

---

## ⚙️ Kurulum

```bash
# Projeyi klonla
git clone https://github.com/gnkalkan/GurkanKalkan-CV-NetCore.git
cd GurkanKalkan-CV-NetCore

# Migration uygula
dotnet ef database update --project Data --startup-project GurkanKalkanPortfolio.Web

# Uygulamayı çalıştır
dotnet run --project GurkanKalkanPortfolio.Web
```

Uygulama varsayılan olarak `https://localhost:5001` adresinde açılır.

---

## 📌 Özellikler

- Kişisel bilgiler, eğitim, deneyim ve yetenekler veritabanı üzerinden yönetilir
- GitHub repoları Octokit.NET ile otomatik çekilir
- İletişim formu ile mesaj gönderimi
- CV PDF olarak indirilebilir
- Responsive tasarım (Bootstrap 5)

---

## 📄 Lisans

Bu proje kişisel portfolyo amaçlı geliştirilmiştir.
