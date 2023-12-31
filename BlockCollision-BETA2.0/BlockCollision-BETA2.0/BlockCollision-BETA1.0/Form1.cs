

using System.Configuration;

namespace BlockCollision_BETA1._0
{
    public partial class Form1 : Form
    {
        public bool ymatches;
        public bool collision;
        public bool firstCollision = false;
        public bool wallcollisionred = false;
        public bool wallcollisionblue = false;
        public double v1a;
        public double v2a;
        public double a1;
        public double b1;
        public double a2;
        public double b2;
        public double a3;
        public double a4;
        public double b3;
        public double b4;
        public bool buttonGoClicked;
        public int v1ad;
        public int v2ad;
        public bool red2negativ;
        public bool blue2negativ;
        public bool bluenegativ;
        public bool rednegativ;
        public Random rnd = new Random();
        public int autobluespeed;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            labelCollisionStatus.ForeColor = Color.Red;
            panelRed.Location = new Point(this.Width / 2 - panelRed.Width - this.Width / 4, this.Height / 2 - panelRed.Height / 2);
            panelBlue.Location = new Point(this.Width / 2 + this.Width / 4, this.Height / 2 - panelBlue.Height / 2);
            await Task.Delay(1000);
            collisionChecker();
            movement();
            //movementblue();
            //movementred();
            generalloop();
        }

        public async void generalloop()
        {
            await Task.Delay(10);
            while (true)
            {
                if(autoPlayer.Checked == true)
                {
                    textBoxRedWeight.Text = rnd.Next(1, 100).ToString();
                    await Task.Delay(500);
                    textBoxBlueWeight.Text = rnd.Next(1, 100).ToString();
                    await Task.Delay(500);
                    textBoxRedSpeed.Text = rnd.Next(1, 7).ToString();
                    await Task.Delay(500);
                    autobluespeed = rnd.Next(1, 7) * -1;
                    textBoxBlueSpeed.Text = autobluespeed.ToString();
                    await Task.Delay(500);
                    textBox1.Text = rnd.Next(0, 130).ToString();
                    await Task.Delay(500);
                    button1.PerformClick();
                    await Task.Delay(15000);
                }
                await Task.Delay(500);
            }
        }

        public async void collisionChecker()
        {
            //Cursor.Position = ((Control)sender).PointToScreen(new Point(panelBlue.Location.X, panelBlue.Location.Y));
            await Task.Delay(1);
            while (true)
            {
                //try
                //{
                //    panelBlue.Location = ((Control)sender).PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
                //}
                //catch (ObjectDisposedException)
                //{

                //};
                if(panelRed.Location.X == this.Width - this.Width)
                {
                    wallcollisionred = true;
                    //v1ad = v1ad * -1;
                }

                if(panelBlue.Location.X == this.Width - panelBlue.Width)
                {
                    wallcollisionblue = true;
                    //v2ad = v2ad * -1;
                }

                if (panelRed.Location.Y + panelRed.Height > panelBlue.Location.Y && panelRed.Location.Y < panelBlue.Location.Y + panelBlue.Height)
                {
                    ymatches = true;
                }
                else
                {
                    ymatches = false;
                }

                if (panelRed.Location.X + panelRed.Width == panelBlue.Location.X || panelRed.Location.X + panelRed.Width > panelBlue.Location.X && ymatches == true && firstCollision == false)
                {
                    //labelCollisionStatus.Text = "Collision!";
                    //
                    collision = true;
                    firstCollision = true;
                    collisionCalculator();
                }
                else
                {
                    //labelCollisionStatus.Text = "No Collision";
                    collision = false;
                }
                await Task.Delay(3);
            }
        }

        public void collisionCalculator()
        {
            if (textBoxRedWeight.Text != "" && textBoxRedSpeed.Text != "" && textBoxBlueWeight.Text != "" && textBoxBlueSpeed.Text != "" && buttonGoClicked == true)
            {
                a1 = int.Parse(textBoxRedWeight.Text) * int.Parse(textBoxRedSpeed.Text) + int.Parse(textBoxBlueWeight.Text) * int.Parse(textBoxBlueSpeed.Text);
                a2 = 2 * a1;
                a3 = int.Parse(textBoxRedWeight.Text) + int.Parse(textBoxBlueWeight.Text);
                a4 = a2 / a3;
                v1a = a4 - int.Parse(textBoxRedSpeed.Text);
                b1 = int.Parse(textBoxRedWeight.Text) * int.Parse(textBoxRedSpeed.Text) + int.Parse(textBoxBlueWeight.Text) * int.Parse(textBoxBlueSpeed.Text);
                b2 = 2 * b1;
                b3 = int.Parse(textBoxRedWeight.Text) + int.Parse(textBoxBlueWeight.Text);
                b4 = b2 / b3;
                v2a = b4 - int.Parse(textBoxBlueSpeed.Text);
                //b1 = 10 * 20 + 10 * -20;
                //a1 = 2 * b1;
                //a3 = 10 + 10;
                //a2 = a1 / a3;
                //b2 = a2 - 20;
                //labelCollisionStatus.Text = v1a.ToString() + "; " + v2a.ToString();
                v1ad = (int)v1a;
                v2ad = (int)v2a;
                if (v1a < 1 && v1a > 0)
                {
                    v1ad = 1;
                }
                if (v2a < 1 && v2a > 0)
                {
                    v2ad = 1;
                }
                if (v1a < 0 && v1a > -1)
                {
                    v1ad = -1;
                }
                if (v2a < 0 && v2a > -1)
                {
                    v2ad = -1;
                }
                if (v1ad < 0) red2negativ = true;
                if (v2ad < 0) blue2negativ = true;
                labelCollisionStatus.Text = v1a.ToString() + "; " + v2a.ToString();
                labelCollisionStatus.ForeColor = Color.Green;
            }
        }


