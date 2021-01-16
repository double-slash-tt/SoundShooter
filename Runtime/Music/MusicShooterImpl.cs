using System.Collections.Generic;
using UnityEngine;

namespace SoundShooter.Music
{
    internal static partial class MusicShooter
    {
        //======================================
        // static
        //======================================
        internal static void Provide( IMusicGun weapon )
        {
            Shooter = new MusicShooterImpl( weapon );
        }

        //======================================
        // class
        //======================================

        internal class MusicShooterImpl : IMusicShooter
        {
            //==========================================
            // Field
            //==========================================
            private List<IMusicPlayback> m_list = new List<IMusicPlayback>();
            private Stack<IMusicAmmo> m_history = new Stack<IMusicAmmo>();
            private IMusicGun m_gun = default;

            //==========================================
            // Method
            //==========================================

            internal MusicShooterImpl( IMusicGun gun )
            {
                m_gun = gun;
                m_gun.Setup();
                ShooterServices.Register(this);
            }

            public void Dispose()
            {
            }
            public void OnUpdate(float dt)
            {
            }

            public void Fire(IMusicAmmo ammo)
            {
                m_history.Clear();
                m_history.Push(ammo);

                PlayCore( ammo );
            }
            public void Pop()
            {
                var ammo = m_history.Pop();
                PlayCore( ammo );
            }

            public void Push(IMusicAmmo ammo)
            {
                m_history.Push( ammo );
                PlayCore( ammo );
            }


            private void PlayCore(IMusicAmmo ammo)
            {
                m_gun.Fire( ammo );
            }
        }
    }
}