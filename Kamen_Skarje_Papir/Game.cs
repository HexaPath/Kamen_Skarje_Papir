using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamen_Skarje_Papir
{
    public class Game
    {
        public int P1Score { get; set; }
        public int P2Score { get; set; }
        public int P1State { get; set; }
        public int P2State { get; set; }
        public static int P1HScore { get; set; }
        public static int P2HScore { get; set; }

        public int Play()
        {
            P1State = HelperClass.GetState();
            P2State = HelperClass.GetState();

            /*NEEDS ADJUSTMENTS 'CUZ DAMN THING DON'T WORK*/
            if (P1State == 0)
            {
                if (P2State == 1)
                {
                    return 1;
                }
                else if (P2State == 2)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else if (P1State == 1)
            {
                if (P2State == 0)
                {
                    return 2;
                }
                else if (P2State == 2)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
            else if (P1State == 2)
            {
                if (P2State == 0)
                {
                    return 1;
                }
                else if (P2State == 1)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
