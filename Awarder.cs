namespace knightmoves;

public class AwardSystem
{
    public string CalculateAward(int points)
    {
        if (points > 99)
        {
            return "First Place";
        }
        
        if (points > 49 && points < 100)
        {
            return "Second Place";
        }

        
        return "Participation Award";
    }
}




