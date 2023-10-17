
string NoVowels = RemoveVowels("Hello there, amigo, you are cool");
Console.WriteLine(NoVowels);

static string RemoveVowels(string input) {

    string noVow = string.Empty;

    for (int i = 0; i < input.Length; i++) {
        if (input[i] == 'a' || input[i] == 'e' || input[i] == 'í' || input[i] == 'o' || input[i] == 'u' || input[i]  == 'y')
        {
            continue;
        }
        else {
            noVow += input[i];
        }
    }

    return noVow;
}
