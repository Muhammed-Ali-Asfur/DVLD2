
---

## 1. Proje Tanımı
DVLD, kurum içi veri yönetimini kolaylaştırmak ve lisanslama süreçlerini dijitalleştirmek için geliştirilmiş Windows Forms tabanlı bir masaüstü uygulamasıdır.  

Uygulama kullanıcı dostu arayüzü ve katmanlı mimarisi ile:  
- Personel verilerini düzenleme  
- E-posta bildirimleri gönderme  
- Kurum içi iş süreçlerini otomatikleştirme  

işlemlerini sağlar. Sürdürülebilir ve genişletilebilir bir yapıya sahiptir.

---

## 2. Çözdüğü Problemler
- **Manuel süreçleri dijitalleştirir:** Zaman alan ve hataya açık manuel işlemleri otomatikleştirir.  
- **Veri erişimini merkezileştirir:** SQL Server veritabanı ile tüm veriler merkezi olarak saklanır ve yetkili kullanıcılar tarafından hızlıca erişilebilir.  
- **İletişimi otomatikleştirir:** Gmail API entegrasyonu ile otomatik e-posta bildirimleri sağlar.  
- **Güvenliği artırır:** Tüm işlemler ayrıntılı şekilde kayıt altına alınır, izlenebilirlik ve güvenlik sağlanır.  
- **Kurumsal uyumluluk ve sürdürülebilirlik:** Katmanlı yapı, bakım kolaylığı ve yeni özellik eklemeyi basitleştirir.  
- **Kullanıcı dostu arayüz:** Windows Forms ile geliştirilen arayüz, teknik olmayan personelin bile rahat kullanımına uygundur.

---

## 3. Kullanılan Teknolojiler
- **Platform:** Windows Forms (.NET Framework)  
- **Yapı:** 3 Katmanlı Mimari  
  - Sunum Katmanı (UI): Kullanıcı ile etkileşim  
  - İş Katmanı (BLL): İş kuralları ve mantık  
  - Veri Katmanı (DAL): ADO.NET ile SQL Server erişimi  
- **Veritabanı:** SQL Server  
- **Veri Erişimi:** Parametrik sorgular, transaction desteği  
- **Email Gönderimi:** Gmail API üzerinden SMTP  
- **Programlama Dili:** C#  

---

## 4. Windows Forms Tercih Sebebi
- Hızlı ve verimli masaüstü uygulama geliştirme  
- Stabil ve performanslı çalışma  
- Kolay entegrasyon ile kurumsal sistem uyumu  
- Kullanıcı adaptasyonu kolay, sade arayüz  

---

## 5. Kod ve Yapı Yönetimi
Proje mimarisinde kod tekrarını azaltmak ve yaygın işlevlerin merkezi yönetimini sağlamak için `GlobalClasses` isimli bir klasör (namespace) yapılandırılmıştır.
