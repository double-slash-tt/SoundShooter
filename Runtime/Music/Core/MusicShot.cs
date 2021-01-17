using System;
using UnityEngine;

namespace SoundShooter.Music
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MusicShot : IMusicShot
    {
        //=======================================
        // Field
        //=======================================
        private bool m_isBegin = false;
        private bool m_isFinish = false;

        //=======================================
        // Property
        //=======================================
        public virtual bool IsCompleted { get; }

        //=======================================
        // Method
        //=======================================

        public void Dispose()
        {
            DoDispose();
        }
        protected virtual void DoDispose() { }

        public void OnUpdate(float dt)
        {
            if (!m_isBegin)
            {
                Begin();
                m_isBegin = true;
            }

            DoUpdate(dt);
            if (IsCompleted)
            {
                if (!m_isFinish)
                {
                    Complete();
                    m_isFinish = true;
                }
            }
        }

        protected virtual void DoUpdate(float dt) { }
        protected virtual void Begin()
        {
        }
        protected virtual void Complete()
        {
        }
    }
}