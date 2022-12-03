using UnityEngine;

public class M1911 : Weapon
{
    public override void Shoot(Transform shootPosition)
    {
        Instantiate(Bullet, ShotPoint.position, Quaternion.identity);
    }

    public override void Create(Transform weaponPosition)
    {
        Instantiate(WeaponObject, weaponPosition.position, Quaternion.identity);
    }
}
