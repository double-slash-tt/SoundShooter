using System;
using UnityEngine;

namespace SoundShooter
{
    /// <summary>
    /// Soundシステム初期化マシン
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(ShooterServices), order = -1)]
    public class ShooterServiceProvider : ScriptableObject
    {
        //============================================
        // SerializeField
        //============================================
        [SerializeField] private SoundShooterProvider[] m_providers = default;

        //============================================
        // Method
        //============================================
        public void Provide()
        {
            foreach (var p in m_providers)
            {
                p.Provide();
            }
        }
    }
}