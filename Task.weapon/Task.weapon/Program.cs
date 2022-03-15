using System;

namespace Task.weapon.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Darağın güllə tutumu:");
            int bulletCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daraqdakı güllə sayı:");
            int bulletsCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Darağın boşalma saniyəsi");
            double dischangeSeconds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Atış modu");
            bool shootingMode = Convert.ToBoolean(Console.ReadLine());


            Weapon weapon = new Weapon(bulletCapacity, bulletsCount, dischangeSeconds, shootingMode);
            
            int key = 0;
            do
            {
                Console.WriteLine("Rəqəm daxil edin : ");
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
                        Console.WriteLine("Sağolun");
                        break;
                    default:
                        Console.WriteLine("Yalnış daxil etdiniz");
                        break;
                }
            } while (key != 6);
        }
    }
}
