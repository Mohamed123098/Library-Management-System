using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Library<T> where T:IItem
    {
        List<T> Items { get; set; }
        public Library(List<T> item)
        {
            Items = item;
        }
        public void Add(T Item)
        {
            if(Item!=null)
            {
                Items.Add(Item);
                Item.Status = Status.Avaliable;
            }
        }

        public void Search(string titleOrAuthor)
        {
            bool isFound = false;
            foreach (var Item in Items.ToList())
            {
                if (Item.Title.ToLower() == titleOrAuthor.ToLower() || Item.Author.Name.ToLower() == titleOrAuthor.ToLower())
                {
                    Console.WriteLine(Item);
                    isFound = true;
                }

            }
            if (!isFound) Console.WriteLine("this book is not found");
            
        }
       public void Borrow(Guid id)
        {
            foreach (var item in Items)
            {
                if(item.ISBN==id)
                {
                    item.Status = Status.Borrowed;
                }
            }
        }
        public void Returned(Guid id)
        {
            foreach (var item in Items)
            {
                if (item.ISBN == id)
                {
                    item.Status =Status.Reuterned ;
                }
            }
        }

    }
}
