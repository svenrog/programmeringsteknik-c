using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string lettersString = "abcdefghijklmnopqrstuvwxyz";
        string lettersStringUpperCase = lettersString.ToUpper();

        var characterArray = lettersString.ToCharArray();
        var characterArrayUpperCase = lettersStringUpperCase.ToCharArray();

        string returnText = "";
        foreach (char textCharacter in text)
        {
            if (Array.Exists(characterArray, character => character == textCharacter))
            {
                int characterArrayIndex = Array.IndexOf(characterArray, textCharacter);
                int shiftCharacterArrayIndex = (characterArrayIndex + shiftKey) % lettersString.Length;
                returnText += characterArray[shiftCharacterArrayIndex];
            }
            else if (Array.Exists(characterArrayUpperCase, character => character == textCharacter))
            {
                int characterArrayIndex = Array.IndexOf(characterArrayUpperCase, textCharacter);
                int shiftCharacterArrayIndex = (characterArrayIndex + shiftKey) % lettersString.Length;
                returnText += characterArrayUpperCase[shiftCharacterArrayIndex];
            }
            else returnText += textCharacter;
        }
        return returnText;
    }
}