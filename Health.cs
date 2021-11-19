using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    class Health: MonoBehaviour
    {
        [SerializeField] private float _health;
        [SerializeField] private float _healDamageValue;

        private float _maxHealth;

        public event UnityAction HealthChanged;

        public float CurrentHealth => _health;
        public float MaxHealth => _maxHealth;

        private void Awake()
        {
            _maxHealth = _health;    
        }

        public void GetDamage()
        {
            _health -= _healDamageValue;

            if (_health < 0)
                _health = 0;

            HealthChanged?.Invoke();
        }

        public void GetHeal()
        {
            _health += _healDamageValue;

            if (_health > _maxHealth)
                _health = _maxHealth;

            HealthChanged?.Invoke();
        }
    }
}
