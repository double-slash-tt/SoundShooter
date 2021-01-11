using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    /// <summary>
    /// 発生音の状態管理をするもの
    /// </summary>
    public abstract class SFXOperation : ISFXOperation
    {
        //=========================================
        // Field
        //=========================================
        private bool m_isBegining = false;

        //=========================================
        // Property
        //=========================================
        public abstract bool IsPlaying { get; }

        //=========================================
        // Method
        //=========================================

        public void OnUpdate(float dt)
        {
            if (!m_isBegining)
            {
                Begin();
            }
            DoUpdate(dt);
        }
        protected virtual void DoUpdate(float dt) { }

        protected void Begin()
        {
            DoBegin();
            m_isBegining = true;
        }
        protected abstract void DoBegin();

        public void Stop()
        {
            DoStop();
        }
        protected abstract void DoStop();
    }
}
