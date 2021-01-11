using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioClipAmmo : SFXAmmo
    {
        //===============================
        // SerializeField
        //===============================
        [SerializeField] private AudioClip m_audioClip = default;

        //===============================
        // Property
        //===============================
        public AudioClip Clip => m_audioClip;
    }
}
