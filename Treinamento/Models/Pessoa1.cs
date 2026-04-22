public class Pessoa1()
{ 
    public string Sexo { get; set; } 
    

    public void Apresentar()
    {
        Console.WriteLine($" Meu sexo {Sexo}");
    }
}