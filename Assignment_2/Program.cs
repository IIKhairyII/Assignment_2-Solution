namespace Assignment_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Problem_1
            //Console.WriteLine("Please enter any Number:");
            //int number;
            //if (int.TryParse(Console.ReadLine(), out number))
            //    Console.WriteLine($"You have entered:  {number}");
            //else
            //    Console.WriteLine($"Make sure to enter a valid number");
            #endregion
            #region Problem_2
            //string toBeConverted = "v50";
            //Convert.ToInt32(toBeConverted); //Exception will be thrown if string is empty or contains non-numeric char 
            #endregion
            #region Problem_3
            //float num1 = 5.5f;
            //float num2 = 6.9f;
            //float result = num1 + num2;
            //Console.WriteLine(result); 
            #endregion
            #region Problem_4
            //string sentence = "Hello world! This is the first assignment in C#";
            //Console.WriteLine(sentence.Substring(0, 13)); 
            #endregion
            #region Problem_5
            //int x = 5, y = 7;
            //y = x;
            //x++;
            //Console.WriteLine($"x= {x} , y = {y}"); //The value of x changes but y is not affected anymore by the value of x as we passed only value not reference 
            #endregion
            #region Problem_6
            //Coordinations coordinations1 = new();
            //Coordinations coordinations2;
            //coordinations2 = coordinations1;
            //coordinations2.longtitude = 50.621;
            //coordinations1.latitude = 31.621;
            //Console.WriteLine(coordinations1.longtitude + "    " + coordinations2.latitude);
            //The 2 variables are changing the values in the same reference. As a result both variables will see the changes from each other
            #endregion
            #region Problem_7
            //Console.WriteLine("Please enter any string:");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Please enter another string:");
            //string str2 = Console.ReadLine();
            //Console.WriteLine($"{str1}  {str2}");
            #endregion
            #region Problem_8
            //int d;
            //d = Convert.ToInt32(!(30 < 20)); // b) A value 1 will be assigned to d.
            //Console.WriteLine(d);
            #endregion
            #region Problem_9
            //Console.WriteLine(13 / 2 + " " + 13 % 2); //d) 6 1 
            ////6 not 6.5 as we divide 2 integers so the point part will be deleted
            #endregion
            #region Problem_10
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z); 
            ////The result is d)7 7
            #endregion
        }
    }
}
