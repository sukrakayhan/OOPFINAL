using OOP_Final;
using System;

hey: while (true)
{
    Console.WriteLine("Telefon üretmek için 1 ");
    Console.WriteLine("Bilgisayar üretmek için 2'ye basın. ");
    Console.WriteLine("Çıkış yapmak için q ya basın. ");
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            CreatePhone();
            break;

        case "2":
            CreateComputer();
            break;
        case "q":
            return;
    }
}

static void CreatePhone()
{
    while (true)
    {
        Telefon telefon = new Telefon();
        Console.WriteLine("Telefonun adını girin:");
        telefon.Name = Console.ReadLine();
        Console.WriteLine("Telefonun işletim sistemini girin:");
        telefon.OperatingSystem = Console.ReadLine();
        Console.WriteLine("Telefon hakkında bilgi girin:");
        telefon.Description = Console.ReadLine();
        Console.WriteLine("Telefonun seri numarasını girin:");
        telefon.SerialNumber = Console.ReadLine();
        telefon.BilgileriYazdir();
        Console.WriteLine("Yeni ürün eklemek istiyor musunuz?(e - h)");
        string isContinueTelefon = Console.ReadLine();
        if (isContinueTelefon == "e")
        {
            continue;
        }
        else if (isContinueTelefon == "h")
        {
            return;
        }
        else { return; }
    }
}

static void CreateComputer()
{
    while (true)
    {
        Bilgisayar bilgisayar = new Bilgisayar();
        Console.WriteLine("Bilgisayarın adını girin:");
        bilgisayar.Name = Console.ReadLine();
        Console.WriteLine("Bilgisayarın işletim sistemini girin:");
        bilgisayar.OperatingSystem = Console.ReadLine();
        Console.WriteLine("Bilgisayarın hakkında bilgi girin:");
        bilgisayar.Description = Console.ReadLine();
        Console.WriteLine("Bilgisayarın seri numarasını girin:");
        bilgisayar.SerialNumber = Console.ReadLine();
        Console.WriteLine("Bilgisayarın USB sayısını girin(2 - 4):");
        bilgisayar.USB_PortsNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bluetooth var mı? (e - h)");
        if (Console.ReadLine() == "e")
        {
            bilgisayar.Bluetooth = true;
        }
        else if (Console.ReadLine() == "h")
        {
            bilgisayar.Bluetooth = false;
        }
        else
        {
            Console.WriteLine("Yanlış tuşlama yaptınız yok kabul edildi.");
            bilgisayar.Bluetooth = false;
        }
        bilgisayar.BilgileriYazdir();
        Console.WriteLine("Yeni ürün eklemek istiyor musunuz?(e - h)");
        string isContinueBilgisayar = Console.ReadLine();
        if (isContinueBilgisayar == "e")
        {
            continue;
        }
        else if (isContinueBilgisayar == "h")
        {
            return;
        }
        else { return; }
    }
}