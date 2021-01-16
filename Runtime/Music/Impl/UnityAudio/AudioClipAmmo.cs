using UnityEngine;

namespace SoundShooter.Music.Impl
{
    public class AudioClipAmmo : ScriptableObject,IMusicAmmo
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