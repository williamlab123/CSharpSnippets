 public static string LevenshteinDistance(string _brand, int choose)
        {

            string[] marcas = {
                   ""
        };
        
        string palavra = _brand;


                if(marcas.Contains(palavra))
                {
                 return palavra;
                }

                if (!marcas.Contains(palavra))
                {
                    int distanciaMaxima = 4;
                    string corrigida = null;
                    int menorDistancia = int.MaxValue;

                    foreach (string marca in marcas)
                    {
                        int distancia = DistanciaLevenshtein(palavra, marca);
                        if (distancia <= distanciaMaxima && distancia < menorDistancia)
                        {
                            corrigida = marca;
                            menorDistancia = distancia;
                        }
                    }

                    if (corrigida != null)
                    {


                        Console.Write("Você quis dizer ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.Write(corrigida + " ?");
                        Console.ResetColor();
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            return corrigida;
                        }

                        else
                        {

                            return corrigida = null;
                        }



                    }
                    else
                    {

                        return corrigida = null;
                    }
                }
                else
                {

                    return "";
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
        
        
