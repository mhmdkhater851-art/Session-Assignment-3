using System.Text;

namespace Session_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            //both title and upperTitle to show that title did not change.

            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Q02
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.

            //string str01 = "Clean Code";
            //string str02 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(str01, str02)); // Yes they point to the same object in the memory.
            #endregion

            #region Q03
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.

            //StringBuilder sb = new StringBuilder();
            //sb.Append(("Book List"));
            //sb.Append((" - Updated"));
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Q04
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.

            //sb.Replace(("Book List"), ("Library"));
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Q05
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //Pages: 464" using the + operator.

            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book: " + title + ", Pages: " + pages);
            #endregion

            #region Q06
            //Build the same sentence as above, but using string interpolation ($"...").
            //Console.WriteLine($"Book: {title}, Pages: {pages}");
            #endregion

            #region Q07
            //Build the same sentence again, but using string.Format().
            Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));
            #endregion
        }
    }
}
