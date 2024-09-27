class Program
{
    public static void Main()
    {
        Console.WriteLine("Matn taxrir qiluvchi dasturiga xush kelibsiz!");
        Console.Write("Matn kiriting: ");
        string Matn = Console.ReadLine() ?? "";

        Console.WriteLine("             Tanlang:");
        Console.WriteLine("1. Matnni formatlash (Format)");
        Console.WriteLine("2. Matnni bo'laklarga ajratish (Split)");
        Console.WriteLine("3. Matndan substring olish (Substring)");
        Console.WriteLine("4. Matnlarni taqqoslash (Compare)");
        Console.WriteLine("5. Matnni almashtirish (Replace)");
        Console.WriteLine("6. Matn ichida so'z topish (Contains)");
        Console.WriteLine("7. Matnlarni birlashtirish (Join)");
        Console.WriteLine("8. Bo'sh joylarni olib tashlash (Trim)");
        Console.WriteLine("9. Matn oxirini tekshirish (EndsWith)");
        Console.WriteLine("10. Belgining indeksini aniqlash (IndexOf)");
        Console.WriteLine("11. Matnni o'chirish (Remove)");
        Console.WriteLine("12. Harflarni katta qilish (ToUpper)");
        Console.WriteLine("13. Harflarni kichik qilish (ToLower)");
        Console.WriteLine("14. Matnni chap tomondan to'ldirish (PadLeft)");
        Console.WriteLine("15. Matnni o'ng tomondan to'ldirish (PadRight)");
        Console.WriteLine("16. Matn boshini tekshirish (StartsWith)");
        Console.WriteLine("17. Matnni harflarga ajratish (ToCharArray)");
        Console.WriteLine("18. Oxirgi uchraydigan indeksni aniqlash (LastIndexOf)");
        Console.WriteLine("19. Chiqish");

        Console.WriteLine("Sonni kiriting: ");
        int son = int.Parse(Console.ReadLine() ?? "");

        switch(son)
        {
            case 1:
            Console.WriteLine("Tekstni kiriting: ");
            string text = Console.ReadLine()!;

            
            break;
            case 2:
            
            break;
            case 3:
            
            break;
            case 4:
            
            break;
            case 5:
            
            break;
            case 6:
            
            break;
            case 7:
            
            break;
            case 8:
            
            break;
            case 9:

            
            break;
            case 10:
            
            break;
            case 11:
            
            break;
            case 12:
            
            break;
            case 13:
            
            break;
            case 14:
            
            break;
            case 15:
            
            break;
            case 16:
            
            break;
            case 17:
            
            break;
            case 18:
            
            break;
            if(son == 19)
            {
                break;
            }
            default:
            Console.WriteLine("Invalid Code 404");
            break;
        }
    }
}