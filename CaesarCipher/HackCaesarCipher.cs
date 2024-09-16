using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher;

public class HackCaesarCipher
{
    public static TypeAlphabet TypeAlphabet { get; set; } = TypeAlphabet.Rus;

    public static string Alphabet { get; set; } = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    static Dictionary<char, int>? characterFrequence;

    public static char Analyse(string encrypted)
    {
        characterFrequence = new Dictionary<char, int>();

        for (int i=0, l=Alphabet.Length; i < l; i++)
        {
            characterFrequence[Alphabet[i]] = 0;
        }

        for (int i=0; i < encrypted.Length; i++)
        {
            try
            {
                characterFrequence[char.ToLower(encrypted[i])]++;
            }
            catch { }
        }

        int maxValue = -1;
        char keyOfMaxValue = '\0';

        foreach(KeyValuePair<char, int> entry in characterFrequence) 
        { 
            if (entry.Value > maxValue)
            {
                maxValue = entry.Value;
                keyOfMaxValue = entry.Key;
            }
        }

        return keyOfMaxValue;
    }

    public static int Hack(string encrypted)
    {
        // возвращает часто встречающийся символ
        char symbol = Analyse(encrypted);

        int key = 0;
        // для русского - буква о
        if (TypeAlphabet == TypeAlphabet.Rus) 
        {
            key = symbol - 'о';
        }
        // для английского - буква e
        else
        {
            key = symbol - 'e';
        }

        return key;
    }
}
