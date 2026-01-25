# ResumeProject

## 📌 Proje Özeti

**ResumeProject**, modern web teknolojileri kullanılarak geliştirilmiş, tam dinamik bir **Kişisel CV & Portföy Yönetim Sistemi**dir. Proje; kullanıcı arayüzü (UI) ve yönetim paneli (Admin) olmak üzere iki ana yapıdan oluşur. Tüm içerikler veritabanı üzerinden yönetilmekte ve anlık olarak arayüzde gösterilmektedir.

Bu proje; katmanlı mimari, MVC tasarım deseni, dinamik veri yönetimi ve modern frontend yaklaşımlarının birlikte kullanıldığı, gerçek hayat senaryolarını temel alan kapsamlı bir web uygulamasıdır.

---

## 🎯 Projenin Amacı

* Kişisel CV ve portföy içeriklerinin **tek bir panel üzerinden yönetilebilmesi**
* Statik CV anlayışının yerine **dinamik ve güncellenebilir** bir yapı sunmak
* Admin panel – UI entegrasyonunu gerçek bir ürün mantığıyla kurgulamak
* Modern frontend (Tailwind CSS) ile sade ve profesyonel bir arayüz geliştirmek

---

## 🏗️ Mimari Yapı

Proje, **MVC + Component tabanlı** hibrit bir mimari ile tasarlanmıştır.

### Katmanlar

```
Client (Browser)
   ↓
Controller
   ↓
ViewComponent / Service Logic
   ↓
Entity Framework (DbContext)
   ↓
SQL Server Database
```

### Mimari Akış Diyagramı (Metinsel)

```
[ UI / Razor View ]
        ↓
[ Controller ]  →  Request Routing
        ↓
[ ViewComponent ]  →  Modüler Veri Çekme
        ↓
[ DbContext ]  →  EF Core
        ↓
[ SQL Server ]
```

### Kullanılan Mimari Katmanlar

* **Controllers**: İş mantığının yönetildiği katman
* **Entities**: Veritabanı tablolarını temsil eden sınıflar
* **Context**: Entity Framework Core ile veritabanı bağlantısı
* **Views**: Kullanıcı ve admin arayüzleri
* **ViewComponents**: Tekrar eden dinamik bileşenler (Header, Sidebar, Statistics vb.)

> ViewComponent yapısı sayesinde UI tarafında modüler, okunabilir ve sürdürülebilir bir mimari sağlanmıştır.

---

## 🖥️ Kullanıcı Arayüzü (UI) Özellikleri

### Öne Çıkan Alan (Hero Section)

* Profil fotoğrafı
* Ad – Soyad
* Dinamik değişen meslek yazısı
* Sosyal medya hesapları

Tüm bu alanlar **veritabanı üzerinden yönetilmekte** ve ViewComponent aracılığıyla arayüze yansıtılmaktadır.

### Hakkımda & Yetenekler

* Hakkımda metni dinamik olarak veritabanından çekilir
* Yetenekler yüzde değerleriyle birlikte listelenir

### CV İndirme

* `wwwroot` klasöründe bulunan CV dosyası
* Tek tıkla tarayıcı üzerinden indirilebilir

### İstatistik Alanı

* Kullanıcı tarafından belirlenebilen 4 adet istatistik
* Örnek:

  * Tamamlanan projeler
  * Aktif projeler
  * Referans sayısı

### Deneyimler

* Deneyimler veritabanından dinamik olarak listelenir
* Kronolojik ve sade bir görünüm sunar

### Projeler & Kategoriler (Opsiyonel)

* Projeler görselleriyle birlikte listelenir
* Kategori bazlı filtreleme desteği

### Referanslar (Testimonials)

* Referans içerikleri dinamik olarak gösterilir

### İletişim

* Mailden iletişim kurulabilme
* İletişim formu üzerinden mesaj gönderimi
* Mesajlar admin paneline düşer

---

## 🛠️ Admin Panel Özellikleri

### Dashboard

* 4 adet dinamik istatistik kartı
* Hakkımda bilgisini gösteren özet alan
* Ek bilgi kartları (mesaj sayısı, proje sayısı vb.)

### CRUD Yönetimi

Aşağıdaki tüm alanlar için **Create / Read / Update / Delete** işlemleri eksiksiz uygulanmıştır:

* About Me
* Experiences
* Skills
* Projects
* Categories
* References
* Messages
* Social Media

### Bildirim Sistemi

* Toplam proje sayısını gösteren bildirim
* Okunmamış mesaj sayısını gösteren mesaj ikonu

