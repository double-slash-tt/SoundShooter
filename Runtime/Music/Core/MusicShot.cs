using UnityEngine;

namespace SoundShooter.Music
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MusicShot : IMusicShot
    {
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

        public virtual void OnUpdate(float dt)
        {

        }
    }
}