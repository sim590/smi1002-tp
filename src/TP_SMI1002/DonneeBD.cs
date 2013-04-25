using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    abstract class DonneeBD
    {
        protected int id;

        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}
