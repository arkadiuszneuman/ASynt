using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using ASynt.Player;

namespace ASynt.Keyboard
{
    public class Keyboard
    {
        private Key[] keys = new Key[25];
        private Point position;
        private SoundPlayer player = new SoundPlayer();

        /// <summary>
        /// Tworzy nowy keyboard
        /// </summary>
        /// <param name="mainForm">Forma, na której malowany ma być keyboard</param>
        /// <param name="position">Pozycja na formie, na której ma być malowany keyboard</param>
        public Keyboard(MainForm mainForm, Point position)
        {
            this.position = position;

            for (int i = 0; i < keys.Length; ++i)
            {
                keys[i] = new Key(mainForm, new Point(Key.Size.Width * i + position.X, position.Y), i*1000 - 10000);
            }
            mainForm.MouseDown += new MouseEventHandler(OnMouseDown);
            mainForm.MouseUp += new MouseEventHandler(OnMouseUp);
            mainForm.MouseMove += new MouseEventHandler(OnMouseMove);
            mainForm.Paint += new PaintEventHandler(Draw);
        }

        /// <summary>
        /// Reakcja na kliknięcie myszką na formie
        /// </summary>
        /// <param name="e"></param>
        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Key key in keys)
                {
                    key.checkIsPushed(e.Location);
                    if (key.isPushed)
                    {
                        player.Play(key.Sound);
                    }
                }
            }
        }

        /// <summary>
        /// Reakcja na puszczenie klawisza myszy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Key key in keys)
                {
                    key.setIsPushed();
                }
            }
        }

        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            OnMouseDown(sender, e);
        }

        /// <summary>
        /// Metoda wymagana do pierwszego malowania klawiatury oraz malowania jej, podczas zmiany rozmiaru okna, minimalizacji itp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="p"></param>
        public void Draw(object sender, PaintEventArgs p)
        {
            foreach (Key key in keys)
            {
                key.Draw();
            }
        }
    }
}
