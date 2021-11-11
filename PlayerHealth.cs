using UnityEngine;

namespace Assets.Scripts
{
    class PlayerHealth: MonoBehaviour
    {
        [SerializeField] private float _health;
        private float _previosHealth;

        public float Health => _health;

        public void GetDamage(float damage)
        {
            _health -= damage;
        }

        public void GetHeal(float heal)
        {
            _health += heal;
        }

        public bool Changingealth()
        {
            if (_previosHealth != _health)
            {
                _previosHealth = _health;
                return true;
            }
            return false;
        }
    }
}
