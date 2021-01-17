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

        public (IMusicPlayback, IMusicShot) Fire(IMusicShooter shooter, IMusicAmmo ammo)
        {
            var playback = m_barrel.Fire(ammo);
            var shot = Shot(shooter, playback);
            return (playback, shot);
        }

        protected abstract IMusicShot Shot(IMusicShooter shooter, IMusicPlayback playback);
    }
}