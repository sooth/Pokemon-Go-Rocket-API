using Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo
{
    class Program
    {

        public Account GetFreeAccount()
        {
            DataContext db = new DataContext();
            Account free = db.Accounts.Where(x => x.CheckedOut == false).FirstOrDefault();
            return free;
        }



        static void Main(string[] args)
        {
        
        }
    }
}
