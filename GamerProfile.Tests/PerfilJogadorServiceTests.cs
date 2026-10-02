using GamerProfile.App;
using Xunit;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    private readonly PerfilJogadorService _service = new();

    [Fact]
    public void GerarTagUsuario_DeveConcatenarNicknameECodigo()
    {
        var resultado = _service.GerarTagUsuario("Nickname", "0000");
        Assert.Equal("Nickname#0000", resultado);
    }

    [Fact]
    public void CalcularXPTotal_DeveSomarXpEAplicarBonus()
    {
        var resultado = _service.CalcularXPTotal(200, 300);
        Assert.Equal(600, resultado);
    }

    [Fact]
    public void EEligivelParaRanked_DeveRetornarTrueQuandoNivelMaiorOuIgualA15()
    {
        var resultado = _service.EEligivelParaRanked(15);
        Assert.True(resultado);
    }

    [Fact]
    public void EEligivelParaRanked_DeveRetornarFalseQuandoNivelMenorQue15()
    {
        var resultado = _service.EEligivelParaRanked(10);
        Assert.False(resultado);
    }
}
