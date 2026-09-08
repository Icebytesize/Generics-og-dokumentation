using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_og_dokumentation
{
        /// <summary>
        /// Repræsenterer en generisk samling af elementer.
        /// </summary>
        /// <typeparam name="T">Typen af elementer, som samlingen indeholder.</typeparam>
        public class Collection<T>
        {
            private List<T> _items;

            /// <summary>
            /// Initialiserer en ny tom samling.
            /// </summary>
            public Collection()
            {
                _items = new List<T>();
            }

            /// <summary>
            /// Returnerer antallet af elementer i samlingen.
            /// </summary>
            public int Count
            {
                get { return _items.Count; }
            }

            /// <summary>
            /// Tilføjer et element til samlingen.
            /// </summary>
            /// <param name="element">Elementet, der skal tilføjes.</param>
            public void Add(T element)
            {
                _items.Add(element);
            }

            /// <summary>
            /// Fjerner et element fra samlingen, hvis det findes.
            /// </summary>
            /// <param name="element">Elementet, der skal fjernes.</param>
            /// <returns>
            /// True hvis elementet blev fjernet, ellers false.
            /// </returns>
            public bool Remove(T element)
            {
                return _items.Remove(element);
            }

            /// <summary>
            /// Finder det første element, der opfylder den angivne betingelse.
            /// </summary>
            /// <param name="predicate">
            /// En betingelse, der bruges til at finde et element.
            /// </param>
            /// <returns>
            /// Det første element, der opfylder betingelsen, eller default hvis intet element matcher.
            /// </returns>
            public T? Find(Func<T, bool> predicate)
            {
                foreach (T item in _items)
                {
                    if (predicate(item))
                    {
                        return item;
                    }
                }

                return default;
            }
        }
}
