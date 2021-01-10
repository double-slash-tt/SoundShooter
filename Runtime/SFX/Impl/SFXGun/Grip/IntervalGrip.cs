using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX.Impl
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class IntervalGrip : SFXGrip
    {
        //====================================
        // Field
        //====================================
        [SerializeField] private float m_intervalTime = 1f;

        //====================================
        // Field
        //====================================
        [NonSerialized] private float m_lastPressTime = 0f;

        //====================================
        // Method
        //====================================

        public override bool CanGrip()
        {
            var t = Time.time - m_lastPressTime;

            return t < m_intervalTime;
        }

        public override void Press()
        {
            m_lastPressTime = Time.time;
        }
    }
}
