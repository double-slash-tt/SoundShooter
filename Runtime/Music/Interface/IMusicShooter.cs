using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicShooter : ISoundShooter
    {
        void Fire(IMusicAmmo ammo);
        void Pop();
        void Push(IMusicAmmo ammo);
    }
}