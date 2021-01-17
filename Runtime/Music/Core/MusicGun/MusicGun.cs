using UnityEngine;

namespace SoundShooter.Music
{
    public abstract class MusicGun : ScriptableObject, IMusicGun
    {
        //========================================
        // SerializeField
        //========================================
        [SerializeField] private MusicBarrel m_barrel = default;

        //========================================
        // Method
        //========================================

        public void Dispose()
        {
            if (m_barrel)
            {
                m_barrel.Dispose();
            }
        }
        public void Setup()
        {
            m_barrel.Setup();
        }

        public IMusicPlayback Fire( IMusicAmmo ammo )
        {
            return m_barrel.Fire(ammo);
        }
        public abstract IMusicShot Shot(IMusicPlayer player, IMusicPlayback playback);
    }
}