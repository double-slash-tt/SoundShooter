using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX
{
    public abstract class SFXBarrel : ScriptableObject
    {
        //===========================================
        // Method
        //===========================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ammo"></param>
        public abstract void Fire(SFXAmmo ammo);

        public virtual void Setup() { }
    }
    public abstract class SFXBarrel<TAmmo> : SFXBarrel where TAmmo : SFXAmmo
    {
        public sealed override void Fire(SFXAmmo ammo)
        {
            if (ammo is TAmmo tAmmo )
            {
                DoFire( tAmmo);
            }
        }

        protected abstract void DoFire(TAmmo ammo);
    }
}
