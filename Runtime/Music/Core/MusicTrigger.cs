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
        //=========================================
        // Method
        //=========================================

        public void Fire()
        {
            MusicShooter.Fire( m_ammo );
        }
        public void Push()
        {
            MusicShooter.Push(m_ammo);
        }
        public void Pop()
        {
            MusicShooter.Pop();
        }
    }
}