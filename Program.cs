using System.Runtime.CompilerServices;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] table = new string[20000];
            string inputpath = "C:\\Users\\flsab\\Downloads\\lab1csv.csv";
            string all = "";
            using (var reader = new StreamReader(inputpath))
            {
                
                all = reader.ReadToEnd();
            }
            table = all.Split('\n');
            Array.Resize(ref table, table.Length-1);
            for (int i = 0; i < table.Length; i++)
            {

                table[i] = table[i].Replace('"', ' ');
                table[i] = table[i].Replace('\n', ' ');
            }

                

            string[,] tableToConsole = new string[table.Length,19];
            string[] line = new string[19];

            for (int i = 0; i < table.Length; i++)
            {
                
                line = table[i].Split(',');

                for (int j = 0; j < line.Length; j++)
                {
                    tableToConsole[i, j] = line[j];
                }
            }

            for (int i = 0; i < tableToConsole.Length-1; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    Console.Write("{0}  ", tableToConsole[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}