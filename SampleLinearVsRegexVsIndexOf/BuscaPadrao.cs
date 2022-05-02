using System.Text.RegularExpressions;

namespace SampleLinearVsRegexVsIndexOf;

public class BuscaPadraoRegex
{
    const string sPattern = "__";

    public static bool BuscarPadrao(string mensagem) =>
        Regex.Matches(mensagem, sPattern, RegexOptions.Compiled, TimeSpan.FromSeconds(1)).Any(x => x.Success);
}

public class BuscaPadraoSplitIndexOf
{
    static char sPattern = '_';
    static char sPatternSplit = ' ';

    public static bool BuscarPadrao(string mensagem)
    {
        var ehPadrao = false;

        var palavras = mensagem.Split(sPatternSplit);

        for (int i = 0; i < palavras.Length; i++)
        {
            var indexIncialA = palavras[i].IndexOf(sPattern);
            var indexIncialB = palavras[i].LastIndexOf(sPattern);

            if (indexIncialA >= 0 && indexIncialB > 0)
            {
                ehPadrao = true;
            }
        }

        return ehPadrao;
    }
}

public class BuscaPadraoIndexOf
{
    static char sPattern = '_';

    public static bool BuscarPadrao(string mensagem)
    {
        var ehPadrao = false;

        for (int index = 0; index < mensagem.Length; index++)
        {
            var indexIncialA = mensagem.IndexOf(sPattern, index);
            var indexIncialB = mensagem.LastIndexOf(sPattern, indexIncialA + 1);

            if (indexIncialA > 0 && indexIncialB > 0)
            {
                ehPadrao = true;
                index = indexIncialB;
            }
            else
                break;
        }

        return ehPadrao;
    }
}

public class BuscaPadraoLinear
{
    static char sPattern = '_';

    public static bool BuscarPadrao(string mensagem)
    {
        var ehPadrao = false;
        var texto = mensagem.AsSpan();

        for (int index = 0; index < texto.Length; index++)
        {
            if (texto[index] == sPattern && texto[index + 1] == sPattern)
            {
                ehPadrao = true;
                index++;
            }
        }

        return ehPadrao;
    }
}