using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Auto
    {
        int id, mittariLukema, autonMerkkiId, autonMalliId, varitId, polttoAineId;
        decimal hinta, moottorinTilavuus;
        DateTime rekisteriPaivamaara;

        public int Id { get => id; set => id = value; }
        public int MittariLukema { get => mittariLukema; set => mittariLukema = value; }
        public int AutonMerkkiId { get => autonMerkkiId; set => autonMerkkiId = value; }
        public int AutonMalliId { get => autonMalliId; set => autonMalliId = value; }
        public int VaritId { get => varitId; set => varitId = value; }
        public int PolttoAineId { get => polttoAineId; set => polttoAineId = value; }
        public decimal Hinta { get => hinta; set => hinta = value; }
        public decimal MoottorinTilavuus { get => moottorinTilavuus; set => moottorinTilavuus = value; }
        public DateTime RekisteriPaivamaara { get => rekisteriPaivamaara; set => rekisteriPaivamaara = value; }
    }
}
