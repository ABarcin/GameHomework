using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    public class MyGameSaleManager : ISaleService
    {
        public void Offer(List<Customer> customers, List<Game> games)
        {
            if (customers.Count != 0 && games.Count != 0)
            {
                foreach (var customer in customers)
                {
                    foreach (var game in games)
                    {
                        Console.WriteLine(game.GameName+" Fiyatı= "+game.Price+" Lira");
                        Console.WriteLine(customer.FirstName+" Müşterisine Yapılan Teklif "+(game.Price-(game.Price*0.10))+" Lira");
                    }
                    Console.WriteLine("-------------------------------------------");
                }
            }
            else
            {
                throw new Exception("Hatalı Kullanıcı veya Oyun Girişi");
            }
        }

        public void Sale(Customer customer, Game game)
        {
            Console.WriteLine(game.GameName+" "+game.Price+" Liraya "+customer.FirstName+" isimli Müşteriye Satıldı." );
        }

        public void SpeacialOffer(Customer customer, Game game)
        {
            Console.WriteLine(game.GameName +" Fiyatı = "+game.Price);
            Console.WriteLine(game.GameName+" Oyunu "+customer.FirstName+" Müşterimize Kısa Bir Süre İçin Yalnızca "+(game.Price-(game.Price*0.2))+" Lira");
        }
    }
}
