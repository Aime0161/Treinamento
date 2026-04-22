public class CCorrente
{
  public CCorrente(int numeroConta, decimal saldoInical)
{ 
   NumeroConta = numeroConta;
   saldoConta=  saldoInical;
    
  
}

public int NumeroConta  { get; set; }
private decimal  saldoConta  { get; set; }

public void Sacar(decimal valor)
{
        
        if(saldoConta >= valor)
        {
            saldoConta -= valor;

            Console.WriteLine("saque realizado com sucesso");
        
        }
        else
        {
            Console.WriteLine("sem limite");
        }    
}


public void ExibirSaldo()
{
        
      

            Console.WriteLine("Saldo disponivel" + saldoConta);
        
      
           
      
}
}
