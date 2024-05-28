namespace Algorithms_with_C_Sharp.Solutions;

public class WeightForWeight {
	
    public static string orderWeight(string strng)
    {
       var weights = strng.Split(" ");

       for (int i = 0; i < weights.Length; i++)
       {
           for (int j = i + 1; j < weights.Length; j++)
           {
               int weightI = weights[i].ToCharArray().Sum(c => c - '0');
               int weightJ = weights[j].ToCharArray().Sum(c => c - '0');

               if (weightI > weightJ || (weightI == weightJ && string.Compare(weights[i], weights[j]) > 0))
               {
                   var temp = weights[i];
                   weights[i] = weights[j];
                   weights[j] = temp;
               }
           }
       }
       return string.Join(" ", weights);
    }
}