public class Carro : Veiculo
{
    public override void Acelerar()
    {
        Console.WriteLine("carro acelerando");
        velocidade = velocidade + 10;
    }

    public override void Frear()
    {
        Console.WriteLine("Carro freando");
        velocidade = velocidade - 5;
    }
}
