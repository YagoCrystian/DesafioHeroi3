class Program
{
    static void Main()
    {
        // Criando instâncias de heróis para testar a classe
        Heroi heroi1 = new Heroi("Arthur", 30, "Mago");
        Heroi heroi2 = new Heroi("Lancelot", 28, "Guerreiro");
        Heroi heroi3 = new Heroi("Shifu", 45, "Monge");
        Heroi heroi4 = new Heroi("Ryu", 27, "Ninja");

        // Testando o método Atacar
        Console.WriteLine(heroi1.Atacar()); // Saída: O Mago atacou usando magia.
        Console.WriteLine(heroi2.Atacar()); // Saída: O Guerreiro atacou usando espada.
        Console.WriteLine(heroi3.Atacar()); // Saída: O Monge atacou usando artes marciais.
        Console.WriteLine(heroi4.Atacar()); // Saída: O Ninja atacou usando shuriken.
    }
}