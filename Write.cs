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
        Console.WriteLine("2) Money");
        Console.WriteLine("3) Gender");
        Console.WriteLine("4) Region");
        Console.WriteLine("5) Trainer class");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Enter new value [max 8 characters]");
                string name = Console.ReadLine()!;
                if (name.Length > 8 || name.Length == 0)
                {
                    Console.WriteLine("ERROR: Invalid input");
                    return;
                }
                else
                {
                    Replace(0x64, Util.TextToGen4(name));
                    Util.ChecksumSmallBlock();
                }
                break;
            case "2":
                Console.WriteLine("Enter new value [0-999999]");
                uint money = UInt32.Parse(Console.ReadLine()!);
                if (money >= 0 && money <= 999999)
                {
                    Replace(0x78, BitConverter.GetBytes(money));
                    Util.ChecksumSmallBlock();
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid input");
                    return;
                }
                break;
            case "3":
                Console.WriteLine("Select option:");
                Console.WriteLine("1) Male");
                Console.WriteLine("2) Female");
                byte[] gender = new byte[1];
                switch (Console.ReadLine())
                {
                    case "1":
                        gender[0] = 0x00;
                        break;
                    case "2":
                        gender[0] = 0x01;
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid input");
                        return;
                }
                Replace(0x7C, gender);
                Util.ChecksumSmallBlock();
                break;
            case "4":
                Console.WriteLine("Select option:");
                Console.WriteLine("1) Japan");
                Console.WriteLine("2) English");
                Console.WriteLine("3) France");
                Console.WriteLine("4) Italy");
                Console.WriteLine("5) Germany");
                Console.WriteLine("6) Spain");
                Console.WriteLine("7) South Korea");
                byte[] region = new byte[1];
                switch (Console.ReadLine())
                {
                    case "1":
                        region[0] = 0x01;
                        break;
                    case "2":
                        region[0] = 0x02;
                        break;
                    case "3":
                        region[0] = 0x03;
                        break;
                    case "4":
                        region[0] = 0x04;
                        break;
                    case "5":
                        region[0] = 0x05;
                        break;
                    case "6":
                        region[0] = 0x07;
                        break;
                    case "7":
                        region[0] = 0x08;
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid input");
                        return;
                }
                Replace(0x7D, region);
                Util.ChecksumSmallBlock();
                break;
            case "5":
                Console.WriteLine("Select option:");
                Console.WriteLine("1) School Kid");
                Console.WriteLine("2) Bug Catcher");
                Console.WriteLine("3) Lass");
                Console.WriteLine("4) Battle Girl");
                Console.WriteLine("5) Ace Trainer Male");
                Console.WriteLine("6) Beauty");
                Console.WriteLine("7) Ace Trainer Female");
                Console.WriteLine("8) Roughneck");
                Console.WriteLine("9) Pop Idol");
                Console.WriteLine("10) Social");
                Console.WriteLine("11) Cowgirl");
                Console.WriteLine("12) Ruin Maniac");
                Console.WriteLine("13) Black Belt");
                Console.WriteLine("14) Rich Boy");
                Console.WriteLine("15) Lady");
                Console.WriteLine("16) Psychic");
                byte[] tClass = new byte[1];
                switch (Console.ReadLine())
                {
                    case "1":
                        tClass[0] = 0x03;
                        break;
                    case "2":
                        tClass[0] = 0x05;
                        break;
                    case "3":
                        tClass[0] = 0x06;
                        break;
                    case "4":
                        tClass[0] = 0x07;
                        break;
                    case "5":
                        tClass[0] = 0x0B;
                        break;
                    case "6":
                        tClass[0] = 0x0D;
                        break;
                    case "7":
                        tClass[0] = 0x0E;
                        break;
                    case "8":
                        tClass[0] = 0x0F;
                        break;
                    case "9":
                        tClass[0] = 0x1F;
                        break;
                    case "10":
                        tClass[0] = 0x23;
                        break;
                    case "11":
                        tClass[0] = 0x25;
                        break;
                    case "12":
                        tClass[0] = 0x2A;
                        break;
                    case "13":
                        tClass[0] = 0x32;
                        break;
                    case "14":
                        tClass[0] = 0x3E;
                        break;
                    case "15":
                        tClass[0] = 0x3F;
                        break;
                    case "16":
                        tClass[0] = 0x46;
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid input");
                        return;
                }
                Replace(0x7F, tClass);
                Util.ChecksumSmallBlock();
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
