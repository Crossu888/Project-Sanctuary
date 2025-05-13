public class Read
{
    public static void HallOfFameRecords()
    {
        using (FileStream fs = File.OpenRead(Save.path))
        {
            Console.WriteLine("Choose the record to display 1-30");
            byte Record = Convert.ToByte(Console.ReadLine());
            fs.Seek(0x23000 + (364 * (Record - 1)), SeekOrigin.Begin);
            byte[] Pokemon = new byte[60];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Pokemon ");
                Console.WriteLine(i + 1);
                fs.ReadExactly(Pokemon);
                HallOfFame(Pokemon);
                Console.WriteLine("------------");
            }
            byte[] date = new byte[4];
            fs.ReadExactly(date);
            Console.Write(BitConverter.ToUInt16(date, 0) + 2000);
            Console.Write(".");
            Console.Write(date[2]);
            Console.Write(".");
            Console.WriteLine(date[3]);
        }
    }

    public static void HallOfFame(byte[] Source)
    {
        int DexNum = BitConverter.ToUInt16(Source, 0);
        if (DexNum == 0) { return; }
        byte[] name = new byte[20];
        byte[] OTname = new byte[16];
        UInt16 OTID = BitConverter.ToUInt16(Source, 8);
        UInt16 SID = BitConverter.ToUInt16(Source, 10);
        byte[] PID = new byte[4];
        Array.Copy(Source, 4, PID, 0, 4);
        UInt16 HighPID = BitConverter.ToUInt16(PID, 2);
        UInt16 LowPID = BitConverter.ToUInt16(PID, 0);
        Array.Reverse(PID);
        UInt16 shiny = (UInt16)(OTID ^ SID ^ HighPID ^ LowPID);
        Console.Write("Dex number: ");
        Console.WriteLine(DexNum);
        Console.Write("Level: ");
        Console.WriteLine(Source[2]);
        Array.Copy(Source, 12, name, 0, 20);
        Console.Write("Nickname: ");
        Console.WriteLine(Util.Gen4ToText(name));
        Array.Copy(Source, 34, OTname, 0, 16);
        Console.Write("OT name: ");
        Console.WriteLine(Util.Gen4ToText(OTname));
        Console.Write("OT ID: ");
        Console.WriteLine(OTID);
        Console.Write("OT SID: ");
        Console.WriteLine(SID);
        Console.Write("Personality value: ");
        Console.WriteLine(BitConverter.ToString(PID));
        Console.Write("Shininess: ");
        if (shiny < 8)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }

    public static void Basic()
    {
        using (FileStream fs = File.OpenRead(Save.path))
        {
            byte[] b16 = new byte[16];
            byte[] b4 = new byte[4];
            byte[] b2 = new byte[2];
            byte[] b1 = new byte[1];
            //Trainer name
            fs.Seek(0x64, SeekOrigin.Begin);
            fs.ReadExactly(b16);
            Console.Write("Name: ");
            Console.WriteLine(Util.Gen4ToText(b16));
            //Trainer ID
            fs.ReadExactly(b2);
            Console.Write("ID: ");
            Console.WriteLine(BitConverter.ToUInt16(b2, 0));
            //Secret ID
            fs.ReadExactly(b2);
            Console.Write("SID: ");
            Console.WriteLine(BitConverter.ToUInt16(b2, 0));
            //Money
            fs.ReadExactly(b4);
            Console.Write("Money: ");
            Console.WriteLine(BitConverter.ToUInt32(b4, 0));
            //Gender
            fs.ReadExactly(b1);
            Console.Write("Gender: ");
            switch (b1[0])
            {
                case 0x00:
                    Console.WriteLine("Male");
                    break;
                case 0x01:
                    Console.WriteLine("Female");
                    break;
                default:
                    Console.WriteLine("ERROR: Gender not binary");
                    break;
            }
            //Country
            fs.ReadExactly(b1);
            Console.Write("Country of Origin: ");
            switch (b1[0])
            {
                case 0x01:
                    Console.WriteLine("Japan");
                    break;
                case 0x02:
                    Console.WriteLine("English");
                    break;
                case 0x03:
                    Console.WriteLine("France");
                    break;
                case 0x04:
                    Console.WriteLine("Italy");
                    break;
                case 0x05:
                    Console.WriteLine("Germany");
                    break;
                case 0x07:
                    Console.WriteLine("Spain");
                    break;
                case 0x08:
                    Console.WriteLine("South Korea");
                    break;
            }
            //Trainer Class
            fs.Seek(0x7F, SeekOrigin.Begin);
            fs.ReadExactly(b1);
            Console.Write("Trainer Class: ");
            switch (b1[0])
            {
                case 0x00:
                    Console.WriteLine("None");
                    break;
                case 0x03:
                    Console.WriteLine("School Kid");
                    break;
                case 0x05:
                    Console.WriteLine("Bug Catcher");
                    break;
                case 0x06:
                    Console.WriteLine("Lass");
                    break;
                case 0x07:
                    Console.WriteLine("Battle Girl");
                    break;
                case 0x0B:
                    Console.WriteLine("Ace Trainer Male");
                    break;
                case 0x0D:
                    Console.WriteLine("Beaty");
                    break;
                case 0x0E:
                    Console.WriteLine("Ace Trainer Female");
                    break;
                case 0x0F:
                    Console.WriteLine("Roughneck");
                    break;
                case 0x1F:
                    Console.WriteLine("Pop Idol");
                    break;
                case 0x23:
                    Console.WriteLine("Social");
                    break;
                case 0x25:
                    Console.WriteLine("Cowgirl");
                    break;
                case 0x2A:
                    Console.WriteLine("Ruin Maniac");
                    break;
                case 0x32:
                    Console.WriteLine("Black Belt");
                    break;
                case 0x3E:
                    Console.WriteLine("Rich Boy");
                    break;
                case 0x3F:
                    Console.WriteLine("Lady");
                    break;
                case 0x46:
                    Console.WriteLine("Psychic");
                    break;
            }
            //Badges
        }
    }

    public static void Start()
    {
        Console.WriteLine("Select option:");
        Console.WriteLine("1) Basic save info");
        Console.WriteLine("2) Hall of Fame");
        switch (Console.ReadLine())
        {
            case "1":
                Basic();
                break;
            case "2":
                HallOfFameRecords();
                break;
            default:
                Console.WriteLine("ERROR: Invalid input");
                break;
        }
    }
}
