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
                string jsonString = File.ReadAllText(args[0]);
                Console.WriteLine(jsonString);
                Level? level = JsonSerializer.Deserialize<Level>(jsonString);

                if (level != null)
                {
                    Console.WriteLine(level.width);

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
                }
            }
        }
    }
}