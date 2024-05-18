namespace Algorithms_with_C_Sharp.Solutions;

public class WhoLikesIt
{
    public static string Likes(string[] name)
    {
        var pretext = "no one";
        var likingText =  name.Length > 1 ? "like" : "likes"; 
        if (name.Length == 1)
        {
            pretext = name.ElementAt(0);
        }
        else if(name.Length == 2)
        {
            pretext = string.Join(" and ", name.ElementAt(0), name.ElementAt(1));
        }
        else if(name.Length == 3)
        {
            pretext = name.ElementAt(0) + ", " + name.ElementAt(1) + " and " + name.ElementAt(2); 
        }
        else if(name.Length > 3)
        {
            pretext = name.ElementAt(0) + ", " + name.ElementAt(1) + " and " + (name.Length - 2).ToString() + " others"; 
        }

        return pretext + " " + likingText + " this";
    }
}


