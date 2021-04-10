using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank
    {
        public string TankModel;
        private int Ammunition;
        private int Armor;
        private int Mobility;

        public Tank() { }
        public Tank(string TankModel, int Ammunition, int Armor, int Mobility)
        {
            this.TankModel = TankModel;
            this.Ammunition = Ammunition;
            this.Armor = Armor;
            this.Mobility = Mobility;
        }

        public static void PrintInfo(Tank obj1, Tank obj2)
        {
            string space = new String(' ', 25 - obj1.ToString().Length);

            string ff = string.Format($"Танк: {obj1.TankModel}\t\t{space}Танк: {obj2.TankModel}\n" +
                $"Боекомлект: {obj1.Ammunition}\t\t{space}Боекомлект: {obj2.Ammunition}\n" +
                $"Броня: {obj1.Armor}\t\t{space}Броня: {obj2.Armor}\n" +
                $"Маневренность: {obj1.Mobility}\t{space}Маневренность:{obj2.Mobility}");
            Console.WriteLine(ff);
            //Console.WriteLine($" Танк: " + obj1.TankModel+"\t"+{space}+obj2.TankModel);
            //Console.WriteLine(" Боекомлект: " + obj1.Ammunition+"t"+obj2.Ammunition);
            //Console.WriteLine(" Броня: " + obj1.Armor + "\t"+obj2.Armor);
            //Console.WriteLine(" Маневренность: " + obj1.Mobility + "\t" + obj2.Mobility);
            
            //Console.WriteLine();
        }

        public static bool operator ^(Tank t34, Tank pantera)
        {
            int supermacyT34 = 0;
            int supermacyPantera = 0;

            if (t34.Ammunition > pantera.Ammunition) supermacyT34++;            

            else supermacyPantera++;
            if (t34.Armor > pantera.Armor) supermacyT34++;

            else supermacyPantera++;
            if (t34.Mobility > pantera.Mobility) supermacyT34++;

            else supermacyPantera++;


            return supermacyT34 >= supermacyPantera;                
        }
    }



        
}
