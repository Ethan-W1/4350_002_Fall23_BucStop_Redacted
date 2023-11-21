﻿using BucStop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

/*
 * This file has the controllers for everything outside of the games
 * and game-related pages.
 */

namespace BucStop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Sends the user to the deprecated Index page.
        public IActionResult Index()
        {
            return View(games);
        }

        //Takes the user to the admin page.
        public IActionResult Admin()
        {
            return View();
        }

        //Takes the user to the privacy policy page.
        public IActionResult Privacy()
        {
            return View();
        }

        //Takes the user to the game criteria page.
        public IActionResult GameCriteria()
        {
            return View();
        }

        //If something goes wrong, this will take the user to a page explaining the error.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //Creating the games objects to display on Play and Index
        private static List<Game> games = new List<Game>
        {


            //Game data
            new Game {
                Id = 1,
                Title = "Snake",
                Content = "~/js/snake.js",
                Author = null,
                Description = "Snake Description",
                HowTo = null,
                Thumbnail = "/images/snake.jpg" //640x360 resolution
            },
            new Game {
                Id = 2,
                Title = "Tetris",
                Content = "~/js/tetris.js",
                Author = null,
                Description = "Tetris description.",
                HowTo = null,
                Thumbnail = "/images/tetris.jpg"
            },
            new Game {
                Id = 3,
                Title = "Pong",
                Content = "~/js/pong.js",
                Author = null,
                Description = "Pong description.",
                HowTo = null,
                Thumbnail = "/images/pong.jpg"
            },
        };

    }
}