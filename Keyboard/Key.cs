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
        private Color color, colorClicked; //kolor przycisku, kolor przycisku po kliknięci
        private MainForm mainForm;
        private bool isSmall;
        public Keys KeyboardKey { get; private set; }
        public Sound KeySound {get; set;}
        public Point Position { get { return position; } }

        public Size Size { get {return size; } }
        private bool isPushed;
        public bool IsPushed
        {
            get { return isPushed; }
            set
            {
                //if (value && isPushed)
                {
                    isPushed = value;
                    //isPushed = false;
                    Draw();
                }
            }
        }

        /// <summary>
        /// Ustawienie częstotliwości odtwarzanego dźwięku
        /// </summary>
        public int SetFrequency
        {
            set
            {
                KeySound.ChangeFrequency(value);
            }
        }

        #region Konstruktory
        /// <summary>
        /// Tworzy nowy key
        /// </summary>
        /// <param name="mainForm">Forma, na której będzie malowany przycisk</param>
        /// <param name="position">Pozycja przycisku</param>
        /// <param name="keyboardKey">Przycisk klawiatury, na jaki będzie reagował key</param>
        /// <param name="file">Scieżka do dźwięku, jaki ma być odtwarzany przy naciśnięciu keya</param>
        public Key(MainForm mainForm, Point position, Keys keyboardKey, string file)
        {
            this.position = position;
            this.mainForm = mainForm;
            KeySound = new Sound(file);
            color = Color.White;
            colorClicked = Color.FromArgb(200, 200, 200);
            this.KeyboardKey = keyboardKey;
        }

        /// <summary>
        /// Tworzy nowy key
        /// </summary>
        /// <param name="mainForm">Forma, na której będzie malowany przycisk</param>
        /// <param name="position">Pozycja przycisku</param>
        /// <param name="keyboardKey">Przycisk klawiatury, na jaki będzie reagował key</param>
        /// <param name="sound">Dzwięk, jaki będzie odtwarzany po naciśnięciu keya</param>
        public Key(MainForm mainForm, Point position, Keys keyboardKey, Sound sound)
        {
            this.position = position;
            this.mainForm = mainForm;
            KeySound = sound;
            color = Color.White;
            colorClicked = Color.FromArgb(200, 200, 200);
            this.KeyboardKey = keyboardKey;
        }

        /// <summary>
        /// Tworzy nowy key
        /// </summary>
        /// <param name="mainForm">Forma, na której będzie malowany przycisk</param>
        /// <param name="position">Pozycja przycisku</param>
        /// <param name="keyboardKey">Przycisk klawiatury, na jaki będzie reagował key</param>
        /// <param name="file">Scieżka do dźwięku, jaki ma być odtwarzany przy naciśnięciu keya</param>
        /// <param name="isSmall">Czy tworzony przycisk ma być mały (czyli czarny)</param>
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

        /// <summary>
        /// Tworzy nowy key
        /// </summary>
        /// <param name="mainForm">Forma, na której będzie malowany przycisk</param>
        /// <param name="position">Pozycja przycisku</param>
        /// <param name="keyboardKey">Przycisk klawiatury, na jaki będzie reagował key</param>
        /// <param name="sound">Dzwięk, jaki będzie odtwarzany po naciśnięciu keya</param>
        /// <param name="isSmall">Czy tworzony przycisk ma być mały (czyli czarny)</param>
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

        /// <summary>
        /// Rysuje Keya na formie głównej
        /// </summary>
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

        /// <summary>
        /// Sprawdza, czy key jest aktualnie wciśnięty
        /// </summary>
        /// <param name="mouse">Punkt, w którym znajduje się mysz</param>
        /// <returns>True, jeśli key wciśnięty, false w przeciwnym wypadku</returns>
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
    }
}
