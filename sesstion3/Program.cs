using System.Text;

namespace sesstion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // 1. String Immutability and ToUpper()
            string name1;
            name1 = "clean code";
            name1 = name1.ToUpper();

            Console.WriteLine($"Upper title: {name1}");
            #endregion

            #region Question 2

            //2.referance
            string name2;
            name2 = "CleanCode";
            Console.WriteLine(object.ReferenceEquals(name1, name2));
            #endregion

            #region Question 3

            //3.StringBuilder ->Append
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb.ToString());
            #endregion

            #region Question 4

            //4.StringBuilder ->replace
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());
            #endregion

            #region Question 5
            // 5. String Concatenation using +
            StringBuilder cd = new StringBuilder();
            string student01 = "CleanCode";
            int page = 464;
            string route = "pages : " + page + " Book :" + student01;
            Console.WriteLine(route);

            #endregion

            // 6. String Concatenation using $
            Console.WriteLine($"pages: {page},Book :{student01}");

            // 7. String Concatenation using string.format()
            string student1 = string.Format("Book :{0},pages :{1}", student01, page);
            Console.WriteLine(student1);

            // 8. If / Else Statement

            int pages = 464;
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("short Book");
            }

            bool isAvailable = true;

            if (pages > 300 && isAvailable == true)
            {
                Console.WriteLine("you can borrow this book");
            }

            String title = "Refactoring";
            switch (title)
            {
                case "Clean code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nicen pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }



            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }

            do
            {
                Console.WriteLine("Checking book...");
                index++;
            }
            while (index < 3);

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    continue;
                }

                Console.WriteLine(book);
            }
            static void PrintFirstBook(string[] books)
            {
                if (books.Length == 0)
                {
                    return;
                }

                Console.WriteLine(books[0]);
            }
        }
    }
}
