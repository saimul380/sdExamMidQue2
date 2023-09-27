namespace sdExamq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            int count=0;
            int i;
            for (i = 0; i < firstLine.Length; i++)
            {
                if (secondLine[0] == firstLine[i])
                {
                    count = i + 1;
                    break;
                }
            }
            if(count==0) {
                Console.WriteLine("Does not contain the alphabet");
            }
            else
            {
                Console.WriteLine(count);
            }
        }
    }
}