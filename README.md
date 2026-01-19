Hello guys.
This DataBase in "World mep"
World Map Database

Ushbu loyiha dunyo geografik obyektlari bo‘yicha ma’lumotlarni saqlash va boshqarish uchun mo‘ljallangan SQL Server ma’lumotlar bazasidir. Loyiha Windows Forms (C#) ilovalari bilan ishlashga moslab ishlab chiqilgan.

Maqsad

Geografik obyektlar o‘rtasidagi bog‘lanishlarni to‘g‘ri modellashtirish va ular ustida CRUD amallarini bajarish.
![Demo](demo3.gif)

Ma’lumotlar bazasi obyektlari

Qitalar

Materiklar

Davlatlar

Shaharlar

Poytaxtlar

Dengizlar

Daryolar

Ko‘llar

Tog‘lar

Orollar

Bog‘lanishlar

Qita – Davlat (1 : ko‘p)

Davlat – Shahar (1 : ko‘p)

Davlat – Poytaxt (1 : 1)

Daryo – Davlat (ko‘p : ko‘p)

Ko‘l – Davlat (ko‘p : ko‘p)

Dengiz – Davlat (ko‘p : ko‘p)

Tog‘ – Davlat (ko‘p : ko‘p)

Barcha bog‘lanishlar FOREIGN KEY orqali ta’minlangan.

Texnologiyalar

MS SQL Server

C# (.NET Framework)

Windows Forms

ADO.NET

Ishga tushirish

SQL Server’da ma’lumotlar bazasini yarating

SQL skriptlarni ishga tushiring

ConnectionString’ni sozlang

Loyihani ishga tushiring

Muallif

Ro‘ziyev Eldor: AIZUEldor.
