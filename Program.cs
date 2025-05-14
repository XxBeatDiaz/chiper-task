namespace Example
{
    class AtbashCipher 
    {
        static void Main()
        {
            System.Console.WriteLine(CleanString("hhgsd fg$$$5  ^jgd eh$hghd."));
        }
        static Dictionary<char, char> lookupTable = new Dictionary<char, char>
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


        //convert string to array-string(word)
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
 
    }
}


