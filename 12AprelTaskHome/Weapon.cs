using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12AprelTaskHome
{
    internal class Weapon
    {
        private static int  _id;
        public int Id { get; set; }
        public string BulletType { get; set; }
        public  int BulletSay { get; set; }
        public int MaxBulletSay { get; set; }
        public Weapon()
        {
            _id++;
            Id = _id;
        }
        public void Fire(string bullettype ,int bulletsay)
        {
         
           BulletSay = bulletsay;
            BulletType = bullettype;
            if(BulletSay>0)
            {
                Console.WriteLine(BulletSay);
                Console.WriteLine($"Silahin Novu-{BulletType} Gullenin sayi-{BulletSay - 1}");
                BulletSay--;
            }
            else
            {
                Console.WriteLine("Gulle yoxdur");
            }
        }
        public void Fill()
        {
            Bullet[] bullets = new Bullet[0];
           
            
            BulletSay = MaxBulletSay;
            Console.WriteLine(BulletSay);
            Console.WriteLine("gulle dolduruldu");


        }
        public void PullTrigger()
        {
            Console.WriteLine($"Novbeti gulle{BulletType}");
            
        }
    }
   
}
