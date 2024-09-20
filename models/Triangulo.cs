using System;

class Triangulo : Forma
{
  public double Base {get; set;}
  public double Altura {get; set;}
  

  public Triangulo (double baseTriangulo, double altura)
  {
    this.Base = baseTriangulo;
    this.Altura = altura;
    this.Nome = "Triangulo";
  }

  public override double Area()
  {
  return (Base * Altura) / 2;
  }
  
}