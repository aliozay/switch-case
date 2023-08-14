int month = DateTime.Now.Month;

switch (month)
{
    
    case 6:
        Console.WriteLine("Haziran Ayındasınız");
        break;
    case 7:
        Console.WriteLine("Temmuz Ayındasınız");
        break;
    case 8:
        Console.WriteLine("Ağustos Ayındasınız");
        break;
    case 9:
        Console.WriteLine("Eylül Ayındasınız");
        break;

    default:
        Console.WriteLine("Yanlış Veri Girişi");
        break;



    
}

switch (month)
{
    case 6:
    case 7:
    case 8:
        System.Console.WriteLine("Yaz Mevsimi");
        break;

    default:
    break;    


}