using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //balıkların bilgisini içeren text
            string text = "1. Akya Balığı\n\nCarangida familyasının bir üyesi olan akya balığı, boyutları ve zevkli avcılığı ile olta balıkçılarının avlanırken en çok heyecanlandığı deniz balıklarından biridir. Akya olarak bilinen bu tür, aynı zamanda liça balığı olarak da adlandırılır.\n\nMaksimum yetişkin boyutları, 200 cm uzunluk ve 50 kg ağırlıktır. Ancak, genellikle Ege denizinde bulunanların 120 cm civarına kadar büyüdükleri görülmüştür.\n\nÜreme dönemleri olan Mayıs ve Ağustos arasında yumurtlamak için gittikleri nehir birleşimlerinde kefaller ve sardalyaları yiyerek güç toplarlar. Ana besinleri kefal yavrularıdır.\n\nNehir ağızlarına yakın alanlarda daha küçük boyuttakiler bulunurken büyük boyutlu akyalar, 40-50 metre derinlikte ve kıyıya uzak olmayan alanlarda yaşar.\n\n2. Yaygın Aslan Balığı (Şeytan ateş balığı)\n\nHint-Pasifik bölgesine özgü bir aslan balığı varyantı olan bu tür, bilimsel olarak Pterois miles olarak adlandırılmıştır. Benzerlikleri dolayısıyla kırmızı aslan balığı ile karışıtırılırlar.\n\nHint-Pasifik bölgesinin yanı sıra ülkemiz sularından Ege denizinde de yaşadıkları biliniyor. Genel aslan balığı çeşitleri gibi bu tür de zehirli bir türdür.\n\nSırtında toplamda 13 adet diken bulunur. Renkleri kırmızı, gri veya ten rengi tonlarındadır. Geceleri avlandıklarından gündüzleri pek aktif bir tür değillerdir. Küçük kabuklular ve balıklar ile beslenirler.\n\nYetişkin boyutları 35 cm’ye kadar ulaşabilir. Ege balıkları arasında olsalar da yaygın olarak Kızıldeniz’de ve Endenozya sularında görülürler.\n\n3. Barbunya (Barbun)\n\nGerçek adı Barbunya balığı olsa da halk arasında Barbun adı ile bilinir. Mullidae familyasından olan bu türe Mullus barbatus bilimsel adı verilmiştir.\n\nEge denizi gibi sıcak ve ılıman suların kıyıya yakın kumlu ve çamurlu bölgelerinde yaşarlar. Nadiren de olsa kayalık alanlarda görülmektedirler. Tekir balığına benzerlikleri ile bilinirler. Aradaki farkı anlamak için burun, göz altı ve sırt yüzgecine bakılmalıdır.\n\nMaksimum boyutları 40 cm’dir ancak, Ege Denizi bölgesindekiler genellikle 18-20 cm civarında olurlar. Ege balıkları arasında ticari öneme sahip, eti lezzetli balıklardandır.\n\n4. Çipura\n\nÇipura balığı diğer adıyla Çupra, Ege denizi balık türleri arasında yer alsa da aslında Akdeniz bölgesinde de yaşarlar.\n\nIlıman sulara sahip bölgelerin, kumlu ve çamurlu bölgelerinde yaşarlar. Zaman zaman nehir ağızları ve lagünlerde bulundukları da olur.\n\n200 gr ve üzeri olanlar Çipura, bunun altında olanlar ise Lidaki olarak isimlendirilir. Kuvvetli bir çeneye sahiptir ve bu sayede kabukluları kolayca yiyebilir.\n\nAvlanmak isteniyorsa yaz aylarında kıyıya yakın, kış aylarında 30-40 metre derinlikte avlanabilirler. Kışın boyut olarak daha iri Çipuralar daha derin noktalara inerler. Ticari değeri yüksek ve eti oldukça lezzetli ege denizi balıklarındandır.\n\n5. Çitari (Sarpa)\n\nGörüntü olarak Çipura balığına çok benzerdir. Halk arasında Sarpa balığı olarak bilinirler. Yüzeyden 70 metre derinliğe kadar uzanan yaşam alanları vardır.\n\nMaviye çalan gri renkli üst kısımları, gümüş renkli yan kısımları vardır. Maksimum olarak 51 cm uzunluk ölçülmüş olup, genellikle 15-30 cm civarında görülürler.\n\nEge denizi balık türleri arasında ticari değeri yoktur. Yapılan araştırmalarda tam olarak tespit edilemese de balığın tükettiği bir alg neticesinde, sarpa yiyen insanlarda halüsinojenik balık sarhoşluğu denilen rahatsızlığa sebep olur.\n\n6. Çizgili Hani Balığı (Yazılı Hani)\n\nHani balığı, Orfoz’un da içinde bulunduğu Serranidae familyasından ve Levreğin içinde bulunduğu Serraninae alt türünden bir balıktır. Bilimsel adı Serranus scriba’dır. Çizgili hani balığı Ege denizi balıkları arasında yer almaktadır ancak hani balıkları genel olarak Akdeniz ve Karadeniz’de yaygındırar.\n\nÜlkemiz denizlerinden Ege Denizi’ne özgü Çizgili hani, 5 ila 150 metre arasında yaşam alanına sahiptir. Gündüzleri kayalıkların oluşturduğu mağaralarda geçirirken, alacakaranlık ve geceleri avlanmak için ortaya çıkar.\n\nGenellikle yalnız yaşadıkları görülse de küçük sürüler halinde yüzdüklerine de rastlanmaktadır. Uzunlukları en fazla 25 cm’ye ulaşır. Kabuklular, kafadanbacaklılar ve küçük balıklar ile beslenir. Ticari değeri olmayan, eti lezzetli Ege balıklarından biridir.\n\n7. Dikenli vatoz\n\nDikenli vatoz, Dasyatidae familyasından bir vatoz balığı türüdür. Akdeniz ve Karadeniz bölgelerimizde de görülen bu tür, daha fazla görülmesi sebebiyle Ege Denizi balık türleri arasında bulunmalıdır.\n\nÇok derin sularda değil, genellikle 60 metre civarı derinlikte ve çamurlu alanlarda yaşarlar. Ana besinleri dipte yaşayan kabuklu türleridir. Ek olarak yumuşakçalar, solucanlar ve küçük balıklarla da beslenir.\n\nEge denizinde bulunan dikenli vatozlar, genellikle 40-45 cm civarında veya daha küçük boyuttadır. Tırtırlı kuyruk ve iğneleri yüzünden insanlar için tehlikeli balık türleri arasındadır. Ticari değeri yoktur.\n\n8. Eşkina\n\nEşina balığı, Sciaenidae familyasından bir deniz balığı türüdür. Bilimsel adı Sciaena umbra olan bu tür, Akdeniz ve Ege Denizi bölgelerimizde bulunmaktadır. Eşkina balığı amatör avcılık yapanların sıklıkla karşılaştığı bir türdür.\n\nYavru eşkinalar kıyı şeritlere yakın nehir ağızlarında yaşarken, yetişkinler 5 metre ile 200 metre arasında yaşarlar. Ege balıkları listemize dahil ettiğimiz eşkina, en fazla 60 cm boyuta ulaşabilir ancak, ülkemiz sularında genellikle 30-40 cm civarında görülürler.\n\nBu balığı sıradışı kılan bir özelliği de vardır. Balığın kafasından, alın bölgesinden 1 cm çapında taş çıkar. Bilimsel olarak kanıtlanmamış olsa da bu taş limon ile eritilerek tüketildiğinde böbrek taşı rahatsızlığına iyi geldiği düşünülür.\n\nTicari değer açısından orta seviyelerdedir. Genellikle balık lokanlarında servis edilen, lezzetli bir türdür.\n\n9. Horozbina Balığı\n\nHorozbina, Blenniidae familyasından 900 civarı alt türe sahip, hem tuzlu hem de tatlı sularda (küçük bir bölümü) yaşayan alt varyantlara sahip balık türlerinin ortak adıdır.\n\nHorozbina tür adı altında 150 farklı cins ve 900 civarı da varyant tanımlanmıştır. Tatlı su blennysi olarak bilinen bir türü, nadiren de olsa akvaryumlarda beslenmektedir.\n\nGenellikle küçük boyutlara sahip olabilen bu balığın, yılan balığına benzer varyantlarıyla 55 cm boyutuna ulaştığı görülmüştür. İri bir göz ve ağız yapısına sahiptir.\n\nZamanlarının büyük kısmını deniz tabanında ve kayalık yarıklarında geçirirler. Ticari değeri olmayan, Akdeniz ve Ege Denizi balıklarından biridir.\n\n10. İskaroz (Papağan Balığı)\n\nGenellikle ılıman ve sıcak sulara sahip denizlerde yaşarlar. Bilimsel adı Sparisoma cretense olan tür Scaridae familyasındandır.\n\nParlak renklere sahip bir balıktır. Görünüşü itibariyle sazan balığının tropik halini andırır. Papağan isminin verilmesi ağızlarının papağan gagasına benzemesindendir.\n\nErkekler daha koyu tondaki renklere sahipken dişiler, kırmızı-turuncu tonlarındadır. Zamanlarının çoğu mercan resiflerinde geçer. Burada deniz yosunu ile beslenirler.\n\nYetişkin dönemlerinde en fazla 50 cm olabilirler ancak, ülkemizdeki iskaroz balıkları 20-30 cm civarındadır. Ticari değeri bulunmayan iskarozun eti orta lezzettedir.\n\n11. İskorpit Balığı\n\nİskorpit, Ege balıkları arasında zehirli türlerden biridir. Yüzgeçlerinde bulunan dikenlere dokunulduğunda kişiyi zehirler ve bölgede kızarıklık, şişlik görülür.\n\nBu etki 2-3 gün devam eder. Amonyak kullanılarak tedavi edilebilir. Özellikle amatör balıkçılar tarafından kırlangıç balığı ile karıştırılıp yaralanmalara sebep olmaktadır. Tutulduğunda dikenlerine dokunmamaya dikkat edilmelidir.\n\nKayıt edilmiş maksimum uzunluk 37 cm iken, ülkemiz sularında yetişkin olanları 20-25 cm civarında görülürler. Akdeniz, Karadeniz ve Ege denizi balık türlerinden biridir.\n\nİskorpit, zehirli balıklardan biri olsa da eti lezzetli olan ve barındırdığı vitamin ve yağlar ile insan sağlığına çok yararlı bir balıktır.\n\n12. İsparoz (İspari Balığı)\n\nSparidae familyasından olan isparinin bilimsel adı Diplodus annularis’dir. Bu balık genellikle ılıman sahil bölgelerine yakın alanlarda yaşar. Ege balıklarından biridir ve diğer denizlerimizde de bulunur.\n\nMaksimum 25 cm uzunluğa erişebilirler. Ülkemiz sularında 15-18 cm civarında ispariler bulunur. Sportif balıkçılıkta sevilen bir balık türüdür. Genç olanları kışın lagünlere giderek beslenirler. Karides, yavru balıklar ve kurtçuklar ana besinleridir.\n\nTicari değeri düşüktür ve genellikle olta balıkçılığı ile avlanırlar. Eti lezzetli ve az kılçıklı bir balıktır.\n\n13. İzmarit Balığı (İstrongilos)\n\nİzmarit balığı, Ege denizi balık türleri arasında yer alıyor ancak Akdeniz bölgelemizde daha yaygın bulunur. Bilimsel adı Spicara smaris olan izmarit, Sparidae familyasından bir deniz balığı türüdür.\n\nIlık sulara sahip bölgelerin kayalık, çamurlu dip kısımlarında yaşamaktadır. En fazla 25 cm boyutuna (erkekler) ulaşan bu tür, ülkemizde genellikle 15 cm civarında görülür.\n\nÜlkemiz sularında iki tür izmarit yaşamaktadır; İstargilos ve Menekşe izmarit. Eti lezzetli bir balıktır ve genellikle önce pişirilip sonra ayıklanır.\n\n14. Kalkan Balığı\n\nKalkan balığı (Scophthalmus maximus), gözleri vücudunun solunda olan, Scophthalmidae familyasından bir deniz balığı türüdür. Vücudunun sağını deniz tabanına yatmak için kullanır.\n\nÜlkemizin tüm denizlerinde yaşayan bir türdür. Yaşam alanları 20 metre ile 70 metre arasındadır. Tipik balık türlerinden farklı olarak yuvarlak bir vücuda sahiptir. Maksimum 1 metre uzunluğa erişebilirler. Ülkemiz denizlerinde ise yetişkinler 60-70 cm civarında görülür.\n\nHenüz yavruyken gözleri sağda ve solda ayrı durmaktadır. 8-10 cm civarına ulaştıklarında sağ göz vücutlarının sol tarafına kaymaya başlar.\n\nTicari değeri yüksek, eti çok lezzetli ege balıkları arasındadır.\n\n15. Karagöz Balığı\n\nKaragöz balığının Çipura ile yakın akrabalığı bulunmaktadır. Sarmos, mırmır, sivri gaga gibi birkaç çeşidi vardır.\n\nMaksimum 50 cm boyutuna ulaşabilir. Ülkemizde Akdeniz, Karadeniz ve Ege Denizi bölgelerimizde yaşarlar. Bu bölgelerde yaygın olarak 25 cm civarında görülür. Kayalık, kumlu alanlarda yaşarlar.\n\nGörünüşü ile Çupra balığına benzemesinin yanı sıra lezzet olarak da benzerdir. Serin dönemlerde tüketimesi tavsiye edilir bu dönemlerde eti daha yağlı ve lezzetli olmaktadır.\n\n16. Kolyoz Balığı\n\nUskumsugillerden olan kolyoz, Scombridae familyasından bir deniz balığıdır. Uskumruya çok benzeyen bir balıktır. Kuyruk yüzgecine bakılarak ayırt edilebilir. Bu türün kuyruk yüzgecinin ucu daha sivridir.\n\nGenç olanlar kıyılara yakın kumlu alanlar ve yosun yataklarında yaşarken, yetişkin olanlar daha açıkta derin sularda yaşar.\n\nSürüler halinde yaşamlarını sürdürürler. En fazla 50 cm uzunluğa kadar büyüyebilir ancak ülkemiz sularında görülen yetişkinler ortalama 20-25 cm civarındadır. Eti lezzetli ege balıkları arasındadır.\n\n17. Kırma Mercan\n\nKırma mercan balığı (Pagellus erythrinus) çipura ailesinden, Sparidae familyası mensubu, Akdeniz ve Ege balıklarından biridir. Özellikle Akdeniz ülkelerinde bolca tüketilen lezzetli bir balık türüdür.\n\nİnce, oval yapıda bir vücuda sahip olan kırma mercan en fazla 50 cm boyutuna ulaşabilir. Genel olarak 15-30 cm arasında görülürler. Bu tür bir hermafrodittir; sonradan cinsiyet değiştirebilirler.\n\nGenellikle hayatlarının ilk yıllarında dişi, sonraki yıllarında ise erkek olurlar. Hepçil bir balıktır ve ana besinleri küçük balıklar ve omurgasızlardan oluşur. Akdeniz ülkelerinde ticari değere sahip, lezzetli bir balıktır.\n\n18. Lahoz Balığı (Grida balığı)\n\nLahoz balığı Hani balıkları ailesinden, Ege ve Akdeniz bölgelerinde bulunan bir türdür. Bu tür iri ege balıkları arasındadır. En fazla 125 cm uzunluk ve 25 kg ağırlığa ulaşabilirler.\n\nPeople Also Read  Ters Yüzen Çöpçü\nYaşam alanları 20-250 metre arasında kayalık, çakıllı ve taşlı alanlardır. Son derece yırtıcı etçil balıklardan biridir. Yiyebileceği her türlü balık, omurgasız ve kabuklu türleri ile beslenir.\n\nOrfoz balığı ile yakından akrabadır ve ticari değeri bulunduğu bölgeye göre değişir. Özellikle Akdeniz bölgesinde etinin lezzetli ile bilinir.\n\nBu tür birkaç farklı isimle bilinir.\n\n19. Levrek\n\nBirçoğumuzun da yakından tanıdığı Levrek balığı, Dicentrarchus familyasından bir balık türüdür. Bilimsel olarak ilk kez 1758 yılında Dicentrarchus labrax olarak tanımlanmıştır.\n\nŞimdiye kadar kayıt altına alınan en büyük boyutları 1m ve 12 kg olsa da yaygın olarak 50 cm ve 5 kg civarında görülürler. Akdeniz ve Ege başta olmak üzere tüm denizlerimizde yaşadıkları biliniyor.\n\nHaliçler, lagünler, akarsuların denize döküldüğü yerler ana yaşam alanlarıdır. Kısa bir süreliğine tatlı sulara geçtikleri de bilinmektedir (tatlı su levreklerinin dışında).\n\nTicari değeri yüksek, etinin lezzetini kanıtlamış Ege denizi balık türlerinden biridir.\n\n20. Lipsoz Balığı\n\nLipsoz balığı, görünümü ile iskorpit balığına benzeyen Scorpaenidae familyasından bir balık türüdür. Lipsos ismiyle de bilinen bu türün bilimsel adı Scorpaena scrofa’dır.\n\nÜlkemiz sularında Akdeniz ve Ege Denizi türlerinden biridir, Karadeniz bölgesinde bulunmaz. S. porcus türü Karadeniz bölgesinde görülebilir. İskorpit balığı gibi bu balık da zehirli balıklardan biridir.\n\nVücut rengi kiremit rengi tonlarından, pembemsi tonlara kadar değişebilir. En fazla 50 cm ve 3 kg ağırlığa ulaştığı biliniyor ancak, sularımızdaki yetişkin lipsoz balıkları genellikle 25-30 cm civarındadır.\n\nYenilebilir balıklardan biridir, en çok çorba ve buğulama yapıldığında lezzetlidir.\n\n21. Lüfer Balığı\n\nLüfer,  Pomatomidae familyasından bir balık türüdür. Ege balıkları arasında ekonomik değeri yüksek ve çok lezzetli bir balıktır. Bilimsel adı Pomatomus saltatrix olan lüfer, ülkemizin tüm denizlerinde bulunmaktadır.\n\nMaksimum ölçülen boyutları 120 cm ve 14 kg’dır. Bölgemizde yaşayan yetişkin lüferler 30-60 cm arasında bulunurlar. Lüfer, gevşek ve küçük gruplar halinde yaşayan yırtıcı deniz balıklarından balıklardan biridir.\n\nLüfer çeşitli boyutlara göre farklı isimler almıştır:\n\nSarıkanat: 18 – 25 cm boyutlarında olan lüfer yavrusudur. 18 cm altının avlanması veya satılması yasaktır.\nLüfer: 28 – 35 cm boyutlarına ulaştığında lüfer adı verilir. Avlamak ve satış serbesttir.\nKofana: 35 cm üzerine çıkan lüferlere bu ad verilmiştir. Avlanması ve satılması serbesttir.\nSırtıkara: 50 cm’nin üzerindeki lüferlere verilmiş isimdir. Ülkemiz denizlerinde uzun süredir görülmemiştir. Avlamak ve satışını yapmak serbesttir.\nLüfer bir dönem koruma altına alınarak avlanılması ve satışı yapılması yasaklanmış balık türlerindendir. Ancak, günümüzde yasak bitirilerek 18 cm ve üzeri olanların avlanması ve satılması serbest bırakılmıştır.\n\n22. Mahmuzlu camgöz köpek balığı\n\nMahmuzlu camgöz Squalidae familyasından, Akdeniz ve Ege Denizi başta olmak üzere ülkemiz sularında bulunmaktadır. Ülkemizde tüketilmese de Avrupa ülkelerinde tüketildiği bilinmektedir.\n\nAna besinleri balık sürüleri ve ahtapotlar olan bu türün, profesyonel balıkçıların ağlarına ciddi hasar verdiği biliniyor. Nadiren de olsa dip balıklarını avlayan amatör balıkçıların oltasına takıldığı görülmektedir.\n\nEn fazla 150 cm ve 10 kg boyutlarına eriştikleri tespit edilmiştir ancak, genellikle 80 cm ve 4 kg civarlarına ulaşırlar. Ticari değeri yoktur.\n\n23. Mandagöz Mercan Balığı\n\nKırmızı (kızıl) çipura olarak da bilinen mandagöz mercan (Pagellus bogaraveo) Sparidae familyasından bir deniz balığıdır.\n\nAkdeniz başta olmak üzere ılıman ve sıcak denizleri tercih eden bir türdür, ılıman ısısıyla Ege balıklarından da biridir. Bulunduğu bölgeye göre en fazla 400 ila 700 metre derine inebilen bir balıktır.\n\nKaydedilen en büyük uzunluk 70 cm, yaygın olarak da 30 cm ve 4 kg’dır. Eti lezzetli, ızgarada pişilmesi tercih edilen bir mercan varyantıdır.\n\n24. Melanur Balığı (Melanurya)\n\nMelanur diğer adıyla Melanurya, Sparidae familyasından bir deniz türüdür. Ülkemizde Akdeniz, Marmara ve Ege bölgerinde bulunur. Bilimsel adı Oblada melanura olan melanur, Ege denizi balık türleri arasında yer alıyor.\n\nÇok iri boyutlara ulaşabilen bir tür değildir. Kaydedilen maksimum boyutları, 38 cm ve 930 gr’dır. Ülkemiz sularında yaygın olarak 20 cm civarında görülürler. Hepçil olan türün ana besini omurgasızlardır.\n\nEti lezzetli türlerden biri olan melanurun ticari değeri orta seviyelerdedir.\n\n25. Mersin Balığı\n\nMersin balığı birçok farklı türün ortak adıdır. Mersin balığı adı altında 19 farklı cins balık bulunmaktadır. Görünümlerindeki ufak farklılar ile ayrılırlar. Bu balıklar Acipenseridae familyasına aittir. Akdeniz bölgemizde daha yaygın olan tür, Ege balıkları arasında da bulunmaktadır.\n\nTüre göre boyutları farketmektedir. Yetişkin mersin balıkları ortalama 140 ila 300 cm uzunluğa, 100 ila 200 kg ağırlığa ulaşabilirler. Şimdiye kadarki ölçülen en büyük boyutlar; 7.2 metre ve 1571 kilogramdır.\n\nMersin balığı altında bulunan 19 farklı tür şu şekildedir:\nSibirya mersini\nKısa burunlu mersin balığı\nYangtze mersin balığı\nGöl mersin balığı\nRus mersin balığı\nYeşil mersin balığı\nSakhalin mersin balığı\nJapon mersin balığı\nAdriyatik mersin balığı\nŞip balığı\nKörfez mersinbalığı\nAtlantik mersin balığı\nİran mersin balığı\nÇuka balığı\nAmur mersin balığı\nÇin mersin balığı\nYıldızlı mersin balığı\nKolan balığı\nBeyaz mersin balığı\n\n26. Mürekkepbalığı\n\nMürekkepbalığı Cephalopoda (Kafadanbacaklılar) sınıfından, deniz türleri arasında olan bir yumuşakça türüdür. İkisi diğerlerinden daha uzun olan toplam 10 adet kolları vardır ve iç bölgelerinde çok sayıda vantuz bulunur.\n\nEge denizi balıkları arasında yer alan mürekkepbalığı, sıcak sularda yaşayan bir türdür. Bu türün boyutları çok değişkendir. Cinse göre 20 cm ile 17 metre arasında değişen çeşitleri vardır. Yaygın olarak yetişkin olanları 50-60 cm arasındadır.\n\nTicari değeri olan, eti lezzetli bir yumuşakça türüdür.\n\n27. Mırmır Balığı\n\nSparidae familyasından olan mırmır balığı, ekonomik değeri yüksek lezzetli balık türlerinden biridir. Denizin diplerinde ve kumlu kısımlarda yaşayan mırmır balığı sıklıkla avlanan Ege balıkları arasındadır.\n\nPeople Also Read  Akvaryum Balık Hastalıkları: 9 Yaygın Hastalık ve Tedavileri - 2023\nÜlkemizde Ege, Akdeniz ve Marmara bölgelerinde bolca bulunurlar. Ana besinlerini kabuklular, solucanlar ve yumuşakçalar oluşturur.\n\nEn fazla 55 cm ve 1 kg ağırlığa ulaşmaktadırlar ancak, yaygın boyutları 30 cm civarındadır. Ticari değeri yüksek Ege denizi balık türlerinden biridir.\n\n28. Orfoz Balığı\n\nSerranidae familyasından Orfoz, Taş hanisi adıyla da bilinir. Bilimsel adı Epinephelus marginatus’dur. Orfozlar hermafrodit (çift cinsiyetli) deniz balıkları arasındadır.\n\nOrfoz balığı neslinin tükenmesiyle karşı karşıya olduğu için avlanması yasak türlerdendir. Ülkemizde Akdeniz ve Ege denizlerinin güney kısımlarında yaşarlar.\n\nEn fazla 140 cm ve 60 kg boyutlarına ulaşabilirler. Boyutları ile iri ege balıklarından biridir. Ülkemiz denizlerinde yaygın görülen boyutları ortalama 60 cm ve 15 kg’dır.\n\n29. Orkinos (Ton balığı)\n\nÇoğumuzun marketlerde konserve içerinde gördüğü Orkinos, Uskumrugiller (Scombridae) ailesinin üyesidir. Kendi aralarında farklı türlere sahip olan, Orkinos ortak adı verilen bu balık denizlerdeki en iri balıklardan biridir.\n\nEge denizi balıkları arasında en büyük türlerden biridir. Yetişkin bir ton balığı, 6 metre uzunluğa ve 1 ton ağırlığa ulaşmaktadır. Ancak, bu boyutlarda Orkinos bulma ihtimali çok düşüktür genellikle 3-4 metre ve 400-600 kg arasında avlanırlar.\n\nEkonomik değeri çok yüksek ve son deree lezzetli balıklardandır.\n\n30. Pisi Balığı\n\nPisi balığı kalkan ile karıştırılabilir ancak resimlerine bakıldığında kolayca ayırt edilebilir. Pleuronectidae familyasından olan pisi balığının vücudu kalkana göre daha elips şeklindedir ve kalkanın sırtında olan düğme diye tabir edilen kemikli yapılar yoktur.\n\nYine pisi balığının gözleri de vücudun sağ tarafındadır. En fazla 60 cm boyut ölçülmüştür ancak, yaygın boyutları 30 cm civarındadır.\n\nÜlkemizde Akdeniz, Ege, Karadeniz ve Marmara bölgelerimizde bulunur.\n\n31. Sardalya Balığı\n\nSaldalya hamsi ile yakından akraba, Clupeinae familyasından bir balık türüdür. Sürüler halinde kıyıya yakın geçerek göç ederek yaşamlarını sürdürürler.\n\nAkdeniz ve Karadeniz’de daha yaygın görülen sardalya, Ege denizi balık türleri arasında da yer almaktadır. Denizlerimizde 15-20 cm boyutlara ulaşırlar ancak okyanus bölgelerindeki sardalyalar 30 cm uzunluğa kadar büyümektedir.\n\nTicari değeri çok yüksek, lezzetli balık türlerindendir.\n\n32. Sargan Balığı (Zargana)\n\nTipik balık görünümünün dışında uzun ve ince bir vücuda sahip sargan (Belone belone), Belonidae familyasının üyesidir. Vücut yapıları sayesinde hızlı ve çevik deniz balıklarındandır.\n\nYaşadıkları bölgeye göre 1 metre uzunluğa erişmektedirler ancak Akdeniz ve Ege denizlerimizde 60 cm civarına kadar büyümektedirler.\n\nAna besinleri küçük balıklardır ve hamsi, çaça gibi balık türleri ile beslenir. Ticari değeri yüksek, lezzetli Akdeniz ve Ege balıkları arasındadır.\n\n33. Sargoz Balığı\n\nSargoz, Akdeniz ve Ege bölgelerinde sıklıkla Karagöz ile karıştırılır. Diplodus sargus bilimsel adı verilmiştir ve Sparidae ailesinden bir deniz balığı türüdür.\n\nBu balık bölgeye göre farklı isimler almıştır. Baltabaş, Sargos ve Ak Karagöz olarak da bilinirler. Ülkemizde Akdeniz ve Ege bölgelerimizde yaygındır.\n\nGüçlü çeneye sahiptirler ana besinleri; kabuklular, yumuşakçalar ve deniz yosunları. Ekonomik değeri yüksek, lezzetli bir balıktır.\n\n34. Sinarit Balığı\n\nSparidae familyasından olan Sinarit’in bilimsel adı Dentex dentex’dir. Akdeniz’de yaygındır ancak Karadeniz, Marmara ve Ege balıkları arasında da yer alırlar.\n\nTaşlı ve kumlu bölgelerde 200 metre derinliğe kadar yaşarlar. Ana besinleri kafadanbacaklılar ve yumuşakçalardır. Genellikle yalnız yaşarlar ancak üreme dönemlerinde küçük sürüler halinde görülmektedirler.\n\n1 metre uzunluğa, 20 kg ağırlığa ulaşırlar. Olta avcılığı son derece zevkli, eti lezzetli ama az bulunan bir balıktır.\n\n35. Tekir Balığı\n\nBilimsel adı Mullus surmuletus olan Tekir, Mullidae familyasından bir deniz balığıdır. Akdeniz, Karadeniz ve Ege denizi balık türleri arasındadır.\n\n5 metrelik sığ sulardan 400 metre derinlikteki sulara kadar uzanan yaşam alanları vardır. Kaydedilmiş en büyük boyutları 40 cm ve 1 kg’dır ancak sularımızda yaygın olarak 25 cm civarında görülürler. Ticari değeri olan bir balıktır ve av balığı olarak da kullanılmaktadır.\n\n36. Trakonya Balığı\n\nTrakonya balığı halk arasında dragon balığı olarak da bilinmektedir. Trachinidae ailesinden olan balığın bilimsel adı Trachinus draco’dur.\n\nVücudunda zehirli dikenlere sahiptir ve dokunulduğunda toksik bir madde salgılar. Zehirli Ege balıkları arasındadır. Zehri kuvvetlidir, uzuv kaybı veya kalp krizine neden olabilmektedir.\n\n1 metre ile 150 metre arasında kumlu, çakıllı alanlarda yaşamaktadır. Küçük balıklar, omurgasızlar ve kabuklular ana besinleridir. En fazla 55 cm boyuta ulaşabilirler ve genellikle 25 cm civarında görülürler. Ticari değer yoktur.\n\n37. Trança\n\nEge balıkları arasında meşhurlaşmış türlerden biridir. Bölgede Çavuş, Antenli mercan, Altınkaş isimleri ile de bilinir. Bilimsel adı Pagrus caeruleostictus’dur ve mercan familyasından bir türdür.\n\nSığ ve sıcak sularda tek olarak yaşayan iri bir balıktır. Etçil bir balıktır ve kafadanbacaklılar, küçük balıklar ana besinleridir. Okyanuslara ve farklı denizlere sürekli göç eden balıklardandır.\n\nYetişkin boyutları 60-75 cm civarındadır ancak 1 metre üzerine de çıkabilmektedir. Ekonomik değeri yüksek, lezzetli bir balıktır.\n\n38. Zurna Balığı\n\nZurna balığı (Scomberesox saurus), Scomberesocidae familyasından bir deniz balığıdır. Açık denizlerde yaşayan bu tür, Süveyş kanalının açılmasından sonra Akdeniz ve Ege denizlerinde görülmüştür.\n\nEn fazla 50 cm, ortamala 35 cm boyutlarındadır. Balık yavruları ve plankton ile beslenir. Avlanmadıkları için herhangi bir ticari değeri yoktur.";

            string[] BalıklarAyrılmış = BalıkStringleriniAyırma(text);//balıkları 1. 2. olarak stringlere ayıran methodu çalıştırma

            List<EgeDeniziB> balıkListesi = new List<EgeDeniziB>();// Balık generic list oluşturma

            for (int i = 0; i < BalıklarAyrılmış.Length; i++)//balıkları EgeDeniziB objesi haline getirip listeye atma döngüsü
            {
                EgeDeniziB balık = BalıkClassOluştur(BalıklarAyrılmış[i]);// balık nesnesi oluşturma
                balıkListesi.Add(balık);
            }


            List<List<EgeDeniziB>> BileşikBalıkListesi = new List<List<EgeDeniziB>>(4);//balık listesini 10 10 10 8 şeklinde atacağımız bileşik liste

            for (int i = 0; i < 4; i++)//4 grup haline getirmek için döngü
            {
                List<EgeDeniziB> grup = new List<EgeDeniziB>(10);//Grup listesini oluşturma
                for (int j = 0; j < 10; j++)//10 eleman ekleme döngüsü
                {
                    int index = i * 10 + j;
                    if (index < balıkListesi.Count) // boyut kontrolü
                    { grup.Add(balıkListesi[index]); }//gruba ekleme

                }
                BileşikBalıkListesi.Add(grup);// grubu bileşik listeye ekleme
            }

            BileşikListeyiYazdır(BileşikBalıkListesi);//bileşik listeyi yazdırma

            //Balık Yığıtı
            BalıkYığıtı balıkYığıtı = new BalıkYığıtı(38);//Balık yığıtı oluşturma
            foreach (EgeDeniziB balık in balıkListesi)//balıklistesindeki elemanları balıkyığıtına aktarma döngüsü
            {
                balıkYığıtı.push(balık);//en üste ekleme
            }

            //Balık yığıtını yazdırma döngüsü
            Console.WriteLine("BALIK YIĞITI: ");
            Console.WriteLine();
            while (!balıkYığıtı.isEmpty())
            {
                Console.WriteLine(balıkYığıtı.pop());//sondaki elemanı silip yazdırıyoruz
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine();


            //Balık Kuyruğu
            BalıkKuyruğu balıkKuyruğu = new BalıkKuyruğu(38);
            foreach (EgeDeniziB balık in balıkListesi)//balıklistesindeki elemanları balıkKuyruğuna aktarma döngüsü
            {
                balıkKuyruğu.insert(balık);//en üste ekleme
            }
            //Balık Kuyruğunu yazdırma döngüsü
            Console.WriteLine("BALIK KUYRUĞU: ");
            Console.WriteLine();
            while (!balıkKuyruğu.isEmpty())
            {
                Console.WriteLine(balıkKuyruğu.remove());//baştaki elemanı silip yazdırıyoruz
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine();


            //Öncelikli Balık Kuyruğu
            ÖncelikliBalıkKuyruk öncelikliBalıkKuyruğu = new ÖncelikliBalıkKuyruk(38);
            foreach (EgeDeniziB balık in balıkListesi)//balıklistesindeki elemanları öncelikliKuyruğa aktarma döngüsü
            {
                öncelikliBalıkKuyruğu.ekle(balık);//en üste ekleme
            }
            //Öncelikli Kuyruğu yazdırma döngüsü
            Console.WriteLine("BALIK ÖNCELİKLİ KUYRUĞU: ");
            Console.WriteLine();
            while (!öncelikliBalıkKuyruğu.bosMu())
            {
                Console.WriteLine(öncelikliBalıkKuyruğu.sil());//en öncelikli elemanı silip yazdırıyoruz
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine();

            
            
            int[] müşteriSepetleri = { 15, 1, 12, 8, 7, 4, 21, 3, 2, 6, 5, 9, 11};//müşterilerin sepetlerindeki elemanları tutan array
            
            TamsayıKuyruğu marketSırası = new TamsayıKuyruğu(müşteriSepetleri.Length);// marketSırası kuyruğumuzu oluşturuyoruz
            List<double[]> müşteriİşlemSüreleri = new List<double[]>();//müşterilerin normal kuyruğa göre sürelerini tutan bağlı liste
            foreach (int s in müşteriSepetleri) { marketSırası.ekle(s); } //elemanları oluşturduğumuz kuyruğa ekliyoruz

            Console.WriteLine("NORMAL KUYRUĞA GÖRE İŞLEM SÜRELERİ:");
            while (!marketSırası.bosMu())
            {
                int silinen = marketSırası.sil(); //sırayla sepetleri siliyoruz ve ürün sayısını değere atıyoruz (sil metodu zaten değerleri yazdırıyor)
                müşteriİşlemSüreleri.Add(new double[] { silinen, marketSırası.getToplamSüre(), marketSırası.getOrtalama() });
            }
           
            // işlem sürelerini öncelikli kuyrukla aynı sırada olması için sıralama
            List<double[]> sıralıSüreler = müşteriİşlemSüreleri.OrderBy(s => s[0]).ToList();


            ÖncelikliTamSayıKuyruğu marketSırasıÖncelikli = new ÖncelikliTamSayıKuyruğu(müşteriSepetleri.Length);// marketSırası kuyruğumuzu oluşturuyoruz
            List<double[]> müşteriÖncelikliİşlemSüreleri = new List<double[]>();//müşterilerin öncelikli kuyruğa göre sürelerini tutan bağlı liste
            foreach (int s in müşteriSepetleri) { marketSırasıÖncelikli.ekle(s); } //elemanları oluşturduğumuz kuyruğa ekliyoruz
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("ÖNCELİKLİ KUYRUĞA GÖRE İŞLEM SÜRELERİ:");
            while (!marketSırasıÖncelikli.bosMu()) 
            { 
                int silinen = marketSırasıÖncelikli.sil();//sırayla sepetleri siliyoruz ve ürün sayısını değere atıyoruz
                //süreleri ürün sayısı ile birlikte bağlı listemize ekliyoruz
                müşteriÖncelikliİşlemSüreleri.Add(new double[] { silinen, marketSırasıÖncelikli.getToplamSüre(), marketSırasıÖncelikli.getOrtalama() });
            }

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("MÜŞTERİ İŞLEM SÜRELERİ KARŞILAŞTIRMASI\t\t İŞLEM SÜRESİ  ORTALAMA SÜRE");
            for (int i = 0; i < müşteriÖncelikliİşlemSüreleri.Count(); i++)
            {
                double ürünSayısı = müşteriÖncelikliİşlemSüreleri[i][0];
                double[] normal = sıralıSüreler[i];
                double[] öncelikli = müşteriÖncelikliİşlemSüreleri[i];

                Console.WriteLine($"{ürünSayısı} ürünü olan müşteri; \t Normal Kuyruk :\t {normal[1]:F2} sn,\t {normal[2]:F2} sn" +
                                                           $"\n\t\t\t Öncelikli Kuyruk :\t {öncelikli[1]:F2} sn,\t {öncelikli[2]:F2} sn");
                Console.WriteLine();
            }

        }//Main kapanış


        static string[] BalıkStringleriniAyırma(string text)// text dosyasını sıralamaya göre ayıran method
        {
            string[] BalıklarAyrılmış = new string[38];// son array
            //string[] textSatırAyrılmış = text.Split("\n\n"); satır başlarındaki sıralama sayılarını kontrol etmek için tek tek her harfi dönmemek için oluşturduğumuz array

            for (int i = 1; i < 39; i++)
            {
                int index1 = 0, index2 = 0;
                if (i < 10)//s sıralama sayısına eşit ise ("1." den "9." kadar) indexleri alınıyor
                {
                    index1 = text.IndexOf(i + ".") + 2; //2 ekleyerek baştaki sayıyı atıyoruz ve aradığımız sayının başlama indexini buluyoruz
                    index2 = text.IndexOf((i + 1) + ".") - 4;
                }
                else if (i < 38)//10,11....37
                {
                    index1 = text.IndexOf(i + ".") + 3; // 4 ekliyoruz çünkü sayılar çift basamaklı ve 1 boşluk da siliyoruz aynı hizada olmaları için
                    index2 = text.IndexOf((i + 1) + ".") - 4;//sonraki sayının başladığı index \n\n çıkarmak için 4 çıkarıyoruz
                }
                else //38. eleman için
                {
                    index1 = text.IndexOf(i + ".") + 3;
                    index2 = text.Length - 1;//39. eleman olmadığı için sona kadar gidyoruz
                }

                int length = index2 - index1 + 1;//text parçasının uzunluğu
                BalıklarAyrılmış[i - 1] = text.Substring(index1, length);
            }
            return BalıklarAyrılmış;
        }

        static string[] AdAyırma(string adSatırı)//iki adı varsa diğer adı alınıyor
        {
            string[] AdSatırı = adSatırı.Split('(');//eğer ( varsa ayırılıyor
            string[] AdSatırıAyrılmış = new string[2];
            AdSatırıAyrılmış[0] = AdSatırı[0];
            AdSatırıAyrılmış[1] = AdSatırı.Length > 1 ? AdSatırı[1].Replace(')', ' ').Trim() : "Diğer Adı Yok";

            return AdSatırıAyrılmış;
        }
        static EgeDeniziB BalıkClassOluştur(string balık)//verilen stringi balık classına dönüştüren method
        {
            string[] balıkSatırAyrılmış = balık.Split("\n\n");//balığın satırları ayrılıyor

            string AdSatırı = balıkSatırAyrılmış[0];//ilk ad satırı
            string[] AdSatırıAyrılmış = AdAyırma(AdSatırı);//diğer adı ayrılıyor
            string ad = AdSatırıAyrılmış[0];
            string DiğerAd = AdSatırıAyrılmış[1];

            string boyut = "", bilgi = "";
            List<string> bölgeler = new List<string>();

            for (int i = 1; i < balıkSatırAyrılmış.Length; i++)//tüm satırları döndüğümüz for döngüsü
            {
                string satır = balıkSatırAyrılmış[i];
                
                bilgi += satır;//bilgi kısmına satır her türlü ekleniyor

                // içinde boyut ile ilgili kelimeler geçen paragraflar boyut paragrafına ekleniyor
                if (satır.Contains("boyut") || satır.Contains("cm") || satır.Contains("uzunluk") || satır.Contains("uzunluğa"))
                {
                    boyut += satır;
                }
                
                //ortam için bölgelerin paragrafta geçtiğini kontrol ediyoruz
                if (satır.Contains("Ege") && !bölgeler.Contains("Ege")) { bölgeler.Add("Ege"); }
                else if (satır.Contains("Akdeniz") && !bölgeler.Contains("Akdeniz")) { bölgeler.Add("Akdeniz"); }
                else if (satır.Contains("Karadeniz") && !bölgeler.Contains("Karadeniz")) { bölgeler.Add("Karadeniz"); }
                else if (satır.Contains("Marmara") && !bölgeler.Contains("Marmara")) { bölgeler.Add("Marmara"); }
            }
            return new EgeDeniziB(ad, DiğerAd, boyut, bilgi, bölgeler);
        }//balık class oluştur kapanışı

        static void BileşikListeyiYazdır(List<List<EgeDeniziB>> BListe)
        {
            int count = 0, DiğerAdSayısı;
            foreach (List<EgeDeniziB> Liste in BListe)
            {
                int sayac = 0;
                DiğerAdSayısı = 0;
                Console.WriteLine("GRUP " + count + " İÇİN BİLGİLER: \n");
                for (int i = 0; i < Liste.Count; i++)
                {
                    EgeDeniziB balık = Liste[i];
                    Console.WriteLine("BALIK " + (i + 1));
                    if (balık.DiğerAdı != "Diğer Adı Yok") { DiğerAdSayısı++; }//diğer adı varsa sayaç artıyor
                    Console.WriteLine(balık.ToString());
                    Console.WriteLine();
                    if(balık.Boyut.Equals(null)){ sayac++; }
                }
                count++;
                Console.WriteLine("Bu gruptaki Diğer Ad sayısı: " + DiğerAdSayısı);
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine();
            }
        }

    }//class program kapanışı
    class EgeDeniziB
    {
        public string BalıkAdı, DiğerAdı, Boyut, Bilgi;
        public List<string> Ortam { get; set; }//ortam sayısı değişebileceği için liste olarak oluşturduk

        public EgeDeniziB()
        {
            BalıkAdı = "";
            DiğerAdı = "";
            Boyut = "";
            Bilgi = "";
            Ortam = new List<string>();
        }
        public EgeDeniziB(string balıkAdı, string diğerAdı, string boyut, string bilgi, List<string> ortam)//constructor
        {
            BalıkAdı = balıkAdı;
            DiğerAdı = diğerAdı;
            Boyut = boyut;
            Bilgi = bilgi;
            Ortam = ortam;
        }

        public override string ToString()
        {
            // ortam listesini string olarak birleştir
            string ortamBilgisi = (Ortam != null && Ortam.Count != 0) ? (string.Join(", ", Ortam)) : ("Bilgi yok");

            // tüm bilgileri birleştirdik ve döndürdük
            return $"BALIK ADI: {this.BalıkAdı}\n" +
                   $"DİĞER ADI: {this.DiğerAdı}\n" +
                   $"BOYUT: {this.Boyut}\n" +
                   $"BİLGİ: {this.Bilgi}\n" +
                   $"ORTAM: {ortamBilgisi}";
        }

    }

    class BalıkYığıtı
    {
        private int maxSize;        // arrayin boyutu
        private EgeDeniziB[] stackArray;
        private int top;            // en üst eleman
                                    
        public BalıkYığıtı(int size)         // constructor
        {
            maxSize = size;             //Arrayin boyutunu ayarlıyoruz
            stackArray = new EgeDeniziB[maxSize];  // array oluştur
            top = -1;                // item yok
        }
        
        public void push(EgeDeniziB b)    // en üste eleman ekleme
        {
            stackArray[++top] = b;     // top 1 artırıp elemanı ekle
        }

        public EgeDeniziB pop()           // en üstten eleman silme
        {
            return stackArray[top--];  // elemanı döndürüp en üstü 1 azaltıyoruz
        }
        
        public EgeDeniziB peek()          // en üstteki elemanı görme
        {
            return stackArray[top];
        }
        
        public bool isEmpty()  
        {
            return (top == -1); // en üstü 1 azaltıyoruz
        }
        
        public bool isFull() 
        {
            return (top == maxSize - 1); // top sınıra ulaşmış mı kontrolü
        }
        public int count()
        {
            return top + 1;
        }

    }// BalıkYığıtı Sonu


    class BalıkKuyruğu
    {
        private int maxSize;
        private EgeDeniziB[] kuyrukArray;
        private int front,rear;
        private int nItems;
        
        public BalıkKuyruğu(int s)          // constructor
        {
            maxSize = s;
            kuyrukArray = new EgeDeniziB[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }
        
        public void insert(EgeDeniziB j)   // en arkaya eleman ekleme
        {
            if (rear == maxSize - 1)         // en sona ulaştıysa başa dön
                rear = -1;
            kuyrukArray[++rear] = j;         // önü 1 artırıp ekle
            nItems++;                     // item sayısını artır
        }
        
        public EgeDeniziB remove()         // en önden eleman silme
        {
            EgeDeniziB temp = kuyrukArray[front++]; // elemanı alıp en önü 1 artır
            if (front == maxSize)           // en sona ulaştıysa başa dön
                front = 0;
            nItems--;                      // item sayısını azalt
            return temp;//silinen elemanı döndür
        }
        
        public EgeDeniziB peekFront()      // en öndeki elemanı döndürme
        {
         return kuyrukArray[front];
        }
        
        public bool isEmpty()    // boş mu
        {
            return (nItems == 0);
        }
        
        public bool isFull()     // dolu mu
        {
            return (nItems == maxSize);
        }
        
        public int size()   //kuyruk boyutu
        {
            return nItems;
        }
        
    }//BalıkKuyruğu bitiş


    class ÖncelikliBalıkKuyruk
    {
        private int maxSize;
        private List<EgeDeniziB> liste;
        

        public ÖncelikliBalıkKuyruk(int s)//yapılandırıcı method
        {
            maxSize = s;
            liste = new List<EgeDeniziB>(s);
        }

        public void ekle(EgeDeniziB b)//listeye eleman ekleme
        {
            liste.Add(b);
        }

        public EgeDeniziB sil()//en öncelikli elemanı silme 
        {
            string enÖncekiAd="";// karşılaştırma için en öncelikli ad
            EgeDeniziB enÖncekiBalık=new EgeDeniziB();//silinecek en öncelikli ada sahip balık
            foreach(EgeDeniziB b in liste)
            {
                
                if (enÖncekiAd == "") 
                { 
                    enÖncekiAd = b.BalıkAdı; 
                    enÖncekiBalık = b;
                }
                else if (b.BalıkAdı.CompareTo(enÖncekiAd) == -1)
                {
                    enÖncekiAd = b.BalıkAdı;
                    enÖncekiBalık=b;
                }
            }
            liste.Remove(enÖncekiBalık);
            return enÖncekiBalık;
        }

        public bool bosMu()
        {
            return liste.Count == 0;
        }

    }//öncelikli kuyruk bitiş

    class TamsayıKuyruğu
    {
        private Queue<int> kuyruk;
        private int toplamMüşteriSayısı;
        private double toplamSüre = 0,ortalama = 0;
        private double aktifSüre;
        private double işlemSüresi = 3.3;

        public TamsayıKuyruğu(int s)// oluşturucu
        {
            kuyruk = new Queue<int>(s);
            toplamMüşteriSayısı = 0;
            aktifSüre = toplamSüre = 0;
        }

        public void ekle(int j)   // en arkaya eleman ekleme
        {
            kuyruk.Enqueue(j);
        }

        public int sil()  // en önden eleman silme ve süre hesaplama
        {
            int sepet=0; 
            if (!this.bosMu())//kuyruk boş mu kontrolü
            {
               sepet = kuyruk.Dequeue();//öndeki elemanı silip değere ata
            }
            else { Console.WriteLine("Kuyruk Boş");return 0; }//boşsa 0 döndür
            
            aktifSüre = sepet * işlemSüresi;//aktif müşterinin işlem süresi
            toplamSüre += aktifSüre;//toplam süreyi artır
            toplamMüşteriSayısı++;//toplam item sayısını artır (ortalama hesaplamak için)
            ortalama = toplamSüre / toplamMüşteriSayısı;

            Console.WriteLine($"{sepet} ürünü olan müşterinin; İşlem tamamlanma süresi: {toplamSüre:F2}\t    Ortalama işlem süresi: {ortalama:F2}");
            Console.WriteLine();
            return sepet;//silinen elemanı döndür
        }
        public bool bosMu()    // boş mu
        {
            return (kuyruk.Count == 0);
        }

        public int uzunluk() { return kuyruk.Count; }

        public double getToplamSüre()
        {
            return toplamSüre;
        }
        public double getOrtalama()
        {
            return ortalama;
        }

    }

    class ÖncelikliTamSayıKuyruğu
    {
        private List<int> liste;
        private int toplamMüşteriSayısı;
        private double toplamSüre = 0,ortalama = 0;
        private double aktifSüre;
        private double işlemSüresi = 3.3;


        public ÖncelikliTamSayıKuyruğu(int s)//yapılandırıcı method
        {
            toplamMüşteriSayısı = 0;
            liste = new List<int>(s);
        }

        public void ekle(int b)//listeye eleman ekleme
        {
            liste.Add(b);
        }

        public int sil()//en öncelikli elemanı silme 
        {
            int enKüçükSayı = int.MaxValue;// karşılaştırma için en büyük sayı atıyoruz
            if (bosMu())//kuyruk boş ise 0 döndürüyoruz
            {
                Console.WriteLine("Kuyruk Boş");
                return 0;
            }
            else
            {
                enKüçükSayı = liste.Min();//listedeki en küçük sayıyı bulma methodu

                liste.Remove(enKüçükSayı);//en küçük sayıyı çıkarma
                aktifSüre = enKüçükSayı * işlemSüresi;//şuanki müşteri için toplam işlem süresi
                toplamSüre += aktifSüre;//şuanki süreyi toplam süreye ekleme
                toplamMüşteriSayısı++;//toplam item sayısını artır (ortalama hesaplamak için)
                ortalama = toplamSüre / toplamMüşteriSayısı;
                Console.WriteLine($"{enKüçükSayı} ürünü olan öncelikli müşterinin; İşlem tamamlanma süresi: {toplamSüre:F2}\t    Ortalama işlem süresi: {ortalama:F2}");
                Console.WriteLine();
                return enKüçükSayı;
            }
        }

        public bool bosMu()
        {
            return liste.Count == 0;
        }

        public double getToplamSüre()
        {
            return toplamSüre;
        }
        public double getOrtalama()
        {
            return ortalama;
        }

    }//öncelikli tamsayı kuyruk bitiş
}
