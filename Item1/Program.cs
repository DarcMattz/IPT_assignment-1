namespace Assignment1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string word = "";

            Console.Write("Input a string: ");
            word = Console.ReadLine();
            
            middle(word);
        }

        static void middle(string word)
        {
            int length = word.Length;
            string mid = "";
            int index = length / 2;

            if (length % 2 != 0)
            {
                mid += word[index];            }
            else
            {
                mid += word[--index];
                mid += word[++index];
            }

            Console.Write("The middle character in the string: " + mid);
            
        }
    }
}