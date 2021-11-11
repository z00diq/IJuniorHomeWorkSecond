using UnityEngine;

namespace Assets.Scripts
{
    class PlayerHealthState: MonoBehaviour
    {
        [SerializeField] private PlayerHealth _player;
        [SerializeField] private float  _damage;
        [SerializeField] private float _heal;
        
        public void GetDamage()
        {
            _player.GetDamage(_damage);
        }

        public void GetHeal()
        {
            _player.GetHeal(_heal);
        }
    }
}