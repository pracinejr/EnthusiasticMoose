using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
    MooseQuestion("Is Canada real?", "really? It seems very unlikely.", "I KNEW IT!!!!");
    MooseQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
    MooseQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will... oh, yes, you will...");
    MooseQuestion("Do you want to know a secret?", "ME TOO!!!! I love secres... tell me one!", "Oh, no... secrets are the best, I love to share them!");

}

void MooseSays(string message)
{
    Console.WriteLine($@"
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
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    // this line is writing to the console the question that is passed to the function
    Console.Write($"{question} ");
    // this line reads the code and then changes all the text to lower case
    string answer = Console.ReadLine().ToLower();
    //this while reads the answer given (either y or n) and makes sure to re-ask the question if the answer is not either y or n
    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void MooseQuestion(string question, string yesAnswer, string noAnswer)
{
    bool isTrue = MooseAsks($"{question} (Y/N): ");
    if (isTrue)
    {
        MooseSays(yesAnswer);
    }
    else
    {
        MooseSays(noAnswer);
    }
}


