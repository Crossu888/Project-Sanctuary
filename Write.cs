public class Write
{
    public static void Replace(int offset, byte[] value)
    {
        using (FileStream fs = File.OpenWrite(Save.path))
        {
            fs.Seek(offset, SeekOrigin.Begin);
            fs.Write(value);
        }
    }

    public static void Basic()
    {
        Console.WriteLine("Select option:");
        Console.WriteLine("1) Name");
        Console.WriteLine("2) ID [!]");
        Console.WriteLine("3) SID [!]");
        Console.WriteLine("4) Money");
        Console.WriteLine("5) Gender");
        Console.WriteLine("6) Region");
        Console.WriteLine("7) Badges");
        Console.WriteLine("8) Trainer class");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Enter new value [max 8 characters]");
                string value = Console.ReadLine()!;
                if (value.Length > 8 || value.Length == 0)
                {
                    Console.WriteLine("ERROR: Invalid input");
                    return;
                }
                else
                {
                    Replace(0x64, Util.TextToGen4(value));
                    Util.ChecksumSmallBlock();
                }
                break;
            case "2":

                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
            case "7":
                break;
            case "8":
                break;
            default:
                break;
        }
    }

    public static void Start()
    {
        Console.WriteLine("Select option:");
    }
}
