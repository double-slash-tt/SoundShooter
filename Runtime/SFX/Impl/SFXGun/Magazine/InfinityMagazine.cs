using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SoundShooter.SFX.Impl
{
    /// <summary>
    /// 無限弾倉
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(SFX) + "/" + nameof(SFXGun) + "/" + nameof(SFXMagazine) + "/" + nameof(InfinityMagazine))]
    public class InfinityMagazine : SFXMagazine
    {
        public override bool IsEmpty() => false;

        public override void Pop() { }
        public override void Push() { }
    }
}
