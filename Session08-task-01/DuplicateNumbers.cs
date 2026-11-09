namespace Session11_task
{
    internal class DuplicateNumbers
    {
        static void Main(string[] args)
        {

                List<int> numbers = new List<int>();

                Console.WriteLine("Enter 5 numbers:");

                for (int i = 0; i < 5; i++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(number);
                }

                try
                {
                    CheckDuplicates(numbers);
                    Console.WriteLine("No duplicates found.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            static void CheckDuplicates(List<int> numbers)
            {
                List<int> checkedNumbers = new List<int>();

                foreach (int number in numbers)
                {
                    if (checkedNumbers.Contains(number))
                    {
                        throw new Exception("Duplicate number found: " + number);
                    }

                    checkedNumbers.Add(number);
                }
            }
        }

    }


