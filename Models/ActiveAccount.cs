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
        private string _Filter = "";

        public int ID { get { return _ID; } set {  _ID = value; } }
        public string FirstName { get { return _FirstName; } set {  _FirstName = value; } }
        public string Filter { get { return _Filter; } set { _Filter = value; } }
        public ActiveAccount() { 

        }
    }
}
