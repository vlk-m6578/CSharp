using System;

namespace lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string folder = "Lebedeva_Lab4";
            if (Directory.Exists(folder))
            {
                Directory.Delete(folder, true);
                Console.WriteLine("The folder already exists.");
            }
            Directory.CreateDirectory(folder);


            List<string> extensions = new List<string> { ".txt", ".rtf", ".dat", ".inf" };
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
               string name = Path.Combine(folder, Path.GetRandomFileName());
               name += extensions[random.Next(extensions.Count)];

                File.WriteAllText(name, "");
            }


            var files = Directory.GetFiles(folder);
            foreach(string f in files)
            {
                string name = Path.GetFileName(f);
                string extension = Path.GetExtension(name);
                Console.WriteLine("File <" + name + "> имеет расширение <" + extension + ">.");
            }

            List<Mammal> mammals = new List<Mammal>();
            mammals.Add(new Mammal("Lion", 8, true));
            mammals.Add(new Mammal("Elephant", 25, true));
            mammals.Add(new Mammal("Cat", 5, false));
            mammals.Add(new Mammal("Wolf", 6, true));
            mammals.Add(new Mammal("Dog", 4, false));
            mammals.Add(new Mammal("Bear", 10, true));

            FileService fileService = new FileService();
            string fileName = Path.Combine(folder, "Mammals.bin");
            fileService.SaveData(mammals, fileName);

            string newFileName = Path.Combine(folder, "ModifiedMammals.bin");
            File.Move(fileName, newFileName);

            List<Mammal> newList = new List<Mammal>(fileService.ReadFile(newFileName));

            Console.WriteLine("\nThe original collection: ");
            IEnumerable<Mammal> readList = fileService.ReadFile(newFileName);
            foreach (Mammal m in readList)
            {
                Console.WriteLine("Name: "+m.Name+" | Age: "+m.Age+" | IsWild: "+m.IsWild);
            }

            Console.WriteLine("\nThe sorted collection by Name: ");
            var sortedListByName = newList.OrderBy(m=>m, new MyCustomComparer());
            foreach(var m in sortedListByName)
            {
                Console.WriteLine("Name: " + m.Name + " | Age: " + m.Age + " | IsWild: " + m.IsWild);
            }

            Console.WriteLine("\nThe sorted collection by Age: ");
            var sortedListByAge = newList.OrderBy(m => m.Age);
            foreach (var m in sortedListByAge)
            {
                Console.WriteLine("Name: " + m.Name + " | Age: " + m.Age + " | IsWild: " + m.IsWild);
            }
        }
    }
}
