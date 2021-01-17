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
        // Field
        //====================================
        private float m_virtualVolume = 0f;

        //====================================
        // Property
        //====================================
        private AudioSource AudioSource { get; set; }
        private AudioClipAmmo Ammo { get; set; }
        private VolumePowder Powder { get; set; }

        public override bool IsPlaying => AudioSource != null ? AudioSource.isPlaying : false;

        public override float Volume => m_virtualVolume;

        //====================================
        // Method
        //====================================

        public UnityAudioPlayback(AudioSource audioSource, AudioClipAmmo ammo, VolumePowder powder)
        {
            this.AudioSource = audioSource;
            this.Ammo = ammo;
            this.Powder = powder;

            m_virtualVolume = 1f;
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
            m_virtualVolume = v;
        }

        public override void OnUpdate(float dt)
        {
            if (AudioSource && Powder)
            {
                var v = m_virtualVolume * Powder.Ratio;
                if (!Mathf.Approximately(v, AudioSource.volume))
                {
                    AudioSource.volume = v;
                }
            }
        }
    }
}