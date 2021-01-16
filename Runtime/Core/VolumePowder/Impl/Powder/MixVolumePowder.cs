using UnityEngine;

namespace SoundShooter
{
    /// <summary>
    /// 合成
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(VolumePowder) + "/" + nameof(MixVolumePowder))]
    public class MixVolumePowder : VolumePowder
    {
        //=========================
        // SerializeField
        //=========================
        [SerializeField] VolumePowder[] m_powders = default;

        //=========================
        // Property
        //=========================
        public override float Ratio
        {
            get
            {
                var r = 0f;
                for (int i = 0; i < m_powders.Length; i++)
                {
                    var p = m_powders[i];
                    r *= p.Ratio;
                }
                return r;
            }
        }
    }
}