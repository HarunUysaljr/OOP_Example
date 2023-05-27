Interface, bir sınıfın belirli bir davranışı (metotları) uygulamasını sağlayan bir yapıdır. Bir arayüz olarak da adlandırılır. İnterface, bir veya daha fazla metot bildirimini içerir, ancak bu metotların gerçek uygulamaları interface içinde yer almaz. Bunun yerine, bir sınıf interface'i uyguladığında, belirtilen metotların gerçek uygulamalarını sağlaması gerekir.

İnterface'ler, bir sınıfın birden fazla interface'i uygulamasına olanak tanır, bu da çoklu mirasın sağlanamadığı durumlarda farklı davranışları bir arada kullanmanın bir yolunu sunar.

İnterface'lerin bazı temel özellikleri şunlardır:
1 - Sadece metot bildirimlerini içerir, gerçek uygulamalar içermez.
2 - İnterface'lerdeki metotlar varsayılan olarak public'tir ve geri dönüş türü, parametreler ve metot adı belirtilir.
3 - İnterface'lerde ayrıca özellikler (properties) ve indeksler (indexers) de tanımlanabilir.
4 - Bir sınıf, bir veya birden fazla interface'i uygulayabilir. Bu uygulama, "interface adı : uygulanan_interface_adı" şeklinde yapılır.
5 - Bir sınıf, bir interface'i uyguladığında, içindeki tüm metotları ve özellikleri (properties) gerçek uygulamalarıyla birlikte sağlamalıdır.

İnterface'ler, nesne tabanlı programlamada kodun daha esnek, modüler ve test edilebilir olmasını sağlar. 
Ayrıca, birlikte çalışması gereken sınıflar arasında belirli bir sözleşme veya arayüz sağlar, böylece uyumlu ve değiştirilebilir bileşenler oluşturulabilir.
