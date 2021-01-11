﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter.SFX
{
    public interface ISFXWeapon
    {
        /// <summary>
        /// 発射
        /// </summary>
        ISFXOperation Fire(ISFXAmmo ammo);

        /// <summary>
        /// 回収
        /// </summary>
        void Return(ISFXOperation op);
    }
}