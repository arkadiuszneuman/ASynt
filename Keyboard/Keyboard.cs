using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using ASynt.Player;
using Un4seen.Bass;
using System.IO;
using System.Timers;
using System.Windows.Forms;

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

        private static List<KeySequence> keySequence = new List<KeySequence>();
        private System.Timers.Timer timer = new System.Timers.Timer();
        private static bool isRecording = false;
        private static DateTime startRecordingTime = new DateTime();
        private ulong timeCounter = 0;

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

            timer.Interval = 10;
            timer.Elapsed += new ElapsedEventHandler(timer_Tick);
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
                        //keySequence.Add(new KeySequence(1, Convert.ToByte(i)));
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

        public void SaveSequence()
        {
            StreamWriter sw = new StreamWriter("test.txt");

            foreach (KeySequence keyS in keySequence)
            {
                sw.WriteLine(keyS.ToString());                
            }

            sw.Close();
        }

        public void ReadSequence()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "TXT files (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] line;
                StreamReader sr = new StreamReader(fileDialog.FileName);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine().Split(';');
                    //keySequence.Add(new KeySequence(ulong.Parse(line[0]), byte.Parse(line[1])));
                }

                sr.Close();
            }
        }

        public void PlaySequence()
        {
            foreach (KeySequence keyS in keySequence)
            {
                //player.Play(AllKeys[Convert.ToInt16(keyS.key)].KeySound);
                //Thread.Sleep(500);
            }
        }

        public void Record()
        {
            timer.Start();
            isRecording = true;
            startRecordingTime = DateTime.Now;
            
        }

        public void Stop()
        {
            timer.Stop();
            if (isRecording)
            {
                timeCounter = 0;
                isRecording = false;
            }
        }

        public static void SaveKey(DateTime dateTime, Keys key)
        {
            if (isRecording)
            {
                keySequence.Add(new KeySequence(startRecordingTime - dateTime, key));
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isRecording)
            {
                /*for (int i = 0; i < keys.Length; ++i)
                {
                    if (keys[1].IsNotSavedToTimer)
                    {
                        keys[1].IsNotSavedToTimer = false;
                        keySequence.Add(new KeySequence(timeCounter, (byte)keys[1].KeyboardKey));
                    }
                }*/

                ++timeCounter;
            }
        }
    }
}
