using UnityEngine;

public class Death : CoreComponent
{
    [SerializeField] private GameObject[] deathparticles;

    private ParticleManager ParticleManager => particleManager ? particleManager : core.GetCoreComponent(ref particleManager);
    private ParticleManager particleManager;

    private Stats Stats { get => stats ?? core.GetCoreComponent(ref stats); }
    private Stats stats;

    public void Die()
    {
        foreach(var particle in deathparticles)
        {
            ParticleManager.StartParticles(particle);
        }

        core.transform.parent.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        Stats.OnHealthZero += Die;
    }


    private void OnDisable()
    {
        Stats.OnHealthZero -= Die;
    }
}
