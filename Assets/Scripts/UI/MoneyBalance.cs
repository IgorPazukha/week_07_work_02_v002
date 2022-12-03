using TMPro;
using UnityEngine;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _moneyText;
    [SerializeField] private Transform _shotPoint;

    private void OnEnable()
    {
        _moneyText.text = _player.Money.ToString();
        _player.MoneyChanged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _player.MoneyChanged -= OnMoneyChanged;
    }

    private void OnMoneyChanged(int money)
    {
        _moneyText.text = money.ToString();
    }
}