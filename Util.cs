public class Util
{
    public static byte[] TextToGen4(string Source, ushort length)
    {
        char[] src = Source.ToCharArray();
        byte[] res = new byte[length];
        int i = 0;
        foreach (char b in src)
        {
            switch (b)
            {
                case '0':
                    res[i] = 0x21;
                    res[i + 1] = 0x01;
                    break;
                case '1':
                    res[i] = 0x22;
                    res[i + 1] = 0x01;
                    break;
                case '2':
                    res[i] = 0x23;
                    res[i + 1] = 0x01;
                    break;
                case '3':
                    res[i] = 0x24;
                    res[i + 1] = 0x01;
                    break;
                case '4':
                    res[i] = 0x25;
                    res[i + 1] = 0x01;
                    break;
                case '5':
                    res[i] = 0x26;
                    res[i + 1] = 0x01;
                    break;
                case '6':
                    res[i] = 0x27;
                    res[i + 1] = 0x01;
                    break;
                case '7':
                    res[i] = 0x28;
                    res[i + 1] = 0x01;
                    break;
                case '8':
                    res[i] = 0x29;
                    res[i + 1] = 0x01;
                    break;
                case '9':
                    res[i] = 0x2A;
                    res[i + 1] = 0x01;
                    break;
                case 'A':
                    res[i] = 0x2B;
                    res[i + 1] = 0x01;
                    break;
                case 'B':
                    res[i] = 0x2C;
                    res[i + 1] = 0x01;
                    break;
                case 'C':
                    res[i] = 0x2D;
                    res[i + 1] = 0x01;
                    break;
                case 'D':
                    res[i] = 0x2E;
                    res[i + 1] = 0x01;
                    break;
                case 'E':
                    res[i] = 0x2F;
                    res[i + 1] = 0x01;
                    break;
                case 'F':
                    res[i] = 0x30;
                    res[i + 1] = 0x01;
                    break;
                case 'G':
                    res[i] = 0x31;
                    res[i + 1] = 0x01;
                    break;
                case 'H':
                    res[i] = 0x32;
                    res[i + 1] = 0x01;
                    break;
                case 'I':
                    res[i] = 0x33;
                    res[i + 1] = 0x01;
                    break;
                case 'J':
                    res[i] = 0x34;
                    res[i + 1] = 0x01;
                    break;
                case 'K':
                    res[i] = 0x35;
                    res[i + 1] = 0x01;
                    break;
                case 'L':
                    res[i] = 0x36;
                    res[i + 1] = 0x01;
                    break;
                case 'M':
                    res[i] = 0x37;
                    res[i + 1] = 0x01;
                    break;
                case 'N':
                    res[i] = 0x38;
                    res[i + 1] = 0x01;
                    break;
                case 'O':
                    res[i] = 0x39;
                    res[i + 1] = 0x01;
                    break;
                case 'P':
                    res[i] = 0x3A;
                    res[i + 1] = 0x01;
                    break;
                case 'Q':
                    res[i] = 0x3B;
                    res[i + 1] = 0x01;
                    break;
                case 'R':
                    res[i] = 0x3C;
                    res[i + 1] = 0x01;
                    break;
                case 'S':
                    res[i] = 0x3D;
                    res[i + 1] = 0x01;
                    break;
                case 'T':
                    res[i] = 0x3E;
                    res[i + 1] = 0x01;
                    break;
                case 'U':
                    res[i] = 0x3F;
                    res[i + 1] = 0x01;
                    break;
                case 'V':
                    res[i] = 0x40;
                    res[i + 1] = 0x01;
                    break;
                case 'W':
                    res[i] = 0x41;
                    res[i + 1] = 0x01;
                    break;
                case 'X':
                    res[i] = 0x42;
                    res[i + 1] = 0x01;
                    break;
                case 'Y':
                    res[i] = 0x43;
                    res[i + 1] = 0x01;
                    break;
                case 'Z':
                    res[i] = 0x44;
                    res[i + 1] = 0x01;
                    break;
                case 'a':
                    res[i] = 0x45;
                    res[i + 1] = 0x01;
                    break;
                case 'b':
                    res[i] = 0x46;
                    res[i + 1] = 0x01;
                    break;
                case 'c':
                    res[i] = 0x47;
                    res[i + 1] = 0x01;
                    break;
                case 'd':
                    res[i] = 0x48;
                    res[i + 1] = 0x01;
                    break;
                case 'e':
                    res[i] = 0x49;
                    res[i + 1] = 0x01;
                    break;
                case 'f':
                    res[i] = 0x4A;
                    res[i + 1] = 0x01;
                    break;
                case 'g':
                    res[i] = 0x4B;
                    res[i + 1] = 0x01;
                    break;
                case 'h':
                    res[i] = 0x4C;
                    res[i + 1] = 0x01;
                    break;
                case 'i':
                    res[i] = 0x4D;
                    res[i + 1] = 0x01;
                    break;
                case 'j':
                    res[i] = 0x4E;
                    res[i + 1] = 0x01;
                    break;
                case 'k':
                    res[i] = 0x4F;
                    res[i + 1] = 0x01;
                    break;
                case 'l':
                    res[i] = 0x50;
                    res[i + 1] = 0x01;
                    break;
                case 'm':
                    res[i] = 0x51;
                    res[i + 1] = 0x01;
                    break;
                case 'n':
                    res[i] = 0x52;
                    res[i + 1] = 0x01;
                    break;
                case 'o':
                    res[i] = 0x53;
                    res[i + 1] = 0x01;
                    break;
                case 'p':
                    res[i] = 0x54;
                    res[i + 1] = 0x01;
                    break;
                case 'q':
                    res[i] = 0x55;
                    res[i + 1] = 0x01;
                    break;
                case 'r':
                    res[i] = 0x56;
                    res[i + 1] = 0x01;
                    break;
                case 's':
                    res[i] = 0x57;
                    res[i + 1] = 0x01;
                    break;
                case 't':
                    res[i] = 0x58;
                    res[i + 1] = 0x01;
                    break;
                case 'u':
                    res[i] = 0x59;
                    res[i + 1] = 0x01;
                    break;
                case 'v':
                    res[i] = 0x5A;
                    res[i + 1] = 0x01;
                    break;
                case 'w':
                    res[i] = 0x5B;
                    res[i + 1] = 0x01;
                    break;
                case 'x':
                    res[i] = 0x5C;
                    res[i + 1] = 0x01;
                    break;
                case 'y':
                    res[i] = 0x5D;
                    res[i + 1] = 0x01;
                    break;
                case 'z':
                    res[i] = 0x5E;
                    res[i + 1] = 0x01;
                    break;
                case '!':
                    res[i] = 0xAB;
                    res[i + 1] = 0x01;
                    break;
                case '?':
                    res[i] = 0xAC;
                    res[i + 1] = 0x01;
                    break;
                case ',':
                    res[i] = 0xAD;
                    res[i + 1] = 0x01;
                    break;
                case '.':
                    res[i] = 0xAE;
                    res[i + 1] = 0x01;
                    break;
                case '/':
                    res[i] = 0xB1;
                    res[i + 1] = 0x01;
                    break;
                case '\'':
                    res[i] = 0xB3;
                    res[i + 1] = 0x01;
                    break;
                case '"':
                    res[i] = 0xB5;
                    res[i + 1] = 0x01;
                    break;
                case '(':
                    res[i] = 0xB9;
                    res[i + 1] = 0x01;
                    break;
                case ')':
                    res[i] = 0xBA;
                    res[i + 1] = 0x01;
                    break;
                case '+':
                    res[i] = 0xBD;
                    res[i + 1] = 0x01;
                    break;
                case '-':
                    res[i] = 0xBE;
                    res[i + 1] = 0x01;
                    break;
                case '*':
                    res[i] = 0xBF;
                    res[i + 1] = 0x01;
                    break;
                case '#':
                    res[i] = 0xC0;
                    res[i + 1] = 0x01;
                    break;
                case '=':
                    res[i] = 0xC1;
                    res[i + 1] = 0x01;
                    break;
                case '&':
                    res[i] = 0xC2;
                    res[i + 1] = 0x01;
                    break;
                case '~':
                    res[i] = 0xC3;
                    res[i + 1] = 0x01;
                    break;
                case ':':
                    res[i] = 0xC4;
                    res[i + 1] = 0x01;
                    break;
                case ';':
                    res[i] = 0xC5;
                    res[i + 1] = 0x01;
                    break;
                case '@':
                    res[i] = 0xD0;
                    res[i + 1] = 0x01;
                    break;
                case '%':
                    res[i] = 0xD2;
                    res[i + 1] = 0x01;
                    break;
                case '$':
                    res[i] = 0xA8;
                    res[i + 1] = 0x01;
                    break;
                default:
                    res[i] = 0xFF;
                    res[i + 1] = 0xFF;
                    break;
            }
            if (res[i] == 0xFF)
                continue;
            i += 2;
        }
        return res;
    }

    public static string Gen4ToText(byte[] Source)
    {
        char[] res = new char[Source.Length / 2];
        int j = 0;
        for (int i = 0; i < Source.Length; i += 2, j++)
        {
            byte x = Source[i];
            byte y = Source[i + 1];
            /*Console.Write(x.ToString("X2"));
            Console.Write(" ");
            Console.WriteLine(y.ToString("X2"));*/
            if (x == 0xFF && y == 0xFF || x == 0x00 && y == 0x00) { break; }
            switch (y)
            {
                case 0x00:
                    switch (x)
                    {
                        case 0x01:
                            res[j] = '　';
                            break;
                        case 0x02:
                            res[j] = 'ぁ';
                            break;
                        case 0x03:
                            res[j] = 'あ';
                            break;
                        case 0x04:
                            res[j] = 'ぃ';
                            break;
                        case 0x05:
                            res[j] = 'い';
                            break;
                        case 0x06:
                            res[j] = 'ぅ';
                            break;
                        case 0x07:
                            res[j] = 'う';
                            break;
                        case 0x08:
                            res[j] = 'ぇ';
                            break;
                        case 0x09:
                            res[j] = 'え';
                            break;
                        case 0x0A:
                            res[j] = 'ぉ';
                            break;
                        case 0x0B:
                            res[j] = 'お';
                            break;
                        case 0x0C:
                            res[j] = 'か';
                            break;
                        case 0x0D:
                            res[j] = 'が';
                            break;
                        case 0x0E:
                            res[j] = 'き';
                            break;
                        case 0x0F:
                            res[j] = 'ぎ';
                            break;
                        case 0x10:
                            res[j] = 'く';
                            break;
                        case 0x11:
                            res[j] = 'ぐ';
                            break;
                        case 0x12:
                            res[j] = 'け';
                            break;
                        case 0x13:
                            res[j] = 'げ';
                            break;
                        case 0x14:
                            res[j] = 'こ';
                            break;
                        case 0x15:
                            res[j] = 'ご';
                            break;
                        case 0x16:
                            res[j] = 'さ';
                            break;
                        case 0x17:
                            res[j] = 'ざ';
                            break;
                        case 0x18:
                            res[j] = 'し';
                            break;
                        case 0x19:
                            res[j] = 'じ';
                            break;
                        case 0x1A:
                            res[j] = 'す';
                            break;
                        case 0x1B:
                            res[j] = 'ず';
                            break;
                        case 0x1C:
                            res[j] = 'せ';
                            break;
                        case 0x1D:
                            res[j] = 'ぜ';
                            break;
                        case 0x1E:
                            res[j] = 'そ';
                            break;
                        case 0x1F:
                            res[j] = 'ぞ';
                            break;
                    }
                    break;
                case 0x01:
                    switch (x)
                    {
                        case 0x00:
                            res[j] = '○';
                            break;
                        case 0x01:
                            res[j] = '□';
                            break;
                        case 0x02:
                            res[j] = '△';
                            break;
                        case 0x03:
                            res[j] = '◇';
                            break;
                        case 0x04:
                            res[j] = '＠';
                            break;
                        case 0x05:
                            res[j] = '♪';
                            break;
                        case 0x06:
                            res[j] = '％';
                            break;
                        case 0x07:
                            res[j] = '☀';
                            break;
                        case 0x08:
                            res[j] = '☁';
                            break;
                        case 0x09:
                            res[j] = '☂';
                            break;
                        case 0x0A:
                            res[j] = '☃';
                            break;
                        case 0x0B:
                            res[j] = ':';
                            j++;
                            res[j] = ')';
                            break;
                        case 0x0C:
                            res[j] = ':';
                            j++;
                            res[j] = 'D';
                            break;
                        case 0x0D:
                            res[j] = 'D';
                            j++;
                            res[j] = ':';
                            break;
                        case 0x0E:
                            res[j] = ':';
                            j++;
                            res[j] = '(';
                            break;
                        case 0x0F:
                            res[j] = '↑';
                            break;
                        case 0x10:
                            res[j] = '↓';
                            break;
                        case 0x11:
                            res[j] = 'z';
                            break;
                        case 0x12:
                            res[j] = '円';
                            break;
                        case 0x13:
                            res[j] = 'x';
                            break;
                        case 0x14:
                            res[j] = 'x';
                            break;
                        case 0x15:
                            res[j] = 'x';
                            break;
                        case 0x16:
                            res[j] = 'x';
                            break;
                        case 0x17:
                            res[j] = 'x';
                            break;
                        case 0x18:
                            res[j] = 'x';
                            break;
                        case 0x19:
                            res[j] = 'x';
                            break;
                        case 0x1A:
                            res[j] = 'x';
                            break;
                        case 0x1B:
                            res[j] = '←';
                            break;
                        case 0x1C:
                            res[j] = '↑';
                            break;
                        case 0x1D:
                            res[j] = '↓';
                            break;
                        case 0x1E:
                            res[j] = '→';
                            break;
                        case 0x1F:
                            res[j] = '►';
                            break;
                        case 0x20:
                            res[j] = '＆';
                            break;
                        case 0x21:
                            res[j] = '0';
                            break;
                        case 0x22:
                            res[j] = '1';
                            break;
                        case 0x23:
                            res[j] = '2';
                            break;
                        case 0x24:
                            res[j] = '3';
                            break;
                        case 0x25:
                            res[j] = '4';
                            break;
                        case 0x26:
                            res[j] = '5';
                            break;
                        case 0x27:
                            res[j] = '6';
                            break;
                        case 0x28:
                            res[j] = '7';
                            break;
                        case 0x29:
                            res[j] = '8';
                            break;
                        case 0x2A:
                            res[j] = '9';
                            break;
                        case 0x2B:
                            res[j] = 'A';
                            break;
                        case 0x2C:
                            res[j] = 'B';
                            break;
                        case 0x2D:
                            res[j] = 'C';
                            break;
                        case 0x2E:
                            res[j] = 'D';
                            break;
                        case 0x2F:
                            res[j] = 'E';
                            break;
                        case 0x30:
                            res[j] = 'F';
                            break;
                        case 0x31:
                            res[j] = 'G';
                            break;
                        case 0x32:
                            res[j] = 'H';
                            break;
                        case 0x33:
                            res[j] = 'I';
                            break;
                        case 0x34:
                            res[j] = 'J';
                            break;
                        case 0x35:
                            res[j] = 'K';
                            break;
                        case 0x36:
                            res[j] = 'L';
                            break;
                        case 0x37:
                            res[j] = 'M';
                            break;
                        case 0x38:
                            res[j] = 'N';
                            break;
                        case 0x39:
                            res[j] = 'O';
                            break;
                        case 0x3A:
                            res[j] = 'P';
                            break;
                        case 0x3B:
                            res[j] = 'Q';
                            break;
                        case 0x3C:
                            res[j] = 'R';
                            break;
                        case 0x3D:
                            res[j] = 'S';
                            break;
                        case 0x3E:
                            res[j] = 'T';
                            break;
                        case 0x3F:
                            res[j] = 'U';
                            break;
                        case 0x40:
                            res[j] = 'V';
                            break;
                        case 0x41:
                            res[j] = 'W';
                            break;
                        case 0x42:
                            res[j] = 'X';
                            break;
                        case 0x43:
                            res[j] = 'Y';
                            break;
                        case 0x44:
                            res[j] = 'Z';
                            break;
                        case 0x45:
                            res[j] = 'a';
                            break;
                        case 0x46:
                            res[j] = 'b';
                            break;
                        case 0x47:
                            res[j] = 'c';
                            break;
                        case 0x48:
                            res[j] = 'd';
                            break;
                        case 0x49:
                            res[j] = 'e';
                            break;
                        case 0x4A:
                            res[j] = 'f';
                            break;
                        case 0x4B:
                            res[j] = 'g';
                            break;
                        case 0x4C:
                            res[j] = 'h';
                            break;
                        case 0x4D:
                            res[j] = 'i';
                            break;
                        case 0x4E:
                            res[j] = 'j';
                            break;
                        case 0x4F:
                            res[j] = 'k';
                            break;
                        case 0x50:
                            res[j] = 'l';
                            break;
                        case 0x51:
                            res[j] = 'm';
                            break;
                        case 0x52:
                            res[j] = 'n';
                            break;
                        case 0x53:
                            res[j] = 'o';
                            break;
                        case 0x54:
                            res[j] = 'p';
                            break;
                        case 0x55:
                            res[j] = 'q';
                            break;
                        case 0x56:
                            res[j] = 'r';
                            break;
                        case 0x57:
                            res[j] = 's';
                            break;
                        case 0x58:
                            res[j] = 't';
                            break;
                        case 0x59:
                            res[j] = 'u';
                            break;
                        case 0x5A:
                            res[j] = 'v';
                            break;
                        case 0x5B:
                            res[j] = 'w';
                            break;
                        case 0x5C:
                            res[j] = 'x';
                            break;
                        case 0x5D:
                            res[j] = 'y';
                            break;
                        case 0x5E:
                            res[j] = 'z';
                            break;
                        case 0x5F:
                            res[j] = 'À';
                            break;
                        case 0x60:
                            res[j] = 'Á';
                            break;
                        case 0x61:
                            res[j] = 'Â';
                            break;
                        case 0x62:
                            res[j] = 'Ã';
                            break;
                        case 0x63:
                            res[j] = 'Ä';
                            break;
                        case 0x64:
                            res[j] = 'Å';
                            break;
                        case 0x65:
                            res[j] = 'Æ';
                            break;
                        case 0x66:
                            res[j] = 'Ç';
                            break;
                        case 0x67:
                            res[j] = 'È';
                            break;
                        case 0x68:
                            res[j] = 'É';
                            break;
                        case 0x69:
                            res[j] = 'Ê';
                            break;
                        case 0x6A:
                            res[j] = 'Ë';
                            break;
                        case 0x6B:
                            res[j] = 'Ì';
                            break;
                        case 0x6C:
                            res[j] = 'Í';
                            break;
                        case 0x6D:
                            res[j] = 'Î';
                            break;
                        case 0x6E:
                            res[j] = 'Ï';
                            break;
                        case 0x6F:
                            res[j] = 'Ð';
                            break;
                        case 0x70:
                            res[j] = 'Ñ';
                            break;
                        case 0x71:
                            res[j] = 'Ò';
                            break;
                        case 0x72:
                            res[j] = 'Ó';
                            break;
                        case 0x73:
                            res[j] = 'Ô';
                            break;
                        case 0x74:
                            res[j] = 'Õ';
                            break;
                        case 0x75:
                            res[j] = 'Ö';
                            break;
                        case 0x76:
                            res[j] = '×';
                            break;
                        case 0x77:
                            res[j] = 'Ø';
                            break;
                        case 0x78:
                            res[j] = 'Ù';
                            break;
                        case 0x79:
                            res[j] = 'Ú';
                            break;
                        case 0x7A:
                            res[j] = 'Û';
                            break;
                        case 0x7B:
                            res[j] = 'Ü';
                            break;
                        case 0x7C:
                            res[j] = 'Ý';
                            break;
                        case 0x7D:
                            res[j] = 'Þ';
                            break;
                        case 0x7E:
                            res[j] = 'ß';
                            break;
                        case 0x7F:
                            res[j] = 'à';
                            break;
                        case 0x80:
                            res[j] = 'á';
                            break;
                        case 0x81:
                            res[j] = 'â';
                            break;
                        case 0x82:
                            res[j] = 'ã';
                            break;
                        case 0x83:
                            res[j] = 'ä';
                            break;
                        case 0x84:
                            res[j] = 'å';
                            break;
                        case 0x85:
                            res[j] = 'æ';
                            break;
                        case 0x86:
                            res[j] = 'ç';
                            break;
                        case 0x87:
                            res[j] = 'è';
                            break;
                        case 0x88:
                            res[j] = 'é';
                            break;
                        case 0x89:
                            res[j] = 'ê';
                            break;
                        case 0x8A:
                            res[j] = 'ë';
                            break;
                        case 0x8B:
                            res[j] = 'ì';
                            break;
                        case 0x8C:
                            res[j] = 'í';
                            break;
                        case 0x8D:
                            res[j] = 'î';
                            break;
                        case 0x8E:
                            res[j] = 'ï';
                            break;
                        case 0x8F:
                            res[j] = 'ð';
                            break;
                        case 0x90:
                            res[j] = 'ñ';
                            break;
                        case 0x91:
                            res[j] = 'ò';
                            break;
                        case 0x92:
                            res[j] = 'ó';
                            break;
                        case 0x93:
                            res[j] = 'ô';
                            break;
                        case 0x94:
                            res[j] = 'õ';
                            break;
                        case 0x95:
                            res[j] = 'ö';
                            break;
                        case 0x96:
                            res[j] = '÷';
                            break;
                        case 0x97:
                            res[j] = 'ø';
                            break;
                        case 0x98:
                            res[j] = 'ù';
                            break;
                        case 0x99:
                            res[j] = 'ú';
                            break;
                        case 0x9A:
                            res[j] = 'û';
                            break;
                        case 0x9B:
                            res[j] = 'ü';
                            break;
                        case 0x9C:
                            res[j] = 'ý';
                            break;
                        case 0x9D:
                            res[j] = 'þ';
                            break;
                        case 0x9E:
                            res[j] = 'ÿ';
                            break;
                        case 0x9F:
                            res[j] = 'Œ';
                            break;
                        case 0xA0:
                            res[j] = 'œ';
                            break;
                        case 0xA1:
                            res[j] = 'Ş';
                            break;
                        case 0xA2:
                            res[j] = 'ş';
                            break;
                        case 0xA3:
                            res[j] = 'ª';
                            break;
                        case 0xA4:
                            res[j] = 'º';
                            break;
                        case 0xA5:
                            res[j] = 'X';
                            break;
                        case 0xA6:
                            res[j] = 'X';
                            break;
                        case 0xA7:
                            res[j] = 'r';
                            break;
                        case 0xA8:
                            res[j] = '$';
                            break;
                        case 0xA9:
                            res[j] = '¡';
                            break;
                        case 0xAA:
                            res[j] = '¿';
                            break;
                        case 0xAB:
                            res[j] = '!';
                            break;
                        case 0xAC:
                            res[j] = '?';
                            break;
                        case 0xAD:
                            res[j] = ',';
                            break;
                        case 0xAE:
                            res[j] = '.';
                            break;
                        case 0xAF:
                            res[j] = '…';
                            break;
                        case 0xB0:
                            res[j] = '･';
                            break;
                        case 0xB1:
                            res[j] = '/';
                            break;
                        case 0xB2:
                            res[j] = '‘';
                            break;
                        case 0xB3:
                            res[j] = '\'';
                            break;
                        case 0xB4:
                            res[j] = '“';
                            break;
                        case 0xB5:
                            res[j] = '”';
                            break;
                        case 0xB6:
                            res[j] = '„';
                            break;
                        case 0xB7:
                            res[j] = '«';
                            break;
                        case 0xB8:
                            res[j] = '»';
                            break;
                        case 0xB9:
                            res[j] = '(';
                            break;
                        case 0xBA:
                            res[j] = ')';
                            break;
                        case 0xBB:
                            res[j] = '♂';
                            break;
                        case 0xBC:
                            res[j] = '♀';
                            break;
                        case 0xBD:
                            res[j] = '+';
                            break;
                        case 0xBE:
                            res[j] = '-';
                            break;
                        case 0xBF:
                            res[j] = '*';
                            break;
                        case 0xC0:
                            res[j] = '#';
                            break;
                        case 0xC1:
                            res[j] = '=';
                            break;
                        case 0xC2:
                            res[j] = '&';
                            break;
                        case 0xC3:
                            res[j] = '~';
                            break;
                        case 0xC4:
                            res[j] = ':';
                            break;
                        case 0xC5:
                            res[j] = ';';
                            break;
                        case 0xC6:
                            res[j] = '♠';
                            break;
                        case 0xC7:
                            res[j] = '♣';
                            break;
                        case 0xC8:
                            res[j] = '♥';
                            break;
                        case 0xC9:
                            res[j] = '♦';
                            break;
                        case 0xCA:
                            res[j] = '★';
                            break;
                        case 0xCB:
                            res[j] = '◎';
                            break;
                        case 0xCC:
                            res[j] = '○';
                            break;
                        case 0xCD:
                            res[j] = '□';
                            break;
                        case 0xCE:
                            res[j] = '△';
                            break;
                        case 0xCF:
                            res[j] = '◇';
                            break;
                        case 0xD0:
                            res[j] = '@';
                            break;
                        case 0xD1:
                            res[j] = '♪';
                            break;
                        case 0xD2:
                            res[j] = '%';
                            break;
                        case 0xD3:
                            res[j] = '☀';
                            break;
                        case 0xD4:
                            res[j] = '☁';
                            break;
                        case 0xD5:
                            res[j] = '☂';
                            break;
                        case 0xD6:
                            res[j] = '☃';
                            break;
                        case 0xD7:
                            res[j] = ':';
                            j++;
                            res[j] = ')';
                            break;
                        case 0xD8:
                            res[j] = ':';
                            j++;
                            res[j] = 'D';
                            break;
                        case 0xD9:
                            res[j] = 'D';
                            j++;
                            res[j] = ':';
                            break;
                        case 0xDA:
                            res[j] = ':';
                            j++;
                            res[j] = '(';
                            break;
                        case 0xDB:
                            res[j] = '↑';
                            break;
                        case 0xDC:
                            res[j] = '↓';
                            break;
                        case 0xDD:
                            res[j] = 'z';
                            break;
                        case 0xDE:
                            res[j] = ' ';
                            break;
                        case 0xDF:
                            res[j] = 'e';
                            break;
                        case 0xE0:
                            res[j] = 'P';
                            j++;
                            res[j] = 'K';
                            break;
                        case 0xE1:
                            res[j] = 'M';
                            j++;
                            res[j] = 'N';
                            break;
                        case 0xE2:
                            res[j] = ' ';
                            break;
                        case 0xE3:
                            res[j] = ' ';
                            break;
                        case 0xE4:
                            res[j] = ' ';
                            break;
                        case 0xE5:
                            res[j] = ' ';
                            break;
                        case 0xE6:
                            res[j] = ' ';
                            break;
                        case 0xE7:
                            res[j] = ' ';
                            break;
                        case 0xE8:
                            res[j] = '°';
                            break;
                        case 0xE9:
                            res[j] = '_';
                            break;
                        case 0xEA:
                            res[j] = '＿';
                            break;
                        case 0xEB:
                            res[j] = '․';
                            break;
                        case 0xEC:
                            res[j] = '‥';
                            break;
                        default:
                            res[j] = 'X';
                            break;
                    }
                    break;
            }
        }
        string result = new string(res);
        return result;
    }

    public static ushort Checksum(byte[] Source)
    {
        byte top = 0xFF;
        byte bot = 0xFF;
        foreach (var b in Source)
        {
            var x = b ^ top;
            x ^= (x >> 4);
            top = (byte)(bot ^ (x >> 3) ^ (x << 4));
            bot = (byte)(x ^ (x << 5));
        }
        return (ushort)((top << 8) | bot);
    }

    public static void ReplaceChecksum(byte[] Source, int offset)
    {
        using (FileStream fs = File.OpenWrite(Save.path))
        {
            byte[] newSum = BitConverter.GetBytes(Checksum(Source));
            fs.Seek(offset, SeekOrigin.Begin);
            fs.Write(newSum);
        }
    }

    public static void ChecksumSmallBlock()
    {
        byte[] b = new byte[Save.smallBlockSize - Save.footerSize];
        using (FileStream fs = File.OpenRead(Save.path))
        {
            fs.Seek(0, SeekOrigin.Begin);
            fs.ReadExactly(b);
        }
        ReplaceChecksum(b, Save.smallBlockSize - 2);
    }

    public static void ChecksumBigBlock()
    {
        byte[] b = new byte[Save.bigBlockSize - Save.footerSize];
        using (FileStream fs = File.OpenRead(Save.path))
        {
            fs.Seek(Save.bigBlockOffset, SeekOrigin.Begin);
            fs.ReadExactly(b);
        }
        ReplaceChecksum(b, Save.bigBlockOffset + Save.bigBlockSize - 2);
    }

    public static uint rand(uint seed)
    {
        return 0x41C64E6D * seed + 0x6073;
    }

    public static ushort[] RandArray(uint seed, int length)
    {
        ushort[] res = new ushort[length];
        for (int i = 0; i < length; i++)
        {
            seed = rand(seed);
            res[i] = (ushort)(seed >> 16);
        }
        return res;
    }

    public static byte[] UnshufflePKM(byte[] source) //136 bytes
    {
        byte A = 8;
        byte B = 40;
        byte C = 72;
        byte D = 104;
        byte[] res = new byte[136];
        Array.Copy(source, 0, res, 0, 8);
        uint personality = BitConverter.ToUInt32([source[0], source[1], source[2], source[3]]);
        int shift = (((int)(personality) & 0x3E000) >> 0xD) % 24;
        switch (shift)
        {
            case 0:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 1:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 2:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 3:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 4:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 5:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 6:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 7:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 8:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 9:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 10:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 11:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 12:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 13:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 14:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 15:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 16:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 17:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 18:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 19:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 20:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 21:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 22:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 23:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, A, 32);
                break;
        }
        return res;
    }

    public static byte[] DecryptPKM(byte[] data) //136 bytes
    {
        byte[] pid = new byte[4];
        byte[] checksum = new byte[2];
        Array.Copy(data, 0, pid, 0, 4);
        Array.Copy(data, 6, checksum, 0, 2);
        uint personality = BitConverter.ToUInt32(pid);
        ushort[] encryptionKey = Util.RandArray(BitConverter.ToUInt16(checksum), 128 / 2);
        ushort word = 0;
        byte[] wordBytes = new byte[2];
        for (int i = 0; i < 128 / 2; i++)
        {
            word = BitConverter.ToUInt16(data, (i * 2) + 8);
            word = (ushort)(word ^ encryptionKey[i]);
            wordBytes = BitConverter.GetBytes(word);
            data[(i * 2) + 8] = wordBytes[0];
            data[(i * 2) + 9] = wordBytes[1];
        }
        return UnshufflePKM(data);
    }

    public static PKM Gen4ToPKM(byte[] data)
    {
        PKM res = new PKM();
        res.pv = BitConverter.ToUInt32([data[0], data[1], data[2], data[3]]);
        res.dexNum = (Species)BitConverter.ToUInt16([data[0x08], data[0x09]]);
        res.HeldItem = BitConverter.ToUInt16([data[0x0A], data[0x0B]]);
        res.otid = BitConverter.ToUInt16([data[0x0C], data[0x0D]]);
        res.otsid = BitConverter.ToUInt16([data[0x0E], data[0x0F]]);
        res.exp = BitConverter.ToUInt32([data[0x10], data[0x11], data[0x12], data[0x13]]);
        res.friendship = data[0x14];
        res.ability = (Ability)data[0x15];
        res.marks = data[0x16];
        res.ogRegion = (Region)data[0x17];
        res.hpEV = data[0x18];
        res.attackEV = data[0x19];
        res.defenseEV = data[0x1A];
        res.speedEV = data[0x1B];
        res.spAttackEV = data[0x1C];
        res.spDefenseEV = data[0x1D];
        res.coolCV = data[0x1E];
        res.beautyCV = data[0x1F];
        res.cuteCV = data[0x20];
        res.smartCV = data[0x21];
        res.toughCV = data[0x22];
        res.sheenCV = data[0x23];
        res.ribbonsSinnoh1 = BitConverter.ToUInt16([data[0x24], data[0x25]]);
        res.ribbonsSinnoh2 = BitConverter.ToUInt16([data[0x26], data[0x27]]);
        res.ribbonsSinnoh3 = BitConverter.ToUInt16([data[0x60], data[0x61]]);
        res.ribbonsSinnoh4 = BitConverter.ToUInt16([data[0x62], data[0x63]]);
        res.move1 = (Move)BitConverter.ToUInt16([data[0x28], data[0x29]]);
        res.move2 = (Move)BitConverter.ToUInt16([data[0x2A], data[0x2B]]);
        res.move3 = (Move)BitConverter.ToUInt16([data[0x2C], data[0x2D]]);
        res.move4 = (Move)BitConverter.ToUInt16([data[0x2E], data[0x2F]]);
        res.move1pp = data[0x30];
        res.move2pp = data[0x31];
        res.move3pp = data[0x32];
        res.move4pp = data[0x33];
        res.PPUP = BitConverter.ToUInt32([data[0x34], data[0x35], data[0x36], data[0x37]]);
        uint ivs = BitConverter.ToUInt32([data[0x38], data[0x39], data[0x3A], data[0x3B]]);
        res.hpIV = (byte)(ivs >> 0 & 0b11111);
        res.attackIV = (byte)(ivs >> 5 & 0b11111);
        res.defenseIV = (byte)(ivs >> 10 & 0b11111);
        res.speedIV = (byte)(ivs >> 15 & 0b11111);
        res.spAttackIV = (byte)(ivs >> 20 & 0b11111);
        res.spDefenseIV = (byte)(ivs >> 25 & 0b11111);
        res.isEgg = (ivs >> 30 & 1) == 1;
        res.isNicknamed = (ivs >> 31 & 1) == 1;
        res.ribbonsHoeen1 = BitConverter.ToUInt16([data[0x3C], data[0x3D]]);
        res.ribbonsHoeen2 = BitConverter.ToUInt16([data[0x3E], data[0x3F]]);
        byte altForms = data[0x40];
        res.fateful = (altForms & 1) == 1;
        res.gender = (Gender)((altForms >> 1) & 3);
        res.altForms = (byte)((altForms >> 3) & 0b11111);
        res.sLeaves = data[0x41];
        res.eggLocationPt = BitConverter.ToUInt16([data[0x44], data[0x45]]);
        res.metLocationPt = BitConverter.ToUInt16([data[0x46], data[0x47]]);
        res.nickname = Gen4ToText([data[0x48], data[0x49], data[0x4A], data[0x4B], data[0x4C], data[0x4D], data[0x4E], data[0x4F], data[0x50], data[0x51], data[0x52], data[0x53], data[0x54], data[0x55], data[0x56], data[0x57], data[0x58], data[0x59], data[0x5A], data[0x5B], data[0x5C], data[0x5D],]);
        res.ogGame = (GameVersion)data[0x5F];
        res.otName = Gen4ToText([data[0x68], data[0x69], data[0x6A], data[0x6B], data[0x6C], data[0x6D], data[0x6E], data[0x6F], data[0x70], data[0x71], data[0x72], data[0x73], data[0x74], data[0x75], data[0x76], data[0x77]]);
        res.eggDate = [data[0x78], data[0x79], data[0x7A]];
        res.metDate = [data[0x7B], data[0x7C], data[0x7D]];
        res.eggLocation = BitConverter.ToUInt16([data[0x7E], data[0x7F]]);
        res.metLocation = BitConverter.ToUInt16([data[0x80], data[0x81]]);
        res.pokerus = data[0x82];
        res.pokeball = (Ball)data[0x83];
        res.encounterType = data[0x85];
        res.otGender = (Gender)((data[0x84] & 0b10000000) >> 7);
        res.metLevel = (byte)(data[0x84] & 0b01111111);
        res.nature = (Nature)(res.pv % 25);
        return res;
    }

    public static ushort PKMChecksum(byte[] data)
    {
        uint res = 0;
        for (int i = 8; i < data.Length; i += 2)
        {
            res += BitConverter.ToUInt16([data[i], data[i + 1]]);
        }
        return (ushort)(res);
    }

    public static byte[] PKMToGen4(PKM pk)
    {
        byte[] res = new byte[136];
        Array.Copy(BitConverter.GetBytes(pk.pv), 0, res, 0, 4);
        Array.Copy(BitConverter.GetBytes((ushort)(pk.dexNum)), 0, res, 8, 2);
        Array.Copy(BitConverter.GetBytes(pk.HeldItem), 0, res, 10, 2);
        Array.Copy(BitConverter.GetBytes(pk.otid), 0, res, 12, 2);
        Array.Copy(BitConverter.GetBytes(pk.otsid), 0, res, 14, 2);
        Array.Copy(BitConverter.GetBytes(pk.exp), 0, res, 16, 4);
        res[20] = pk.friendship;
        res[21] = (byte)(pk.ability);
        res[22] = pk.marks;
        res[23] = (byte)(pk.ogRegion);
        res[24] = pk.hpEV;
        res[25] = pk.attackEV;
        res[26] = pk.defenseEV;
        res[27] = pk.speedEV;
        res[28] = pk.spAttackEV;
        res[29] = pk.spDefenseEV;
        res[30] = pk.coolCV;
        res[31] = pk.beautyCV;
        res[32] = pk.cuteCV;
        res[33] = pk.smartCV;
        res[34] = pk.toughCV;
        res[35] = pk.sheenCV;
        Array.Copy(BitConverter.GetBytes(pk.ribbonsSinnoh1), 0, res, 36, 2);
        Array.Copy(BitConverter.GetBytes(pk.ribbonsSinnoh2), 0, res, 38, 2);
        Array.Copy(BitConverter.GetBytes((ushort)pk.move1), 0, res, 40, 2);
        Array.Copy(BitConverter.GetBytes((ushort)pk.move2), 0, res, 42, 2);
        Array.Copy(BitConverter.GetBytes((ushort)pk.move3), 0, res, 44, 2);
        Array.Copy(BitConverter.GetBytes((ushort)pk.move4), 0, res, 46, 2);
        res[48] = pk.move1pp;
        res[49] = pk.move2pp;
        res[50] = pk.move3pp;
        res[51] = pk.move4pp;
        Array.Copy(BitConverter.GetBytes(pk.PPUP), 0, res, 52, 4);
        uint ivs = 0;
        if (pk.isNicknamed)
            ivs = 0b10000000_00000000_00000000_00000000;
        if (pk.isEgg)
            ivs |= 0b01000000_00000000_00000000_00000000;
        ivs |= pk.hpIV;
        ivs |= (uint)(pk.attackIV << 5);
        ivs |= (uint)(pk.defenseIV << 10);
        ivs |= (uint)(pk.speedIV << 15);
        ivs |= (uint)(pk.spAttackIV << 20);
        ivs |= (uint)(pk.spDefenseIV << 25);
        Array.Copy(BitConverter.GetBytes(ivs), 0, res, 56, 4);
        Array.Copy(BitConverter.GetBytes(pk.ribbonsHoeen1), 0, res, 60, 2);
        Array.Copy(BitConverter.GetBytes(pk.ribbonsHoeen2), 0, res, 62, 2);
        byte alt = 0;
        if (pk.fateful)
            alt = 1;
        alt |= (byte)(0b110 & ((byte)pk.gender << 1));
        alt |= (byte)(pk.altForms << 3);
        res[64] = alt;
        res[65] = pk.sLeaves;
        Array.Copy(BitConverter.GetBytes(pk.eggLocationPt), 0, res, 68, 2);
        Array.Copy(BitConverter.GetBytes(pk.metLocationPt), 0, res, 70, 2);
        Array.Copy(TextToGen4(pk.nickname, 22), 0, res, 72, 22);
        res[95] = (byte)pk.ogGame;
        Array.Copy(BitConverter.GetBytes(pk.ribbonsSinnoh3), 0, res, 96, 2);
        Array.Copy(BitConverter.GetBytes(pk.ribbonsSinnoh4), 0, res, 98, 2);
        Array.Copy(TextToGen4(pk.otName, 16), 0, res, 104, 16);
        Array.Copy(pk.eggDate, 0, res, 120, 3);
        Array.Copy(pk.metDate, 0, res, 123, 3);
        Array.Copy(BitConverter.GetBytes(pk.eggLocation), 0, res, 126, 2);
        Array.Copy(BitConverter.GetBytes(pk.metLocation), 0, res, 128, 2);
        res[130] = pk.pokerus;
        res[131] = (byte)pk.pokeball;
        byte metLevel = 0;
        if ((byte)pk.otGender == 1)
            metLevel = 0b10000000;
        metLevel |= pk.metLevel;
        res[132] = metLevel;
        res[133] = pk.encounterType;
        res[134] = (byte)pk.pokeball;
        Array.Copy(BitConverter.GetBytes(PKMChecksum(res)), 0, res, 6, 2);
        return res;
    }

    public static byte[] ShufflePKM(byte[] source) //136 bytes
    {
        byte A = 8;
        byte B = 40;
        byte C = 72;
        byte D = 104;
        byte[] res = new byte[136];
        Array.Copy(source, 0, res, 0, 8);
        uint personality = BitConverter.ToUInt32([source[0], source[1], source[2], source[3]]);
        int shift = (((int)(personality) & 0x3E000) >> 0xD) % 24;
        switch (shift)
        {
            case 0:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 1:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 2:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 3:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 4:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 5:
                Array.Copy(source, A, res, A, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 6:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 7:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 8:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 9:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 10:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 11:
                Array.Copy(source, A, res, B, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 12:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 13:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 14:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, D, 32);
                break;
            case 15:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, D, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 16:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 17:
                Array.Copy(source, A, res, C, 32);
                Array.Copy(source, B, res, D, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 18:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 19:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, A, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 20:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, C, 32);
                break;
            case 21:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, B, 32);
                Array.Copy(source, C, res, C, 32);
                Array.Copy(source, D, res, A, 32);
                break;
            case 22:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, A, 32);
                Array.Copy(source, D, res, B, 32);
                break;
            case 23:
                Array.Copy(source, A, res, D, 32);
                Array.Copy(source, B, res, C, 32);
                Array.Copy(source, C, res, B, 32);
                Array.Copy(source, D, res, A, 32);
                break;
        }
        return res;
    }

    public static byte[] EncryptPKM(byte[] data) //136 bytes
    {
        byte[] pid = new byte[4];
        byte[] checksum = new byte[2];
        Array.Copy(data, 0, pid, 0, 4);
        Array.Copy(data, 6, checksum, 0, 2);
        uint personality = BitConverter.ToUInt32(pid);
        ushort[] encryptionKey = Util.RandArray(BitConverter.ToUInt16(checksum), 128 / 2);
        ushort word = 0;
        byte[] wordBytes = new byte[2];
        data = ShufflePKM(data);
        for (int i = 0; i < 128 / 2; i++)
        {
            word = BitConverter.ToUInt16(data, (i * 2) + 8);
            word = (ushort)(word ^ encryptionKey[i]);
            wordBytes = BitConverter.GetBytes(word);
            data[(i * 2) + 8] = wordBytes[0];
            data[(i * 2) + 9] = wordBytes[1];
        }
        return data;
    }
}
