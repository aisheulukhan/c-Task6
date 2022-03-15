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

            if (bulletsCount == 0)

            {
                Console.WriteLine("Güllə bitib");
            }
            else if (bulletsCount > 0)
            {
                bulletsCount -= 1;
                Console.WriteLine("Dış Dış");
            }
            else
            {
                Console.WriteLine("Sayı mənfi ola bilməz");
            }

        }
        public void Fire()

        {
            if (dischangeSeconds > 0 && bulletsCount > 0 && bulletCapacity > 0)
            {
                double Second= (bulletsCount * dischangeSeconds) / bulletCapacity;
                Console.WriteLine($"{Second} - Saniyəyə bitir");
            }
            else
            {
                Console.WriteLine("Yalnış daxil edilib!");
            }


        }
        public void GetRemainBulletCount()
        {
            if (bulletCapacity > 0 && bulletsCount >= 0 && bulletCapacity> bulletsCount)
            {
                int NeededbulletsCount = bulletCapacity - bulletsCount;
                Console.WriteLine($"{NeededbulletsCount} - Darağın dolmasi üçün lazım olan gülle sayı");
            }
            else
            {
                Console.WriteLine("Yalnış daxil edilib!");
            }

        }
        public void Reload()
        {
            if (bulletCapacity > 0 && bulletsCount >= 0)
            {
                
               int NeededbulletsCount = bulletCapacity - bulletsCount;
                bulletsCount += NeededbulletsCount;
                Console.WriteLine("Daraq yenidən doldu");
            }
            else
            {
                Console.WriteLine("Yalnış daxil edilib!");
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
                Console.WriteLine("Təkdir");
                shootingMode = false;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("1.Shoot");
            Console.WriteLine("2.Fire");
            Console.WriteLine("3.Reload");
            Console.WriteLine("4.changefiremode");


        }
    }
}
