using System;

Main();

void Main()
{
    // Display welcome message
    Console.WriteLine("Welcome tothe Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    // Function to display moose art
    void MooseSays(string message)
    {
        string mooseArt = @"
                                    _.--^^^--,
                                    .'          `\
.-^^^^^^-.                      .'              |
/          '.                   /            .-._/
|             `.                |             |
\              \          .-._ |          _   \
`^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
    /             (         \     /  \  /
    /`               `\        |   /    `'
    '..-`\        _.-. `\ _.__/   .=.
        |  _    / \  '.-`    `-.'  /
        \_/ |  |   './ _     _  \.'
            '-'    | /       \ |
                    |  .-. .-.  |
                    \ / o| |o \ /
                    |   / \   |    " + message + @"
                    / `^`   `^` \
                    /             \
                    | '._.'         \
                    |  /             |
                    \ |             |
                    ||    _    _   /
                    /|\  (_\  /_) /
                    \ \'._  ` '_.'
                    `^^` `^^^`
";
        Console.WriteLine(mooseArt);
    }


    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic!");

    // Function that gets Y or N answer from the user 
    bool MooseAsks(string question)
    {
       Console.Write($"{question} (Y/N): ");
        string answer = Console.ReadLine().ToLower();
        // Keep asking until a valie answer is given (Y or N)
        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }

        // Return true for "yes" and false for "no"
        return answer == "y";

    }

    void CanadaQuestion()
    {
        bool isTrue = MooseAsks("Is Canada real?");
        if (isTrue)
        {
            MooseSays("Really? It seem very unlikely.");
        }
        else
        {
            MooseSays("I  K N E W  I T  ! ! !");
        }

    }

    void EnthusiasticQuestion()
    {
        bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
        if (isEnthusiastic)
        {
            MooseSays("Yay!");
        }
        else
        {
            MooseSays("You should try it!");
        }
    }
    void SecretQuestion()
    {
        bool wantsSecret = MooseAsks("Do you want to know a secret?");
        if (wantsSecret)
        {
            MooseSays("ME TOO!!!! I love secrets...tell me one!");
        }
        else
        {
            MooseSays("Oh, no...secrets are the best, I love to share them!");
        }
    }

    CanadaQuestion();
    EnthusiasticQuestion();
    SecretQuestion();
}

