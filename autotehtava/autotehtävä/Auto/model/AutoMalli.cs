using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class AutoMalli
    {
        int id, merkkiId;
        string malliNimi;

        public int Id { get => id; set => id = value; }
        public int MerkkiId { get => merkkiId; set => merkkiId = value; }
        public string MalliNimi { get => malliNimi; set => malliNimi = value; }
    }
}
