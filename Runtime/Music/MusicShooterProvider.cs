using UnityEngine;

namespace SoundShooter.Music
{
    public class MusicShooterProvider : SoundShooterProvider
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