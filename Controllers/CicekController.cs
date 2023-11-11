using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class CicekController : Controller
{
   
    public IActionResult Index (){
        //modelden view'a deger dondurmek icin deger atamalarını gerceklestireceğiz
        Cicek c1 = new Cicek();
        c1.name = "Achille";
        c1.about = "Achillea efsanevi bir bitkidir ve polen taşıyıcılar arasındaki popülaritesinden dolayı her kurak alanın değerli bir parçasıdır. Bu kır çiçeği Avrupa'da ortaya çıkmış olabilir, ancak bugün geniş bir alana yayılmıştır.";
        c1.amount =1500;
        c1.Image = "odev1.jpg";
        return View(c1);
    }

    public IActionResult Shop(){
        var cicekler = new List<Cicek>{
            new Cicek(){
                name= "White Wormwood", about="Beyaz Pelin, Asterales takımının çok yıllık bir çalısıdır. Bu çalı 8-16 inç yüksekliğe kadar büyüyebilir.A. herba-alba'nın gövdeleri sert ve diktir. Beyaz Solucan ağaçları chamaephyte'dir. Bitki ayrıca aromatiktir. Ek olarak, beyaz pelin esansiyel yağlar üretir. Beyaz pelin ağacının yaprakları aromatiktir. İnce salgı bezleri yaprakları kaplar ve çalıya grimsi bir etki verir. Beyaz pelin sapsız çiçekli kafalara sahiptir. Her kafanın 2-5 sarımsı hermafrodit çiçeği vardır."
                , amount= 2000, Image = "odev2.jpg"
            },
            new Cicek(){
                name= "Syringa", about="Syringa, doğu Asya'dan güneydoğu Avrupa'ya kadar ormanlara ve çalılıklara özgü olan ve başka yerlerde ılıman bölgelerde yaygın olarak yetiştirilen Oleaceae (zeytin) familyasındaki odunsu çiçekli bitkilerin bilinen yaklaşık 12 türünden[1] oluşan bir cinstir. Syringa, Idaho'nun devlet çiçeği olarak kutlanıyor."
                , amount= 2900, Image = "odev3.jpg"
            },
            new Cicek(){
                name = "Spider Lily", about="Hymenocallis littoralis veya örümcek zambağıZambak, Latin Amerika'nın ılıman kıyı bölgelerine özgü Hymenocallis cinsinin bir türüdür. Hymenocallis 60'tan fazla çok yıllık bitki türünü içerir.",
                amount=90, Image= "odev4.jpg"
            }

        };
        return View(cicekler);
    }
   
}
