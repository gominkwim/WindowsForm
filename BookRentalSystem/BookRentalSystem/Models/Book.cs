using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalSystem.Models
{
    /// <summary>
    /// Contains all information about a book
    /// </summary>
    class Book
    {
        #region Properties
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int CategoryId { get; set; }
        public string Barcode { get; set; }
        public bool Available { get; set; }
        #endregion

        #region Methods

        #endregion

        #region Exception handler

        #endregion
    }
}
