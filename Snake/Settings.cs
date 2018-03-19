﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int width { get; set; }
        public static int height { get; set; }
        public static int speed { get; set; }
        public static int score { get; set; }
        public static int points { get; set; }
        public static bool gameOver { get; set; }
        public static Direction direction { get; set; }

        //Settings of the game
        public Settings()
        {
            width = 20;//in pixel
            height = 20;//"
            speed = 20;
            score = 0;
            points = 10;
            gameOver = false;
            direction = Direction.Right; 
        }
    }
}
