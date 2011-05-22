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
        private Key[] keys = new Key[7];
        private Key[] smallKeys = new Key[5];
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
                keys[i] = new Key(mainForm, new Point(20 * i + position.X, position.Y), @"piano1\" + (char)('a'+i));
            }

            smallKeys[0] = new Key(mainForm, new Point(20 * 1 + position.X, position.Y), @"piano1\a#", true);
            smallKeys[1] = new Key(mainForm, new Point(20 * 3 + position.X, position.Y), @"piano1\c#", true);
            smallKeys[2] = new Key(mainForm, new Point(20 * 4 + position.X, position.Y), @"piano1\d#", true);
            smallKeys[3] = new Key(mainForm, new Point(20 * 6 + position.X, position.Y), @"piano1\f#", true);
            smallKeys[4] = new Key(mainForm, new Point(20 * 6 + position.X, position.Y), @"piano1\g#", true);

            mainForm.MouseDown += new MouseEventHandler(OnMouseDown);
            mainForm.MouseUp += new MouseEventHandler(OnMouseUp);
            mainForm.MouseMove += new MouseEventHandler(OnMouseDown);
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
                foreach (Key key in smallKeys)
                {
                    bool check = key.IsPushed; //zapamietanie czy key był wciśniety wcześniej (key.checkIsPushed zmienia key.isPushed na true
                    if (key.checkIsPushed(e.Location))
                    {
                        if (!check)
                            player.Play(key.KeySound); //jeśli przed sprawdzeniem czy key jest wciśniety key był wciśnięty to nie można odtworzyć dźwięku

                        for (int i = 0; i < keys.Length; ++i) //odmalowanie wszystkich knefli na wypadek szorowania myszką po klawiaturze
                        {
                            if (keys[i].IsPushed)
                            {
                                keys[i].IsPushed = false;
                                keys[i].Draw();
                            }

                            foreach (Key other in smallKeys)
                            {
                                other.Draw();
                            }
                        }

                        return;
                    }
                }

                for (int i = 0; i < keys.Length; ++i)
                {
                    if (!keys[i].IsPushed && keys[i].checkIsPushed(e.Location))
                    {
                        for (int y = 0; y < keys.Length; ++y)
                        {
                            keys[y].checkIsPushed(e.Location);
                        }

                        foreach (Key key in smallKeys)
                        {
                            key.Draw();
                        }
                        
                        player.Play(keys[i].KeySound);
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
                for (int i = 0; i < keys.Length; ++i)
                {
                    keys[i].setIsPushed();

                    foreach (Key key in smallKeys)
                    {
                        key.Draw();
                        key.setIsPushed();
                    }
                }
            }
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

            foreach (Key key in smallKeys)
            {
                key.Draw();
            }
        }
    }
}
