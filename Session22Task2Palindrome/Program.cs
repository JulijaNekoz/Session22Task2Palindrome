using System.Text.RegularExpressions;

Console.WriteLine("Enter a string to see if it's a palindrome");
string userInput = Console.ReadLine().ToLower();

string userInputFormated = string.Empty;
Regex re = new Regex("[a-zA-Z]");
for (int i = 0; i < userInput.Length; i++)
{
    if (re.IsMatch(userInput[i].ToString()))
    {
        userInputFormated += userInput[i];
    }
}

Stack<char> myStack = new Stack<char>();
foreach(char letter in userInputFormated)
{
    myStack.Push(letter);
}

string reversedString = string.Empty;
while (myStack.Count > 0)
{
    reversedString += myStack.Pop();
}

if (userInputFormated == reversedString)
{
    Console.WriteLine("It is a palindrome");
}
else
{
    Console.WriteLine("It is not a palindrome");
}