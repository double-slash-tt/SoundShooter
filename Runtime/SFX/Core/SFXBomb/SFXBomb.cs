using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    public class SFXBomb : SFXWeapon
    {
        public override void Fire(ISFXShooter shooter, ISFXAmmo ammo)
        {
            throw new NotImplementedException();
        }

        public override void Return(ISFXPlayback op)
        {
        }
    }
}
