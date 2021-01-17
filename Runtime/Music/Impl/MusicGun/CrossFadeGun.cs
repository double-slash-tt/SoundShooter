using System.Collections.Generic;
using UnityEngine;

namespace SoundShooter.Music.Impl
{
    /// <summary>
    /// クロスフェードマシン
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(Music) + "/" + nameof(MusicGun) + "/" + nameof(CrossFadeGun))]
    public sealed class CrossFadeGun : MusicGun
    {
        //=========================================
        // Field
        //=========================================
        [SerializeField] private float m_duration = 1f;

        //=========================================
        // Method
        //=========================================
        protected override IMusicShot Shot(IMusicShooter shooter, IMusicPlayback playback)
        {
            var playlist = shooter.PlayList;
            var list = new List<IMusicShot>();
            foreach (var p in playlist)
            {
                var fadeOut = new FadeMusicShot(p.Volume, 0, m_duration, p);
                
                list.Add(fadeOut);
            }
            var fadeIn = new FadeMusicShot(0, 1, m_duration, playback);
            list.Add(fadeIn);
            return new ParallelMusicShot( list );
        }
    }
}