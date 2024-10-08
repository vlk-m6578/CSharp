using lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class FileService : IFileService<Mammal>
    {
        public void SaveData(IEnumerable<Mammal> data, string fileName)
        {
            using var file = File.OpenWrite(fileName);
            using var binWriter = new BinaryWriter(file);

            foreach (var m in data)
            {
                try
                {
                    binWriter.Write(m.Name);
                    binWriter.Write(m.Age);
                    binWriter.Write(m.IsWild);
                }
                catch(IOException ex)
                {
                    Console.WriteLine("Recording error: "+ex);
                }
            }
            //binWriter.Close();
            //file.Close();
        }
        public IEnumerable<Mammal> ReadFile(string fileName)
        {
            using var file = File.OpenRead(fileName);
            using var binReader = new BinaryReader(file);

            var name = "";
            var age = 0;
            var isWild = false;

            while (binReader.PeekChar() != -1)
            {
                try
                {
                    name = binReader.ReadString();
                    age = binReader.ReadInt32();
                    isWild = binReader.ReadBoolean();
                }
                catch(IOException ex)
                {
                    Console.WriteLine("Error reading: "+ex);
                }
                yield return new Mammal(name, age, isWild);
            }
            //binReader.Close();
            //file.Close();
        }
    }
}
