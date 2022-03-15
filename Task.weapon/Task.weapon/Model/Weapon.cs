using System;
using System.Collections.Generic;
using System.Text;

namespace Task.weapon.Model
{
    class Weapon
    {
        public int bulletCapacity;
        public int bulletsCount;
        public double dischangeSeconds;
        public bool shootingMode;

        public Weapon(int bulletCapacity, int bulletsCount, double dischangeSeconds, bool shootingMode)
        {
            this.bulletCapacity = bulletCapacity;
            this.bulletsCount = bulletsCount;
            this.dischangeSeconds = dischangeSeconds;
            this.shootingMode = shootingMode;
        }
        public void Shoot()
        {

            if (bulletsCount > 0)

            {
                bulletsCount = bulletsCount - 1;
                Console.WriteLine("Diw diw");
            }
            else if (bulletsCount == 0)
            {
                Console.WriteLine("Gulle bitib");
            }
            else
            {
                Console.WriteLine("Sayi menfi ola bilmez");
            }

        }
        public void Fire()

        {
            if (dischangeSeconds > 0 && bulletsCount > 0 && bulletCapacity > 0)
            {
                double Second= (bulletsCount * dischangeSeconds) / bulletCapacity;
                Console.WriteLine($"{Second} - Saniyeye bitir");
            }
            else
            {
                Console.WriteLine("Yalnis daxil edilib!");
            }


        }
        public void GetRemainBulletCount()
        {
            if (bulletCapacity > 0 && bulletsCount > 0)
            {
                Console.WriteLine($"{bulletCapacity - bulletsCount} - Daragin dolmasi ucun lazim olan gulle sayi");
            }
            else
            {
                Console.WriteLine("Yalnis daxil edilib!");
            }

        }
        public void Reload()
        {
            if (bulletCapacity > 0 && bulletsCount > 0)
            {
                Console.WriteLine($"{(bulletCapacity - bulletsCount) + bulletsCount} - Daraq yeniden doldu");
            }
            else
            {
                Console.WriteLine("Yalnis daxil edilib!");
            }

        }
        public void changefiremode()
        {
            if (shootingMode == false)
            {
                Console.WriteLine("Avtomatik");
                shootingMode = true;
            }
            else
            {
                Console.WriteLine("Tekdir");
                shootingMode = false;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Daragin gulle tutumu:{bulletCapacity }");
            Console.WriteLine($"Daraqdaki gulle sayi:{bulletsCount }");
            Console.WriteLine($"Daragin bosalma saniyesi:{dischangeSeconds }");
            Console.WriteLine($"Atis modu:{shootingMode }");


        }
    }
}
