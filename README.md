asp.net mvc ile dinamik tabanlı kişisel web site yapım aşamasında şunları yaptım:
html-css ile ilgili bir tema yaptık admin login ve kişisel bir profil olmak üzere ve sonrasında visual studiodan asp.net web controller seçip dosya adını verdik.sonrasında siteyi mvc olacak şekilde ayarladık.Mvc ne diye soracak olursanız ise(Model View Controller)demektir.Sonrasında yeni açtığımız bu sayfanın içine html&css ile yaptıklarımızı dosya içine aktardık.Sonra controller kısmından boş bir sayfa açtık şimdi.Onun içerisine boş bir web sitesi açtık bu alan kişisel olan kısmın alanı oldu htmlde algılama oranına göre değişiklik gösterebiliyor başına tilda ve yanına da dosya adını da yazarak dahil etmiş oluyoruz.Oradan sonra models kısmı içi boştu biz bunlara sınıfları yani class ekledik bunlar admin-anasayfa-ikonlar gibi üç tane basit class ekledik ve entity(code first-kendimiz yazarak oluşturyoruz) key-data annotations vasfını ekledik,özellikli olması adına bunların içine en sonra yanına context yani bağlantı alanının oluştuğu burada dosyaya sağ tık ekle özelliğinden nuget packet manager özelliğinden browserla entity framework paketini dahil etmiş oldum.Sonra Context yanına :DbContext yazdım hatalıydı çünkü entity framework aktif değildi onu da sağ tık lamba ile entity çevirerek classların dbset özelliğini oluşturdum.Sonra SQLServer'da classtan hazırladığım veritabanı için programda web config kısmına gelerek connectionString içerisine özelliklerini yazdım ve sonrasında console terminal kısmından enable-database ve update database yazarak veritabanım ve içindeki tablolar da çıkmış oldu.
