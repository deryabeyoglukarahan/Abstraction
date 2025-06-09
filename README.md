# Abstraction - Çalışanlar Uygulaması

Bu proje, C# dilinde **abstraction (soyutlama)** kavramını göstermek amacıyla hazırlanmıştır. Şirket çalışanlarının görevlerini temsil eden soyut bir yapı içerir.

## 🔍 Proje Açıklaması

Projede bir `Calisan` adlı **soyut sınıf (abstract class)** tanımlanmıştır. Bu sınıf tüm çalışanlar için ortak olan özellikleri (ad, soyad, departman) barındırır ve her çalışanın kendi görevini tanımladığı `Gorev()` adlı bir soyut metot içerir.

### Kullanılan Sınıflar:

- `Calisan` (Abstract class): 
  - Özellikler: `Ad`, `Soyad`, `Departman`
  - Metotlar: `abstract Gorev()`, `BilgiYazdir()`
  
- `YazilimGelistirici` (Calisan'dan türetilmiştir): 
  - Görev: "Yazılım geliştirici olarak çalışıyorum."
  
- `ProjeYoneticisi` (Calisan'dan türetilmiştir): 
  - Görev: "Proje yöneticisi olarak çalışıyorum."

- `SatisTemsilcisi` (Calisan'dan türetilmiştir): 
  - Görev: "İş Analisti olarak çalışıyorum."
