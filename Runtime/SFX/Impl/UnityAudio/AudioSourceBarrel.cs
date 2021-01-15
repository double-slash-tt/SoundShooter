﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX.Impl
{
    /// <summary>
    /// AudioClip
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(SFX) + "/" + nameof(SFXGun) + "/" + nameof(SFXBarrel) + "/" + nameof(AudioSourceBarrel))]
    public class AudioSourceBarrel : SFXBarrel<AudioClipAmmo>
    {
        //======================================
        // Field
        //======================================
        private ListBuffer<ISFXPlayback> m_list = new ListBuffer<ISFXPlayback>(() => new SFXAudioClipPlayback());
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
                m_audioSource = ShooterServices.Instantiate<AudioSource>( name );
            }
        }

        /// <summary>
        /// 発射時処理
        /// </summary>
        protected override ISFXPlayback DoFire(ISFXWeapon weapon, AudioClipAmmo ammo)
        {
            var op = m_list.Alloc() as SFXAudioClipPlayback;
            op.Setup( weapon, m_audioSource, ammo );

            return op;
        }

        public override void DoReturn(ISFXPlayback op)
        {
            m_list.Free(op);
        }
    }
}
