BeeLibrary.sln
├── BeeLibrary.Web              ← ASP.NET Core Web App (MVC)
├── BeeLibrary.Core             ← Class Library (бізнес-логіка, інтерфейси, моделі)
├── BeeLibrary.Data             ← Class Library (EF Core, репозиторії)
├── BeeLibrary.Rag              ← Class Library (AI, векторна база)
└── BeeLibrary.Tests*            ← xUnit Test Project


bee-library/                        ← репозиторій GitHub
│
├── src/                            ← вихідний код
│   ├── BeeLibrary.Web              ← веб-сайт (MVC, контролери, в'юхи)
│   ├── BeeLibrary.Core             ← бізнес-логіка, моделі, інтерфейси
│   ├── BeeLibrary.Data             ← база даних (EF Core, репозиторії)
│   └── BeeLibrary.Rag              ← AI, векторна база, робота з PDF
│
├── tests/                          ← тести
│   ├── BeeLibrary.Core.Tests       ← тести бізнес-логіки
│   ├── BeeLibrary.Data.Tests       ← тести роботи з БД
│   └── BeeLibrary.Rag.Tests        ← тести AI та векторної бази
│
├── uploads/                        ← PDF файли книг
│
├── BeeLibrary.sln                  ← Solution файл Visual Studio
└── README.md                       ← опис проєкту