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
        public override IMusicShot Shot(IMusicPlayer player, IMusicPlayback playback)
        {
            var playlist = player.PlayList;
            var list = new List<IMusicShot>();
            foreach (var p in playlist)
            {
                var fadeOut = new FadeOutMusicShot(m_duration, p);

                list.Add(fadeOut);
            }
            if (playback != null)
            {
                var fadeIn = new FadeInMusicShot(m_duration, playback);
                list.Add(fadeIn);
            }
            return new ParallelMusicShot( list );
        }
    }
}