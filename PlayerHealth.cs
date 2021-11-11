using UnityEngine;

namespace Assets.Scripts
{
    class PlayerHealth: MonoBehaviour
    {
        [SerializeField] private float _health;
        [SerializeField] private float _healDamageValue;

        private float _previosHealth;
        private bool _healthChanged;

        public float Health => _health;

        public bool HealthChanged => _healthChanged;
        public void GetDamage()
        {
            _health -= _healDamageValue;
            _healthChanged = true;
        }

        public void GetHeal()
        {
            _health += _healDamageValue;
            _healthChanged = true;
        }

        public void ChangingHealthStatus()
        {
            _healthChanged = !_healthChanged;
        }
    }
}
