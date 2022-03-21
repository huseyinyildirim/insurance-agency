### Notlar

* Teklif çekme sınıfları interface içinde gelmektedir. İlgili serviste Constructor Based Dependecy Injection yöntemini kullandım. Setter Based Dependency Injection yönteminide tercih ediyorum.
* Database migration yaptıktan sonra uygulamayı ilk çalıştırdığınızda dummy veriler için DataSeeding classı hazırlanmıştır.
* Uygulamayı MacBook üzerinde Visual Studio ile geliştirilmiştir.
* Swagger ile API test edilmiştir.
* Web uygulaması 5001 portundan yayın yapmaktadır.
* Teklif çekmek için API 5002 portundan yayın yapmaktadır.
* Demo için lütfen multiple olarak InsuranceAgency.WebUI ve InsuranceAgency.ProviderAPI projesini çalıştırınız.
* Belirtilmediği için web uygulamasındaki formlar haricinde validation kullanmadım.
* Code First yöntemi kullanılmıştır.
* SQL Server kullanılmıştır.
* Demo yapmadan önce InsuranceAgency.WebUI içindeki appsettings.json içinden veritabanı ayarlarını yapınız.

### Database Migrations

* dotnet ef --startup-project ../InsuranceAgency.WebUI migrations add Initial
* dotnet ef --startup-project ../InsuranceAgency.WebUI database update
