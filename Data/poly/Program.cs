using System;
class Id
{
    public string Nom { get; set; }
    public int Age { get; set; }
    public int Num_tel { get; set; }
    public string Adress { get; set; }
    public Id(string nom, int age, int num_tel, string adress)
    {
        Nom = nom;
        Age = age;
        Num_tel = num_tel;
        Adress = adress;
    }
    public virtual void Info()
    {
        System.Console.WriteLine($"Nom: {Nom}, Age: {Age} ans, Num: {Num_tel}, Adress: {Adress}");
    }
}
class Personne1 : Id
{
    public Personne1(string nom, int age, int num_tel, string adress) : base(nom, age, num_tel, adress) { }
    public override void Info()
    {
        base.Info();
    }
}
class Personne2 : Id
{
    public Personne2(string nom, int age, int num_tel, string adress) : base(nom, age, num_tel, adress) { }
    public override void Info()
    {
        base.Info();
    }
}
class Personne3 : Id
{
    public Personne3(string nom, int age, int num_tel, string adress) : base(nom, age, num_tel, adress) { }
    public override void Info()
    {
        base.Info();
    }
}
class Program
{
    static void Main()
    {
        Personne1 p1 = new Personne1("Keno", 23, 37737626, "Delmas 19");
        p1.Info();
        Personne2 p2 = new Personne2("Sarah", 17, 38023221, "Tabarre 27");
        p2.Info();
        Personne3 p3 = new Personne3("Archange", 32, 313618876, "Tabarre");
        p3.Info();
        System.Console.WriteLine();
    }
}
