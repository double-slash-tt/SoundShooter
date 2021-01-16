using UnityEditor;
using UnityEngine;

namespace SoundShooter.Music.Impl
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class AudioSourceBarrel : MusicBarrel<AudioClipAmmo>
    {
        //======================================
        // Field
        //======================================
        //======================================
        // Method
        //======================================

        protected override IMusicPlayback DoFire(AudioClipAmmo ammo)
        {
            return new AudioClipPlayback();
        }
    }
}