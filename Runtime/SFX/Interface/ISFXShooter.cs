using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    public interface ISFXShooter : ISoundShooter
    {
        void Fire(ISFXWeapon weapon, ISFXAmmo ammo);
        void Shot(ISFXPlayback playback);
    }
}
