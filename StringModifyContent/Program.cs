﻿namespace StringModifyContent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string message = "Find what is (inside the parenthesis)";

            //int openingPosition = message.IndexOf('(');
            //int closingPosition = message.IndexOf(')');

            //Console.WriteLine(openingPosition);
            //Console.WriteLine(closingPosition);

            //int length = closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition + 1,length - 1));


            //message = "What is the value <span>between the tags</span>?";

            //const string openSpan = "<span>";
            //const string closeSpan = "</span>";

            //openingPosition = message.IndexOf(openSpan);
            //closingPosition = message.IndexOf(closeSpan);

            //openingPosition += openSpan.Length;
            //length = closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition,length));

            //message = "(What if) I am (only interested in the last (set of parentheses)?";
            //openingPosition = message.LastIndexOf('(');
            //openingPosition += 1;

            //closingPosition = message.LastIndexOf(')');
            
            //length= closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition,length));

            //string message = "(What if) there are (more than) one (set of parentheses)?";
            //while (true)
            //{
            //    int openingPosition = message.IndexOf('(');
            //    if (openingPosition == -1)
            //    {
            //        break;
            //    }
            //    openingPosition += 1;
            //    int closingPosition = message.IndexOf(')');
            //    int length = closingPosition-openingPosition;
            //    Console.WriteLine(message.Substring(openingPosition,length));
            //    message= message.Substring(closingPosition + 1);

            //}

            string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
            char[] openSymbols = { '[', '{', '(' };

            int closingPosition = 0;

            while (true)
            {
                int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1)
                {
                    break;
                }

                string currentSymbol = message.Substring(openingPosition, 1);

                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition,length));
            }

        }
    }
}