using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{

    public class Book : IItem
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Guid ISBN { get ; set ; }
        public Status Status { get; set; } = Status.Avaliable;
        public Book()
        {
            ISBN = Guid.NewGuid();
            Author = new();
        }
        public override string ToString()
        {
            return $"ISBN : {ISBN}\tTitle: {Title}\tStatus : {Status}\tAuthor Name : {Author.Name}\tAuthor Age : {Author.Age}";
        }
    }
}
