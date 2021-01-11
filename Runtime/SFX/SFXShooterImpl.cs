using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    public static partial class SFXShooter
    {
        //====================================
        // class
        //====================================
        /// <summary>
        /// 内部実装
        /// </summary>
        public class SFXShooterImpl : ISFXShooter
        {
            //========================================
            // Field
            //========================================
            private List<ISFXPlayback> m_list = new List<ISFXPlayback>();

            //========================================
            // Method
            //========================================

            internal SFXShooterImpl()
            {
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
                var op = weapon.Fire( ammo );
                if (op == null)
                {
                    return;
                }

                m_list.Add(op);
            }


            /// <summary>
            /// 更新処理
            /// </summary>
            public void OnUpdate( float dt )
            {
                for (int i = m_list.Count - 1; i >= 0; i--)
                {
                    var op = m_list[i];
                    op.OnUpdate( dt );
                    if (!op.IsPlaying )
                    {
                        op.Stop();
                        m_list.RemoveAt(i);
                    }
                }
            }
        }
    }
}
