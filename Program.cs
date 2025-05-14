






























































// Gets text and decrypt it by atbash.
static string DecryptText(string text)
{
    string newText = "";
    foreach (char c in text)
    {
        char decrypt = ChangeAtbash(char.ToUpper(c));
        char newChar = char.ToLower(decrypt);
        newText += newChar;
    }
    return newText;
}

// Gets encrypt char and return it decrypt by atbash.
static char ChangeAtbash(char c)
{
    Dictionary<char, char> atbashDicti = new Dictionary<char, char>
    {
        { 'A', 'Z' }, { 'B', 'Y' }, { 'C', 'X' },
        { 'D', 'W' }, { 'E', 'V' }, { 'F', 'U' },
        { 'G', 'T' }, { 'H', 'S' }, { 'I', 'R' },
        { 'J', 'Q' }, { 'K', 'P' }, { 'L', 'O' },
        { 'M', 'N' }, { 'N', 'M' }, { 'O', 'L' },
        { 'P', 'K' }, { 'Q', 'J' }, { 'R', 'I' },
        { 'S', 'H' }, { 'T', 'G' }, { 'U', 'F' },
        { 'V', 'E' }, { 'W', 'D' }, { 'X', 'C' },
        { 'Y', 'B' }, { 'Z', 'A' }
    };

    char decryptChar = 'c';
    foreach (var encryptedLetter in atbashDicti.Keys)
    {
        if (encryptedLetter == c)
        {
            decryptChar = atbashDicti[c];
        }
    }
    return decryptChar;
}


