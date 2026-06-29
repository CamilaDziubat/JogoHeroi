using System;

class Program
{
    static void Main(string[] args)
    {
        Heroi heroi1 = new Heroi("Merlin", 120, "mago");
        Heroi heroi2 = new Heroi("Arthur", 35, "guerreiro");
        Heroi heroi3 = new Heroi("Lee", 28, "monge");
        Heroi heroi4 = new Heroi("Hanzo", 30, "ninja");

        heroi1.Atacar();
        heroi2.Atacar();
        heroi3.Atacar();
        heroi4.Atacar();
    }
}