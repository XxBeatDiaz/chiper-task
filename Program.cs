namespace Example
{
    class AtbashCipher 
    {
        static void Main()
        {
            string message = GetMessage();
            string[] words = GetDengerWord();
            string decryptedText = DecryptText(message);
            string cleanText = CleanString(decryptedText);
            string[] messageToArr = ConvertToArray(cleanText);
            string[] cleanArr = CleanArray(messageToArr);
            int totalCount = SearchResults(cleanArr);
            System.Console.WriteLine(PrintWarninglavel(totalCount));
              
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
        static char ChangeAtbash(char letter)
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

            char decryptChar = letter;
            foreach (var encryptedLetter in atbashDicti.Keys)
            {
                if (encryptedLetter == letter)
                {
                    decryptChar = atbashDicti[letter];
                }
            }
            return decryptChar;
        }

        //message.
        static string GetMessage()
        {
            string message = """
            Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.
            Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.
            Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.
            Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.
            Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.
            Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.
            Erxglib rh mvzi. Hgzb ivzwb. 
            """;
            return message;
        }

        //return denger words.
        static string[] GetDengerWord()
        {
            string[] dengerWord = ["bomb", "nukhba", "fighter", "rocket", "secret"];
            return dengerWord;
        }

        //Text analysis and data retrieval.


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

        //Prints the dangerous word and the number of times it appears in the textץ
        static int SearchResults(string[] text)
        {
            int totalCount = 0;
            
            foreach (var item in GetDengerWord())
            {
                int currentCount = CountWordExists(text, item);
                totalCount += currentCount;
                System.Console.WriteLine($"Word: {item} - appears {currentCount} times in the text.");   
            }
            return totalCount;
        }

        //return the final result.


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
                else if (letter == '.')
                {
                    cleanString += '\n';
                }
            }
            return cleanString;
        }

        //print the warning and sum the dangerous words.
        static string PrintWarninglavel(int totalPoints)
        {
            string lavel = "";
            if (totalPoints >= 1 && totalPoints <= 5)
            {
                lavel = $"The points: {totalPoints} \nlavel: - WARNING!";
                return lavel;
            } 
            else if (totalPoints >= 6 && totalPoints <= 10)
            {
                lavel = $"The points: {totalPoints} \nlavel: - DANGER!";
                return lavel;
            }
            else if (totalPoints >= 11)
            {
                lavel = $"The points: {totalPoints} \nlavel: - ULTRA ALERT!";
                return lavel;
            }
            return "Routine!";
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



