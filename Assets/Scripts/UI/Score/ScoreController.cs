using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    int score = 0;
    Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        this.textComponent = GameObject.Find("Score").GetComponent<Text>();
        this.textComponent.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore()
    {
        this.score += 300;
        this.textComponent.text = "Score: " + score.ToString();
    }

    public void AddScoreBoss()
    {
        this.score += 3000;
        this.textComponent.text = "Score: " + score.ToString();
    }
}
