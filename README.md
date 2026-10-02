# 🎮 GamerProfile

![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![xUnit](https://img.shields.io/badge/Testes-xUnit-5C2D91?style=for-the-badge)
![License](https://img.shields.io/badge/Licença-MIT-green?style=for-the-badge)

Uma solução .NET para gerenciar o cadastro de jogadores, com cobertura completa de testes unitários usando **xUnit**. 🕹️

> [!NOTE]
> Este projeto foi desenvolvido como atividade prática da disciplina de **Garantia da Qualidade de Software**, com foco em testes unitários no ecossistema .NET.

---

## 📖 Sobre o projeto

O `PerfilJogadorService` implementa três regras de negócio simples, cada uma cobrindo um tipo de retorno diferente — **string**, **int** e **bool** — para praticar os três principais tipos de asserção do xUnit.

| Método | Retorno | O que faz |
|---|:---:|---|
| `GerarTagUsuario(nickname, codigo)` | `string` | Concatena o nickname e o código com `#` (ex: `"Aragorn#1042"`) |
| `CalcularXPTotal(xpFase1, xpFase2)` | `int` | Soma o XP de duas fases e aplica um bônus fixo de **100 pontos** |
| `EEligivelParaRanked(nivelJogador)` | `bool` | Retorna `true` se o nível for **≥ 15**, senão `false` |

---

## 🧪 Testes unitários

A suíte de testes, no projeto `GamerProfile.Tests`, cobre os três métodos usando o atributo `[Fact]` do xUnit:

| Teste | Tipo de asserção | O que valida |
|---|---|---|
| `GerarTagUsuario_DeveConcatenarNicknameECodigo` | `Assert.Equal` | Formatação correta da tag (`"Nickname#0000"`) |
| `CalcularXPTotal_DeveSomarXpEAplicarBonus` | `Assert.Equal` | Soma de XP + bônus fixo (`200 + 300 + 100 = 600`) |
| `EEligivelParaRanked_DeveRetornarTrueQuandoNivelMaiorOuIgualA15` | `Assert.True` | Elegibilidade para nível ≥ 15 |
| `EEligivelParaRanked_DeveRetornarFalseQuandoNivelMenorQue15` | `Assert.False` | Bloqueio para nível < 15 |

> [!IMPORTANT]
> O método `bool` foi coberto por **dois** testes separados (`True` e `False`) para validar explicitamente os dois caminhos possíveis da regra de negócio.

---

## 🚀 Como executar

### Pré-requisitos

![.NET SDK](https://img.shields.io/badge/Requer-.NET%2010%20SDK-blue?style=flat-square)

Você precisa ter o [.NET 10 SDK](https://dotnet.microsoft.com/download) instalado. Para conferir sua versão:

```bash
dotnet --version
```

### Instalação

```bash
git clone https://github.com/JoTaP-MX/gamer-profile-xunit.git
cd gamer-profile-xunit
```

### Rodando os testes

```bash
dotnet test
```

### Exemplo de saída

Resumo do teste: total: 4; falhou: 0; bem-sucedido: 4; ignorado: 0
Construir êxito em 3,6s


---

## 🛠️ Tecnologias utilizadas

- 🟣 **.NET 10**
- 🧪 **xUnit** — framework de testes unitários
- 📦 Estrutura de solução com dois projetos: `GamerProfile.App` (produção) e `GamerProfile.Tests` (testes)

---

## 👤 Sobre o Autor

Feito com 💻 por **João Pedro Gonçalves**

---

## 📄 Licença

Este projeto está sob a licença **MIT**. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
