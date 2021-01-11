using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX
{
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(SFX) + "/" + nameof(SFXTrigger))]
    public class SFXTrigger : ScriptableObject
    {
        //=========================================
        // SerializeField
        //=========================================
        [SerializeField] private SFXAmmo m_ammo = default;
        [SerializeField] private SFXWeapon m_weapon = default;

        //=========================================
        // Method
        //=========================================

        public void Fire()
        {
            SFXShooter.Fire(m_weapon, m_ammo);
        }
    }
}