---

## 📐 Kullanılan Teknolojiler

* ASP.NET Core MVC
* Entity Framework Core
* MSSQL Server
* Tailwind CSS
* HTML5 / CSS3
* JavaScript
<br /><br />
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-blue)
![EF Core](https://img.shields.io/badge/Entity%20Framework-Core-green)
![MSSQL](https://img.shields.io/badge/Database-MSSQL-red)
![Tailwind](https://img.shields.io/badge/Tailwind-CSS-38bdf8)

---

## 🤖 Yapay Zeka Araçlarının Kullanımı

Proje geliştirme sürecinde;

* **Claude**
* **Stitch**
* Diğer AI tabanlı araçlardan

kod iyileştirme, tasarım fikirleri ve problem çözme aşamalarında **destekleyici araç** olarak faydalanılmıştır.

> Admin panel veya UI tarafında hazır bir template kullanılmamış, tüm yapı sıfırdan geliştirilmiştir.

---

## 📚 Bu Projede Neler Öğrendim?

* ASP.NET Core MVC mimarisini gerçek bir proje üzerinde uygulamayı
* ViewComponent kullanarak modüler UI geliştirmeyi
* Admin – UI veri senkronizasyonunu yönetmeyi
* Entity Framework Core ile dinamik veri işlemlerini
* Tailwind CSS ile modern ve responsive arayüz tasarlamayı
* Büyük projelerde klasör yapısı ve okunabilir kod yazımını

---

## 🖼️ Ekran Görüntüleri

<br /><br />
### 🔐 Admin Panel
<br /><br />
📊 Dashboard
<br /><br />
<img src="https://github.com/user-attachments/assets/d23f713b-1d48-48d6-bdce-e7c831153fd1" width="100%" />

<br /><br />

👤 Hakkımda
<br /><br />
<img src="https://github.com/user-attachments/assets/b5ba3af2-8d69-47e2-85c2-2287832a57b4" width="100%" />

<br /><br />

🛠️ Yetenekler
<br /><br />
<img src="https://github.com/user-attachments/assets/5785e777-629b-451c-babd-9adbae8924b0" width="100%" />

<br /><br />

📁 Projeler
<br /><br />
<img src="https://github.com/user-attachments/assets/a5d2b916-21ab-461e-ba7a-d9c334c56e92" width="100%" />

<br /><br />

💬 Mesajlar
<br /><br />
<img src="https://github.com/user-attachments/assets/9f122076-82d9-4541-916e-c3cd76580eef" width="100%" />

<br /><br />

🔍 Mesaj Detay
<br /><br />
<img src="https://github.com/user-attachments/assets/f44dee96-1934-485c-92e6-3a4f5f0663a9" width="100%" />
### 🌐 UI (Kullanıcı Arayüzü)
<br /><br />
🏠 Anasayfa
<br /><br />
<img src="https://github.com/user-attachments/assets/ce5ec34b-09d9-4748-ac0e-7d1ad1d969dc" width="100%" />

<br /><br />

🙋‍♂️ Hakkımda
<img src="https://github.com/user-attachments/assets/61adcbaf-971f-4909-bda2-9e1bef530988" width="100%" />

<br /><br />

🧰 Hizmetlerim
<br /><br />

<img src="https://github.com/user-attachments/assets/3bbf9682-3e1f-41b9-bb51-7716b2e6b35c" width="100%" />

<br /><br />

📚 Bilgi Birikimim
<br /><br />

<img src="https://github.com/user-attachments/assets/c253625f-8ea0-4b1c-a947-9b3b2a72b489" width="100%" />

<br /><br />

💼 Projelerim
<br /><br />
<img src="https://github.com/user-attachments/assets/f1d187d3-454f-4fee-85b5-d18139ced478" width="100%" />

<br /><br />

⭐ Referanslar (Testimonials)
<br /><br />
<img src="https://github.com/user-attachments/assets/0c8aced3-de7a-4a16-98cc-86ef5465e6ad" width="100%" />

<br /><br />

📞 İletişim
<br /><br />
<img src="https://github.com/user-attachments/assets/8d09a501-3ced-4ce3-a7a7-f36925bab7d6" width="100%" />
---

## 🚀 Sonuç

ResumeProject, hem teknik hem de görsel açıdan modern yaklaşımlar barındıran, gerçek dünya ihtiyaçlarına uygun olarak geliştirilmiş kapsamlı bir portföy projesidir. Proje; geliştiricinin backend, frontend ve mimari konulardaki yetkinliğini açıkça ortaya koymaktadır.
