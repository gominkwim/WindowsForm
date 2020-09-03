using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalSystem.Models
{
    /// <summary>
    /// Conatins all information about an account
    /// </summary>
    class Account
    {
        #region Properties
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        #endregion

        #region Methods

        #endregion

        #region Exception handler

        #endregion
    }
}
