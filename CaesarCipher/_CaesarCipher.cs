using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace CaesarCipher;

public enum TypeAlphabet
{
    Rus,
    Eng
}

public class _CaesarCipher
{
    public static string Alphabet { get; set; } = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    public static string Encrypt(string sourceText, BigInteger key)
    {
        string encryptedText = "";

        for (int i = 0, alphabetLength = Alphabet.Length; i < sourceText.Length; i++)
        {
            bool upper = char.IsUpper(sourceText[i]);
            char currentSymbol = char.ToLower(sourceText[i]);

            int index = Alphabet.IndexOf(currentSymbol);

            if (index == -1)
            {
                encryptedText += sourceText[i];
            }
            else
            {
                int newIndex = mod(index + key, alphabetLength);

                encryptedText += upper ? char.ToUpper(Alphabet[newIndex])  : Alphabet[newIndex];
            }
        }

        return encryptedText;
    }

    public static string Decrypt(string encryptedText, BigInteger key)
    {
        string decryptedText = "";
        key = -key;

        for (int i = 0, alphabetLength = Alphabet.Length; i < encryptedText.Length; i++)
        {
            bool upper = char.IsUpper(encryptedText[i]);
            char currentSymbol = char.ToLower(encryptedText[i]);

            int index = Alphabet.IndexOf(currentSymbol);

            if (index == -1)
            {
                decryptedText += encryptedText[i];
            }
            else
            {
                int newIndex = mod(index + key, alphabetLength);
                decryptedText += upper ? char.ToUpper(Alphabet[newIndex]) : Alphabet[newIndex];
            }
        }

        return decryptedText;
    }

    static int mod(BigInteger a, int b)
    {
        int c = (int)( a % b );

        if (c < 0)
            c += b;

        return c;
    }
}

