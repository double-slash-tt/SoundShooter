using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX
{
    /// <summary>
    /// 再生用マシン
    /// </summary>
    public abstract class SFXWeapon : ScriptableObject, ISFXWeapon
    {
        /// <summary>
        /// 初期化
        /// </summary>
        public virtual void Setup() { }

        /// <summary>
        /// 発射
        /// </summary>
        public abstract void Fire(ISFXShooter shooter, ISFXAmmo ammo);

        /// <summary>
        /// 返還
        /// </summary>
        public abstract void Return( ISFXPlayback op );
    }
}
