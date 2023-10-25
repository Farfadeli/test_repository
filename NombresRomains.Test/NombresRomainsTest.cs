namespace NombresRomains.Test;

public class NombresRomainsTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Test1(uint chiffre)
    {
        // ETANT DONNE le chiffre <chiffre>
        // QUAND on le convertit en nombres romains
        var nombreRomain = 
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "I", <chiffre> fois
        var attendu = new string('I', (int) chiffre);
        Assert.Equal(attendu, nombreRomain);
    }

    [Fact]
    public void Test5()
    {
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(5);
        var attente = "V";
        Assert.Equal(attente, nombreRomain);
    }
}