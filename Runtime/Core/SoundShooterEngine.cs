using UnityEngine;

namespace SoundShooter
{
    /// <summary>
    /// SoundShooter初期化用のコンポーネント
    /// </summary>
    public class SoundShooterEngine : MonoBehaviour
    {
        //===================================
        // SerializeField
        //===================================
        [SerializeField] private ShooterServiceProvider m_provider = default;
        [SerializeField] private bool m_isRunningUpdate = true;
        //===================================
        // Field
        //===================================
        private static bool ms_isInit = false;
        private static SoundShooterEngine ms_singleton = default;

        //===================================
        // Method
        //===================================

        private void OnDestroy()
        {
            if (ms_singleton != this)
            {
                return;
            }
            ms_singleton = default;
        }

        private void Start()
        {
            if (ms_isInit)
            {
                return;
            }
            ms_isInit = true;
            ms_singleton = this;
            ShooterServices.Provide( m_provider );
            GameObject.DontDestroyOnLoad(this);
        }

        private void Update()
        {
            if (!m_isRunningUpdate)
            {
                return;
            }
            ShooterServices.OnUpdate(Time.deltaTime);
        }
    }
}