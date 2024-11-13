using OOPIntro_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPIntro_0
{
    public partial class Form1 : Form
    {


        /*
         
                        OOP(Object Oriented Programming)

          Nesne Yonelimli Programlama bizlere bilgisayarda tanımlı olmayan yapıları tam istedigimiz bir şekilde ve efektif bir şekilde bilgisayarımızın anlayabilecegi bir halde tanımlama imkanı sunar....

        Bizim görebildigimiz, hissedebildigimiz, düsünebildigimiz her şey bir nesnedir... Her nesnenin de tam anlamıyla bilinebilmesi adına bir kavramı(tasarımı/idea) vardır (sablon/tasarım/kalıp).. Bu kavram, ilgili nesnenin özelliklerini ve davranıslarını belirleyen bir yapıdır. Bu da bizim icin class'tır. Class yapısı , bilgisayara ilgili sablonu tanıtır...Yani bilgisayar, class yapısı sayesinde benim ona nasıl bir şey tanıtmak istedigimi anlar ve zihninde (RAM'de) o sablonu olusturur...Yani bilgisayar , class yapısı sayesinde bir ideaya sahip olacaktır...Ancak bu sablon sadece soyut bir düsüncedir...Bizim dolayısıyla bir nesne yaratmak adına yaratmıs oldugumuz bu ideadan(kavram/tasarımdan) nesne yaratma yönetmini kullanarak bir nesne olusturmamız gerekir(instance almak)...Class yaratarak önce bilgisayara yaratmak istedigimiz nesnenin nasıl bir yapıya, hangi özelliklere sahip oldugunu, hangi davranıslarda bulunacagını söyleriz...(yani önce bilgisayarın zihninde o ideayı olustururuz). Sonra o class'tan nesne yaratma yöntemini kullanarak (instance almak) bir nesne yaratırız...

        Ozetle sınıflar(class'lar) bizim nesne yaratmamızı saglayan kalıplardır(tasarım/sablon/idea)

        Siz, bilgisayara bir class tanımladıgınızda artık bilgisayar o class'ı kendi dijital zihninde düsünmeye baslar...O sablon bilgisayar icin bir düsünce kavramındadır...O sablondan istediginiz kadar nesne üretebilirsiniz....

        Instance Almak => Bir class'ın örneginin Ram üzerine kopyalanmasıdır... Bir sınıftan nesne yaratmak icin kullandıgımız bir yöntemdir...Sınıfın üzerinde işlem yapılmaması gerektiginden dolayı o kalıptan bir nesne üretmektir...Ram üzerinde ürettiginiz bu nesne dolayısıyla o kalıbın tüm özelliklerine ve tüm davranıslarına sahip olacaktır...
         
         
         
         
         
         
         
         
         
         
         
         
         
         */

       


        public Form1()
        {
            InitializeComponent();
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {

            Oyuncu birinciOyuncu = new Oyuncu();
            birinciOyuncu.Irk = "İnsan";
            birinciOyuncu.Isim = "Cagri";
            birinciOyuncu.Brans = "Komando";
            birinciOyuncu.Moral = true;
            birinciOyuncu.OzelVurus = 100;


            

            Oyuncu ikinciOyuncu = new Oyuncu();
            ikinciOyuncu.Irk = "İnsan";
            ikinciOyuncu.Isim = "Fatih";
            ikinciOyuncu.Brans = "Ozel tim";
            ikinciOyuncu.Moral = true;
            ikinciOyuncu.OzelVurus = 200;
          
        }
    }
}
