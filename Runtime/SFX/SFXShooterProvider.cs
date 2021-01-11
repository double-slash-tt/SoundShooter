using UnityEngine;

namespace SoundShooter.SFX
{
    /// <summary>
    /// SFX用機能の初期化マシン
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(SFX) + "/" + nameof(SFXShooter), order = -1)]
    public class SFXShooterProvider : SoundShooterProvider
    {
        //========================================
        // Method
        //========================================
        [SerializeField] private SFXWeapon[] m_weapons = default;

        //========================================
        // Method
        //========================================
        public override void Provide()
        {
            SFXShooter.Provide( m_weapons );
        }
    }
}