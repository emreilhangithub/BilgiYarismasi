# BilgiYarismasi

## Proje Tanıtımı 

*Bu projede **.Net** kullanarak bilgi yarışması oyunu oluşturdum. CRUD operasyonları için ado.net kullanıldım.*

# Database Yedeği #
Databse kısmına aşşağıdan ulaşıp kendinize yükleyebilirsiniz. https://github.com/emreilhangithub/BilgiYarismasi/tree/master/database

# Proje İçeriği #

### KullaniciGiris
1)Kullanıcı Giriş Butonu = Kullanıcı bilgilerini doldurarak sisteme giriş yapabilir.

2)Kayıt Ol Butonu = Kullanıcının kayıt olacabileceği ekran açılır.

3)Skorlar Butonu = Oyuncu skorlarının görünteneceği ekran açılır.

4)Yönetici Giriş Butonu = Yöneticinin giriş yapabileceği ekran açılır.

![KullaniciGiris](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/KullaniciGiris.png)

### Oyun Ekrani
1)Kullanıcı giriş yaptıktan sonra oyun ekranı açılır.

En Yüksek Skor = Oyundaki en yüksek skoru temsil eder.

En Yüksek Skorum = Kullanıcıya ait en yüksek skorunu temsil eder.

2)Başlat butonuna basarak oyunu başlatabilirsiniz.
![OyunEkrani](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/OyunEkrani.png)

3)Skorlarim butonuna basarak skorlarınızı görebilirsiniz.
![Skorlarim](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/Skorlarim.png)

4)Oyun başlat butonuna bastıktan sonra oyun başlar.

Aşağıdaki örnekte olduğu gibi soruyu cevaplamak için istediğiniz cevabı seçmek için butona basabilirsiniz Örnek 1903.

Soruyu atlamak için Sonraki butonuna basabilirsiniz.
![Soru1](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/Soru1.png)

5)Soruya doğru yanıt veriseniz doğru sayınız ve puanınız artacaktır aynı zamanda ekrana yeşil tik işareti çıkar.
![DogruCevap](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/DogruCevap.png)

6)Soruya yanlış yanıt veriseniz yanlış sayınız artıp puanınız azalacaktır aynı zamanda ekrana kırmızı çarpı işareti çıkar.
![YanlisCevap](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/YanlisCevap.png)

7)Oyunu bitirmek için Bitir butonuna bitirince skorlarını sisteme kayıt olur.

![Bitir](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/Bitir.png)

8)Oyunu bitirdikten sonra yeniden başlatmak için Yeniden başlat butonuna basarsanız oyun yeniden başlar.
![YenidenOyunBaslat](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/YenidenOyunBaslat.png)

### Kayıt Ol
Kayit Ol = Kullanıcı bilgilerini doldurarak sisteme kayıt olabilir.

![KayitOl](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/KayitOl.png)

### Skorlar
Bu ekranda daha önce oyun oynamış tüm oyuncuların skorları gözükür.
![Skorlar](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/Skorlar.png)

### Yönetici Giriş
Yönetici bilgilerini doldurarak sisteme kayıt olabilir.

![YoneticiGiris](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/YoneticiGiris.png)

### Yönetici Paneli
Soru Listele Butonu: Sistemde var olan tüm sorular listeyerek datagride basar.

Soru Ekle Butonu: Yeni bir soru eklemek için kullanılır. Boş alanları doldurup "Ekle" butonuna basarak yeni bir soru oluşturabilirsiniz.

Soru Güncelle Butonu: Seçilen bir soruyu güncellemek için kullanılır. Güncellenmek istenen soruyu seçip, değişiklikleri yapın ve "Güncelle" butonuna basın.

Soru Sil Butonu: Seçilen bir soruyu silmek için kullanılır. Silmek istediğiniz soruyu seçip "Sil" butonuna basın.

Soru Ara Butonu: Belirli bir kelime veya ifade içeren soruları aramak için kullanılır. Arama kutusuna aramak istediğiniz kelimeyi yazın ve "Ara" butonuna basın.

![YoneticiPaneli](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/YoneticiPaneli.png)

Kategori Ekle Butonu: Yeni bir kategori eklemek için kullanılır. "Kategori Adı" alanına yeni kategorinin adını yazın ve "Ekle" butonuna basın.


![YoneticiKategoriEkle](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/YoneticiKategoriEkle.png)

Kategori Güncelle Butonu: Varolan bir kategoriyi güncellemek için kullanılır. Güncellemek istediğiniz kategoriyi seçin, yeni adını yazın ve "Güncelle" butonuna basın.


![YoneticiKategoriGuncelle](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/YoneticiKategoriGuncelle.png)

Kategori Pasif Yap Butonu: Seçilen bir kategoriyi pasif hale getirmek için kullanılır. Pasif hale getirmek istediğiniz kategoriyi seçin ve "Pasif Yap" butonuna basın.


![YoneticiKategoriPasifeAlma](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/YoneticiKategoriPasifeAlma.png)

Kategoriye Göre Arama Yap Butonu: Seçilen kategoriye göre oyun listesini günceller burada amaç sadece o kategoriye ait soruları görebilmek. 


![YoneticiPaneliKategoriyeGoreListeleme](https://github.com/emreilhangithub/BilgiYarismasi/blob/master/images/YoneticiPaneliKategoriyeGoreListeleme.png)

```.NET``` ```C#``` ```MSSQL```  ```WindowsForm``` ```Software``` ```Computer``` ```Programmer```