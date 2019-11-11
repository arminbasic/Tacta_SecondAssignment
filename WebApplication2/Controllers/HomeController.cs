using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        Random random = new Random();

        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult Game()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXY";

            GameModel gameModel = new GameModel
            {
                LetterArray = new string[4,4],
                Words= new List<string>()
                
            };

            //Get random letter for the game to be displayed, in two-dimensional array 4x4
            for (int i=0; i <= 3; i++)
            {
                for (int j=0; j <= 3; j++)
                {
                    gameModel.LetterArray[i,j]= chars[random.Next(chars.Length)].ToString();
                }
            }

            return View(gameModel);
        }







        public IActionResult Result(GameModel gameModel)
        {
            gameModel.ResultPerWord = new List<int>();
            gameModel.TotalResult = 0;
            gameModel.ResultPerWord1 = new List<int>();
            gameModel.TotalResult1 = 0;

            //checking if there are same words for player1
            if (gameModel.Words != null) {
            for (int i=0; i < gameModel.Words.Count; i++)
            {
                for (int j = i+1; j < gameModel.Words.Count; j++)
                {
                    if (gameModel.Words[i] == gameModel.Words[j])
                    {
                        gameModel.Words.RemoveAt(j);
                    }
                }
            }
            }


            //checking if there are same words for player1
            if (gameModel.Words1 != null)
            {
                for (int i = 0; i < gameModel.Words1.Count; i++)
                {
                    for (int j = i + 1; j < gameModel.Words1.Count; j++)
                    {
                        if (gameModel.Words1[i] == gameModel.Words1[j])
                        {
                            gameModel.Words1.RemoveAt(j);
                        }
                    }
                }
            }

            //checking if there are the same words in both player's lists
            if (gameModel.Words!=null && gameModel.Words1 != null)
            {
                for (int i=0; i < gameModel.Words.Count; i++)
                {
                    for (int j=0; j < gameModel.Words1.Count; j++)
                    {
                        if (gameModel.Words[i] == gameModel.Words1[j])
                        {
                            if (i > j)
                            {
                                gameModel.Words.RemoveAt(i);
                            }
                            else
                            {
                                gameModel.Words1.RemoveAt(j);
                            }
                        }
                    }
                }
            }


            
            if (gameModel.Words != null) {

            for (int i=0; i < gameModel.Words.Count; i++)
            {
                gameModel.ResultPerWord.Add(0);
            }



            //get result for each of the words in the list for Player 1
            for (int i=0; i < gameModel.Words.Count; i++) {
            
                if (gameModel.Words[i].Length == 3 || gameModel.Words[i].Length == 4)
                {
                    gameModel.ResultPerWord[i] += 1;
                    
                }
                else if (gameModel.Words[i].Length == 5)
                {
                    gameModel.ResultPerWord[i] += 2;
                }
                else if (gameModel.Words[i].Length == 6)
                {
                    gameModel.ResultPerWord[i] += 3;
                }
                else if (gameModel.Words[i].Length == 7)
                {
                    gameModel.ResultPerWord[i] += 5;
                }
                else if (gameModel.Words[i].Length >= 8)
                {
                    gameModel.ResultPerWord[i] += 11;
                }

 }
            //sum total result for Player 1
          for (int i=0; i < gameModel.ResultPerWord.Count; i++)
            {
                gameModel.TotalResult += gameModel.ResultPerWord[i];
            }

            }


            if (gameModel.Words1 != null)
            {

                for (int i = 0; i < gameModel.Words1.Count; i++)
                {
                    gameModel.ResultPerWord1.Add(0);
                }




                //get result for each of the words in the list for Player 2
                for (int i = 0; i < gameModel.Words1.Count; i++)
                {

                    if (gameModel.Words1[i].Length == 3 || gameModel.Words1[i].Length == 4)
                    {
                        gameModel.ResultPerWord1[i] += 1;

                    }
                    else if (gameModel.Words1[i].Length == 5)
                    {
                        gameModel.ResultPerWord1[i] += 2;
                    }
                    else if (gameModel.Words1[i].Length == 6)
                    {
                        gameModel.ResultPerWord1[i] += 3;
                    }
                    else if (gameModel.Words1[i].Length == 7)
                    {
                        gameModel.ResultPerWord1[i] += 5;
                    }
                    else if (gameModel.Words1[i].Length >= 8)
                    {
                        gameModel.ResultPerWord1[i] += 11;
                    }

                }


                //sum total result for Player 2
                for (int i = 0; i < gameModel.ResultPerWord1.Count; i++)
                {
                    gameModel.TotalResult1 += gameModel.ResultPerWord1[i];
                }

            }




            return View(gameModel);
        }








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
