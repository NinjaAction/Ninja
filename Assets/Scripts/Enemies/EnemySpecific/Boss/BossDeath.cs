using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDeath : CoreComponent
{
    [SerializeField] private GameObject[] deathparticles;

    private ParticleManager ParticleManager => particleManager ? particleManager : core.GetCoreComponent(ref particleManager);
    private ParticleManager particleManager;

    private Stats Stats { get => stats ?? core.GetCoreComponent(ref stats); }
    private Stats stats;

    public void Die()
    {
        foreach (var particle in deathparticles)
        {
            ParticleManager.StartParticles(particle);
        }
        GameObject.Find("Canvas").GetComponent<ScoreController>().AddScoreBoss();

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
