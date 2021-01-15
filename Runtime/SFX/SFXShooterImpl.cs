using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    internal static partial class SFXShooter
    {
        //====================================
        // Method
        //====================================
        internal static void Provide(IReadOnlyList<ISFXWeapon> weapons )
        {
            Shooter = new SFXShooterImpl( weapons );
        }

        //====================================
        // class
        //====================================
        /// <summary>
        /// 内部実装
        /// </summary>
        internal class SFXShooterImpl : ISFXShooter
        {
            //========================================
            // Field
            //========================================
            private List<ISFXPlayback> m_list = new List<ISFXPlayback>();
            private HashSet<ISFXWeapon> m_weapons = new HashSet<ISFXWeapon>();

            //========================================
            // Method
            //========================================

            internal SFXShooterImpl(IReadOnlyList<ISFXWeapon> weapons)
            {
                foreach (var w in weapons)
                {
                    w.Setup();
                    m_weapons.Add(w);
                }
                ShooterServices.Register(this);
            }
            /// <summary>
            /// 破棄処理
            /// </summary>
            public void Dispose()
            {
                m_list.Clear();
            }

            /// <summary>
            /// 再生処理
            /// </summary>
            public void Fire(ISFXWeapon weapon, ISFXAmmo ammo)
            {
                weapon.Fire(this, ammo);
            }


            /// <summary>
            /// 更新処理
            /// </summary>
            public void OnUpdate(float dt)
            {
                foreach (var w in m_weapons)
                {
                    w.OnUpdate( dt );
                }

                for (int i = m_list.Count - 1; i >= 0; i--)
                {
                    var op = m_list[i];
                    op.OnUpdate(dt);
                    if (!op.IsPlaying)
                    {
                        op.Stop();
                        m_list.RemoveAt(i);
                    }
                }
            }

            public void Shot(ISFXPlayback playback)
            {
                m_list.Add(playback);
            }
        }
    }
}
