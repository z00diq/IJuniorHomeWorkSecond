using UnityEngine;

namespace Assets.Scripts
{
    class PlayerHealthState: MonoBehaviour
    {
        [SerializeField] PlayerModel _player;
        [SerializeField] float  _damage;
        [SerializeField] float _heal;
        
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
