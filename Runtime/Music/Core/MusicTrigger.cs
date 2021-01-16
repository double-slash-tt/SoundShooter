using UnityEngine;

namespace SoundShooter.Music
{
    public class MusicTrigger : ScriptableObject
    {
        //=========================================
        // SerializeField
        //=========================================
        [SerializeField] private MusicAmmo m_ammo = default;
        //=========================================
        // Method
        //=========================================

        public void Fire()
        {
            MusicShooter.Fire( m_ammo );
        }
    }
}