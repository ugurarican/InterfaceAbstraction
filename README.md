# InterfaceAbstraction  
### Bizden bu ödevde istenilenler
- Düşünün ki bir şirketin çalışanlarını temsil eden bir program yazıyorsunuz.  
- Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır.  
- Ancak her çalışanın görevi (pozisyonu) farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).  
- Gorev metodunu çağırdığımızda her çalışan kendi yaptığı işi konsol ekranında söyleyecek.  
- Örneğin  
- Hasan Çıldırmış şirketin Proje yönetcisi, kendisi üzerinden Gorev() abstract metodu çağırıldığında konsol ekranında  
- " Proje yöneticisi olarak çalışıyorum. " yazdırılmasını istiyoruz.
### IWorker Inrerface   
- İlk olarak ortak özellikleri belirliyoruz. Ad, Soyad, Depertman ve Hangi görevde olduğunu söylediği metot.  
- Bunların hepsini interface'te tanımlıyoruz ki oluşturacağımız Meslek Classları bunları implemente etmek zorunda kalsın.
![Iworker](https://github.com/ugurarican/InterfaceAbstraction/blob/master/IWorker.png)  

### Software Developer Class  
- Her meslek grubu için ayrı bir sınıf oluşturuyoruz.  
- IWorker interfaceini implemente ediyoruz böylelikler interface ifadesindeki bütün yapıyı kullanmak zorunda kalıyoruz.
![SoftwareDeveloper](https://github.com/ugurarican/InterfaceAbstraction/blob/master/SoftwareDeveloper.png)  

### Project Manager Class  
- Her meslek grubu için ayrı bir sınıf oluşturuyoruz.  
- IWorker interfaceini implemente ediyoruz böylelikler interface ifadesindeki bütün yapıyı kullanmak zorunda kalıyoruz.
![ProjectManager](https://github.com/ugurarican/InterfaceAbstraction/blob/master/ProjectManager.png)  

### Project Manager Class  
- Her meslek grubu için ayrı bir sınıf oluşturuyoruz.  
- IWorker interfaceini implemente ediyoruz böylelikler interface ifadesindeki bütün yapıyı kullanmak zorunda kalıyoruz.
![SalesRepressentative](https://github.com/ugurarican/InterfaceAbstraction/blob/master/SalesRepressentative.png)  

### Program   
-  Oluşturdğumuz interfacei yazıyoruz ve değişken ismi veriyoruz ardından new diyerek hangi nesneyi (Mesleği) oluşturmak istediğimizi seçiyoruz.  
-  Oluşturduğumuz nesnenin Ad, Soyad, Departman bilgilerini dolduruyoruz.  
-  Görevlerini console yazdığımız Duty() metodunu ve kişi bilgilerini yazıyoruz.
![Program](https://github.com/ugurarican/InterfaceAbstraction/blob/master/Program.png)

### Console  
- Uygulamamızın console çıktısı.  
![Display](https://github.com/ugurarican/InterfaceAbstraction/blob/master/Display.png)
