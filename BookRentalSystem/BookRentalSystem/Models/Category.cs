using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalSystem.Models
{
    /// <summary>
    /// Contains all information about a category
    /// </summary>
    class Category
    {
        #region Properties
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        #endregion
    }
}
