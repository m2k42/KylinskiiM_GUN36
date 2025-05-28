
string ConcatenateStrings(string str1, string str2)
{
        return str1 + str2;
}
    Console.WriteLine("\n Task 1");
    Console.WriteLine(ConcatenateStrings("Hello, ", "world!"));


string GreetUser(string name, int age)
{
    return $"Hello, {name}!{Environment.NewLine}You are {age} years old.";
}

    Console.WriteLine("\n Task 2 ");
    Console.WriteLine(GreetUser("Alice", 25));


string GetStringInfo(string input)
{
    int length = input.Length;
    string upper = input.ToUpper();
    string lower = input.ToLower();

    return $"Length: {length}{Environment.NewLine}Upper: {upper}{Environment.NewLine}Lower: {lower}";
}
    Console.WriteLine("\n Task 3");
    Console.WriteLine(GetStringInfo("Hello World"));



string GetFirstFiveChars(string input)
{
    if (input.Length < 5)
        return input;

    return input.Substring(0, 5);
}
    Console.WriteLine("\n Task 4");
    Console.WriteLine(GetFirstFiveChars("Hello World")); 


System.Text.StringBuilder ConcatenateStringArray(string[] words)
{
    var sb = new System.Text.StringBuilder();
    foreach (string word in words)
    {
        sb.Append(word).Append(' '); 
    }
    return sb;
}
    Console.WriteLine("\n Task 5");
    string[] words = { "This", "is", "a", "test" };
    var sb = ConcatenateStringArray(words);
    Console.WriteLine(sb.ToString());


string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
{
    return inputString.Replace(wordToReplace, replacementWord);
}
    Console.WriteLine("\n Task 6");
    Console.WriteLine(ReplaceWords("Hello world", "world", "universe")); 
