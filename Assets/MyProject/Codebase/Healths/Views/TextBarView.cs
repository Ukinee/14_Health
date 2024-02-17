using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MyProject.Codebase.Healths.View
{
    public class TextBarView : MonoBehaviour, IHealthView
    {
        [SerializeField] private TMP_Text _text;
        
        private float _maxValue;
        
        public void SetMaxValue(float maxValue)
        {
            _maxValue = maxValue;
        }

        public void SetValue(float value)
        {
            _text.text = $"{(int)value}/{(int)_maxValue}";
        }
    }
}
