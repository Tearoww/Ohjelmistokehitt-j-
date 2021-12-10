using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class AutoMerkki
    {
        int id;
        string merkkiNimi;

        public int Id { get => id; set => id = value; }
        public string MerkkiNimi { get => merkkiNimi; set => merkkiNimi = value; }
    }
}
