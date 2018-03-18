using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        // Rest the setting and rest of the time
        public Form1()
        {
            InitializeComponent();

            new Settings();

            gTimer.Interval = 1000/Settings.speed;
            //gTimer.Tick += updateScreen();
            gTimer.Start();

            StartGame();
        }

        private void StartGame()
        {
            lblgameover.Visible = false;
            //throw new NotImplementedException();
            new Settings();

            //New player
            Snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            lblscore.Text = Settings.score.ToString();//0

            GenerateFood();
        }

        //Random Food somewhere on the map
        private void GenerateFood()
        {
            //throw new NotImplementedException();
            int maxXpos = Gcanvas.Size.Width/Settings.width;
            int maxYpos = Gcanvas.Size.Width/Settings.height;

            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXpos);
            food.Y = random.Next(0, maxYpos);
        }

        private void updateScreen(object sender, EventArgs e)    
        {
            //if not gameover
            if(Settings.gameOver == true)
            {
                //Start : Entrer
                if(Input.keyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.keyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.keyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.keyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
               else if (Input.keyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                moveSnake();
            }

            Gcanvas.Invalidate();
        }
        
        private void Gcanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            
            if(!Settings.gameOver)
            {
                Brush snakeColour;

                for(int i = 0; i< Snake.Count; i++)
                {
                    if (i == 0)
                        snakeColour = Brushes.Black;
                    else
                        snakeColour = Brushes.Green;

                    canvas.FillEllipse(snakeColour, new Rectangle(Snake[i].X * Settings.width, Snake[i].Y * Settings.height, Settings.width, Settings.height));

                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * Settings.width, Settings.height, Settings.width, Settings.height));
                     
                }
            }
            else
            {
                String msgGameover = " Game over my dude ur score is  : " + Settings.score + "\nEntrer to try again LUL";
                lblgameover.Text = msgGameover;
                lblgameover.Visible = true;
            }
        }


        private void moveSnake()
        {
            for(int i = Snake.Count -1; i>=0; i++)
            {
                if(i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;

                        case Direction.Left:
                            Snake[i].X--;
                            break;

                        case Direction.Up:
                            Snake[i].Y++;
                            break;

                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                            
                    }

                    int max_Xpos = Gcanvas.Size.Width / Settings.width;
                    int max_Ypos = Gcanvas.Size.Width / Settings.height;

                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= max_Xpos || Snake[i].Y >= max_Ypos)
                    {
                        //Dead();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if(Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            //Dead();
                        }
                    }

                    if(Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Dead()
        {
            Settings.gameOver = true;
        }

        private void Eat()
        {
            Circle food = new Circle();
            food.X = Snake[Snake.Count - 1].X;
            food.Y = Snake[Snake.Count - 1].Y;

            Snake.Add(food);

            Settings.score += Settings.points;
            lblscore.Text = Settings.score.ToString();
        }
    }
}
