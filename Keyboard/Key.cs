using System.Drawing;
using System.Drawing.Drawing2D;
using ASynt.Player;

namespace ASynt.Keyboard
{
    public class Key
    {
        private Point position; //pozycja przycisku
        private static Size size = new Size(20, 100); //wysokość i szerokość przycisku
        public bool isPushed;
        private MainForm mainForm;
        public Sound Sound {get; private set;}

        public static Size Size { get {return size; } }

        public Key(MainForm mainForm, Point position, int frequency)
        {
            this.position = position;
            isPushed = false;
            this.mainForm = mainForm;
            Sound = new Sound("piano");
            Sound.ChangeFrequency(44100 + frequency);
        }

        public void Draw()
        {
            Graphics g = mainForm.CreateGraphics();
            LinearGradientBrush brush;
            if (!isPushed)
                brush = new LinearGradientBrush(position, position + size, Color.FromArgb(255, 255, 255), Color.FromArgb(100, 100, 100));
            else
                brush = new LinearGradientBrush(position, position + size, Color.FromArgb(255, 255, 255), Color.FromArgb(50, 50, 50));
            g.FillRectangle(brush, new Rectangle(position, size));
            brush.Dispose();
            g.Dispose();
        }

        public void checkIsPushed(Point mouse)
        {
            if (mouse.X > position.X && mouse.Y > position.Y && mouse.X < position.X + size.Width && mouse.Y < position.Y + size.Height)
            {
                isPushed = true;
                Draw();
            }
            else if (isPushed) //odklikniecie keya w razie trzymania myszki i ruszania nia po klawiaturze
            {
                isPushed = false;
                Draw();
            }
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
