using UnityEditor;
using UnityEngine;

namespace SoundShooter.Music.Impl
{
    /// <summary>
    /// AudioClipとAudioSourceでの再生状況マシン
    /// </summary>
    public sealed class UnityAudioPlayback : MusicPlayback
    {
        //====================================
        // Property
        //====================================
        private AudioSource AudioSource { get; set; }
        private AudioClipAmmo Ammo { get; set; }

        public override bool IsPlaying => AudioSource != null ? AudioSource.isPlaying : false;

        public override float Volume => AudioSource.volume;

        //====================================
        // Method
        //====================================

        public UnityAudioPlayback(AudioSource audioSource, AudioClipAmmo ammo)
        {
            this.AudioSource = audioSource;
            this.Ammo = ammo;
        }

        protected override void DoDispose()
        {
            AudioSource = default;
            Ammo = default;
        }
        public override void Play()
        {
            if (AudioSource)
            {
                AudioSource.clip = Ammo.Clip;
                AudioSource.Play();
            }
        }
        public override void Stop()
        {
            if (AudioSource)
            {
                AudioSource.Stop();
            }
        }

        public override void SetVolume(float v)
        {
            if (AudioSource)
            {
                AudioSource.volume = v;
            }
        }
    }
}