using Xunit;
using CalculadoraFrete.App;
namespace CalculadoraFrete.Tests;
public class CalculadoraFreteTests
{
[Theory]
[InlineData(1, 10)]
[InlineData(2, 12)]
[InlineData(5, 18)]
public void Frete_PesoValido(int peso, int esperado)
{
var servico = new CalculadoraFrete.App.CalculadoraFrete();
Assert.Equal(esperado, servico.Calcular(peso));
}
[Theory]
[InlineData(0)]
[InlineData(-1)]
public void Frete_PesoInvalido(int peso)
{
var servico = new CalculadoraFrete.App.CalculadoraFrete();
Assert.Throws<ArgumentOutOfRangeException>(() => servico.Calcular(peso));
}
}