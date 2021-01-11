using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    /// <summary>
    /// 鳴ってる情報
    /// </summary>
    public interface ISFXHandle
    {
    }

    public interface ISFXPlayback : ISFXHandle
    {
        bool IsPlaying { get; }

        void OnUpdate(float dt);
        void Stop();
    }
}
