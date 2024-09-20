using System;

class Quadrado : Forma
{
  public double Lado {get; set;}

  public Quadrado(double lado)
  {
    Lado = lado;
    Nome = "Quadrado";
    
  }
  public override double Area()
  {
    return Lado * Lado;  
  }
}