using UnityEngine;

namespace SoundShooter
{
    /// <summary>
    /// 親のカーブの値から自身のカーブの値を参照する
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(VolumePowder) + "/" + nameof(BlendVolumePowder), order = -1)]
    public sealed class BlendVolumePowder : VolumePowder
    {
        //=====================================
        // SerializeField
        //=====================================
        [SerializeField] private VolumePowder m_powder = default;

        //=====================================
        // Method
        //=====================================

        public override float Evaluate(float ratio)
        {
            return DoEvaluate(m_powder.Evaluate(ratio));
        }
    }
}