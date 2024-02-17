using MyProject.Codebase.Healths.Model;
using MyProject.Codebase.Healths.Presenter;

namespace MyProject.Codebase.Buttons.Presenter
{
    public class HealthButtonPresenter : IDamageDealer, IHealer
    {
        private readonly Health _health;

        public HealthButtonPresenter(Health health)
        {
            _health = health;
        }
        
        public void TakeDamage(float damage)
        {
            _health.TakeDamage(damage);
        }

        public void RestoreHealth(float heal)
        {
            _health.RestoreHealth(heal);
        }
    }
}
