using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX
{
    /// <summary>
    /// 
    /// </summary>
    public class SFXGun : SFXWeapon
    {
        //=================================
        // SerializeField
        //=================================
        [SerializeField] private SFXBarrel m_barrel = default;
        [SerializeField] private SFXMagazine m_magazine = default;
        [SerializeField] private SFXGrip m_grip = default;

        //=================================
        // Method
        //=================================

        public override void Setup()
        {
            m_barrel.Setup();
            m_grip.Setup();
            m_magazine.Setup();
        }

        /// <summary>
        /// 発射
        /// </summary>
        public override ISFXPlayback Fire( ISFXAmmo ammo )
        {
            if (!m_grip.CanGrip())
            {
                // 打てない状況なら無視
                return default;
            }
            if (m_magazine.IsEmpty())
            {
                // 空なら無理
             ///   return default;
            }
            return m_barrel.Fire(this, ammo);
        }

        /// <summary>
        /// 返還
        /// </summary>
        public override void Return(ISFXPlayback op)
        {
            m_barrel.Return(op);
            m_magazine.Push();
        }
    }
}
