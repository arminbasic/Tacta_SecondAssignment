﻿using System;
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

            if (gameModel.Words != null) {

            for (int i=0; i < gameModel.Words.Count; i++)
            {
                gameModel.ResultPerWord.Add(0);
            }




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
            
          for (int i=0; i < gameModel.ResultPerWord.Count; i++)
            {
                gameModel.TotalResult += gameModel.ResultPerWord[i];
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
