namespace Algorithms_with_C_Sharp.Solutions;

public class WeightForWeight {
	
    public static string orderWeight(string strng)
    {
       var weights = strng.Split(" ");

       for (int i = 0; i < weights.Length; i++)
       {
           for (int j = i + 1; j < weights.Length; j++)
           {
               int weightI = weights[i].ToCharArray().Select(x=> int.Parse(x.ToString())).Sum();
               int weightJ = weights[j].ToCharArray().Select(x=> int.Parse(x.ToString())).Sum();

               if (weightI > weightJ ||  (weightI == weightJ && int.Parse(weights[i]) > int.Parse(weights[j])))
               {
                   var temp = weights[i];
                   weights[i] = weights[j];
                   weights[j] = temp;
               }
           }
       }

       return string.Join(" ", weights);
    }
    public static string orderWeightWithLinq(string strng)
    {
        var values = strng.Split(" ").Select(weight =>
        {
            return new
            {
                sub = weight.ToCharArray().Select(x => int.Parse(x.ToString())).Sum(),
                self = weight
            };
        }).OrderBy(x => x.sub).ThenBy(x=> x.self).ToList();
        return String.Join(" ",  values.Select(x=>x.self));
    }
    public static string orderWeightBest(string strng)
    {
        return string.Join(" ", strng.Split(" ")
            .OrderBy(x => x.ToCharArray().Select(x=> int.Parse(x.ToString())).Sum())
            .ThenBy(x => x));
    }
}