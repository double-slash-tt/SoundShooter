using UnityEngine;

namespace SoundShooter.Music.Impl
{
    /// <summary>
    /// フェード動作
    /// </summary>
    public abstract class FadeMusicShot : MusicShot
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

        protected IMusicPlayback Playback { get; set; }

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

        protected override void DoUpdate(float dt)
        {
            var t = Mathf.InverseLerp(0, Duration, m_timeCount);
            var v = Mathf.Lerp(StartValue, EndValue, t);
            Playback?.SetVolume( v );
            m_timeCount += dt;
        }
    }

    /// <summary>
    /// フェードアウト用
    /// </summary>
    public sealed class FadeOutMusicShot : FadeMusicShot
    {
        public FadeOutMusicShot(float duration, IMusicPlayback playback) : base(playback.Volume, 0, duration, playback)
        {
        }

        protected override void Complete()
        {
            Playback?.Stop();
        }
    }

    /// <summary>
    /// フェードイン用
    /// </summary>
    public sealed class FadeInMusicShot : FadeMusicShot
    {
        public FadeInMusicShot(float duration, IMusicPlayback playback) : base(0, 1, duration, playback)
        {
        }
        protected override void Begin()
        {
            Playback?.Play();
        }
    }
}