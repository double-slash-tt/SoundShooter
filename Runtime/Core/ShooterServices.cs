using System;
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
        public static void Provide(ShooterServiceProvider provider)
        {
            provider.Provide();
        }
        public static void Register(ISoundShooter shooter)
        {
            if (!Instance)
            {
                return;
            }
            Instance.Refister(shooter);
        }

        public static void OnUpdate(float dt)
        {
            if (!Instance)
            {
                return;
            }
            Instance.OnUpdate(dt);
        }

        public static T Instantiate<T>(string name) where T : Component
        {
            var go = new GameObject(name);
            go.transform.SetParent(Instance.transform);
            return go.AddComponent<T>();
        }
    }
}