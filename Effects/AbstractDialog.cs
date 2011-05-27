using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASynt.Effects.Effect;

namespace ASynt.Effects
{

    //zabawa z debugami jest tutaj w celu odpowiedniego wyświetlenia dialogów dziedziczących w designerze
    //nie mogą one być wyświetlona jeśli klasa bazowa jest abstrakcyjna
#if DEBUG
    public partial class AbstractDialog : Form
#else
    /// <summary>
    /// Okienko abstrakcyjne, przygotowane do dodawania nowych efektów
    /// </summary>
    public abstract partial class AbstractDialog : Form
#endif
    {
        /// <summary>
        /// Strona efektu, na której aktualnie użytkownik się znajduje
        /// </summary>
        protected int page;
        /// <summary>
        /// Instancja efektu, na którym będą wykonywane operacje.
        /// </summary>
        protected Effect.Effect effect;

#if DEBUG
        protected virtual string ProportiesName { get { throw new NotImplementedException(); } }
        protected virtual string EffectName { get { throw new NotImplementedException(); } }
        protected virtual void UpdateControls() { throw new NotImplementedException(); }
        protected virtual void EditEffect() { throw new NotImplementedException(); }
        protected virtual void AddEffect() { throw new NotImplementedException(); }
        protected virtual void ResetControls() { throw new NotImplementedException(); }

#else
        /// <summary>
        /// Nazwa właściwości np. "Właściwości echa"
        /// </summary>
        protected abstract string ProportiesName { get; }
        /// <summary>
        /// Nazwa efektu np. "echo"
        /// </summary>
        protected abstract string EffectName { get; }
        /// <summary>
        /// Uaktualnienie kontrolek po przełączeniu się na następny/poprzedni efekt lub podczas ponownego otwarcia okienka
        /// </summary>
        protected abstract void UpdateControls();
        /// <summary>
        /// Metoda, która edytuje efekt
        /// </summary>
        protected abstract void EditEffect();
        /// <summary>
        /// Metoda, która dodaje efekt
        /// </summary>
        protected abstract void AddEffect();
        /// <summary>
        /// Metoda, która ustawia wszystkie kontrolki w stan początkowy (najczęściej 0)
        /// </summary>
        protected abstract void ResetControls();
#endif

        /// <summary>
        /// Konstruktor potrzebny do Designera w VS
        /// </summary>
        protected AbstractDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda ta musi być wywołana dopiero po wywołaniu konstruktora oraz InitializeComponent z klasy dziedziczącej, inicjalizuje kontrolki na samym początku
        /// </summary>
        protected void Init()
        {
            page = effect.EffectsCount;

            if (effect.EffectsCount > 0)
            {
                groupBoxEchoProporties.Text = ProportiesName + " " + page + "/" + effect.EffectsCount;
                if (effect.EffectsCount > 1)
                    buttonPrevious.Enabled = true;

                panelNoEffect.Visible = false;
                UpdateControls();
            }
            else
            {
                panelNoEffect.BringToFront();
                panelNoEffect.Visible = true;
                buttonAddEcho.Text = "Dodaj " + EffectName;
                buttonNext.Enabled = false;
                buttonDeleteEcho.Enabled = false;
            }
        }


        /// <summary>
        /// Reakcja na zmianę trackbarów lub checkboksa - napisanie na labelu aktualnej wartości trackbara + zastosowanie ustawień w efekcie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void trackBarValueChanged(object sender, EventArgs e)
        {
            if (sender is TrackBar)
            {
                TrackBar track = (TrackBar)sender;
                String label = "labelHow" + track.Name.Substring(8);

                foreach (Control c in panelProporties.Controls)
                {
                    if (c.Name == label)
                    {
                        c.Text = track.Value.ToString();
                    }
                }
            }

            if (page - 1 < effect.EffectsCount) //zeby nie wywalał błędu przy wchodzeniu tutaj po naciśnięciu przycisku następny
            {
                EditEffect();
            }
        }

        /// <summary>
        /// Reakcja na dodanie nowego efektu - ukrycie panelu z przyciskiem dodaj echo i wyświetlenie odpowiedniego panelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddEffect_Click(object sender, EventArgs e)
        {
            panelNoEffect.Visible = false;
            buttonNext.Enabled = true;
            buttonDeleteEcho.Enabled = true;

            AddEffect();

            if (page == 0)
                page = 1;

            groupBoxEchoProporties.Text = ProportiesName + " " + page + "/" + effect.EffectsCount;
        }

        /// <summary>
        /// Reakcja na kliknięcie przycisku Następny - odpowiednie ustawienie/uaktualnienie kontrolek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            ++page;
            groupBoxEchoProporties.Text = ProportiesName + " " + page + "/" + effect.EffectsCount;

            if (page > 1)
                buttonPrevious.Enabled = true;

            if (page > effect.EffectsCount)
            {
                buttonNext.Enabled = false;
                panelNoEffect.Visible = true;
                panelNoEffect.BringToFront();
                buttonDeleteEcho.Enabled = false;

                ResetControls();
            }
            else
            {
                UpdateControls();
            }
        }

        /// <summary>
        /// Reakcja na kliknięcie przycisku Poprzedni - odpowiednie ustawienie/uaktualnienie kontrolek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            --page;
            if (page == 1)
                buttonPrevious.Enabled = false;

            panelNoEffect.Visible = false;
            buttonNext.Enabled = true;
            buttonDeleteEcho.Enabled = true;

            groupBoxEchoProporties.Text = ProportiesName + " " + page + "/" + effect.EffectsCount;

            UpdateControls();
        }

        /// <summary>
        /// Reakcja na kliknięcie przycisku Usuń - odpowiednie uaktualnienie kontrolek oraz usunięcie efektu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteEcho_Click(object sender, EventArgs e)
        {
            effect.Delete(page-1);

            if (page > 1)
                buttonPrevious_Click(null, null);
            else
            {
                if (effect.EffectsCount == 0)
                {
                    --page;
                    panelNoEffect.Visible = true;
                    buttonNext.Enabled = false;
                    buttonDeleteEcho.Enabled = false;

                    groupBoxEchoProporties.Text = ProportiesName + " " + page + "/" + effect.EffectsCount;
                }
                else
                {
                    groupBoxEchoProporties.Text = ProportiesName + " " + page + "/" + effect.EffectsCount;
                    UpdateControls();
                }
            }
        } 
    }
}
