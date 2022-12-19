using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Data_Normal
{
    public int m_nLevel;
}


public class SceneChange_normal : MonoBehaviour,IGvrPointerHoverHandler,IPointerExitHandler
{
    public float time = 0.0f;
    public static int count01 = 0;
    public static int count02 = 0;
    public static int count03 = 0; // 플레이 횟수

    int random;

    public void OnGvrPointerHover(PointerEventData eventData){
        time+=Time.deltaTime;
        Debug.Log(time);
        if (time > 2.0f)
        {
            hit();
        }
    }

    public void OnPointerExit(PointerEventData eventData){
        time = 0.0f;
    }

    public void hit()
    {   
        if (count03 == 0)
        {
            random = Random.Range(1, 5);
            Debug.Log("random01: " + random);
            save(random); // 처음 플레이
            count03++;
        }

        else if(count03 == 1)
        {
            
            count01 = load(); // 처음 플레이한 스테이지 번호
            random = Random.Range(1, 5);
            while (count01 == random)
            {
                random = Random.Range(1, 5); // 다른 숫자 나옴
            }
        
            save02(random);
            count03++;
        }

        else if(count03 == 2)
        {
            count01 = load();
            count02 = load02();
            random = Random.Range(1, 5); // 세번째
            while(count01 == random || count02 == random)
            {
                random = Random.Range(1, 5);
            }
        }

        else
        {
            random = 0;
        }

        if (random == 1){
            SceneManager.LoadScene("Five_03");
            //Debug.Log("Move to Scene 3");
            time = 0.0f;
        }

        if(random == 2){
            SceneManager.LoadScene("Five_04");
            //Debug.Log("Move to Scene 4");
            time = 0.0f;
        }

        if(random == 3){
            SceneManager.LoadScene("Five_05");
            //Debug.Log("Move to Scene 5");
            time = 0.0f;
        }

        if(random == 4){
            SceneManager.LoadScene("Five_06");
            //Debug.Log("Move to Scene 6");
            time = 0.0f;
        }
    }

    public void save(int random)
    {
        // file save
        Data_Normal data_1 = new Data_Normal();
        data_1.m_nLevel = random;
        //Debug.Log("save: " + data_1.m_nLevel);
        File.WriteAllText(Application.dataPath + "/NormalPlayedStage.json", JsonUtility.ToJson(data_1));
    }

    public int load()
    {
        // file load
        string str2 = File.ReadAllText(Application.dataPath + "/NormalPlayedStage.json");

        Data_Normal data_2 = JsonUtility.FromJson<Data_Normal>(str2);
        //Debug.Log("load: " + data_2.m_nLevel);
        return data_2.m_nLevel;
    }

    public void save02(int random)
    {
        // file save
        Data_Normal data_3 = new Data_Normal();
        data_3.m_nLevel = random;
        //Debug.Log("save: " + data_3.m_nLevel);
        File.WriteAllText(Application.dataPath + "/NormalPlayedStage02.json", JsonUtility.ToJson(data_3));
    }

    public int load02()
    {
        // file load
        string str4 = File.ReadAllText(Application.dataPath + "/NormalPlayedStage02.json");

        Data_Normal data_4 = JsonUtility.FromJson<Data_Normal>(str4);
        //Debug.Log("load: " + data_4.m_nLevel);
        return data_4.m_nLevel;
    }
}

