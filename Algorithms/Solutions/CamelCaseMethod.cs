namespace Algorithms_with_C_Sharp.Solutions;

public class CamelCaseMethod
{
    public static string CamelCase(string str)
    {
        var arr = str.Split(" ");
        var result = new List<string>();
        var capitalizedText = "";
        
        foreach (var text in arr)
        {
            if (text.Length == 1)
            {
                capitalizedText = text[0].ToString().ToUpper();
            }
            if (text.Length > 1)
            { 
                capitalizedText = text[0].ToString().ToUpper() + text.Substring(1);
            }
            
            result.Add(capitalizedText);
            capitalizedText = "";
        }

        return string.Join("", result.ToArray() );
    }
}