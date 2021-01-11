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
    public abstract class SFXPlayback : ISFXPlayback
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
                m_isBegining = true;
                Begin();
            }
            DoUpdate(dt);
        }
        protected virtual void DoUpdate(float dt) { }

        protected void Begin()
        {
            DoBegin();
        }
        protected abstract void DoBegin();

        public void Stop()
        {
            DoStop();
            m_isBegining = false;
        }
        protected abstract void DoStop();
    }
}
