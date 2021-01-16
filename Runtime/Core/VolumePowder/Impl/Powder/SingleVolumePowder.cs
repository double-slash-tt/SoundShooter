using System;
using UnityEngine;

namespace SoundShooter
{
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(VolumePowder) + "/" + nameof(SingleVolumePowder))]
    public class SingleVolumePowder : VolumePowder
    {
        //================================
        // SerializeField
        //================================
        [Range(0, 1)]
        [SerializeField] private float m_initialValue = 1;

        //================================
        // Field
        //================================
        [NonSerialized] private float m_ratio = 0f;

        //================================
        // Property
        //================================
        public override float Ratio => m_ratio;

        //================================
        // Method
        //================================
        public void Set(float ratio) => m_ratio = Mathf.Clamp01(ratio);

        private void OnValidate()
        {
            Set(m_initialValue);
        }
    }
}