using System;
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
    public class AudioSourceBarrel : SFXBarrel<AudioClipAmmo>
    {
        //======================================
        // Field
        //======================================
        private ListBuffer<ISFXOperation> m_list = new ListBuffer<ISFXOperation>(() => new SFXAudioClipOperation());
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
        protected override ISFXOperation DoFire(ISFXWeapon weapon, AudioClipAmmo ammo)
        {
            var op = m_list.Alloc() as SFXAudioClipOperation;
            op.Setup( weapon, m_audioSource, ammo );

            return op;
        }

        public override void DoReturn(ISFXOperation op)
        {
            m_list.Free(op);
        }
    }
}
