using MyProject.Codebase.Buttons;
using MyProject.Codebase.Buttons.Presenter;
using MyProject.Codebase.Healths.Model;
using MyProject.Codebase.Healths.Presenter;
using MyProject.Codebase.Healths.View;
using MyProject.Codebase.Healths.Views;
using UnityEngine;

namespace MyProject.Codebase.Bootstrap
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private DiscreteBarView _discreteDiscreteBarView;
        [SerializeField] private ContinuousBarView _continuousDiscreteBarView;
        [SerializeField] private TextBarView _textBarView;
        
        [SerializeField] private DamageButton _damageButton;
        [SerializeField] private HealButton _healButton;

        private void Awake()
        {
            Health health = new Health(300);
            
            HealthPresenter textHealthPresenter = new HealthPresenter(health, _textBarView);
            HealthPresenter discreteHealthPresenter = new HealthPresenter(health, _discreteDiscreteBarView);
            HealthPresenter continuousHealthPresenter = new HealthPresenter(health, _continuousDiscreteBarView);

            HealthButtonPresenter healthButtonPresenter = new HealthButtonPresenter(health);
            
            _damageButton.Construct(healthButtonPresenter);
            _healButton.Construct(healthButtonPresenter);
            
            textHealthPresenter.Enable();
            discreteHealthPresenter.Enable();
            continuousHealthPresenter.Enable();
        }
    }
}
