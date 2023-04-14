 static void Main()
    {
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            Environment.SetEnvironmentVariable("PROMPT", "$P$G");
        }
        else
        {
            Environment.SetEnvironmentVariable("PS1", "\\u@\\h:\\w\\$ ");
        }

        while (true)
        {
            Console.Write(Environment.GetEnvironmentVariable("PROMPT") ?? Environment.GetEnvironmentVariable("PS1"));
            string input = Console.ReadLine();
            Console.WriteLine($"You entered: {input}");
        }
    }
    
    //This code allows you to have your personalized prompt, like a linux or windows terminal, wich is basically: johndoe@john-pc:~$
    //Using this code you can create your own personalized prompt in your program. To use, put all your code inside the while and set your personalized prompy in 
    //'Environment.SetEnvironmentVariable("PROMPT", "$P$G");', change "$P$G" to whatever you want.
