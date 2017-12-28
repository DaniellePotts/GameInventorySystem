using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// this exception is thrown when the user attempts to equip more then one weapon at a time
    /// </summary>
    class EquipWeaponException : Exception
    {
        private const String msg = "You can only equip one weapon at a time!";

        public EquipWeaponException() : base(msg) { }
    }
}
