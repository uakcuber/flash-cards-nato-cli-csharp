using System.Collections.Generic;
namespace Flash_Cards
{

    class Program
    {
        Dictionary<string, string> alfabe = new Dictionary<string, string>()
        {
            ["A"] = "Alpha",
            ["B"] = "Bravo",
            ["C"] = "Charlie",
            ["D"] = "Delta",
            ["E"] = "Echo",
            ["F"] = "Foxtrot",
            ["G"] = "Golf",
            ["H"] = "Hotel",
            ["I"] = "India",
            ["J"] = "Juliett",
            ["K"] = "Kilo",
            ["L"] = "Lima",
            ["M"] = "Mike",
            ["N"] = "November",
            ["O"] = "Oscar",
            ["P"] = "Papa",
            ["Q"] = "Quebec",
            ["R"] = "Romeo",
            ["S"] = "Sierra",
            ["T"] = "Tango",
            ["U"] = "Uniform",
            ["V"] = "Victor",
            ["W"] = "Whiskey",
            ["X"] = "X-ray",
            ["Y"] = "Yankee",
            ["Z"] = "Zulu",
        };


        public static void Main()
        {
            Console.Clear();
            string secim_val = "";
            var program = new Program();
            Random rand = new Random();

            Console.WriteLine("|  NATO phonetic alphabet code words");
            Console.WriteLine("|");
            Console.WriteLine("|  A -> Alpha      B -> Bravo       C -> Charlie    D -> Delta");
            Console.WriteLine("|  E -> Echo       F -> Foxtrot     G -> Golf       H -> Hotel");
            Console.WriteLine("|  I -> India      J -> Juliett     K -> Kilo       L -> Lima");
            Console.WriteLine("|  M -> Mike       N -> November    O -> Oscar      P -> Papa");
            Console.WriteLine("|  Q -> Quebec     R -> Romeo       S -> Sierra     T -> Tango");
            Console.WriteLine("|  U -> Uniform    V -> Victor      W -> Whiskey    X -> X-ray");
            Console.WriteLine("|  Y -> Yankee     Z -> Zulu");
            Thread.Sleep(5000);
            Console.Clear();

            do
            {
                int random_sayi = rand.Next(27);
                KeyValuePair<string, string> random_dict = program.alfabe.ElementAt(random_sayi);
                Console.Write($"{random_dict.Key} -->");
                secim_val = Console.ReadLine()!;
                if (secim_val.ToLower() == random_dict.Value.ToLower())
                {
                    Console.WriteLine($"DOĞRU! {random_dict.Key}->{random_dict.Value}");
                }

                else
                {
                    Console.WriteLine($"YANLIŞ {random_dict.Key}-->{random_dict.Value}");
                }

            }
            while (secim_val != "exit");

        }


    }
}
