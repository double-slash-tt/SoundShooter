using System.Collections.Generic;
using UnityEngine;

namespace SoundShooter.Music
{
    internal static partial class MusicShooter
    {
        //======================================
        // static
        //======================================
        internal static void Provide(IMusicGun weapon)
        {
            Shooter = new MusicShooterImpl(weapon);
        }

        //======================================
        // class
        //======================================

        internal class MusicShooterImpl : IMusicShooter
        {
            //==========================================
            // Field
            //==========================================
            private List<IMusicPlayback> m_playList = new List<IMusicPlayback>();
            private Stack<IMusicAmmo> m_history = new Stack<IMusicAmmo>();
            private IMusicShot m_shot = default;
            private IMusicGun m_gun = default;

            //==========================================
            // Property
            //==========================================
            public IReadOnlyList<IMusicPlayback> PlayList => m_playList;

            //==========================================
            // Method
            //==========================================

            internal MusicShooterImpl(IMusicGun gun)
            {
                m_gun = gun;
                m_gun.Setup();
                ShooterServices.Register(this);
            }

            public void Dispose()
            {
                foreach (var p in m_playList)
                {
                    p.Dispose();
                }
                m_history.Clear();
                m_playList.Clear();
            }

            public void OnUpdate(float dt)
            {
                if (m_shot != null)
                {
                    m_shot.OnUpdate(dt);
                    if (m_shot.IsCompleted )
                    {
                        m_shot?.Dispose();
                        m_shot = default;
                    }
                }

                for (int i = 0; i < m_playList.Count; i++)
                {
                    var p = m_playList[i];
                    p.OnUpdate(dt);
                }
                for (int i = m_playList.Count - 1; i >= 0; i--)
                {
                    var p = m_playList[i];
                    if (!p.IsPlaying)
                    {
                        p.Dispose();
                    }
                    if (p.IsDisposed)
                    {
                        m_playList.RemoveAt(i);
                    }
                }
            }

            public void Fire(IMusicAmmo ammo)
            {
                m_history.Clear();
                m_history.Push(ammo);

                PlayCore(ammo);
            }
            public void Pop()
            {
                var ammo = m_history.Pop();
                PlayCore(ammo);
            }

            public void Push(IMusicAmmo ammo)
            {
                m_history.Push(ammo);
                PlayCore(ammo);
            }


            private void PlayCore(IMusicAmmo ammo)
            {
                var (playback, shot) = m_gun.Fire(this, ammo);
                m_playList.Add(playback);
                m_shot = shot;
            }
        }
    }
}