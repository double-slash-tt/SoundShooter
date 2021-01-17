using System;
using UnityEngine;

namespace SoundShooter.Music
{
    internal static partial class MusicShooter
    {
        //=================================
        // Property
        //=================================
        private static IMusicShooter Shooter { get; set; }

        //=================================
        // Method
        //=================================

        /// <summary>
        /// 通常再生
        /// </summary>
        /// <param name="ammo"></param>
        internal static void Fire(IMusicGun gun, IMusicAmmo ammo)
        {
            Shooter?.Fire(gun, ammo);
        }
        /// <summary>
        /// 履歴を戻して再生
        /// </summary>
        internal static void Pop(IMusicGun gun)
        {
            Shooter?.Pop( gun );
        }
        /// <summary>
        /// 履歴に積んで再生
        /// </summary>
        internal static void Push(IMusicGun gun, IMusicAmmo ammo)
        {
            Shooter?.Push(gun, ammo);
        }
        internal static void Stop(IMusicGun gun )
        {
            Shooter?.Stop(gun);
        }
    }
}