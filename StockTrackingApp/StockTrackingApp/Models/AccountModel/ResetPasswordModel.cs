using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackingApp.Models.AccountModel
{
    public class ResetPasswordModel
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
