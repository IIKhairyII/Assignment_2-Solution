namespace Assignment_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Problem_1
            Console.WriteLine("Please enter any Number:");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine($"You have entered:  {number}");
            else
                Console.WriteLine($"Make sure to enter a valid number");
            #endregion
            #region Problem_2
            string toBeConverted = "v50";
            Convert.ToInt32(toBeConverted); //Exception will be thrown if string is empty or contains non-numeric char 
            #endregion


        }
    }
}
