using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    public interface ISaleService
    {
        void Sale( Customer customer,Game game);
        void Offer(List<Customer> customers, List<Game> games);
        void SpeacialOffer(Customer customer, Game game);
    }
}
