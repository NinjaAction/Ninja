using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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

        SceneManager.LoadScene("GameClear", LoadSceneMode.Single);

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
