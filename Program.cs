using System.IO.Compression;
using System.Text.Json;

namespace JSON2LVL
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Reading file \"" + args[0]+"\"...");
                string jsonString = File.ReadAllText(args[0]);
                Console.WriteLine("Done!");

                Console.WriteLine("Deserializing JSON...");
                Level? level = JsonSerializer.Deserialize<Level>(jsonString);
                Console.WriteLine("Done!");

                Console.WriteLine("Writing file...");
                if (level != null)
                {
                    FileStream fs = File.Create(args[0].Substring(0, args[0].Length-5) + ".lvl");
                    GZipStream gs = new GZipStream(fs, System.IO.Compression.CompressionLevel.Optimal);
                    BinaryWriter bw = new BinaryWriter(gs);

                    bw.Write((uint)level.width);
                    bw.Write((uint)level.height);

                    for (int i = 0; i < level.layers.Length; i++)
                    {
                        for (int j = 0; j < level.layers[i].data.Length; j++)
                        {
                            bw.Write((ushort)(level.layers[i].data[j] + 1));
                        }
                    }

                    bw.Close();
                    gs.Close();
                    fs.Close();
                    Console.WriteLine("Done!");
                }
                else
                {
                    Console.WriteLine("Error Could not Write file. There may be a problem with your JSON file, make sure it is formated correctly.");
                }
            }
        }
    }
}