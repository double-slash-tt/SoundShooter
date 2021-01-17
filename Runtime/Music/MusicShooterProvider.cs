using UnityEngine;

namespace SoundShooter.Music
{
    /// <summary>
    /// Musicシステムの初期化マシン
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(Music) + "/" + nameof(MusicShooter), order = -1)]
    public sealed class MusicShooterProvider : SoundShooterProvider
    {
        //===================================
        // SerializeField
        //===================================
        [SerializeField] private MusicGun m_gun = default;

        //===================================
        // Method 
        //===================================
        public override void Provide()
        {
            MusicShooter.Provide( m_gun );
        }
    }
}