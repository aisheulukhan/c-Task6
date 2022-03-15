using System;

namespace Task.weapon.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daragin gulle tutumu:");
            int bulletCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daraqdaki gulle sayi:");
            int bulletsCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daragin bosalma saniyesi");
            double dischangeSeconds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Atis modu");
            bool shootingMode = Convert.ToBoolean(Console.ReadLine());


            Weapon weapon = new Weapon(bulletCapacity, bulletsCount, dischangeSeconds, shootingMode);
            
            int key = 0;
            do
            {
                Console.WriteLine("Reqem daxil edin : ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        weapon.ShowInfo();
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        weapon.GetRemainBulletCount();
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.changefiremode();
                        break;
                    case 6:
                        Console.WriteLine("Sagolun");
                        break;
                    default:
                        Console.WriteLine("Yalnis daxil etdiniz");
                        break;
                }
            } while (key != 6);
        }
    }
}
