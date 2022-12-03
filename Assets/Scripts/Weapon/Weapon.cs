using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _lable;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isBuyed = false;

    [SerializeField] protected Bullet Bullet;
    [SerializeField] protected GameObject WeaponObject;
    [SerializeField] protected Transform ShotPoint;

    private Player _position;

    public string Lable => _lable;
    public int Price => _price;
    public Sprite Icon => _icon;
    public bool IsBuyed => _isBuyed;
    public Player Postion => _position;

    public abstract void Shoot(Transform shootPosition);

    public abstract void Create(Transform position);

    public void Buy()
    {
        _isBuyed = true;
    }
}