namespace rle;
public class Util
{
    /// <summary>
    /// This function is based on the Run-length encoding.
    /// Elements that have the same data and are consecutive will be stored
    /// as a single data value and count.
    /// </summary>
    /// <param name="input">Uncompressed string</param>
    /// <returns>Compressed results</returns>
    public static string Compress(string input) {
        
        List<string> result = new List<string>();
        
        int counter = 1;
        char currentChar = new char();
        char previousChar = new char();

        for (int i = 0; i < input.Length; i++) {

            currentChar = input[i];
            if (i > 0) { previousChar = input[i - 1]; }

            // Do we have contiguous chars?
            if (currentChar == previousChar)
            {
                // Most folks would wrap the first "if" on one line,
                // when I'm presenting or sharing with other folks I make it over verbose
                // to make it easier to follow and/or debug.
                counter++;  
            }
            else if(i > 0) {
                // Chars are not the same, skip the first iteration,
                // let's add the previous char to the stack and reset the counter
                result.Add($"{counter}");
                result.Add($"{previousChar}");
                counter = 1;
            }

            // Loop will end, let's add the last one.
            if (i == input.Length-1)
            {
                result.Add($"{counter}");
                result.Add($"{currentChar}");
                counter = 1;
            }
            
        }

        return String.Join("", result);
    }

}
