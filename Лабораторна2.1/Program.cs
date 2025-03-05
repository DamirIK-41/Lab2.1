

using System.ComponentModel;


while (true)
{
    short TaskNumber = 0;
    try
    {
        Console.Write("Обери номер завдання:");
        TaskNumber = short.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Обери будь ласка номер, тобто число");
        continue;
    }
        
    switch (TaskNumber)
    {
        case 1:
            {
                List<double> I = new List<double>() { 0.4, 0.5, 0.9 };
                List<double> U = new List<double>() { 4.3, 3.7, 6.5 };
                List<double> R = new List<double>();
                for (int i = 0; i < I.Count; i++)
                {
                    R.Add(U[i] / I[i]);
                }
                Console.WriteLine(string.Join(", ", R));
                double AverageR = R.Average();
                Console.WriteLine($"Наближене значення опору R = {AverageR}");
            }
            break;
        case 2:
            {
                var DictArray = new List<Dictionary<string, string>>
                {
                    new Dictionary<string, string> {{"IK-41", "Demchenko Bogdan"}, {"Sex", "Man"} },
                    new Dictionary<string, string> {{"IK-41", "Zinchenko Alina"}, {"Sex", "Woman"} },
                    new Dictionary<string, string> {{"IK-41", "Polshakov Damir"}, {"Sex", "Man"} }
                };
                string Key = "Sex";
                int countDict = 0;
                foreach (var dict in DictArray)
                {
                    if(dict.ContainsKey(Key))
                    {
                        countDict++;
                    }
                }
                Console.WriteLine($"Кількість знайдених словників по ключу дорівнює {countDict}");
            }
            break;
        case 3:
            {
                string[] Array = {"Apple", "Banana", "Juice", "Man"};
                var symbols =  Array.Select(s => s.Length % 2 == 1 ? s[0] : s[s.Length - 1]).OrderByDescending(c => c).ToArray();
                Console.WriteLine(string.Join(", ", symbols));
            }
            break;
        default:
            {
                Console.WriteLine("Не існує завдання під таким номером, обери будь ласка завдання, яке.");
            }
            break;
    }
    Console.WriteLine("Ти бажаєшь вийти з програми(y), чи хочешь повторити?");
    if (Console.ReadLine() == "y")
    {
        break;
    }
}

Console.ReadKey();
