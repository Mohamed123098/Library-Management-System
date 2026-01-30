using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public interface IItem
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public Guid ISBN { get; set; }
        public Status Status { get; set; }

    }
}
