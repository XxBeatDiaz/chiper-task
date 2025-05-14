namespace Example
{
    class AtbashCipher 
    {
        static void Main()
        {
            
        }

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




        //Convert string to array-string(word)
        static string[] ConvertToArray(string str)
        {
            string[] arrStr = str.Split(' ');
            return arrStr;
        }

        //Accepts a word and a string and returns how many times it appears.
        static int CountWordExists(string[] wordArray, string word)
        {
            int countWord = 0;
            foreach (var item in wordArray)
            {
                if (item == word)
                {
                    countWord++;
                }
            }
            return countWord;
        }

        //Cleaning a string of unnecessary characters
        static string CleanString(string str)
        {
            string cleanString = "";
            foreach (char letter in str)
            {
                if (char.IsLetter(letter) || letter == ' ')
                {
                    cleanString += letter;
                }
            }
            return cleanString;
        }

        //Clearing an array of empty cells
        static string[] CleanArray(string[] wordArray)
        {
            List<string> ListWord = new List<string>();
            ListWord = wordArray.ToList();
            ListWord.RemoveAll(r => r == "");
            string[] cleanArr = ListWord.ToArray();
            return cleanArr;
        }
    }
}



