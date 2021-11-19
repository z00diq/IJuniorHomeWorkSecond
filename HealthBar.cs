using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Slider))]
    class HealthBar : MonoBehaviour
    {
        [SerializeField] private Health _player;
        [SerializeField] private float _duratuion;

        private Slider _slider;
        private float _normalizedHealth;

        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _slider.value = _slider.maxValue;
               
        }

        private void OnEnable()
        {
            _player.HealthChanged += OnHealthChanged;
        }

        private void OnDisable()
        {
            _player.HealthChanged -= OnHealthChanged;
        }
        private void OnHealthChanged()    
        {
            _normalizedHealth = _player.CurrentHealth / _player.MaxHealth;
            _slider.DOValue(_normalizedHealth, _duratuion);
        }

    }
}
