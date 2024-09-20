using System;

//criando a classe mãe das formas geometricas com nome e area 
public abstract class Forma{
  public string Nome {get; set;}
  public abstract double Area(); 
}