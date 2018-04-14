using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGames
{
    
    public partial class Snake : Form
    {
        public bool check1 = true;
        public bool check2 = true;
        public bool check3 = true;
        public bool check4 = true;

        public int a = 0;
        public int b = 75;
        public int c = 0; public int l = 0; public int u = 0;
        public int d = 0;
        public int LeftPos=0;
        public int TopPos=0;
        public Button Yem;
        public Button LeftSnake=new Button();
        public Button RightSnake=new Button();
        public Button UpSnake=new Button();
        public Button  DownSnake=new Button();
        public Button snake = new Button();
        public List<Button> buttons = new List<Button>() { };
        public Timer time = new Timer();

        
        public Snake()
        {
            
            InitializeComponent();

            time.Interval = 300;
            time.Start();

            //LeftSnake.Click += new EventHandler(LeftData);
            //RightSnake.Click += new EventHandler(RightData);
            //UpSnake.Click += new EventHandler(UpData);
            //DownSnake.Click += new EventHandler(DownData);

            //LeftRightUpDown();
            //time.Tick += new EventHandler(LeftData);

            Snakee();
            YEM();



        }
        public void LeftData(object obj, EventArgs e)
        {
            if (buttons.Count > 5 && buttons.Count < 15)
            {

                time.Interval = 200;
                time.Start();
            }
            else if (buttons.Count >= 15 && buttons.Count < 30)
            {
                time.Interval = 150;
                time.Start();
            }
            else if(buttons.Count==30)
            {
                MessageBox.Show("Tebrikler siz 5000000$ uddunuz");
                time.Stop();
            }
            if (buttons.Count > 1)
            {
                
                for (int i = buttons.Count - 1; i > 0; i--)
                {

                    buttons[i].Top = buttons[i - 1].Top;
                    buttons[i].Left = buttons[i - 1].Left;


                }
            }
            snake.Left -= snake.Width;
            if (snake.Left <= -25)
            {
                time.Stop();
            }        
            if (snake.Top == Yem.Top && snake.Left == Yem.Left)
            {
                buttons.Add(Yem);
                c = 0;

                YEM();
            }



        }
        public void RightData(object obj, EventArgs e)
        {

            if (buttons.Count > 5 && buttons.Count < 15)
            {

                time.Interval = 200;
                time.Start();
            }
            else if (buttons.Count >= 15 && buttons.Count < 30)
            {
                time.Interval = 150;
                time.Start();
            }
            else if (buttons.Count == 30)
            {
                MessageBox.Show("Tebrikler siz 5000000$ uddunuz");
                time.Stop();
            }


            if (buttons.Count > 1)
            {
                for (int i = buttons.Count - 1; i > 0; i--)
                {
                
                    buttons[i].Top = buttons[i - 1].Top;
                    buttons[i].Left = buttons[i - 1].Left;
                   
                }

            }
           
            snake.Left += snake.Width;
            if (snake.Left > this.Width-20 )
            {
                time.Stop();

                //snake.Left = 0;

            }
      
            if (snake.Top == Yem.Top && snake.Left == Yem.Left)
            {
                buttons.Add(Yem);

                c = 0;
                YEM();
            }




        }
        public void UpData(object obj, EventArgs e)
        {

            if (buttons.Count > 5 && buttons.Count < 15)
            {

                time.Interval = 200;
                time.Start();
            }
            else if (buttons.Count >= 15 && buttons.Count < 30)
            {
                time.Interval = 150;
                time.Start();
            }
            else if (buttons.Count == 30)
            {
                MessageBox.Show("Tebrikler siz 5000000$ uddunuz");
                time.Stop();
            }


            if (buttons.Count > 1)
            {
                for (int i = buttons.Count - 1; i > 0; i--)
                {
                    
                    buttons[i].Top = buttons[i - 1].Top;
                    buttons[i].Left = buttons[i - 1].Left;
                   
                }

            }
           
            snake.Top -= snake.Height;

            if (snake.Top < 0)
            {
                time.Stop();
                
            }
        

            if (snake.Top == Yem.Top && snake.Left == Yem.Left)
            {
                buttons.Add(Yem);

                c = 0;
                YEM();
            }



        }
        public void DownData(object obj, EventArgs e)
        {
          

            if (buttons.Count > 5&&buttons.Count<15)
            {

                time.Interval = 200;
                time.Start();
            }
            else if (buttons.Count >= 15&&buttons.Count<30)
            {
                time.Interval = 150;
                time.Start();
            }
            else if (buttons.Count == 30)
            {
                MessageBox.Show("Tebrikler siz 5000000$ uddunuz");
                time.Stop();
            }
          

            if (buttons.Count > 1)
            {
                for (int i = buttons.Count - 1; i > 0; i--)
                {
                   
                    buttons[i].Top = buttons[i - 1].Top;
                    buttons[i].Left = buttons[i - 1].Left;
               
                }

            }
            


            
            snake.Top += snake.Height;

            if (snake.Top > this.Height-40)
            {
                time.Stop();
               
            }
          
            if (snake.Top == Yem.Top && snake.Left == Yem.Left)
            {
                buttons.Add(Yem);


                c = 0;
                YEM();
            }









        }
        public void YEM()
        {
             Yem = new Button();
            Random yemrand = new Random();
            int b = yemrand.Next(20);
            Yem.Width = 20;
            Yem.Height = 20;
            Yem.Top = b * Yem.Height;
            Yem.Left = b * Yem.Width;
            Yem.TabIndex = 1;
            Yem.FlatAppearance.BorderSize = 1;
            Yem.FlatStyle = FlatStyle.Flat;
            Yem.BackColor = Color.Red;
            Yem.Enabled = false;
            Controls.Add(Yem);
        }
        public void Snakee()
        {
            for (int i = 0; i < 1; i++)
            {

                snake.Width = 20;
                snake.Height = 20;
                snake.Left = 0;
                snake.Top = 0;
                snake.Name = "afdsvdas";
                snake.TabIndex = 0;
                snake.FlatStyle = FlatStyle.Flat;
                snake.FlatAppearance.BorderSize = 5;
                snake.FlatAppearance.BorderColor = Color.BlueViolet;
                buttons.Add(snake);
                snake.BackColor = Color.BlueViolet;
                snake.KeyUp += new KeyEventHandler(Key);
                Controls.Add(snake);
            
            }

        }
        public void LeftRightUpDown()
        {
            LeftSnake.Width = 25;
            LeftSnake.Height = 25;
            LeftSnake.TabIndex = 2;
            LeftSnake.Left = this.Width - LeftSnake.Width * 3 - 17;
            LeftSnake.Top = this.Height - LeftSnake.Height * 3 - 17;
            
            LeftSnake.Text = "L";

            RightSnake.Width = 25;
            RightSnake.Height = 25;
            RightSnake.TabIndex = 3;
            RightSnake.Left = this.Width - RightSnake.Width * 1 - 17;
            RightSnake.Top = this.Height - RightSnake.Height * 3 - 17;
            RightSnake.Text = "R";

            UpSnake.Width = 25;
            UpSnake.Height = 25;
            UpSnake.TabIndex = 4;
            UpSnake.Left = this.Width - UpSnake.Width * 2 - 17;
            UpSnake.Top = this.Height - UpSnake.Height * 4 - 17;
            UpSnake.Text = "U";

            DownSnake.Width = 25;
            DownSnake.Height = 25;
            DownSnake.TabIndex = 5;
            DownSnake.Left = this.Width - DownSnake.Width * 2 - 17;
            DownSnake.Top = this.Height - DownSnake.Height * 2 - 17;
            DownSnake.Text = "D";


            Controls.Add(LeftSnake);
            Controls.Add(RightSnake);
            Controls.Add(UpSnake);
            Controls.Add(DownSnake);
        }
        public void Key(object obj, KeyEventArgs e)
        {
            
            switch (e.KeyData.ToString())
            { 
                case "Left":
                    if (check1)
                    {
                        time.Tick -= RightData;
                        time.Tick -= UpData;
                        time.Tick -= DownData;
                   
                        time.Tick += new EventHandler(LeftData);
                        check1 = false;
                    }
                    check2 = true;
                    check3 = true;
                    check4 = true;

                    break;

                case "Right":
                    if (check2)
                    {
                        time.Tick -= LeftData;
                        time.Tick -= UpData;
                        time.Tick -= DownData;

                        time.Tick += new EventHandler(RightData);
                        check2 = false;
                    }
                    check1 = true;
                    check3 = true;
                    check4 = true;
                    break;
                case "Up":
                    if (check3)
                    {
                        time.Tick -= LeftData;
                        time.Tick -= RightData;
                        time.Tick -= DownData;

                        time.Tick += new EventHandler(UpData);
                        check3 = false;
                    }
                    check2 = true;
                    check1 = true;
                    check4 = true;
                    break;
                case "Down":
                    if (check4)
                    {
                        time.Tick -= LeftData;
                        time.Tick -= RightData;
                        time.Tick -= UpData;

                        time.Tick += new EventHandler(DownData);
                        check4 = false;
                    }
                    check2 = true;
                    check3 = true;
                    check1 = true;

                    break;
            }
        }

    }
}
