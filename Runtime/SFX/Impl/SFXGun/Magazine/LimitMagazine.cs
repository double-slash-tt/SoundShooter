using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX.Impl
{
    /// <summary>
    /// 弾数制限
    /// </summary>
    public class LimitMagazine : SFXMagazine
    {
        //=======================================
        // SerializeField
        //=======================================
        [SerializeField] private int m_limit = 10;

        //=======================================
        // Field
        //=======================================
        [NonSerialized] private int m_count = 0;

        //=======================================
        // Method
        //=======================================

        /// <summary>
        /// 空かどうか
        /// </summary>
        /// <returns></returns>
        public override bool IsEmpty()
        {
            return (m_limit - m_count) <= 0;
        }

        /// <summary>
        /// /取り出す(発射数増加)
        /// </summary>
        public override void Pop()
        {
            m_count = Mathf.Clamp(m_count + 1, 0, m_limit);
        }
        /// <summary>
        /// 戻す(発射数低下)
        /// </summary>
        public override void Push()
        {
            m_count = Mathf.Clamp(m_count - 1, 0, m_limit);
        }
    }
}
