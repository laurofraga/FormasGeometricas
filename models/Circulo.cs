using System;

class Circulo : Forma
{
  public double Raio {get; set;}

  public Circulo(double raio)
  {
    Raio = raio;
    Nome = "Circurlo";
  }

  public override double Area()
  {
    return Math.PI * Raio * Raio;
  }
}