using System;

// Definição da classe Heroi
public class Heroi
{
    // Propriedades da classe Heroi
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    // Construtor da classe Heroi
    public Heroi(string nome, int idade, string tipo)
    {
        Nome = nome;
        Idade = idade;
        Tipo = tipo;
    }

    // Método para realizar o ataque
    public string Atacar()
    {
        string ataque;

        // Definindo o tipo de ataque com base no tipo do herói
        switch (Tipo.ToLower())
        {
            case "mago":
                ataque = "magia";
                break;
            case "guerreiro":
                ataque = "espada";
                break;
            case "monge":
                ataque = "artes marciais";
                break;
            case "ninja":
                ataque = "shuriken";
                break;
            default:
                ataque = "ataque desconhecido";
                break;
        }

        // Retornando a mensagem de ataque
        return $"O {Tipo} atacou usando {ataque}.";
    }
}