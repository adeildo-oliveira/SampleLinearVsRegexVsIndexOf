# Objetivo

Benchmark `Regex` VS `IndexOf`.

[BenchmarkDotNet](https://www.nuget.org/packages/BenchmarkDotNet/)

## Resultados

|                Method |             mensagem |        Mean |    Error |   StdDev |  Gen 0 | Allocated |
|---------------------- |--------------------- |------------:|---------:|---------:|-------:|----------:|
|           **UsandoRegex** |  **01. (...)hem. [385]** |   **240.41 ns** | **1.141 ns** | **1.012 ns** | **0.1223** |     **384 B** |
| UsandoSplitComIndexOf |  01. (...)hem. [385] | 1,497.61 ns | 9.965 ns | 9.321 ns | 0.7896 |   2,480 B |
| UsandoArrayComIndexOf |  01. (...)hem. [385] |   124.09 ns | 0.688 ns | 0.610 ns |      - |         - |
|     UsandoBuscaLinear |  01. (...)hem. [385] |   788.99 ns | 6.099 ns | 5.705 ns |      - |         - |
|           **UsandoRegex** |  **02. (...)g... [104]** |   **241.31 ns** | **1.482 ns** | **1.314 ns** | **0.1221** |     **384 B** |
| UsandoSplitComIndexOf |  02. (...)g... [104] |   370.63 ns | 2.605 ns | 2.437 ns | 0.1936 |     608 B |
| UsandoArrayComIndexOf |  02. (...)g... [104] |    51.91 ns | 0.209 ns | 0.185 ns |      - |         - |
|     UsandoBuscaLinear |  02. (...)g... [104] |   311.44 ns | 2.231 ns | 2.087 ns |      - |         - |
|           **UsandoRegex** | **03. I(...)nt... [87]** |   **208.12 ns** | **1.140 ns** | **0.952 ns** | **0.1223** |     **384 B** |
| UsandoSplitComIndexOf | 03. I(...)nt... [87] |   335.37 ns | 2.311 ns | 2.049 ns | 0.1731 |     544 B |
| UsandoArrayComIndexOf | 03. I(...)nt... [87] |    50.72 ns | 0.371 ns | 0.310 ns |      - |         - |
|     UsandoBuscaLinear | 03. I(...)nt... [87] |   178.26 ns | 0.970 ns | 0.907 ns |      - |         - |

