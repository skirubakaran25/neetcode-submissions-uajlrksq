public class Solution {
   public bool ValidWordAbbreviation(string word, string abbr)
 {
     int wordLen = word.Length;
     int abbrLen = abbr.Length;

     int wordPointer = 0, abbrPointer = 0;

     while (wordPointer < wordLen && abbrPointer < abbrLen)
     {
         if (word[wordPointer] == abbr[abbrPointer])
         {
             wordPointer++;
             abbrPointer++;
         }
         else
         {
             // not matching
             if (char.IsNumber(abbr[abbrPointer]))
             {
                 if (abbr[abbrPointer] == '0')  // if zero, then return invalid
                 {
                     return false;
                 }
                 int decNumber = 0;
                 while (abbrPointer < abbrLen && char.IsNumber(abbr[abbrPointer]))
                 {
                     decNumber = decNumber * 10 + (abbr[abbrPointer] - '0'); // to convert to digit and to handle multiple digits in the string.
                     abbrPointer++;
                 }
                 wordPointer += decNumber;
             }
             else
             {
                return false;
             }
         }
     }
     if (wordPointer == wordLen && abbrPointer == abbrLen)
     {
         return true;
     }
     return false;
 }
}