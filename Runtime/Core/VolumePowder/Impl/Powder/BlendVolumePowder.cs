using UnityEngine;

namespace SoundShooter
{
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(VolumePowder) + "/" + nameof(BlendVolumePowder))]
    public class BlendVolumePowder : VolumePowder
    {
        //======================================
        // Property
        //======================================
        [SerializeField] private VolumePowder m_powder = default;
        [SerializeField] private AnimationCurve m_curve = AnimationCurve.Constant(0, 1, 1);

        //======================================
        // Property
        //======================================
        public override float Ratio {
            get
            {
                if (m_powder)
                {
                    m_curve.Evaluate(m_powder.Ratio);
                }
                return 0f;
            }
        }
    }
}