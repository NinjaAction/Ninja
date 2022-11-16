using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossUI : MonoBehaviour
{
    private Stats stats;

    private Image image;

    private float m_HP;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        stats = GetComponentInParent<Stats>();
    }

    // Update is called once per frame
    void Update()
    {
        m_HP = stats.GetHP();


        image.fillAmount = m_HP / stats.GetMaxHP();
    }
}
