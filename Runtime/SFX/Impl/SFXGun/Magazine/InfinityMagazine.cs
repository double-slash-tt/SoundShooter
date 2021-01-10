using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX.Impl
{
    /// <summary>
    /// 無限弾倉
    /// </summary>
    public class InfinityMagazine : SFXMagazine
    {
        public override bool IsEmpty() => false;

        public override void Pop() { }
        public override void Push() { }
    }
}
