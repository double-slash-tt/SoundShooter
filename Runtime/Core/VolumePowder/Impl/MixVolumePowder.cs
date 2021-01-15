using UnityEngine;

namespace SoundShooter
{
    /// <summary>
    /// カーブ同士を掛け合わせる
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(VolumePowder) + "/" + nameof(MixVolumePowder), order = -1)]
    public sealed class MixVolumePowder : VolumePowder
    {
        //======================================
        //
        //======================================
        [SerializeField] private VolumePowder m_powder = default;
        public override float Evaluate(float ratio)
        {
            return DoEvaluate(ratio) * m_powder.Evaluate( ratio );
        }
    }
}