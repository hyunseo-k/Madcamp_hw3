using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum InfoType { Time, Health, Exp, Stress, Relation, Money }
    public InfoType type;

    Text myText;
    Slider mySlider;

    void Awake()
    {
        myText = GetComponent<Text>();
        mySlider = GetComponent<Slider>();
    }

    void LateUpdate()
    {
        switch (type) {
            case InfoType.Time:
                int day = Mathf.FloorToInt(GameManager.instance.gameTime / 60) + 1;
                int hour = Mathf.FloorToInt(GameManager.instance.gameTime % 60 * 24 / 60);
                int min = Mathf.FloorToInt(GameManager.instance.gameTime % 60 * 24 % 60);
                myText.text = string.Format("DAY {0:00} - {1:00}:{2:00}", day, hour, min);
                break;
            case InfoType.Health:
                mySlider.value = GameManager.instance.health / GameManager.instance.maxStat;
                break;
            case InfoType.Exp:
                mySlider.value = GameManager.instance.exp / GameManager.instance.maxStat;
                break;
            case InfoType.Stress:
                mySlider.value = GameManager.instance.stress / GameManager.instance.maxStat;
                break;
            case InfoType.Relation:
                mySlider.value = GameManager.instance.relation / GameManager.instance.maxStat;
                break;
            case InfoType.Money:
                mySlider.value = GameManager.instance.money / GameManager.instance.maxStat;
                break;
        }
    }
}
