using System;

namespace Task.weapon.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(30, 10, 0.2, true);
            
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
