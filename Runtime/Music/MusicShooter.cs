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
        internal static void Fire( IMusicAmmo ammo )
        {
            Shooter?.Fire( ammo );
        }
        /// <summary>
        /// 履歴を戻して再生
        /// </summary>
        internal static void Pop()
        {
            Shooter?.Pop();
        }
        /// <summary>
        /// 履歴に積んで再生
        /// </summary>
        internal static void Push(IMusicAmmo ammo)
        {
            Shooter?.Push(ammo);
        }
    }
}