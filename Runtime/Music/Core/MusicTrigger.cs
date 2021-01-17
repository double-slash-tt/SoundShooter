using UnityEngine;

namespace SoundShooter.Music
{
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(Music) + "/" + nameof(MusicTrigger))]
    public class MusicTrigger : ScriptableObject
    {
        //=========================================
        // SerializeField
        //=========================================
        [SerializeField] private MusicAmmo m_ammo = default;
        [SerializeField] private MusicGun m_gun = default;
        //=========================================
        // Method
        //=========================================

        public void Fire()
        {
            MusicShooter.Fire(m_gun, m_ammo);
        }
        public void Push()
        {
            MusicShooter.Push(m_gun, m_ammo);
        }
        public void Pop()
        {
            MusicShooter.Pop(m_gun);
        }
        public void Stop()
        {
            MusicShooter.Stop(m_gun);
        }
    }
}