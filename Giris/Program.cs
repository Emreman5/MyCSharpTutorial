
// C Sharp' ta modüllerimizi using notasyonu ile çağırıyoruz
using System; // System modülünü Program.cs isimli betiğe çağırır.


// namespace, Türkçe Karşılığı isim uzayı anlamına gelmektedir.
// Aynı amaca hizmet eden özellikleri, metodları ve sınıfları bir çatı altında tutan yapıya isim uzayı denir.

namespace MyCSharpTutorial
{
    class Program // Program isimli bir Class oluşturuldu.
    {
        // Aşağıdaki notasyon neredeyse bir çok dilde aynıdır.
        // Program derlendikten sonra bu metodun içinde başlar ve yine bu metodun içinde biter.
        
        // Başında bulunan static notasyonu bu metodun nesne olarak oluşturulmadan çalışmasını sağlar.
        // Void geriye herhangi bir değer döndürmediği anlamına gelir.
        // Metodun parametresinde bulunan string[] args ise komut satırı argümanlarını içeri almak için kullanılır. 
        static void Main(string[] args) // Program isimli Class'a Main isimli bir method oluşturuldu. 
        {

            Console.WriteLine("Hello World!");
            // Console isimli bir sınıftan WriteLine isimli bir metodu "Hello World" parametresi ile çağırıyoruz.
            // Bu metod konsolumuza bizim verdiğimiz parametreyi yazdırmakta kullanılır.
        }
    }
    
    // Bu bir yorum satırıdır C Sharp'ta yorum satırları "//" ile oluşturulurlar.
    // Yorum satırları hiçbir şekilde kodun işleyeşine etki etmezler.
    // Genelde kodun başka geliştiriciler tarafından okunurluğunu arttırmak için kullanılırlar.
    
    /* Çoklu yorum satılarımızı da
     
            "/*" notasyonu ile oluştuturuz
     */
    
    
    
}