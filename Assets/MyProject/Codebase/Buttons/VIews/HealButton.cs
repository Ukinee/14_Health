using MyProject.Codebase.Healths.Presenter;
using UnityEngine;
using UnityEngine.UI;

namespace MyProject.Codebase.Buttons
{
    public class HealButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _heal;

        private IHealer _healer;
        
        public void Construct(IHealer healer)
        {
            _healer = healer;
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
            _healer.RestoreHealth(_heal);
        }
    }
}
