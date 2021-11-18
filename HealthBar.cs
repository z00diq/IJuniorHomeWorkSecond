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
        private float _currentValue;
        private float _normalizedValue;

        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _slider.value = _slider.maxValue;
            _normalizedValue =  _slider.maxValue / _player.CurrentHealth;   
        }

        private void OnEnable()
        {
            _player.OnHealthChanged += RenderFill;
        }

        private void OnDisable()
        {
            _player.OnHealthChanged -= RenderFill;
        }
        private void RenderFill()    
        {
            _currentValue = _player.CurrentHealth * _normalizedValue;
            _slider.DOValue(_currentValue, _duratuion);
        }

    }
}
