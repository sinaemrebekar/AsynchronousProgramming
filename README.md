# 🛒 Market Ürün Yönetimi - Asenkron Programlama Projesi (.NET 8)

Bu proje, bir market sisteminde ürün ve kategori yönetimini sağlayan bir yapının **asenkron programlama** yaklaşımıyla nasıl geliştirileceğini göstermektedir. Kod yapısı sade ve öğretici olacak şekilde tasarlanmıştır.

---

## 🚀 Amaç

- `async/await` yapısını gerçek bir senaryoda göstermek
- EF Core ile birlikte `IEntityTypeConfiguration<T>` kullanarak temiz mimarili bir yapı kurmak
- Kategori ve ürün ilişkilerini pratik şekilde seed etmek
- Temel `CRUD` işlemlerinde asenkron metotlar kullanmak

---

## 🧠 Asenkron Programlama Nedir?

Asenkron programlama, uzun süren işlemleri (veritabanı erişimi, dosya işlemleri, dış servis çağrıları vb.) **uygulamayı kilitlemeden** çalıştırmaya olanak tanır.

Bu projede örneğin:
```csharp
public async Task<List<Product>> GetAllAsync()
{
    return await _context.Products.ToListAsync();
}
```
şeklinde EF Core sorguları `await` ile asenkron olarak çalıştırılır. Bu sayede uygulama daha **verimli**, daha **performanslı** ve daha **yanıt verebilir** hale gelir.

---

## 🛠️ Kullanılan Teknolojiler

- .NET 8
- Entity Framework Core
- C# 12
- SQL Server (LocalDB)
- Asenkron Programlama (async/await)
- Fluent Validation (opsiyonel)
- Visual Studio / Rider

---

## 📦 Seed Data

- Toplam 4 kategori (Meyve & Sebze, Et & Tavuk, Süt & Kahvaltılık, Atıştırmalık)
- Her kategoriye ait 5 ürün olmak üzere toplam 20 ürün
- Görseller dummy olarak `images/` klasöründe tutulur (örnek görsellerle çalışılabilir)

---

## 📁 Proje Yapısı

```
📦 MarketAsyncApp
 ┣ 📂 Data
 ┃ ┣ AppDbContext.cs
 ┃ ┣ CategorySeedConfiguration.cs
 ┃ ┗ ProductSeedConfiguration.cs
 ┣ 📂 Models
 ┃ ┣ Product.cs
 ┃ ┗ Category.cs
 ┣ 📂 Repositories
 ┃ ┗ ProductRepository.cs (IProductRepository + async CRUD)
 ┗ Program.cs
```

---

## ▶️ Nasıl Çalıştırılır?

1. Projeyi klonla:
   ```bash
   git clone https://github.com/kullanici/market-async-app.git
   ```

2. Gerekli NuGet paketlerini yükle (EF Core vs.)

3. Migration oluştur:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. Uygulamayı başlat:
   ```bash
   dotnet run
   ```

---

## 🔍 Dikkat Edilen Asenkron Noktalar

- Tüm veritabanı erişimleri `async` olarak yazıldı
- UI veya API olmamasına rağmen **geliştirilebilir yapı** sunuldu
- `Task`, `await`, `ToListAsync()`, `FirstOrDefaultAsync()` gibi yapılar kullanıldı
- Thread blocking (`.Result`, `.Wait()`) gibi kötü pratikler **kullanılmadı**

---

## 💬 Katkıda Bulun

Geliştirmek istersen PR gönderebilir, issue açabilirsin ✌️  
Bu proje, eğitici ve öğretici amaçlıdır.

---

## 📄 Lisans

MIT License
