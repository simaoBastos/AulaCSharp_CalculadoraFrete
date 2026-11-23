namespace CalculadoraFrete.App;
public class CalculadoraFrete
{
    public decimal Calcular(decimal pesoKg)
    {
        if (pesoKg <= 0) throw new ArgumentOutOfRangeException(nameof(pesoKg));
        return 8m + 2m * pesoKg;
    }
}