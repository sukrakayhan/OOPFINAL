using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final
{
    internal abstract class BaseMakına //Abstract olarak tanımlıyoruz çünkü bu soyur bir sınıf ve tek başına kullanılmasını istemiyoruz.
    {
        //Abstract keyword veriyoruz çünkü bu classı extent eden class bu propları implemente etmek zorunda kalsın.
        public abstract DateTime ProductionDate { get; set; }
        public abstract string SerialNumber { get; set; }
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract string OperatingSystem { get; set; }

        //virtual keyword verilerek extends eden diğer classlarda override edilmesine izin veriyor.
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine("Burayi override etmen gerek.");
        }
        public abstract void UrunAdiGetir();
    }
}