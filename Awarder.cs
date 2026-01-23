namespace knightmoves;

public class AwardCalculator
{
    public static string CalculateAward(int points)
    {
        if (points > 99)
        {
            return "First Place";
        }
        else if (points > 49 && points < 100)
        {
            return "Second Place";
        }
        else
        {
            return "Participation Award";
        }
    }
}




