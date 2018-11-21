using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzor
{
    class KonkretnyBudowniczy2 : Budowniczy
    {

        

            public Order OrderInstance { get; private set; }

            public KonkretnyBudowniczy2()
            {
                OrderInstance = new Order();
                OrderInstance.Punkty = true;
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
