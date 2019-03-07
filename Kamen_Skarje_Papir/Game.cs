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
                switch (P2State)
                {
                    case 0:
                        return 3;
                    case 1:
                        P1Score++;
                        if (P1Score > P1HScore)
                        {
                            P1HScore = P1Score;
                        }
                        return 1;
                    case 2:
                        P2Score++;
                        if (P2Score > P2HScore)
                        {
                            P2HScore = P2Score;
                        }
                        return 2;
                    default:
                        return 0;
                }
            }
            else if (P1State == 1)
            {
                switch (P2State)
                {
                    case 0:
                        P2Score++;
                        if (P2Score > P2HScore)
                        {
                            P2HScore = P2Score;
                        }
                        return 2;
                    case 1:
                        return 3;
                    case 2:
                        P1Score++;
                        if (P1Score > P1HScore)
                        {
                            P1HScore = P1Score;
                        }
                        return 1;
                    default:
                        return 0;
                }
            }
            else if (P1State == 2)
            {
                switch (P2State)
                {
                    case 0:
                        P1Score++;
                        if (P1Score > P1HScore)
                        {
                            P1HScore = P1Score;
                        }
                        return 1;
                    case 1:
                        P2Score++;
                        if (P2Score > P2HScore)
                        {
                            P2HScore = P2Score;
                        }
                        return 2;
                    case 2:
                        return 3;
                    default:
                        return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }

}
