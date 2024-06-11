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
            int x = 5, y = 7;
            y = x;
            x++;
            Console.WriteLine($"x= {x} , y = {y}"); //The value of x changes but y is not affected anymore by the value of x as we passed only value not reference 
            #endregion
        }
    }
}
