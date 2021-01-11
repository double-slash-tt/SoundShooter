using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundShooter
{

    public class ShooterServiceObject : MonoBehaviour
    {
        //====================================
        // Field
        //====================================
        private List<ISoundShooter> m_list = new List<ISoundShooter>();

        //====================================
        // Method
        //====================================

        private void OnDestroy()
        {
            foreach (var s in m_list)
            {
                s.Dispose();
            }
            m_list.Clear();
        }

        public void Refister(ISoundShooter shooter)
        {
            m_list.Add(shooter);
        }

        public void OnUpdate(float dt)
        {
            for (int i = 0; i < m_list.Count; i++)
            {
                var shooter = m_list[i];
                shooter.OnUpdate( dt );
            }
        }
    }
}