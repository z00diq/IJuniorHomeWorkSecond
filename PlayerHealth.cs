using UnityEngine;

namespace Assets.Scripts
{
    class PlayerHealth: MonoBehaviour
    {
        [SerializeField] private float _health;
        [SerializeField] private float _healDamageValue;

        public delegate void ChangeHealth();

        public event ChangeHealth RenderHealth;

        public float Health => _health;

        public void GetDamage()
        {
            _health -= _healDamageValue;
            RenderHealth?.Invoke();
        }

        public void GetHeal()
        {
            _health += _healDamageValue;
            RenderHealth?.Invoke();
        }
    }
}
