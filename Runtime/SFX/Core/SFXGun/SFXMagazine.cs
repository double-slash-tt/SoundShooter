using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX
{
    /// <summary>
    /// 弾数管理
    /// </summary>
    public abstract class SFXMagazine : ScriptableObject
    {
        //====================================
        // Method
        //====================================

        public virtual void Setup() { }

        public abstract void Pop();
        public abstract void Push();

        public abstract bool IsEmpty();
    }
}
