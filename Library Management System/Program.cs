namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new();
            Library<Book> library = new(books);
            string selectedOption = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                selectedOption = PrintOptions();
                switch (selectedOption)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Book book = new();
                        Console.Write("Enter Book title : ");
                        book.Title = Console.ReadLine();
                        Console.Write("Enter Author Name: ");
                        book.Author.Name = Console.ReadLine();
                        Console.Write("Enter Author Age: ");
                        book.Author.Age = Convert.ToInt32(Console.ReadLine());
                        books.Add(book);
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        foreach (var b in books)
                        {
                            Console.WriteLine(b.ToString());
                            Console.WriteLine("-----------------");
                        }
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("Enter title or Author name: ");
                        library.Search(Console.ReadLine());
                        
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        bool isBorrowed = false;
                        foreach (var item in books)
                        {
                            if(title.ToLower()==item.Title.ToLower()&&(item.Status==Status.Avaliable||item.Status==Status.Reuterned))
                            {
                                library.Borrow(item.ISBN);
                                Console.WriteLine("Borrow successfully");
                                isBorrowed = true;
                                break;
                            }

                        }
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        if (!isBorrowed) Console.WriteLine("Not Found or not avaliable for borrowing");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter title: ");
                        string t = Console.ReadLine();
                        bool isReturned = false;
                        foreach (var item in books)
                        {
                            if (t.ToLower() == item.Title.ToLower() && item.Status == Status.Borrowed)
                            {
                                library.Returned(item.ISBN);
                                Console.WriteLine("Return successfully");
                                isReturned = true;
                                break;
                            }

                        }
                        if (!isReturned)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Error is not found borrowed book with the entered title");
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.White;
                        
                        break;


                }

            }
            while (selectedOption != "6");
            }
            
                static string PrintOptions()
                {
                    Console.WriteLine("\n===== LIBRARY MANAGEMENT SYSTEM =====");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. View All Books");
                    Console.WriteLine("3. Search Book");
                    Console.WriteLine("4. Borrow Book");
                    Console.WriteLine("5. Return Book");
                    Console.WriteLine("6. Exit");
                    Console.Write("Select an option: ");
                    string choice = Console.ReadLine();
                    return choice;
                }
            }
}
