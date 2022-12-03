using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _money;
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Transform _shotPoint;

    private Weapon _currentWeapon;
    private int _currentWeaponNumber = 0;
    public int Money => _money;

    public event UnityAction<int> MoneyChanged;

    private void Start()
    {
        ChangeWeapon(_weapons[_currentWeaponNumber]);
        _currentWeapon.Create(_shotPoint);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentWeapon.Shoot(_shotPoint);
        }
    }

    private void ChangeWeapon(Weapon weapon)
    {
        _currentWeapon = weapon;
    }

    public void BuyWeapon(Weapon weapon)
    {
        _money -= weapon.Price;
        _weapons.Add(weapon);
        MoneyChanged?.Invoke(_money);
        _currentWeapon.Create(_shotPoint);
    }

    public void NextWeapon()
    {
        if (_currentWeaponNumber == _weapons.Count - 1)
            _currentWeaponNumber = 0;
        else
            _currentWeaponNumber++;

        ChangeWeapon(_weapons[_currentWeaponNumber]);
    }

    public void PreviousWeapon()
    {
        if (_currentWeaponNumber == 0)
            _currentWeaponNumber = _weapons.Count - 1;
        else
            _currentWeaponNumber--;

        ChangeWeapon(_weapons[_currentWeaponNumber]);
    }
}