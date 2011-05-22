using System.Drawing;
using System.Drawing.Drawing2D;
using ASynt.Player;

namespace ASynt.Keyboard
{
    public class Key
    {
        private Point position; //pozycja przycisku
        private Size size = new Size(20, 100); //wysokość i szerokość przycisku
        private Color color, colorClicked; //kolor przycisku
        public bool isPushed;
        private MainForm mainForm;
        private bool isSmall;
        public Sound Sound {get; private set;}
        public Point Position { get { return position; } }

        public Size Size { get {return size; } }

        public Key(MainForm mainForm, Point position, int frequency)
        {
            this.position = position;
            isPushed = false;
            this.mainForm = mainForm;
            Sound = new Sound("piano");
            Sound.ChangeFrequency(44100 + frequency);
            color = Color.White;
            colorClicked = Color.FromArgb(200, 200, 200);
        }

        public Key(MainForm mainForm, Point position, Sound sound)
        {
            this.position = position;
            isPushed = false;
            this.mainForm = mainForm;
            this.Sound = sound;
            color = Color.White;
            colorClicked = Color.FromArgb(200, 200, 200);
        }

        public Key(MainForm mainForm, Point position, int frequency, bool isSmall) 
            : this(mainForm, position, frequency)
        {
            this.isSmall = isSmall;
            if (isSmall)
            {
                size = new Size(10, 50);
                this.position.X -= 5;
                color = Color.Black;
                colorClicked = Color.FromArgb(50, 50, 50);
            }
        }

        public Key(MainForm mainForm, Point position, Sound sound, bool isSmall)
            : this(mainForm, position, sound)
        {
            this.isSmall = isSmall;
            if (isSmall)
            {
                size = new Size(10, 50);
                this.position.X -= 5;
                color = Color.Black;
                colorClicked = Color.FromArgb(50, 50, 50);
            }
        }

        public void Draw()
        {
            Graphics g = mainForm.CreateGraphics();
            SolidBrush brush;
            if (!isPushed)
                brush = new SolidBrush(color);
                //brush = new LinearGradientBrush(position, position + size, Color.FromArgb(255, 255, 255), Color.FromArgb(100, 100, 100));
            else
                brush = new SolidBrush(colorClicked);
                //brush = new LinearGradientBrush(position, position + size, Color.FromArgb(255, 255, 255), Color.FromArgb(50, 50, 50));
            g.FillRectangle(brush, new Rectangle(position, size));
            brush.Dispose();

            g.Dispose();
        }

        public bool checkIsPushed(Point mouse)
        {
            if (mouse.X > position.X && mouse.Y > position.Y && mouse.X < position.X + size.Width && mouse.Y < position.Y + size.Height)
            {
                isPushed = true;
                Draw();
                return true;
            }
            else if (isPushed) //odklikniecie keya w razie trzymania myszki i ruszania nia po klawiaturze
            {
                isPushed = false;
                Draw();
                return false;
            }

            return false;
        }

        public void setIsPushed()
        {
            if (isPushed)
            {
                isPushed = false;
                Draw();
            }
        }
    }
}
