//Introduction
Console.WriteLine("Hello and welcome to the English to Pig Latin translator!");

bool runProgram = true;

while (runProgram)
{
    Console.WriteLine("Please enter the word that you would like to translate");
    string userInput = Console.ReadLine().ToLower().Trim();
    string[] sentence = userInput.Split(" ");
    string result = "";
    foreach (string word in sentence)
    {
        char firstChar = word[0];

        if (firstChar == 'a' || firstChar == 'e' || firstChar == 'i' || firstChar == 'o' || firstChar == 'u')
        {
            string x = VowelChecker(word);
            result += x + " ";
            //Console.WriteLine(userInput);
        }
        else
        {
            string x = MoveFirstLetter(word);
            result += x + " ";
        }
    }
    Console.WriteLine(result);
    while (true)
    {
        Console.WriteLine("Would you like to run the program again? y/n");
        string runagain = Console.ReadLine().ToLower().Trim();
        if (runagain == "y")
        {
            break;
        }
        else if (runagain == "n")
        {
            Console.WriteLine("Thanks for using the pig latin translator!");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Please make a valid selection!");
        }
    }
}

//Methods
static string VowelChecker(string word)
{
    char[] wordBank = new char[] { 'a', 'e', 'i', 'o', 'u' };
    string modified = "";
    foreach (char letter in wordBank)
    {
        if (word.StartsWith(letter) == true)
        {
            word += "way";
        }
    } return word;
}

static string MoveFirstLetter(string word)
{
    string modified = "";
    bool cons = true;
    int i = 1;
    while (cons && i < word.Length)
    {
        if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
        {
            modified = word.Substring(i, word.Length - i) + word.Substring(0, i) + "ay";
            cons = false;
        }
        else
        {
            i++;
        }
    }
    return modified;
}