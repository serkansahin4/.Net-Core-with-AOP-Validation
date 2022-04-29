** Bu projede, fazlalık hiçbir kod yazılmamış doğrudan sonuca odaklanılmıştır **
** Bu projedeki terimler ve anlatım şekli N-Tier mimari içindir. **
** Bu sadece çalışan bir Validasyon işlemi yapan uygulama örneğidir. **

İş katmanı (Business Layer) bizim mantıksal işlemlerimizi yaptığımız yerdir.
İş katmanındaki metodlarımızın içerisinde yaptığımız validasyonlar, bellekleme, loglama
gibi işlemler, SOLID Prensiplerinin S harfine yani (Single Responsibilty=Tek Sorumluluk) ye aykırıdır.
Bu yüzden, Metod içeriğine dokunarak, o metodun tek sorumluluk ilkesini ihlal etmek yerine, 
Yaptırmamız gereken CCC işlemlerini, metod içeriğine dokunmadan, AOP ile
IL(Intermediate Language)(Uygulamanın exe ve dll lere ayrıldığı kısım) Zamanında yaptırarak, sonradan
koda dahil etmeliyiz.

Bu tarz validasyon işlemleri yada CCC dediğimiz (Cross Cutting Concern) mimariyi dikine
kesen bileşenler, Core diye ayrı bir katmanda tutulmalıdır. 
AOP öğrenmesi zor bir yapı olduğu için, AOP kullanmamızı sağlayan aracı teknolojiler kullanarak,
bu işimizi görebiliyoruz.

Proje içeriği => AOP kullanabilmek için Autofac adında bir teknoloji kullandık. Bu teknolojinin paketleri
{
Autofac
Autofac.Extras.DynamicProxy
Autofac.Extension.DependencyInjection
}
dir.

Validasyon için kullandığımız teknoloji => {
FluentValidation
FluentValidation.AspNetCore
}

Bilmemiz gereken şeyler =>{
Design Pattern => Interceptor Pattern
}

Projenin kullanımını baştan sona anlatmayacağım, internette bununla ilgili kaynaklar bulabilirsiniz.
Business Katmanındaki data klasörü orada olmaması gereken bir klasör. Veritabanı kullanmış olsaydım,
konuyu anlamanız gayet zor olacaktı. Bu yüzden iş katmanındaki metodun içerisine kod bile yazmadım.
Tamamen Attribute alan metoda ürün gönderdiğinizde yapacağı işlemi görmeniz konusuna odaklandım.
