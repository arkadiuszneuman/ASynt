using System.Drawing;
using System.Drawing.Drawing2D;
using ASynt.Player;
using System.Windows.Forms;

namespace ASynt.Keyboard
{
    public class Key
    {
        private Point position; //pozycja przycisku
        private Size size = new Size(40, 200); //wysokość i szerokość przycisku
        private Color color, colorClicked; //kolor przycisku
        
        private MainForm mainForm;
        private bool isSmall;
        public Keys KeyboardKey { get; private set; }
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
        public Key(MainForm mainForm, Point position, Keys keyboardKey, string file)
        {
            this.position = position;
            IsPushed = false;
            this.mainForm = mainForm;
            KeySound = new Sound(file);
            color = Color.White;
            colorClicked = Color.FromArgb(200, 200, 200);
            this.KeyboardKey = keyboardKey;
        }

        public Key(MainForm mainForm, Point position, Keys keyboardKey, Sound sound)
        {
            this.position = position;
            IsPushed = false;
            this.mainForm = mainForm;
            KeySound = sound;
            color = Color.White;
            colorClicked = Color.FromArgb(200, 200, 200);
            this.KeyboardKey = keyboardKey;
        }

        public Key(MainForm mainForm, Point position, Keys key, string file, bool isSmall) 
            : this(mainForm, position, key, file)
        {
            this.isSmall = isSmall;
            if (isSmall)
            {
                size = new Size(size.Width / 2, size.Height / 2);
                this.position.X -= size.Width / 2;
                color = Color.Black;
                colorClicked = Color.FromArgb(50, 50, 50);
            }
        }

        public Key(MainForm mainForm, Point position, Keys key, Sound sound, bool isSmall)
            : this(mainForm, position, key, sound)
        {
            this.isSmall = isSmall;
            if (isSmall)
            {
                size = new Size(size.Width / 2, size.Height / 2);
                this.position.X -= size.Width/2;
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
            else
                brush = new SolidBrush(colorClicked);
            g.FillRectangle(brush, new Rectangle(position, size));
            Pen p = new Pen(Color.Black);
            g.DrawRectangle(p, new Rectangle(position, size));
            p.Dispose();
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
