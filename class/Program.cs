using System;
interface IEtre
{
    void Info();
}
class Moun : IEtre
{
    public string Nom { get; set; }
    public int Laj { get; set; }

    public Moun(string nom, int laj)
    {
        Nom = nom;
        Laj = laj;
    }

    public void Info()
    {
        throw new NotImplementedException();
    }
    // public void Info()
    // {
    //     System.Console.WriteLine($"Nom: {Nom}, laj {Laj} ans");
    // }
}
class Personne1 : Moun
{
    public int Num { get; set; }
    public Personne1(string nom, int laj, int num) : base(nom, laj)
    {
        Num = num;
    }

}