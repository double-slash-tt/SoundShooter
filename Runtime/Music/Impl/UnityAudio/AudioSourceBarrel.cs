using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SoundShooter.Music.Impl
{
    /// <summary>
    /// AudisoSourceを使った再生マシン
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(Music) + "/" + nameof(MusicGun) + "/" + nameof(MusicBarrel) + "/" + nameof(AudioSourceBarrel))]
    public sealed class AudioSourceBarrel : MusicBarrel<AudioClipAmmo>
    {
        //======================================
        // Field
        //======================================
        [SerializeField] private VolumePowder m_powder = default;
        [SerializeField] private int m_bufferCount = 3;

        //======================================
        // Field
        //======================================
        [NonSerialized] private List<AudioSource> m_sourceList = new List<AudioSource>();

        //======================================
        // Method
        //======================================

        public override void Dispose()
        {
            for (int i = 0; i < m_sourceList.Count; i++)
            {
                var s = m_sourceList[i];
                if (s)
                {
                    Destroy(s.gameObject);
                }
            }
        }


        public override void Setup()
        {
            for (int i = 0; i < m_bufferCount; i++)
            {
                Add();
            }
        }

        protected override IMusicPlayback DoFire(AudioClipAmmo ammo)
        {
            var source = GetSource();
            return new UnityAudioPlayback(source, ammo, m_powder);
        }

        private AudioSource GetSource() 
        {
            for (int i = 0; i < m_sourceList.Count; i++)
            {
                var source = m_sourceList[i];
                if (!source.isPlaying)
                {
                    return source;
                }
            }
            if (m_sourceList.Count >= m_bufferCount)
            {
                // バッファ数を超えてたら止める
                return m_sourceList[0];
            }
            var s = Add();
            return s;
        }
        private AudioSource Add()
        {
            var s = ShooterServices.Instantiate<AudioSource>(m_sourceList.Count.ToString());
            m_sourceList.Add(s);

            return s;
        }
    }
}