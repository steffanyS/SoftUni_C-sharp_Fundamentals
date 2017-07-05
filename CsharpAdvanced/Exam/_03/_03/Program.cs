using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex("([0-9]+)([a-zA-z]+)");

            var firstPlayer = new Queue<string>(Console.ReadLine().Split(' '));
            var secondPlayer = new Queue<string>(Console.ReadLine().Split(' '));

            var warCards = new Stack<string>();
            var winner = "";
            var turns = 0;

            while ((firstPlayer.Count > 0 && secondPlayer.Count > 0) && turns < 1000000)
            {
                var firstPlayerCard = firstPlayer.Dequeue();
                var match = regex.Match(firstPlayerCard);
                var firstNumber = int.Parse(match.Groups[1].ToString());
                var firstLetters = match.Groups[2].ToString();
                var firstLetter = firstLetters.Sum(l => char.ToUpper(l) - 64);


                var secondPlayerCard = secondPlayer.Dequeue();
                var matchSecond = regex.Match(secondPlayerCard);
                var secondNumber = int.Parse(matchSecond.Groups[1].ToString());
                var secondLetters = matchSecond.Groups[2].ToString();
                var secondLetter = secondLetters.Sum(l => char.ToUpper(l) - 64);

                if (firstNumber > secondNumber)
                {
                    firstPlayer.Enqueue(firstPlayerCard);
                    firstPlayer.Enqueue(secondPlayerCard);
                }
                else if (secondNumber > firstNumber)
                {
                    secondPlayer.Enqueue(secondPlayerCard);
                    secondPlayer.Enqueue(firstPlayerCard);
                }
                else
                {
                    var firstSum = 0;
                    var secondSum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        if (firstPlayer.Count == 0)
                        {
                            break;
                        }
                        firstPlayerCard = firstPlayer.Dequeue();
                        warCards.Push(firstPlayerCard);
                        firstSum += firstLetter;
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        if (secondPlayer.Count == 0)
                        {
                            break;
                        }
                        secondPlayerCard = secondPlayer.Dequeue();
                        warCards.Push(secondPlayerCard);
                        secondSum += secondLetter;
                    }

                    if (firstSum > secondSum)
                    {
                        while (warCards.Count > 0)
                        {
                            firstPlayer.Enqueue(warCards.Pop());
                        }
                    }
                    else if (secondSum > firstSum)
                    {
                        while (warCards.Count > 0)
                        {
                            secondPlayer.Enqueue(warCards.Pop());
                        }
                    }
                    else
                    {
                        firstSum = 0;
                        secondSum = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            if (firstPlayer.Count == 0)
                            {
                                turns--;
                                winner = "Second player wins";
                                break;
                            }
                            firstPlayerCard = firstPlayer.Dequeue();
                            warCards.Push(firstPlayerCard);
                            firstSum += firstLetter;
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            if (secondPlayer.Count == 0)
                            {
                                turns--;
                                winner = "First player wins";
                                break;
                            }
                            secondPlayerCard = secondPlayer.Dequeue();
                            warCards.Push(secondPlayerCard);
                            secondSum += secondLetter;
                        }
                    }
                }

                if (firstPlayer.Count == 0 && secondPlayer.Count>0)
                {
                    winner = "Second player wins";
                }
                else if (secondPlayer.Count == 0 && firstPlayer.Count > 0)
                {
                    winner = "First player wins";
                }
                else if (firstPlayer.Count==0 && secondPlayer.Count==0)
                {
                    winner = "Draw";
                }

                turns++;
            }

            if (turns > 1000000 && firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                if (firstPlayer.Count > secondPlayer.Count)
                {
                    winner = "First player wins";
                }

                if (firstPlayer.Count < secondPlayer.Count)
                {
                    winner = "Second player wins";
                }
            }

            Console.WriteLine("{0} after {1} turns", winner, turns);
        }
    }
}
