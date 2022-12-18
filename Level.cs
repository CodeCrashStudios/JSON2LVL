public class Level
{
    public string backgroundcolor { get; set; }
    public int compressionlevel { get; set; }
    public Editorsettings editorsettings { get; set; }
    public int height { get; set; }
    public bool infinite { get; set; }
    public Layer[] layers { get; set; }
    public int nextlayerid { get; set; }
    public int nextobjectid { get; set; }
    public string orientation { get; set; }
    public string renderorder { get; set; }
    public string tiledversion { get; set; }
    public int tileheight { get; set; }
    public Tileset[] tilesets { get; set; }
    public int tilewidth { get; set; }
    public string type { get; set; }
    public float version { get; set; }
    public int width { get; set; }
}

public class Editorsettings
{
    public Export export { get; set; }
}

public class Export
{
    public string format { get; set; }
    public string target { get; set; }
}

public class Layer
{
    public int[] data { get; set; }
    public int height { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public int opacity { get; set; }
    public string type { get; set; }
    public bool visible { get; set; }
    public int width { get; set; }
    public int x { get; set; }
    public int y { get; set; }
}

public class Tileset
{
    public int columns { get; set; }
    public int firstgid { get; set; }
    public string image { get; set; }
    public int imageheight { get; set; }
    public int imagewidth { get; set; }
    public int margin { get; set; }
    public string name { get; set; }
    public int spacing { get; set; }
    public int tilecount { get; set; }
    public int tileheight { get; set; }
    public int tilewidth { get; set; }
}
