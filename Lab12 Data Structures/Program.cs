
Console.Write("Please enter a word: ");
string userWord = Console.ReadLine();


static string ReverseString(string input)
{
   
    char[] letters = input.ToCharArray();

    Stack<char> lettersStack = new Stack<char>();

    foreach (char c in letters)
    {
        lettersStack.Push(c);
    }

    foreach (char c in lettersStack)
    {
        Console.Write(c);
    }

    string output = " ";
    return output;

}

ReverseString(userWord);