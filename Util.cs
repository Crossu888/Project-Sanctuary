public class Util
{
    public static byte[] TextToGen4(string Source)
    {
        char[] src = Source.ToCharArray();
        byte[] res = new byte[src.Length * 2];
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
            }
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
        ReplaceChecksum(b, Save.bigBlockSize - 2);
    }
}
