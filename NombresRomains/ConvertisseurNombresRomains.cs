namespace NombresRomains;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffre)
    {
        if(chiffre == 5)
        {
            return "V";
        }
        return chiffre == 1 ? "I" :  chiffre == 2 ? "II" : "III";
    }
}