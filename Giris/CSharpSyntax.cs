using System;

namespace RectangleApplication {
   class Rectangle {
      
      double length;
      double width;
      
      public void Acceptdetails() {
         length = 4.5;    
         width = 3.5;
      }
      public double GetArea() {
         return length * width; 
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine(); 
      }
   }
}

Yukarıdaki kod bloğu çalıştırıldığında konsolda görülecek çıktı aşağıdaki gibidir

  Length: 4.5
  Width: 3.5
  Area: 15.75
  
---------------------------------------------------------------------------------------------------
 * using notasyonu programa isim uzayı eklemek başka bir deyişle kütüphane çağırmak için kullanılır

 // "//" tek satırlık yorum eklemek için kullanılır


 /* " /* " çoklu yorum satırı açmak için kullanılır
  kapatmak içinse */ kullanılır 
  
        Variables (Değişkenler) 

 Değişkenler, verileri depolamak için kullanılan veri üyeleridir.
 Yukarıdaki programda, Rectangle sınıfı uzunluk ve genişlik olarak adlandırılan iki değişkene sahiptir.
    
-----------------------------------------------------------------------------------------------------------  
    
          Methods (Metodlar)

  Metotlar, belirli bir görevi yerine getiren ifadeler kümesidir. 
  Bir sınıfın metotları, sınıfın içinde oluşturulur. Örnek sınıfımız Rectangle üç metota sahiptir:
  
----------------------------------------------------------------------------------------------------------
    
         Tanımlayıcıları isimlendirirken dikkat edilmesi gerekenler :

Tanımlıyıcılar bir sınıfı, değişkeni, işlevi veya herhangi bir kullanıcı tanımlı öğeyi tanımlamak için kullanılan bir addır. 
  C#'da sınıfları adlandırmak için temel kurallar aşağıdaki gibidir':

    1. Bir tanımlayıcı isimlendirilken ilk karakter bir harf olmalıdır.
      Tanımlayıcı rakam ve '_' içerebilir.
      Bir tanımlayıcıdaki ilk karakter bir rakam olamaz.
    2. Tanımlayıcı boşluk veya sembol ( - + ! @ # % ^ & * ( ) [ ] { } . ; : " ' / ve \.) içermemelidir.)
      Ancak alt çizgi ( _ ) kullanılabilir.
                                       
    3. Tanımlayıcı C# 'ta bir işlevi olan herhangi bir anahtar kelimesi olmamalıdır.
  
