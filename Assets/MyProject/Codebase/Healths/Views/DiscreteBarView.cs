using UnityEngine;
using UnityEngine.UI;

namespace MyProject.Codebase.Healths.View
{
    public class DiscreteBarView : MonoBehaviour, IHealthView
    {
        [SerializeField] private Slider _slider;
        
        public void SetMaxValue(float maxValue)
        {
            _slider.maxValue = maxValue;
        }

        public void SetValue(float value)
        {
            _slider.value = value;
        }
    }
}
