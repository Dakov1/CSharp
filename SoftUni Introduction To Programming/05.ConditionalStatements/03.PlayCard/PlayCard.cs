using System;

class PlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter a letter or number and I'll tell you is it valid PlayCard");
        string card = Console.ReadLine();
        bool isTwo = card == "2";
        bool isThree = card == "3";
        bool isFour = card == "4";
        bool isFive = card == "5";
        bool isSix = card == "6";
        bool isSeven = card == "7";
        bool isEight = card == "8";
        bool isNine = card == "9";
        bool isTen = card == "10";
        bool isAce = card == "A";
        bool isQueen = card == "Q";
        bool isKing = card == "K";
        bool isJack = card == "J";
        bool isPlayCard = isTwo || isThree || isFour || isFive || isSix || isSeven || isEight || isNine || isTen || isQueen || isAce || isKing || isJack;
        if (isPlayCard)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

