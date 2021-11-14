using UnityEngine;

namespace Assets.Scripts
{
    class Health: MonoBehaviour
    {
        [SerializeField] private float _health;
        [SerializeField] private float _healDamageValue;

        public delegate void HealthChanger();

        public event HealthChanger HealthIsChanged;

        public float CurrentHealth => _health;

        public void GetDamage()
        {
            _health -= _healDamageValue;
            HealthIsChanged?.Invoke();
        }

        public void GetHeal()
        {
            _health += _healDamageValue;
            HealthIsChanged?.Invoke();
        }
    }
}
