using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChessApp
{
    class Chessboard
    {
            private int _charachterIndex;
            private char _charachter;
            public Chessboard(int intCharIndex, char charCharacter)
            {
                _charachterIndex = intCharIndex;
                _charachter = charCharacter;

                for (var y = 0; y < 8; y++)
                {
                    for (var x = 0; x < 16; x++)
                    {
                        intCharIndex = (x / 2 + y) % 2;
                        charCharacter = intCharIndex == 0 ? '░' : '▓';

                        Console.Write(charCharacter);
                    }
                    Console.Write('\n');
                }
            }
        
    }
}
