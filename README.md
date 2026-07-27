# WarehouseApp

پروژه **WarehouseApp** یک سامانه Web API پیشرفته برای مدیریت انبارداری است که با استفاده از **.NET 8** و بر اساس اصول **Clean Architecture** (معماری پیازی) طراحی و پیاده‌سازی شده است.

## ✨ ویژگی‌های کلیدی

- **مدیریت جامع:** کنترل کامل بر محصولات، دسته‌بندی‌ها و انبارها.
- **سیستم انبارگردانی:** مدیریت دقیق موجودی کالا و ثبت تراکنش‌های ورود و خروج.
- **معماری تمیز (Clean Architecture):** جداسازی منطق کسب‌وکار از زیرساخت.
- **مدیریت داده:** استفاده از EF Core با قابلیت سوییچ بین SQL Server و InMemory Database.
- **امنیت و پایداری:** پیاده‌سازی Global Exception Handling و تنظیمات CORS.
- **توسعه مدرن:** بهره‌گیری از Docker، API Gateway (Ocelot) و مدیریت متمرکز پکیج‌ها (CPM).

## 📂 ساختار پروژه (Project Structure)

مطابق با استاندارد Clean Architecture، پروژه‌ها در دسته‌بندی‌های زیر قرار گرفته‌اند:
```text
WarehouseApp (Solution)
├──📁 src
│   ├──📁 Basket
│   │──📁 Product
│   │   │──📁 Core
│   │   │  │── WarehouseApp.Application (سرویس‌ها و اینترفیس‌ها)
│   │   │  └── WarehouseApp.Domain (موجودیت‌ها و منطق اصلی)
│   │   │──📁 Infrastructure
│   │   │  │── WarehouseApp.ExternalServices.Infrastructure
│   │   │  └── WarehouseApp.Infrastructure (دیتابیس و تنظیمات EF)
│   │   └──📁 Presentation
│   │       ├── WarehouseApp.WebApi (نقطه شروع API)
│   │       ├── WarehouseApp.WebApi.GrpcService
│   │       └── WarehouseApp.WebApiminimal
│   │───📁 Shared
│   │    ├── WarehouseApp.Shared.Core
│   │    ├── WarehouseApp.Shared.Infrastructure
│   │    └── WarehouseApp.Shared.Persentation
│   └───📁 Ticketing 
│       
├──📁 Gateway
│   └── WarehouseApp.ApiGateway (درگاه ورودی میکرو‌سرویس‌ها)
└──📁 Solution Items
    ├── Directory.Packages.props (مدیریت متمرکز نسخه‌ها)
    ├── docker-compose.yml
    └── README.md
