using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_og_dokumentation
{
    /// <summary>
    /// Repræsenterer et produkt med et navn og en pris.
    /// </summary>
    internal class Product
    {
        /// <summary>
        /// Henter navnet på produktet.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Henter eller angiver prisen på produktet.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Initialiserer et nyt produkt.
        /// </summary>
        /// <param name="name">Produktets navn.</param>
        /// <param name="price">Produktets pris.</param>
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Returnerer en tekstbaseret repræsentation af produktet.
        /// </summary>
        /// <returns>Produktets navn og pris som tekst.</returns>
        public override string ToString()
        {
            return $"{Name} - {Price} kr.";
        }
    }
}
