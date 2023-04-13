         while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.L && key.Modifiers == ConsoleModifiers.Control)
                    {
                        Console.Clear();
                        Main();
                    }
                    
              }
              
              
              //This code allows you to clear your console by typing CTRL + L in your program.
              //To use, paste all your program code inside the while.
