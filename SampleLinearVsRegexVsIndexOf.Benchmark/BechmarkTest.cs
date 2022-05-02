using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace SampleLinearVsRegexVsIndexOf.Benchmark;

[MemoryDiagnoser]
[EventPipeProfiler(EventPipeProfile.CpuSampling)]
public class BechmarkTest
{
    [ParamsSource(nameof(Mensagens))]
    public string mensagem;

    public static IEnumerable<string> Mensagens() => new string[]
        {
            "01. In computer science, the Boyer–Moore string-search algorithm is an __efficient__ string-searching algorithm that is the standard benchmark for practical string-search literature.[1] It was __developed__ by Robert S. Boyer and J Strother Moore in 1977.[2] The original paper contained static tables for __computing__ the pattern shifts without an explanation of how to produce them.",
            "02. In computer science, the Boyer–Moore string-search algorithm is an __efficient__ string-searching...",
            "03. In __computer__ science, the Boyer–Moore string-search algorithm is an efficient..."
        };

    [Benchmark]
    public void UsandoRegex() => _ = BuscaPadraoRegex.BuscarPadrao(mensagem);

    [Benchmark]
    public void UsandoSplitComIndexOf() => _ = BuscaPadraoSplitIndexOf.BuscarPadrao(mensagem);

    [Benchmark]
    public void UsandoArrayComIndexOf() => _ = BuscaPadraoIndexOf.BuscarPadrao(mensagem);

    [Benchmark]
    public void UsandoBuscaLinear() => _ = BuscaPadraoLinear.BuscarPadrao(mensagem);
}
