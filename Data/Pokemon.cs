using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonGoManager.Data
{
    class Pokemon
    {
        private static float baseCP = 0.094f;
        public short NatID { get; set; }
        public Type Type1 { get; set; }
        public Type Type2 { get; set; }
        public short BaseStamina { get; set; }
        public short BaseAttack { get; set; }
        public short BaseDefense { get; set; }
        private List<Move> Learnset;

        public Pokemon(short natID, Type type1, Type type2, short s, short a, short d)
        {
            NatID = natID;
            Type1 = type1;
            Type2 = type2;
            BaseStamina = s;
            BaseAttack = a;
            BaseDefense = d;
            Learnset = new List<Move>();
        }

        public Pokemon(short natID, byte[] data)
        {
            if (data.Length != 8) return;
            NatID = natID;
            BaseAttack = BitConverter.ToInt16(data, 2);
            BaseDefense = BitConverter.ToInt16(data, 4);
            BaseStamina = BitConverter.ToInt16(data, 0);
            Type1 = (Type)data[6];
            Type2 = (Type)data[7];
            Learnset = new List<Move>();

        }

        private double getCPMultiplier(decimal level)
        {
            if (level > 40) level = 40;
            level--;
            level *= 2;
            return Data.Lists.cpM[(int)level]; 
        }

        public int getCP(decimal level, int atkIV, int defIV, int staIV)
        {
            int atk = BaseAttack + atkIV;
            int def = BaseDefense + defIV;
            int sta = BaseStamina + staIV;
            double cpMult = getCPMultiplier(level);
            return Math.Max(
                (int)Math.Floor(atk * Math.Pow((double)def, 0.5) * Math.Pow((double)sta, 0.5) * Math.Pow(cpMult, 2) / 10),
                10);
        }

        public int getHP(decimal level, int staIV)
        {
            int sta = BaseStamina + staIV;
            double cpMult = getCPMultiplier(level);
            return Math.Max((int)Math.Floor(sta * cpMult), 10);
        }
    }
}
