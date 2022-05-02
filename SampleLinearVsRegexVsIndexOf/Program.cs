using SampleLinearVsRegexVsIndexOf;
using System.Diagnostics;

int gc0 = GC.CollectionCount(0);
int gc1 = GC.CollectionCount(1);
int gc2 = GC.CollectionCount(2);

var mensagem = "In computer science, the Boyer–Moore string-search algorithm is an __efficient__ string-searching algorithm that is the standard benchmark for practical string-search literature.[1] It was __developed__ by Robert S. Boyer and J Strother Moore in 1977.[2] The original paper contained static tables for __computing__ the pattern shifts without an explanation of how to produce them.";

var sw = new Stopwatch();
sw.Start();

var resultado = BuscaPadraoRegex.BuscarPadrao(mensagem);
Console.WriteLine($"Resultado Busca Regex: {resultado}");

//var resultado = BuscaPadraoSplitIndexOf.BuscarPadrao(mensagem);
//Console.WriteLine($"Resultado Busca Split IndexOf: {resultado}");

//var resultado = BuscaPadraoIndexOf.BuscarPadrao(mensagem);
//Console.WriteLine($"Resultado Busca IndexOf: {resultado}");

//var resultado = BuscaPadraoLinear.BuscarPadrao(mensagem);
//Console.WriteLine($"Resultado Busca Linear: {resultado}");

sw.Stop();
Console.WriteLine($"\nTempo: {sw.Elapsed}s");
Console.WriteLine($"  Gen0: {GC.CollectionCount(0) - gc0}");
Console.WriteLine($"  Gen1: {GC.CollectionCount(1) - gc1}");
Console.WriteLine($"  Gen2: {GC.CollectionCount(2) - gc2}");
Console.WriteLine($"Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024}mb");