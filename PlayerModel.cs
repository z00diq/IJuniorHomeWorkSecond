using UnityEngine;

namespace Assets.Scripts
{
    class PlayerModel: MonoBehaviour
    {
        [SerializeField] private float _health;

        public float Health => _health;

        public void GetDamage(float damage)
        {
            _health -= damage;
        }

        public void GetHeal(float heal)
        {
            _health += heal;
        }
    }
}
