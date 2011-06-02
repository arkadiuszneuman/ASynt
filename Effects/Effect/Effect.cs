using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASynt.Keyboard;

namespace ASynt.Effects.Effect
{
    public abstract class Effect
    {
        protected Key[] keys;

        protected Effect(Keyboard.Keyboard keyboard)
        {
            keys = keyboard.AllKeys;
        }

        /// <summary>
        /// Zwraca ilość efektów
        /// </summary>
        public abstract int EffectsCount { get; }

        /// <summary>
        /// Dodaje nowy efekt
        /// </summary>
        /// <param name="d">Kluczami w słowniku są odpowiednie parametry (np. WetDryFx, Feedback), a wartościami są odpowiednie wartości tych parametrów</param>
        public abstract void Add(Dictionary<string, float> d);

        /// <summary>
        /// Edytuje dany efekt
        /// </summary>
        /// <param name="d">Kluczami w słowniku są odpowiednie parametry (np. WetDryFx, Feedback), a wartościami są odpowiednie wartości tych parametrów
        /// Pierwszy klucz to zawsze "which" - mówi on, który efekt trzeba edytować</param>
        public abstract void Edit(Dictionary<string, float> d);

        /// <summary>
        /// Usunięcie efektu
        /// </summary>
        /// <param name="which">Nr. efektu do usunięcia</param>
        public abstract void Delete(int which);
    }
}
