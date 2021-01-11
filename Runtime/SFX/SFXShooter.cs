using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    internal static partial class SFXShooter
    {
        //=================================
        // Property
        //=================================
        private static ISFXShooter Shooter { get; set; }

        //=================================
        // Method
        //=================================
        internal static void Fire(ISFXWeapon weapon, ISFXAmmo ammo)
        {
            Shooter?.Fire(weapon, ammo);
        }
    }
}
