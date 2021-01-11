using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    public static partial class SFXShooter
    {
        /// <summary>
        /// 内部実装
        /// </summary>
        public class SFXShooterImpl : ISFXShooter
        {
            //========================================
            // Field
            //========================================
            private List<ISFXOperation> m_list = new List<ISFXOperation>();

            //========================================
            // Method
            //========================================
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
            public void DoUpdate( float dt )
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
