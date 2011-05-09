using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Un4seen.Bass;
using System.Threading;


namespace ASynt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
                {
                    // create a stream channel from a file
                    int stream = Bass.BASS_StreamCreateFile(Environment.CurrentDirectory + @"\samples\piano.wav", 0, 0, BASSFlag.BASS_DEFAULT);
                    Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_FREQ, 100000); //od 100 do 100000
                    if (stream != 0)
                    {
                        // play the stream channel
                        Bass.BASS_ChannelPlay(stream, false);
                    }
                    else
                    {
                        // error creating the stream
                        Console.WriteLine("Stream error: {0}", Bass.BASS_ErrorGetCode());
                    }

                    // wait for a key
                    Console.WriteLine("Press any key to exit");
                    //Console.ReadKey(false);
                    Thread.Sleep(200);
                   

                    // free the stream
                    //Bass.BASS_StreamFree(stream);
                    // free BASS
                    //Bass.BASS_Free();
                }

            }
        }
    }
}
