using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final
{
    internal class Bilgisayar : BaseMakına
    {
        private int _usbPortsNumber; //Field tanımını yapıyoruz.
        public override DateTime ProductionDate { get; set; }
        public override string SerialNumber { get; set; }
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override string OperatingSystem { get; set; }

        //Bilgisayar classına özel proplar.
        public bool Bluetooth { get; set; }
        public int USB_PortsNumber
        {
            get
            {
                return _usbPortsNumber;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbPortsNumber = value;
                }
                else
                {
                    _usbPortsNumber = -1
                    ;
                }
            }
        }
        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Bilgisayarın Adı: {Name}");
            Console.WriteLine($"İşletim Sistemi : {OperatingSystem}");
            Console.WriteLine($"Bilgisayar Hakkında : {Description}");
            Console.WriteLine($"Bilgisayarın Seri Numarası: {SerialNumber}");
            Console.WriteLine($"Bilgisayarın USB Sayısı: {USB_PortsNumber}");
            Console.WriteLine($"Bilgisayarda Bluetooth var mı?: {Bluetooth}");
            ProductionDate = DateTime.Today;
            Console.WriteLine($"Bilgisayarın Üretim Tarihi {ProductionDate.ToString("dd/MM/yyyy")}");
        }
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın Adı------> {Name}");
        }

    }
}