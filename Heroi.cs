using System;

class Heroi {
    // Propriedades 
    public string Nome  {get; set;}
    public int  Idade {get; set;}
    public string Tipo {get; set;}


// Constructor 
    public Heroi(string nome, int idade,string tipo)
{
    Nome =  nome;
    Idade = idade;
    Tipo = tipo;
}

// Método Atacar 
public void Atacar ()
{
    string ataque = "";

    switch (Tipo.ToLower())
    {
        case "mago":
        ataque = "magia";
        break;

        case "guerreiro" :
        ataque = "espada";
        break;

        case "monge":
        ataque = "artes marciais";
        break;

        case "ninja" :
        ataque = "shuriken";
        break;

        default:
        ataque = "um ataque desconhecido";
        break;
    }
    Console.WriteLine($"O {Tipo} atacou usando {ataque}");
   }
}