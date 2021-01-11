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
        /// 初期化
        /// </summary>
        public virtual void Setup() { }
        /// <summary>
        /// 発射
        /// </summary>
        /// <param name="ammo"></param>
        public abstract ISFXOperation Fire(ISFXWeapon weapon, ISFXAmmo ammo);
        /// <summary>
        /// 返還
        /// </summary>
        public abstract void Return(ISFXOperation op);
    }
    public abstract class SFXBarrel<TAmmo> : SFXBarrel where TAmmo : SFXAmmo
    {
        public sealed override ISFXOperation Fire(ISFXWeapon weapon, ISFXAmmo ammo)
        {
            if (ammo is TAmmo tAmmo)
            {
                return DoFire(weapon, tAmmo);
            }
            return default;
        }
        protected abstract ISFXOperation DoFire(ISFXWeapon weapon, TAmmo ammo);

        public sealed override void Return(ISFXOperation op)
        {
            DoReturn(op);
        }
        public abstract void DoReturn(ISFXOperation op);
    }
}
