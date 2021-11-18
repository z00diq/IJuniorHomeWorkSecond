using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    class Health: MonoBehaviour
    {
        [SerializeField] private float _health;
        [SerializeField] private float _healDamageValue;

        private float _maxHealth;

        public delegate void HealthChanger();

        public event UnityAction OnHealthChanged;

        public float CurrentHealth => _health;

        private void Awake()
        {
            _maxHealth = _health;    
        }

        public void GetDamage()
        {
            _health -= _healDamageValue;

            if (_health < 0)
                _health = 0;

            OnHealthChanged?.Invoke();
        }

        public void GetHeal()
        {
            _health += _healDamageValue;

            if (_health > _maxHealth)
                _health = _maxHealth;

            OnHealthChanged?.Invoke();
        }
    }
}
