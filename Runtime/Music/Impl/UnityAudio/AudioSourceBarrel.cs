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
        private List<AudioSource> m_sourceList = new List<AudioSource>();

        //======================================
        // Method
        //======================================

        public override void Setup()
        {

        }

        protected override IMusicPlayback DoFire(AudioClipAmmo ammo)
        {
            var source = GetSource();
            return new UnityAudioPlayback(source, ammo);
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
            var s = ShooterServices.Instantiate<AudioSource>(m_sourceList.Count.ToString());
            m_sourceList.Add(s);

            return s;
        }
    }
}