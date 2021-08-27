using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classlar_2
{
    // Buradaki örnekte Interfacelere neden ihtiyacımız olduğunu açıkça görmekteyiz sebebi şudur: 

    // Diyelim ki buraya ayı hayvanını eklemek istiyoruz. Ayı hem etcil hem de otculdur. Ancak C# programlama dili
    // çoklu kalıtıma izin vermez bu yüzden Ayı sınıfı hem Etcil hem de Otcul sınıfından kalıtım alamaz bu yüzdendir ki 
    // bir sınıf için birden fazla interfaceden kalıtım alınabilir. 

    abstract class Etcil 
    {
        public abstract void Etye();
    }

    abstract class Otcul 
    {
        public abstract void Otye();
    }

    class Aslan : Etcil 
    {
        public override void Etye()
        {
            Console.WriteLine("Aslan eti yedi.");
        }
    }

    class Inek : Otcul
    {
        public override void Otye()
        {
            Console.WriteLine("İnek otu yedi.");
        }
    }



}
