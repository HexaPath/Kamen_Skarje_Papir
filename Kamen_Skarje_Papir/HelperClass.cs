using System;

namespace Kamen_Skarje_Papir
{
    public class HelperClass
    {
        static Random rand = new Random();
        static public int GetState()
        {
            int randomizor = rand.Next(0, 3); //0,1,2
            return randomizor;
        }
    }
}
