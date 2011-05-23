using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASynt
{
    public partial class EchoDialog : Form
    {
        private Keyboard.Keyboard keyboard;
        private int page;

        public EchoDialog(Keyboard.Keyboard keyboard)
        {
            InitializeComponent();

            this.keyboard = keyboard;
            page = keyboard.Echo.Count;

            if (keyboard.Echo.Count > 0)
            {
                groupBoxEchoProporties.Text = "Właściwości echa " + page + "/" + keyboard.Echo.Count;
                if (keyboard.Echo.Count > 1)
                    buttonPrevious.Enabled = true;

                panelNoEcho.Visible = false;
                UpdateControls();
            }
            else
            {
                panelNoEcho.Visible = true;
                buttonNext.Enabled = false;
                buttonDeleteEcho.Enabled = false;
            }
        }



        /// <summary>
        /// Reakcja na zmianę trackbarów lub checkboksa - napisanie na labelu aktualnej wartości trackbara + zastosowanie ustawień
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarValueChanged(object sender, EventArgs e)
        {
            if (sender is TrackBar)
            {
                TrackBar track = (TrackBar)sender;
                String label = "labelHow" + track.Name.Substring(8);

                foreach (Control c in panelEchoProporties.Controls)
                {
                    if (c.Name == label)
                    {
                        c.Text = track.Value.ToString();
                    }
                }
            }

            if (page-1 < keyboard.Echo.Count) //zeby nie wywalał błędu przy wchodzeniu tutaj po naciśnięciu przycisku następny
                keyboard.EditEcho(page-1, trackBarWet.Value, trackBarFeedback.Value, trackBarLeftDelay.Value, trackBarRightDelay.Value, checkBoxPanDelay.Checked);
        }

        /// <summary>
        /// Reakcja na dodanie nowego echa - ukrycie panelu z przyciskiem dodaj echo i wyświetlenie odpowiedniego panelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddEcho_Click(object sender, EventArgs e)
        {
            panelNoEcho.Visible = false;
            buttonNext.Enabled = true;
            buttonDeleteEcho.Enabled = true;

            keyboard.AddEcho(trackBarWet.Value, trackBarFeedback.Value, trackBarLeftDelay.Value, trackBarRightDelay.Value, checkBoxPanDelay.Checked);
            if (page == 0)
                page = 1;

            groupBoxEchoProporties.Text = "Właściwości echa " + page + "/" + keyboard.Echo.Count;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ++page;
            groupBoxEchoProporties.Text = "Właściwości echa " + page + "/" + keyboard.Echo.Count;

            if (page > 1)
                buttonPrevious.Enabled = true;

            if (page > keyboard.Echo.Count)
            {
                buttonNext.Enabled = false;
                panelNoEcho.Visible = true;
                buttonDeleteEcho.Enabled = false;

                trackBarWet.Value = 0;
                trackBarFeedback.Value = 0;
                trackBarLeftDelay.Value = 1;
                trackBarRightDelay.Value = 1;
                checkBoxPanDelay.Checked = false;
            }
            else
            {
                UpdateControls();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            --page;
            if (page == 1)
                buttonPrevious.Enabled = false;

            panelNoEcho.Visible = false;
            buttonNext.Enabled = true;
            buttonDeleteEcho.Enabled = true;

            groupBoxEchoProporties.Text = "Właściwości echa " + page + "/" + keyboard.Echo.Count;

            UpdateControls();
        }

        private void UpdateControls()
        {
            int wet = (int)keyboard.Echo[page - 1].fWetDryMix;
            int feed = (int)keyboard.Echo[page - 1].fFeedback;
            int left = (int)keyboard.Echo[page - 1].fLeftDelay;
            int right = (int)keyboard.Echo[page - 1].fRightDelay;
            bool check = keyboard.Echo[page - 1].lPanDelay;
            trackBarWet.Value = wet;
            trackBarFeedback.Value = feed;
            trackBarLeftDelay.Value = left;
            trackBarRightDelay.Value = right;
            checkBoxPanDelay.Checked = check;
        }

        private void buttonDeleteEcho_Click(object sender, EventArgs e)
        {
            keyboard.DeleteEcho(page-1);

            if (page > 1)
                buttonPrevious_Click(null, null);
            else
            {
                --page;
                panelNoEcho.Visible = true;
                buttonNext.Enabled = false;
                buttonDeleteEcho.Enabled = false;

                groupBoxEchoProporties.Text = "Właściwości echa " + page + "/" + keyboard.Echo.Count;
            }
        } 
    }
}
