using GamerProfile.App;
namespace GamerProfile.Tests;

public class UnitTest1
{
    
    [Fact]
    public void GerarTagUsuario_DeveRetornar_NicknameConcatenadoComCodigo_fact()
    {
        // Arrange (Preparação)
        var service = new PerfilJogadorService();
        // Act (Ação)
        var resultado = service.GerarTagUsuario("Nickname", "0000");
        // Assert (Verificação)
        Assert.Equal("Nickname#0000", resultado);
    }
    
    [Fact]
    public void CalcularXPTotal_DeveRetornar_ValorCorretoAplicandoBonus()
    {
        // Arrange (Preparação)
        var service = new PerfilJogadorService();
        // Act (Ação)
        var resultado = service.CalcularXPTotal(100, 200);
        // Assert (Verificação)
        Assert.Equal(400, resultado);
    }
    
    [Theory]
    [InlineData(16)]
    [InlineData(15)]
    [InlineData(20)]
    public void isEligivelParaRanked_DeveRetornarTrue_QualNivelMaiorIgual15(int nivelJogador)
    {
        // Arrange (Preparação)
        var service = new PerfilJogadorService();
        // Act (Ação)
        var resultado = service.isElegivelParaRanked(nivelJogador);
        // Assert (Verificação)
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(10)]
    [InlineData(2)]
    [InlineData(13)]
    public void isEligivelParaRanked_DeveRetornarFalse_QualNivelMaiorIgual15(int nivelJogador)
    {
        // Arrange (Preparação)
        var service = new PerfilJogadorService();
        // Act (Ação)
        var resultado = service.isElegivelParaRanked(nivelJogador);
        // Assert (Verificação)
        Assert.False(resultado);
    }

}
