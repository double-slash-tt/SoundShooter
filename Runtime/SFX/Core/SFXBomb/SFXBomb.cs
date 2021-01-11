using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    public class SFXBomb : SFXWeapon
    {
        public override ISFXOperation Fire(ISFXAmmo ammo)
        {
            throw new NotImplementedException();
        }

        public override void Return(ISFXOperation op)
        {
        }
    }
}
