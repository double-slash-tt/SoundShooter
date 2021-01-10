using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX
{
    /// <summary>
    /// 発射条件管理
    /// </summary>
    public abstract class SFXGrip : ScriptableObject
    {
        /// <summary>
        /// 初期化
        /// </summary>
        public virtual void Setup()
        {
        }
        /// <summary>
        /// 撃てるかどうか
        /// </summary>
        /// <returns></returns>
        public abstract bool CanGrip();
        /// <summary>
        /// 発射
        /// </summary>
        public abstract void Press();
    }
}
