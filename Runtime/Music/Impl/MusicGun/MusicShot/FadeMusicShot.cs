using UnityEngine;

namespace SoundShooter.Music.Impl
{
    /// <summary>
    /// フェード動作
    /// </summary>
    public sealed class FadeMusicShot : MusicShot
    {
        //===================================
        // Field
        //===================================
        private float m_timeCount = 0f;

        //===================================
        // Property
        //===================================
        private float Duration { get; }
        private float StartValue { get; }
        private float EndValue { get; }

        private IMusicPlayback Playback { get; set; }

        public override bool IsCompleted => m_timeCount >= Duration;

        //===================================
        // Method
        //===================================
        public FadeMusicShot(float start, float end, float duration, IMusicPlayback playback)
        {
            Playback = playback;
            StartValue = start;
            EndValue = end;
            Duration = duration;
        }

        protected override void DoDispose()
        {
            Playback = default;
        }

        public override void OnUpdate(float dt)
        {
            var t = Mathf.InverseLerp(0, Duration, m_timeCount);
            var v = Mathf.Lerp(StartValue, EndValue, t);
            Playback.SetVolume( v );
            m_timeCount += dt;
        }
    }
}