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
        
        private MainForm mainForm;
        private bool isSmall;
        public Sound KeySound {get; private set;}
        public Point Position { get { return position; } }

        public Size Size { get {return size; } }
        public bool IsPushed { get; set; }

        public int SetFrequency
        {
            set
            {
                KeySound.ChangeFrequency(value);
            }
        }

        #region Konstruktory
        public Key(MainForm mainForm, Point position, string file)
        {
            this.position = position;
            IsPushed = false;
            this.mainForm = mainForm;
            KeySound = new Sound(file);
            color = Color.White;
            colorClicked = Color.FromArgb(200, 200, 200);
        }

        public Key(MainForm mainForm, Point position, Sound sound)
        {
            this.position = position;
            IsPushed = false;
            this.mainForm = mainForm;
            KeySound = sound;
            color = Color.White;
            colorClicked = Color.FromArgb(200, 200, 200);
        }

        public Key(MainForm mainForm, Point position, string file, bool isSmall) 
            : this(mainForm, position, file)
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
        #endregion

        public void Draw()
        {
            Graphics g = mainForm.CreateGraphics();
            SolidBrush brush;
            if (!IsPushed)
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
                IsPushed = true;
                Draw();
                return true;
            }
            else if (IsPushed) //odklikniecie keya w razie trzymania myszki i ruszania nia po klawiaturze
            {
                IsPushed = false;
                Draw();
                return false;
            }

            return false;
        }

        public void setIsPushed()
        {
            if (IsPushed)
            {
                IsPushed = false;
                Draw();
            }
        }
    }
}
