using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalSystem.Models
{
    /// <summary>
    /// Contains all information about an author
    /// </summary>
    class clsAuthor
    {
        #region Properties
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        #endregion
    }
}
