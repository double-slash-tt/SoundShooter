using System.Collections.Generic;
using UnityEngine;

namespace SoundShooter.Music
{
    internal static partial class MusicShooter
    {
        //======================================
        // static
        //======================================
        internal static void Provide(IReadOnlyList<IMusicGun> guns)
        {
            Shooter = new MusicShooterImpl(guns);
        }

        //======================================
        // class
        //======================================

        internal class MusicShooterImpl : IMusicShooter
        {
            //==========================================
            // Field
            //==========================================
            private Dictionary<IMusicGun, IMusicPlayer> m_table = new Dictionary<IMusicGun, IMusicPlayer>();

            //==========================================
            // Method
            //==========================================

            internal MusicShooterImpl(IReadOnlyList<IMusicGun> guns)
            {
                foreach (var gun in guns)
                {
                    m_table.Add(gun, new MusicPlayer(gun));
                }

                ShooterServices.Register(this);
            }

            public void Dispose()
            {
                foreach (var gun in m_table)
                {
                    gun.Value.Dispose();
                }
                m_table.Clear();
            }
            public void OnUpdate(float dt)
            {
                foreach (var item in m_table)
                {
                    item.Value.OnUpdate(dt);
                }
            }

            public void Fire(IMusicGun gun, IMusicAmmo ammo)
            {
                if (m_table.TryGetValue(gun, out var player))
                {
                    player.Play(ammo);
                }
            }

            public void Pop( IMusicGun gun )
            {
                if (m_table.TryGetValue(gun, out var player))
                {
                    player.Pop();
                }
            }

            public void Push(IMusicGun gun, IMusicAmmo ammo)
            {
                if (m_table.TryGetValue(gun, out var player))
                {
                    player.Push(ammo);
                }
            }

            public void Stop( IMusicGun gun )
            {
                if (m_table.TryGetValue(gun, out var player))
                {
                    player.Stop();
                }
            }
        }
    }
}