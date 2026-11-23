using CalculadoraFrete.App;
var calculadora = new CalculadoraFrete.App.CalculadoraFrete();
Console.Write("Peso em kg: ");
decimal peso = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Frete: {calculadora.Calcular(peso):C}");