using System;

class CorretorOrtografico
{
    static void Main()
    {
        string[] dicionario = { "casa", "carro", "comida", "caneca", "celular" };

        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine();

        if (!Array.Exists(dicionario, x => x == palavra))
        {
            Console.WriteLine("Distância máxima de edição:");
            int distanciaMaxima = int.Parse(Console.ReadLine());

            string corrigida = CorrigirPalavra(palavra, dicionario, distanciaMaxima);

            if (corrigida != null)
            {
                Console.WriteLine("Você quis dizer \"{0}\"?", corrigida);
            }
            else
            {
                Console.WriteLine("Palavra não encontrada no dicionário.");
            }
        }
        else
        {
            Console.WriteLine("Palavra correta.");
        }

        Console.ReadLine();
    }

    static string CorrigirPalavra(string palavra, string[] dicionario, int distanciaMaxima)
    {
        int distanciaMinima = int.MaxValue;
        string melhorCorrecao = null;

        foreach (string palavraCorreta in dicionario)
        {
            int distancia = DistanciaLevenshtein(palavra, palavraCorreta);

            if (distancia <= distanciaMaxima && distancia < distanciaMinima)
            {
                distanciaMinima = distancia;
                melhorCorrecao = palavraCorreta;
            }
        }

        if (distanciaMinima <= distanciaMaxima && melhorCorrecao != null)
        {
            return melhorCorrecao;
        }
        else
        {
            return null;
        }
    }

    static int DistanciaLevenshtein(string s, string t)
    {
        int[,] d = new int[s.Length + 1, t.Length + 1];

        for (int i = 0; i <= s.Length; i++)
        {
            d[i, 0] = i;
        }

        for (int j = 0; j <= t.Length; j++)
        {
            d[0, j] = j;
        }

        for (int j = 1; j <= t.Length; j++)
        {
            for (int i = 1; i <= s.Length; i++)
            {
                int custo = (s[i - 1] == t[j - 1]) ? 0 : 1;

                d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + custo);
            }
        }

        return d[s.Length, t.Length];
    }
}


/*The Levenshtein algorithm, also known as the Levenshtein distance or edit distance algorithm, is a method for calculating the minimum number
of single-character edits (insertions, deletions, or substitutions) required to transform one string into another.

The algorithm takes two strings as input and builds a matrix where each cell represents the minimum number of edits required to convert the substring
up to that point in the first string to the substring up to that point in the second string. It then fills in the matrix by comparing each pair of 
characters in the two strings and choosing the minimum of the three possible edit operations (insertion, deletion, or substitution) to apply to the current cell.

The final value in the bottom right corner of the matrix represents the minimum number of edits required to transform the entire first string into the entire
second string. This value is also known as the Levenshtein distance between the two strings.

To use it in your code, insert the strings you want to complete in the array 'marcar'. Example, if you want to autocomplete 'house' when you type 'hou' ou 'ohuse', 
save 'house' in 'marcas'. You can add as much strings as you want to autocomplete.
*/
        
        
