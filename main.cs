using System;

class Program {
  public static void Main ()
  {
    Forma quadrado = new Quadrado(5);
    Forma circulo = new Circulo(3);
    Forma triangulo = new Triangulo(4,5);

    Console.WriteLine($"{quadrado.Nome} - Área: {quadrado.Area()}");
    Console.WriteLine($"{circulo.Nome} - Área: {circulo.Area()}");
    Console.WriteLine($"{triangulo.Nome} - Área: {triangulo.Area()}");
  }
}