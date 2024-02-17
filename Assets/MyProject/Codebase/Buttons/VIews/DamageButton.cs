using System;
using MyProject.Codebase.Healths.Presenter;
using UnityEngine;
using UnityEngine.UI;

namespace MyProject.Codebase.Buttons
{
    public class DamageButton : MonoBehaviour
    {
        [SerializeField] private Button _button;

        [SerializeField] private float _damage;

        private IDamageDealer _damageDealer;

        public void Construct(IDamageDealer damageDealer)
        {
            _damageDealer = damageDealer;
        }
        
        private void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            _damageDealer.TakeDamage(_damage);
        }
    }
}
