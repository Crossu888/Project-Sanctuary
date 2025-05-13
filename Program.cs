public class Save
{
    public const string path = "SoulSilver.sav";
    public const int footerSize = 0x10;
    public const int smallBlockSize = 0xF628;
    public const int bigBlockSize = 0x12310;
    public const int bigBlockOffset = 0xF700;

    public static void Main()
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("ERROR: File doesn't exist");
            return;
        }
        Console.WriteLine("Select action:");
        Console.WriteLine("1) Read");
        Console.WriteLine("2) Write");
        switch (Console.ReadLine())
        {
            case "1":
                Read.Start();
                break;
            case "2":
                break;
            default:
                Console.WriteLine("ERROR: Invalid input");
                break;
        }
        /*byte[] b = new byte[smallBlockSize - footerSize];
        using (FileStream fs = File.OpenRead(path))
        {
            fs.Seek(0, SeekOrigin.Begin);
            fs.ReadExactly(b);
        }
        Util.ReplaceChecksum(b, path, smallBlockSize - 2);
        Console.WriteLine("Checksum replaced!");*/
    }
}
