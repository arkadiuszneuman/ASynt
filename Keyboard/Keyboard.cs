using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using ASynt.Player;
using Un4seen.Bass;

namespace ASynt.Keyboard
{
    public class Keyboard
    {
        public Key[] keys = new Key[7];
        public Key[] smallKeys = new Key[5];
        public Key[] AllKeys
        {
            get
            {
                Key[] k = new Key[keys.Length + smallKeys.Length];
                keys.CopyTo(k, 0);
                smallKeys.CopyTo(k, 7);

                return k;
            }
        }

        private Point position;
        private SoundPlayer player = new SoundPlayer();

        private List<BASS_DX8_ECHO> echo = new List<BASS_DX8_ECHO>();
        private List<int> echoHandles = new List<int>();
        public List<BASS_DX8_ECHO> Echo { get { return echo; } }

        /// <summary>
        /// Tworzy nowy keyboard
        /// </summary>
        /// <param name="mainForm">Forma, na której malowany ma być keyboard</param>
        /// <param name="position">Pozycja na formie, na której ma być malowany keyboard</param>
        public Keyboard(MainForm mainForm, Point position)
        {
            this.position = position;
            char[] keyLettersBig = { 'A', 'S', 'D', 'F', 'G', 'H', 'J' }; //literki, pod którymi będą grały klawisze białe
            char[] keyLettersSmall = { 'W', 'E', 'T', 'Y', 'U' }; //literki, pod jakimi będą grały klawisze czarne
            int keyWidth = 40;

            for (int i = 0; i < keys.Length; ++i)
            {
                int l = i; //dodawanie do literki
                if ('c' + l > 'g')
                    l -= 7;
                keys[i] = new Key(mainForm, new Point(keyWidth * i + position.X, position.Y), (Keys)keyLettersBig[i], @"Piano\" + (char)('c' + l));
            }

            smallKeys[0] = new Key(mainForm, new Point(keyWidth * 1 + position.X, position.Y), (Keys)keyLettersSmall[0], @"Piano\c#", true);
            smallKeys[1] = new Key(mainForm, new Point(keyWidth * 2 + position.X, position.Y), (Keys)keyLettersSmall[1], @"Piano\d#", true);
            smallKeys[2] = new Key(mainForm, new Point(keyWidth * 4 + position.X, position.Y), (Keys)keyLettersSmall[2], @"Piano\f#", true);
            smallKeys[3] = new Key(mainForm, new Point(keyWidth * 5 + position.X, position.Y), (Keys)keyLettersSmall[3], @"Piano\g#", true);
            smallKeys[4] = new Key(mainForm, new Point(keyWidth * 6 + position.X, position.Y), (Keys)keyLettersSmall[4], @"Piano\a#", true);

            mainForm.MouseDown += new MouseEventHandler(OnMouseDown);
            mainForm.MouseUp += new MouseEventHandler(OnMouseUp);
            mainForm.MouseMove += new MouseEventHandler(OnMouseDown);
            mainForm.Paint += new PaintEventHandler(Draw);
            mainForm.KeyDown += new KeyEventHandler(KeyDown);
            mainForm.KeyUp += new KeyEventHandler(KeyUp);
        }

        #region Eventy myszy

        /// <summary>
        /// Reakcja na kliknięcie myszką na formie
        /// </summary>
        /// <param name="e"></param>
        private void OnMouseDown(object sender, MouseEventArgs e)
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
                                //keys[i].Draw();
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
        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < keys.Length; ++i)
                {
                    keys[i].IsPushed = false;

                    foreach (Key key in smallKeys)
                    {
                        key.Draw();
                        key.IsPushed = false;
                    }
                }
            }
        }

        #endregion

        #region Eventy Klawiatury

        private void KeyDown(object sender, KeyEventArgs keyEvent)
        {
            foreach (Key key in keys)
            {
                if (keyEvent.KeyCode == key.KeyboardKey && !key.IsPushed)
                {
                    key.IsPushed = true;
                    key.Draw();

                    player.Play(key.KeySound);
                }
            }

            foreach (Key key in smallKeys)
            {
                if (keyEvent.KeyCode == key.KeyboardKey && !key.IsPushed)
                {
                    key.IsPushed = true;

                    player.Play(key.KeySound);
                }

                key.Draw(); //odmalowywanie czarnych klawiszy, zeby biale klawisze nie zasonily czarnego podczas zmiany swojego stanu (nacisniecia)
            }
        }

        private void KeyUp(object sender, KeyEventArgs keyEvent)
        {
            foreach (Key key in keys)
            {
                if (keyEvent.KeyCode == key.KeyboardKey)
                {
                    key.IsPushed = false;
                    key.Draw();
                }
            }

            foreach (Key key in smallKeys)
            {
                if (keyEvent.KeyCode == key.KeyboardKey)
                {
                    key.IsPushed = false;
                }

                key.Draw(); //odmalowywanie czarnych klawiszy, zeby biale klawisze nie zasonily czarnego podczas zmiany swojego stanu (puszczenia)
            }
        }

        #endregion

        /// <summary>
        /// Metoda wymagana do pierwszego malowania klawiatury oraz malowania jej, podczas zmiany rozmiaru okna, minimalizacji itp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="p"></param>
        private void Draw(object sender, PaintEventArgs p)
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

        /// <summary>
        /// Dodaje echo do streama
        /// </summary>
        /// <param name="wetDryMix"></param>
        /// <param name="feedback"></param>
        /// <param name="leftDelay"></param>
        /// <param name="rightDelay"></param>
        /// <param name="panDelay"></param>
        public void AddEcho(float wetDryMix, float feedback, float leftDelay, float rightDelay, bool panDelay)
        {
            echo.Add(new BASS_DX8_ECHO(wetDryMix, feedback, leftDelay, rightDelay, panDelay));
            foreach (Key key in keys)
            {
                echoHandles.Add(Bass.BASS_ChannelSetFX(key.KeySound.Stream, BASSFXType.BASS_FX_DX8_ECHO, 1));
                if (echoHandles.Last() == 0)
                {
                    throw new Exception("Błąd ustawienia echa: " + Bass.BASS_ErrorGetCode());
                }

                Bass.BASS_FXSetParameters(echoHandles.Last(), echo.Last());
            }

            foreach (Key key in smallKeys)
            {
                echoHandles.Add(Bass.BASS_ChannelSetFX(key.KeySound.Stream, BASSFXType.BASS_FX_DX8_ECHO, 1));
                if (echoHandles.Last() == 0)
                {
                    throw new Exception("Błąd ustawienia echa: " + Bass.BASS_ErrorGetCode());
                }

                Bass.BASS_FXSetParameters(echoHandles.Last(), echo.Last());
            }
        }

        public void EditEcho(int which, float wetDryMix, float feedback, float leftDelay, float rightDelay, bool panDelay)
        {
            echo[which].fWetDryMix = wetDryMix;
            echo[which].fFeedback = feedback;
            echo[which].fLeftDelay = leftDelay;
            echo[which].fRightDelay = rightDelay;
            echo[which].lPanDelay = panDelay;

            for (int i = which * 12; i < which * 12 + 12; ++i)
                Bass.BASS_FXSetParameters(echoHandles[i], echo[which]);
        }

        public void DeleteEcho(int which)
        {
            for (int i = 0; i < AllKeys.Length; ++i)
            {
                Bass.BASS_ChannelRemoveFX(AllKeys[i].KeySound.Stream, echoHandles[i + which * 12]);
            }

            echo.RemoveAt(which);
            echoHandles.RemoveRange(which * 12, 11);
        }
    }
}
