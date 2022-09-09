namespace CalidadT1;

public class RomanoGenerator
{
    private Dictionary<int, string> romanos = new Dictionary<int, string>()
    {
        {900, "CM"},
        {500, "D"},
        {400, "CD"},
        {100, "C"},
        {90, "XC" },
        {50, "L"},
        {40, "XL"},
        {10, "X"},
        {9, "IX" },
        {5, "V"},
        {4, "IV"},
        {1, "I"},
    };
    // si se envia un numero menor a 1 debe enviar error/ validar hasta el 1000
    public string GetRomano(int number)
    {
        var romano = "";
        if (number <= 0 || number > 1000)
        {
            return "Error";
        }
        while (number > 0)
        {
            foreach (KeyValuePair<int, string> entry in romanos)
            {
                if (number < entry.Key) continue;
                romano += entry.Value;
                number -= entry.Key;
                break;
            }
        }
        return romano;
    }
}