        public async void movementblue()
        {
            await Task.Delay(10);
            while (true)
            {
                if (firstCollision == true)
                {
                    panelBlue.Location = new Point(panelBlue.Location.X + v2ad, panelBlue.Location.Y);
                }
                else if (textBoxRedWeight.Text != "" && textBoxRedSpeed.Text != "" && textBoxRedSpeed.Text != "-" && textBoxBlueWeight.Text != "" && textBoxBlueSpeed.Text != "" && textBoxRedSpeed.Text != "-" && buttonGoClicked == true && firstCollision == false)
                {
                    panelBlue.Location = new Point(panelBlue.Location.X + int.Parse(textBoxBlueSpeed.Text), panelBlue.Location.Y);
                }
                if(wallcollisionblue == true)
                {
                    while(collision != true)
                    {
                        panelBlue.Location = new Point(panelBlue.Location.X + v1ad, panelBlue.Location.Y);
                        await Task.Delay(10);
                    }
                    wallcollisionblue = false;
                }
                await Task.Delay(10);
            }
        }

        public async void movementred()
        {
            await Task.Delay(10);
            while (true)
            {
                if(firstCollision == true)
                {
                    panelRed.Location = new Point(panelRed.Location.X + v1ad, panelRed.Location.Y);
                }
                else if (textBoxRedWeight.Text != "" && textBoxRedSpeed.Text != "" && textBoxRedSpeed.Text != "-" && textBoxBlueWeight.Text != "" && textBoxBlueSpeed.Text != "" && textBoxRedSpeed.Text != "-" && buttonGoClicked == true && firstCollision == false)
                {
                    panelRed.Location = new Point(panelRed.Location.X + int.Parse(textBoxRedSpeed.Text), panelRed.Location.Y);
                }
                if (wallcollisionred == true)
                {
                    while (collision != true)
                    {
                        panelRed.Location = new Point(panelRed.Location.X + v1ad, panelRed.Location.Y);
                        await Task.Delay(10);
                    }
                    wallcollisionred = false;
                }
                await Task.Delay(10);
            }
        }

        public async void movement()
        {
            await Task.Delay(1);
            while (true)
            {
                if (firstCollision == true)
                {
                    panelRed.Location = new Point(panelRed.Location.X + v1ad, panelRed.Location.Y);
                    panelBlue.Location = new Point(panelBlue.Location.X + v2ad, panelBlue.Location.Y);
                }
                else if (textBoxRedWeight.Text != "" && textBoxRedSpeed.Text != "" && textBoxBlueWeight.Text != "" && textBoxBlueSpeed.Text != "" && buttonGoClicked == true && firstCollision == false)
                {
                    panelRed.Location = new Point(panelRed.Location.X + int.Parse(textBoxRedSpeed.Text), panelRed.Location.Y);
                    panelBlue.Location = new Point(panelBlue.Location.X + int.Parse(textBoxBlueSpeed.Text), panelBlue.Location.Y);
                }
                await Task.Delay(10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxRedWeight.Text != "" && textBoxRedSpeed.Text != "" && textBoxRedSpeed.Text != "-" && textBoxBlueWeight.Text != "" && textBoxBlueSpeed.Text != "" && textBoxRedSpeed.Text != "-" && textBox1.Text != "") {
                labelCollisionStatus.Text = "collision-data";
                labelCollisionStatus.ForeColor = Color.Red;
                buttonGoClicked = true;
                firstCollision = false;
                panelRed.Location = new Point(this.Width / 2 - panelRed.Width - this.Width / 4, this.Height / 2 - panelRed.Height / 2);
                panelBlue.Location = new Point(this.Width / 2 + this.Width / 4, this.Height / 2 - panelBlue.Height / 2 + int.Parse(textBox1.Text));
                v1a = 0;
                v2a = 0;
            }
            else
            {
                MessageBox.Show("no field can be empty | Kein Feld kann leer bleiben");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonGoClicked = false;
            wallcollisionblue = false;
            wallcollisionred = false;
            labelCollisionStatus.Text = "collision-data";
            labelCollisionStatus.ForeColor = Color.Red;
            v1ad = 0;
            v2ad = 0;
            panelRed.Location = new Point(this.Width / 2 - panelRed.Width - this.Width / 4, this.Height / 2 - panelRed.Height / 2);
            panelBlue.Location = new Point(this.Width / 2 + this.Width / 4, this.Height / 2 - panelBlue.Height / 2);
        }
    }
}