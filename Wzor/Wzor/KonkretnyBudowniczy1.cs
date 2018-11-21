using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzor
{
    class KonkretnyBudowniczy1 : Budowniczy
    {

        public Order OrderInstance { get; private set; }

        public KonkretnyBudowniczy1()
        {
            OrderInstance = new Order();
            OrderInstance.Punkty = false;
        }




        public override void CreatAddress(string address)
        {

            OrderInstance.Address = address;
        }

    public override void CreatName(string Name)
        {
            OrderInstance.RecipientName = Name;
        }

        public override void CreatOrder(List<Book> booksOrder)
        {
            OrderInstance.BooksOrder = booksOrder;

        }
    }
}
