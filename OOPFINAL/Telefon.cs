using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final
{
    internal class Telefon : BaseMakına
    {
        public override DateTime ProductionDate { get; set; }
        public override string SerialNumber { get; set; }
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override string OperatingSystem { get; set; }
        //Telefon claasına özel prop
        public bool TR_Lisance { get; set; }

        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Telefonun Adı: {Name}");
            Console.WriteLine($"İşletim Sistemi : {OperatingSystem}");
            Console.WriteLine($"Telefon Hakkında : {Description}");
            Console.WriteLine($"Telefonun Seri Numarası: {SerialNumber}");
            ProductionDate = DateTime.Today;
            Console.WriteLine($"Telefonun Üretim Tarihi {ProductionDate.ToString("dd/MM/yyyy")}");
        }
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun Adı------> {Name}");
        }
    }
}