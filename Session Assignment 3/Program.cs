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

            StringBuilder sb = new StringBuilder();
            sb.Append(("Book List"));
            sb.Append((" - Updated"));
            Console.WriteLine(sb.ToString());
            #endregion
        }
    }
}
