using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnhancedOasis.Models
{
    public class ActiveAccount
    {
        private int _ID = 0;
        private string _FirstName = "";

        public int ID { get { return _ID; } set {  _ID = value; } }
        public string FirstName { get { return _FirstName; } set {  _FirstName = value; } }

        public ActiveAccount() { 

        }
    }
}
