using System.Collections;
using UnityEngine;

namespace SoundShooter
{
    /// <summary>
    /// 再生ボリュームのコントロール装置
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(VolumePowder) + "/" + nameof(VolumePowder), order = -1)]
    public class VolumePowder : ScriptableObject
    {
        //===================================
        // SerializeField
        //===================================
        [SerializeField] private AnimationCurve m_curve = AnimationCurve.Constant(0, 1, 1);

        //===================================
        // Method
        //===================================

        public virtual float Evaluate(float ratio)
        {
            return DoEvaluate( ratio );
        }
        protected float DoEvaluate(float ratio) => m_curve.Evaluate(ratio);
    }
}