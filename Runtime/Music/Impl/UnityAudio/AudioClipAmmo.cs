using UnityEngine;

namespace SoundShooter.Music.Impl
{
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(Music) + "/" + nameof(MusicAmmo) + "/" + nameof(AudioClipAmmo))]
    public class AudioClipAmmo : MusicAmmo, IMusicAmmo
    {
        //==========================================
        // SerializeField
        //==========================================
        [SerializeField] private AudioClip m_clip = default;

        //==========================================
        // Property
        //==========================================
        public AudioClip Clip => m_clip;
    }
}