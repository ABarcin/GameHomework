using GameHomework.Adapters;
using GameHomework.Concrete;
using GameHomework.Entities;
using System;
using System.Collections.Generic;

namespace GameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { DateOfBirth = new DateTime(1990, 1, 1), FirstName = "Ahmet", LastName = "Barçın", NationalId = "11111111111", Id = 1, Platform = "PC" };
            Customer customer2 = new Customer { DateOfBirth = new DateTime(1992, 1, 1), FirstName = "Kubra", LastName = "Kubra", NationalId = "22222222222", Id = 2, Platform = "XBox" };
            MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();
            MyGameCustomerManager myGameCustomerManager = new MyGameCustomerManager(mernisServiceAdapter);
            myGameCustomerManager.Save(customer1);
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_");
            Game game1 = new Game {Id=1,GameName="Red Dead Redemption 2",GameType="ActionWest",Price=240,GamePlatform="PC"};
            Game game2 = new Game {Id =2, GameName = "Gta 5", GameType = "Action", Price = 180 ,GamePlatform="XBox"};
            Game game3 = new Game { Id = 3, GameName = "CyberPunk 2077", GameType = "Cyber", Price = 300,GamePlatform="PC"};

            List<Customer> customers = new List<Customer>() { customer1, customer2 };
            List<Game> games = new List<Game>() { game1, game2, game3 };

            MyGameSaleManager myGameSaleManager = new MyGameSaleManager();
            myGameSaleManager.Sale(customer2, game1);
            myGameSaleManager.Offer(customers, games);
            myGameSaleManager.SpeacialOffer(customer1, game1);
        }
    }
}
