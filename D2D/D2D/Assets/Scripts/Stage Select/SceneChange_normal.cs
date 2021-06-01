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
        // Normal 단계에서 몇 개의 스테이지를 플레이했는지 저장하는 파일

        // 빌드할 때 주석 해제
        /*Data_Normal data30 = new Data_Normal();
        data30.m_nLevel = 0;
        File.WriteAllText(Application.dataPath + "/TestNormal03.json", JsonUtility.ToJson(data30));
        Debug.Log("data30.m_nLevel: " + data30.m_nLevel);*/

        // 어디까지 진행했는지 읽어오기
        /*string str31 = File.ReadAllText(Application.dataPath + "/TestNormal03.json");
        Data_Normal data31 = JsonUtility.FromJson<Data_Normal>(str31);
        count03 = data31.m_nLevel;*/

        
        if (count03 == 0)
        {
            random = Random.Range(1, 5);
            Debug.Log("random01: " + random);
            save(random); // 처음 플레이
            count03++;
            /*Data_Normal data3 = new Data_Normal();
            data3.m_nLevel = random;
            File.WriteAllText(Application.dataPath + "/TestNormal.json", JsonUtility.ToJson(data3));*/

            //Data_Normal data32 = new Data_Normal();
            //빌드할 때 주석 해제
            //data32.m_nLevel = 0;
            // 빌드할 때 주석
            //data32.m_nLevel = 1;
            //File.WriteAllText(Application.dataPath + "/TestNormal03.json", JsonUtility.ToJson(data32));
            //Debug.Log("data32.m_nLevel: " + data32.m_nLevel);
        }

        else if(count03 == 1)
        {
            // 저번에 플레이한 씬 뭔지
            /*string str2 = File.ReadAllText(Application.dataPath + "/TestNormal.json");
            Data_Normal data4 = JsonUtility.FromJson<Data_Normal>(str2);
            count01 = data4.m_nLevel;*/

            count01 = load(); // 처음 플레이한 스테이지 번호
            random = Random.Range(1, 5);
            while (count01 == random)
            {
                random = Random.Range(1, 5); // 다른 숫자 나옴
            }
            //Debug.Log("random02: " + random);
            // 두 번째 플레이하는 씬 저장
            /*Data_Normal data1 = new Data_Normal();
            data1.m_nLevel = random;
            File.WriteAllText(Application.dataPath + "/TestNormal02.json", JsonUtility.ToJson(data1));*/
            save02(random);

            // 두 번재 플레이한다는 것 저장
            /*Data_Normal data33 = new Data_Normal();
            data33.m_nLevel = 2;
            File.WriteAllText(Application.dataPath + "/TestNormal03.json", JsonUtility.ToJson(data33));*/
            //Debug.Log("data33.m_nLevel: " + data33.m_nLevel);
            count03++;
        }

        else if(count03 == 2)
        {
            /*string str4 = File.ReadAllText(Application.dataPath + "/TestNormal.json");
            Data_Normal data5 = JsonUtility.FromJson<Data_Normal>(str4);
            count01 = data5.m_nLevel;

            string str3 = File.ReadAllText(Application.dataPath + "/TestNormal02.json");
            Data_Normal data2 = JsonUtility.FromJson<Data_Normal>(str3);
            count02 = data2.m_nLevel;*/
            count01 = load();
            count02 = load02();
            random = Random.Range(1, 5); // 세번째
            while(count01 == random || count02 == random)
            {
                random = Random.Range(1, 5);
            }
            //Debug.Log("random03" + random);

            /*Data_Normal data34 = new Data_Normal();
            data34.m_nLevel = 3;
            File.WriteAllText(Application.dataPath + "/TestNormal03.json", JsonUtility.ToJson(data34));
            Debug.Log("data34.m_nLevel: " + data34.m_nLevel);*/
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

