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
        public void Fire( SFXAmmo ammo )
        {
            if (!m_grip.CanGrip())
            {
                // 打てない状況なら無視
                return;
            }
            if (m_magazine.IsEmpty())
            {
                // 空なら無理
                return;
            }
            // 発射処理
            m_magazine.Pop();
            m_grip.Press();
            m_barrel.Fire( ammo );
        }
    }
}
