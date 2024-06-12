namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ValueType
            //int x;
            //x = 4;
            //Int32 y;
            //y = x;
            //x++;
            //Console.WriteLine(x + "   " + y);
            #endregion
            #region ReferenceType
            //Point P1;
            //P1 = new();
            //Point P2 = new();
            //P2 = P1;
            //P1.x = 9;
            //Console.WriteLine(P2.x);
            //Console.WriteLine(P2.ToString());
            #endregion
            #region Object
            //object o1;
            //o1 = "o1 is now a string";
            //Console.WriteLine(o1);
            //o1 = 2;
            //Console.WriteLine(o1);
            //o1 = false;
            //Console.WriteLine(o1); 
            #endregion
            #region Parsing
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int num_2 = Convert.ToInt32(num.ToString());
            bool flag = Convert.ToBoolean("FALSE");
            Console.WriteLine(flag); 
            #endregion
        }
    }
}
