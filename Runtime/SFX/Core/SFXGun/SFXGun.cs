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
    }
}
