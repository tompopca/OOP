using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

class StringStatistics
{
    private string Text;
    private string[] words;
    private string[] sentences;
    private string[] lines;

    public StringStatistics(string text)
    {
        Text = text;
    }


    public int PocetSlov()
    {
        int pocet = 0;
        bool veSlove = false;

        for (int i = 0; i < Text.Length; i++)
        {
            if (!char.IsWhiteSpace(Text[i]))
            {
                if (!veSlove)
                {
                    pocet++;
                    veSlove = true;
                }
            }
            else
            {
                veSlove = false;
            }
        }

        return pocet;
    }

    public int PocetRadku()
    {
        if (Text.Length == 0)
            return 0;

        int r = 1;

        foreach (var c in Text)
        {
            if (c == '\n')
            {
                r++;
            }
        }

        return r;
    }

    public int PocetVet()
    {
        int r = 0;

        for (int i = 0; i < Text.Length - 1; i++)
        {
            if (Text[i] == '.' || Text[i] == '!' || Text[i] == '?')
            {

                if (i + 1 < Text.Length && char.IsUpper(Text[i + 2]))
                {
                    r++;
                }
            }
        }


        if (Text.Length > 0 && (Text[Text.Length - 1] == '.' || Text[Text.Length - 1] == '!' || Text[Text.Length - 1] == '?'))
        {
            r++;
        }

        return r;
    }

    public string NejdelsiSlovo()
    {
        string[] slova = Text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\n', '\r', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

        string nejdelsi = slova[0];
        string vysledek = nejdelsi;

        foreach (string slovo in slova)
        {
            if (slovo.Length > nejdelsi.Length)
            {
                nejdelsi = slovo;
                vysledek = slovo;
            }
            else if (slovo.Length == nejdelsi.Length && !vysledek.Contains(" " + slovo + " "))
            {
                vysledek += ", " + slovo;
            }
        }
        return vysledek;
    }
    public string NejkratsiSlova()
    {
        string[] slova = Text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\n', '\r', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

        string nejkratsi = slova[0];
        string vysledek = nejkratsi; 

        foreach (string slovo in slova)
        {
            if (slovo.Length < nejkratsi.Length)
            {
                nejkratsi = slovo; 
                vysledek = slovo; 
            }
            else if (slovo.Length == nejkratsi.Length && !vysledek.Contains(" " + slovo + " "))
            {
                vysledek += ", " + slovo; 
            }
        }

        return vysledek;
    }

    public string NejcastejsiSlovo()
    {
        string[] slova = Text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\n', '\r', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < slova.Length; i++)
        {
            slova[i] = slova[i].ToLower();
        }

        Array.Sort(slova);

        int maxPocet = 0;
        int aktualniPocet = 1;
        string aktualniSlovo = slova[0];
        string vysledek = aktualniSlovo;

       
        for (int i = 1; i < slova.Length; i++)
        {
            if (slova[i] == slova[i - 1])
            {
                aktualniPocet++;
            }
            else
            {
                if (aktualniPocet > maxPocet)
                {
                    maxPocet = aktualniPocet;
                    vysledek = aktualniSlovo;
                }
                else if (aktualniPocet == maxPocet)
                {
                    vysledek += " ," + aktualniSlovo;
                }

                aktualniSlovo = slova[i];
                aktualniPocet = 1;
            }
            
        }
        return vysledek;

    }


    public string Abeceda()
    {
        string[] slova = Text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\n', '\r', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);


        Array.Sort(slova, StringComparer.OrdinalIgnoreCase);

        return string.Join(", ", slova);
    }













}













