using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("# Game Control")]
    public bool isLive;
    public float gameTime;
    [Header("# Player Info")]
    public float health, exp, stress, relation, money;
    public float maxStat = 100f;
    [Header("# Game Object")]
    //public Transform uiJoy;
    public Player player;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        isLive = true;

        health = 100;
        exp = 10;
        stress = 0;
        relation = 10;
        money = 100;

        gameTime = 0;
    }

    void Update()
    {
        if (!isLive)
            return;

        gameTime += Time.deltaTime;
        
        health = Mathf.Max(health - 0.05f, 0f);
        exp = Mathf.Min(exp + 0.1f, 100f);
        stress = Mathf.Min(stress + 0.05f, 100f);
        relation = Mathf.Min(relation + 0.1f, 100f);
        money = Mathf.Max(money - 0.1f, 0f);

        if(health == 0f || exp == 0f || stress  == 100f || relation  == 0f || money  == 0f) isLive = false;

        if (Input.GetKeyDown(KeyCode.Alpha1)) health = Mathf.Min(health + 10f, 100f);
        if (Input.GetKeyDown(KeyCode.Alpha2)) health = Mathf.Max(health - 10f, 0f);
        if (Input.GetKeyDown(KeyCode.Alpha3)) exp = Mathf.Max(exp - 10f, 0f);
        if (Input.GetKeyDown(KeyCode.Alpha4)) exp = Mathf.Min(exp + 10f, 100f);
        if (Input.GetKeyDown(KeyCode.Alpha5)) stress = Mathf.Max(stress - 10f, 0f);
        if (Input.GetKeyDown(KeyCode.Alpha6)) stress = Mathf.Min(stress + 10f, 100f);
        if (Input.GetKeyDown(KeyCode.Alpha7)) relation = Mathf.Max(relation - 10f, 0f);
        if (Input.GetKeyDown(KeyCode.Alpha8)) relation = Mathf.Min(relation + 10f, 100f);
        if (Input.GetKeyDown(KeyCode.Alpha9)) money = Mathf.Min(money + 10f, 100f);
        if (Input.GetKeyDown(KeyCode.Alpha0)) money = Mathf.Max(money - 10f, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isLive) Stop();
            else Resume();
        } 
    }

    public void Stop()
    {
        isLive = false;
        Time.timeScale = 0;
        //uiJoy.localScale = Vector3.zero;
    }

    public void Resume()
    {
        isLive = true;
        Time.timeScale = 1;
        //uiJoy.localScale = Vector3.one;
    }
}
