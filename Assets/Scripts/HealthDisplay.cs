using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Text _healthText;

    private void OnEnable()
    {
        _player.HealthChanged += ChangeHealthText;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= ChangeHealthText;
    }

    private void ChangeHealthText(int health)
    {
        _healthText.text = health.ToString();
    }

    
}
