using System;
using UnityEngine;

namespace SoundShooter
{
    /// <summary>
    /// VolumePowderの中間パラメータを管理するオブジェクト
    /// </summary>
    public abstract class VolumePowder : ScriptableObject
    {
        public abstract float Ratio { get; }
    }
}