﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using UnityEngine.EventSystems;

public class NormalText : MonoBehaviour
{
    private TextMeshProUGUI star01;// Normal
    private TextMeshProUGUI star02;
    private TextMeshProUGUI star03;// Easy
    private TextMeshProUGUI star04;
    private TextMeshProUGUI star05;// Hard
    private TextMeshProUGUI star06;

    public GameObject ending;
    public GameObject reset;

    void Start()
    {
        star01 = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        star02 = GameObject.Find("Text02").GetComponent<TextMeshProUGUI>();
        star03 = GameObject.Find("Text03").GetComponent<TextMeshProUGUI>();
        star04 = GameObject.Find("Text04").GetComponent<TextMeshProUGUI>();
        star05 = GameObject.Find("Text05").GetComponent<TextMeshProUGUI>();
        star06 = GameObject.Find("Text06").GetComponent<TextMeshProUGUI>();

        ending.SetActive(false);
        reset.SetActive(false);
    }
    void Update()
    {
        //Normal
        string str = File.ReadAllText(Application.dataPath + "/count_n.json");
        Data_n data2 = JsonUtility.FromJson<Data_n>(str);
        star01.text = data2.star_normal.ToString();
        star02.text = (3-data2.star_normal).ToString();

        //Easy
        string str2 = File.ReadAllText(Application.dataPath + "/count_e.json");
        Data_e data3 = JsonUtility.FromJson<Data_e>(str2);
        star03.text = data3.star_easy.ToString();
        star04.text = (2 - data3.star_easy).ToString();

        //Hard
        string str3 = File.ReadAllText(Application.dataPath + "/count_h.json");
        Data_h data4 = JsonUtility.FromJson<Data_h>(str3);
        star05.text = data4.star_hard.ToString();
        star06.text = (4 - data4.star_hard).ToString();

        if (data2.star_normal.ToString() == "3" && data3.star_easy.ToString() == "2" 
            && data4.star_hard.ToString() == "4")
        {
            ending.SetActive(true);
            reset.SetActive(true);
        }
    }
}
