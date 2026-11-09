namespace Session08_task_02
{
    internal class Vowels
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Enter a word:");

                string word = Console.ReadLine();

                try
                {
                    CheckVowels(word);
                    Console.WriteLine("The word contains vowels.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            static void CheckVowels(string word)
            {
                string vowels = "aeiouAEIOU";

                foreach (char letter in word)
                {
                    if (vowels.Contains(letter))
                    {
                        return;
                    }
                }

                throw new Exception("The word does not contain vowels.");
            }
        }

    }
