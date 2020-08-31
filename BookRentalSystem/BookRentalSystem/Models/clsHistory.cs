using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalSystem.Models
{
    /// <summary>
    /// Contains all information about a history
    /// </summary>
    class clsHistory
    {
        #region Properties
        public int HistoryId { get; set; }
        public int BookId { get; set; }
        public int AccountId { get; set; }
        public DateTime RentDate { get; set; }
        #endregion
    }
}
