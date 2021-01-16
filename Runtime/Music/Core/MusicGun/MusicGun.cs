using UnityEngine;

namespace SoundShooter.Music
{
    public class MusicGun : ScriptableObject, IMusicGun
    {
        //========================================
        // SerializeField
        //========================================
        [SerializeField] private MusicBarrel m_barrel = default;

        //========================================
        // Method
        //========================================

        public void Setup()
        {
            m_barrel.Setup();
        }

        public void Fire(IMusicAmmo ammo)
        {
            var playback = m_barrel.Fire(ammo);
        }
    }
}