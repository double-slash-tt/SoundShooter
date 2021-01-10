using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX
{
    /// <summary>
    /// AudioClip
    /// </summary>
    public class SFXAudioSourceBarrel : SFXBarrel<AudioClipAmmo>
    {
        //======================================
        // Field
        //======================================
        private AudioSource m_audioSource = default;

        //======================================
        // Method
        //======================================

        /// <summary>
        /// 初期化処理
        /// </summary>
        public override void Setup()
        {
            if (!m_audioSource)
            {

            }
        }

        /// <summary>
        /// 発射時処理
        /// </summary>
        protected override void DoFire(AudioClipAmmo ammo)
        {
            m_audioSource.clip = ammo.Clip;
            m_audioSource.Play();
        }
    }
}
