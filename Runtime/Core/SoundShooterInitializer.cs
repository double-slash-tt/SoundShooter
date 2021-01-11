using UnityEngine;

namespace SoundShooter
{
    /// <summary>
    /// SoundShooter初期化用のコンポーネント
    /// </summary>
    public class SoundShooterInitializer : MonoBehaviour
    {
        //===================================
        // SerializeField
        //===================================
        [SerializeField] private GameObject m_go = default;

        //===================================
        // Field
        //===================================
        private static bool ms_isInit = false;
        private static SoundShooterInitializer ms_singleton = default;

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
            ShooterServices.Provide();
        }
    }
}