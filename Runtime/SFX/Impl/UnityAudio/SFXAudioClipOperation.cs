using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX.Impl
{
    /// <summary>
    /// AudioClipを再生する処理
    /// </summary>
    public class SFXAudioClipOperation : SFXOperation
    {
        //============================================
        // Field
        //============================================
        private float m_timeCount = 0f;

        //============================================
        // Property
        //============================================
        private ISFXWeapon Weapon { get; set; }
        private AudioSource Source { get; set; }
        private AudioClipAmmo Ammo { get; set; }
        private float PlayLength => Ammo.Clip.length;

        public override bool IsPlaying => PlayLength > m_timeCount;

        //============================================
        // Method
        //============================================
        public void Setup(ISFXWeapon weapon, AudioSource audioSource, AudioClipAmmo ammo)
        {
            Weapon = weapon;
            Source = audioSource;
            Ammo = ammo;
        }

        protected override void DoBegin()
        {
            Source.PlayOneShot( Ammo.Clip );
        }

        protected override void DoUpdate(float dt)
        {
            m_timeCount += dt;
        }

        protected override void DoStop()
        {
            Weapon.Return(this);
            Weapon = default;
            Source = default;
            Ammo = default;
            m_timeCount = 0f;
        }
    }
}
