using System.Collections.Generic;
using UnityEngine;

namespace SoundShooter.Music.Impl
{
    public class ParallelMusicShot : MusicShot
    {
        //========================================
        // Property
        //========================================
        private IReadOnlyList<IMusicShot> m_list = default;
        public override bool IsCompleted
        {
            get
            {
                if (m_list == null)
                {
                    return true;
                }
                for (int i = 0; i < m_list.Count; i++)
                {
                    if (!m_list[i].IsCompleted)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        //========================================
        // Method
        //========================================
        public ParallelMusicShot( IReadOnlyList<IMusicShot> list )
        {
            m_list = list;
        }

        protected override void DoDispose()
        {
            m_list = default;
        }

        public override void OnUpdate(float dt)
        {
            if (m_list == null)
            {
                return;
            }
            for (int i = 0; i < m_list.Count; i++)
            {
                var shot = m_list[i];
                shot.OnUpdate( dt );
            }
        }
    }
}