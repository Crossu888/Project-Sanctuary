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
            Console.Write("Gender: " + (Gender)b1[0]);
            //Country
            fs.ReadExactly(b1);
            Console.WriteLine("Country of Origin: " + (Region)b1[0]);
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

    public static void Party()
    {
        using (FileStream fs = File.OpenRead(Save.path))
        {
            fs.Seek(0x98 + (236 * 0), SeekOrigin.Begin);
            byte[] data = new byte[136];
            fs.ReadExactly(data);
            data = Util.DecryptPKM(data);
            PKM party1 = Util.Gen4ToPKM(data);
            Console.WriteLine("Species: " + party1.dexNum);
            Console.WriteLine("Personality: " + Convert.ToString(party1.pv, 16));
            Console.WriteLine("Held item: " + party1.HeldItem);
            Console.WriteLine("OTID: " + party1.otid);
            Console.WriteLine("OTSID: " + party1.otsid);
            Console.WriteLine("EXP: " + party1.exp);
            Console.WriteLine("Friendship: " + party1.friendship);
            Console.WriteLine("Ability: " + party1.ability);
            Console.WriteLine("Nature: " + party1.nature);
            Console.WriteLine("markings: " + party1.marks);
            Console.WriteLine("Original region: " + party1.ogRegion);
            Console.WriteLine("-----------------------");
            Console.WriteLine("HP EV: " + party1.hpEV);
            Console.WriteLine("Attack EV: " + party1.attackEV);
            Console.WriteLine("Defense EV: " + party1.defenseEV);
            Console.WriteLine("Speed EV: " + party1.speedEV);
            Console.WriteLine("Special attack EV: " + party1.spAttackEV);
            Console.WriteLine("Special defense EV: " + party1.spDefenseEV);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Cool CV: " + party1.coolCV);
            Console.WriteLine("Beauty CV: " + party1.beautyCV);
            Console.WriteLine("Cute CV: " + party1.cuteCV);
            Console.WriteLine("Smart CV: " + party1.smartCV);
            Console.WriteLine("Tough CV: " + party1.toughCV);
            Console.WriteLine("Sheen CV: " + party1.sheenCV);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Move 1: " + party1.move1);
            Console.WriteLine("Move 2: " + party1.move2);
            Console.WriteLine("Move 3: " + party1.move3);
            Console.WriteLine("Move 4: " + party1.move4);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Move 1 PP: " + party1.move1pp);
            Console.WriteLine("Move 2 PP: " + party1.move2pp);
            Console.WriteLine("Move 3 PP: " + party1.move3pp);
            Console.WriteLine("Move 4 PP: " + party1.move4pp);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Move PP Ups (?): " + Convert.ToString(party1.PPUP, 2));
            Console.WriteLine("-----------------------");
            Console.WriteLine("HP IV: " + party1.hpIV);
            Console.WriteLine("Attack IV: " + party1.attackIV);
            Console.WriteLine("Defense IV: " + party1.defenseIV);
            Console.WriteLine("Speed IV: " + party1.speedIV);
            Console.WriteLine("Special attack IV: " + party1.spAttackIV);
            Console.WriteLine("Special defense IV: " + party1.spDefenseIV);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Fateful Encounter?: " + party1.fateful);
            Console.WriteLine("Gender: " + party1.gender);
            Console.WriteLine("Alternate forms?: " + Convert.ToString(party1.altForms, 2));
            Console.WriteLine("Shiny Leaves: " + Convert.ToString(party1.sLeaves, 2));
            Console.WriteLine("Is Egg?: " + party1.isEgg);
            Console.WriteLine("Is Nicknamed?: " + party1.isNicknamed);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nickname: " + party1.nickname);
            Console.WriteLine("OT name: " + party1.otName);
            Console.WriteLine("OT gender: " + party1.otGender);
            Console.WriteLine("Original game: " + party1.ogGame);
            Console.WriteLine("Egg location: " + party1.eggLocation);
            Console.WriteLine("Date egg received: " + party1.eggDate);
            Console.WriteLine("Met location: " + party1.metLocation);
            Console.WriteLine("Met date: " + party1.metDate);
            Console.WriteLine("Met level: " + party1.metLevel);
            Console.WriteLine("Pokerus: " + Convert.ToString(party1.pokerus, 2));
            Console.WriteLine("Poke ball: " + party1.pokeball + " Ball");
            Console.WriteLine("Encounter type: " + party1.encounterType);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Sinnoh Ribbon Set: " + Convert.ToString((long)(party1.ribbonsSinnoh1), 2));
            Console.WriteLine("Hoeen Ribbon Set: " + Convert.ToString(party1.ribbonsHoeen1, 2));
            Console.WriteLine("-----------------------");
            /*Console.WriteLine(BitConverter.ToString(data));
            Console.WriteLine("-----------------------");
            Console.WriteLine(BitConverter.ToString(Util.PKMToGen4(party1)));
            Console.WriteLine(BitConverter.ToString(data) == BitConverter.ToString(Util.PKMToGen4(party1)));*/
        }
    }

    public static void Start()
    {
        Console.WriteLine("Select option:");
        Console.WriteLine("1) Basic save info");
        Console.WriteLine("2) Hall of Fame");
        Console.WriteLine("3) Party Pokemon");
        switch (Console.ReadLine())
        {
            case "1":
                Basic();
                break;
            case "2":
                HallOfFameRecords();
                break;
            case "3":
                Party();
                break;
            default:
                Console.WriteLine("ERROR: Invalid input");
                break;
        }
    }
}
