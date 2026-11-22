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

            #region Question 6

            // 6. String Concatenation using $
            Console.WriteLine($"pages: {page},Book :{student01}");
            #endregion

            #region Question 7

            // 7. String Concatenation using string.format()
            string student1 = string.Format("Book :{0},pages :{1}", student01, page);
            Console.WriteLine(student1);
            #endregion

            #region Question 8

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
            #endregion

            #region Question 9
            // 9. AND Operator (&&)
            bool isAvailable = true;

            if (pages > 300 && isAvailable == true)
            {
                Console.WriteLine("you can borrow this book");
            }
            #endregion

            #region Question 10

            // 10. Switch Statement

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
            #endregion


            #region Question 11
            // 11. Ternary Operator

            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            #region Question 12
            // 12. For Loop

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion

            #region Question 13

            // 13. While Loop

            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }
            #endregion

            #region Question 14
            // 14. Do-While Loop (Exactly 3 Times)

            do
            {
                Console.WriteLine("Checking book...");
                index++;
            }
            while (index < 3);

            #endregion

            #region Question 15
            // 15. Foreach Loop
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion

            #region Question 16
            // 16. Break Statement

            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }
            #endregion

            #region Question 17
            // 17. Continue Statement

            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    continue;
                }

                Console.WriteLine(book);
            }
            #endregion

            #region Question 18
            // 18. Method with Return

            PrintFirstBook(books);
            static void PrintFirstBook(string[] books)
            {
                if (books.Length == 0)
                {
                    return;
                }

                Console.WriteLine(books[0]);
            }
            #endregion
        }
    }
}
