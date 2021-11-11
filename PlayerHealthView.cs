using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Slider))]
    class PlayerHealthView : MonoBehaviour
    {
        [SerializeField] private PlayerHealth _player;
        [SerializeField] private float _duratuion;
        private Slider _slider;
        private float _currentValue;
        private float _normalizedValue;

        public PlayerHealth Player => _player;

        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _slider.value = _slider.maxValue;
            _normalizedValue = _slider.maxValue / Player.Health;
        }

        private void Update()    
        {
            if (_player.ChangedHealth())
            {
                _currentValue = Player.Health*_normalizedValue;
                _slider.DOValue(_currentValue, _duratuion);
            }
        }
    }
}
