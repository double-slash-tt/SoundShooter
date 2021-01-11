﻿using System;
using UnityEngine;

namespace SoundShooter
{
    /// <summary>
    /// 統合マネージャ
    /// </summary>
    public static class ShooterServices
    {
        //=========================================
        // Field
        //=========================================
        private static ShooterServiceObject ms_instance;

        //=========================================
        // Property
        //=========================================
        private static ShooterServiceObject Instance
        {
            get
            {
                if (!Application.isPlaying)
                {
                    return default;
                }
                if (ms_instance)
                {
                    return ms_instance;
                }
                var go = new GameObject(nameof(SoundShooter));
                GameObject.DontDestroyOnLoad(go);
                return (ms_instance = go.AddComponent<ShooterServiceObject>());
            }
        }

        //==========================================
        // Method
        //==========================================
        public static void Provide()
        {
            var _ = Instance;
        }
        public static void Register(ISoundShooter shooter)
        {
            if (!Instance)
            {
                return;
            }
            Instance.Refister(shooter);
        }
    }
}