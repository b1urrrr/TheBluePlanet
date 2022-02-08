using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public Text textName;
    public Text textSentence;
    int arrayIndex;

    string[] nameArray = {"엄마", "웨드", "엄마", "웨드", "엄마", "엄마","웨드","엄마","엄마","웨드","웨드","웨드"
            ,"엄마","웨드","웨드","엄마", "엄마","엄마" };
    string[] sentenceArray = {"... 2000년 전의 아름다웠던 지구는 역사에 기록되어 오래도록 기억될 것입니다.", "와- 엄마, 지구는 정말 아름다운 별이네요.","맞아, 그렇게 푸른 별은 앞으로도 찾기 힘들 거야.", "그 별에 제가 찾아가볼 수 있을까요?"
            , "웨드야, 그건 많이 힘들거야.", "지구는 2천년 전과 많이 달라졌어.", "그게 무슨 말이에요, 엄마?"
            ,"오래 전 지구에 살던 자들은 지구의 자연을 아끼지 않았어.", "그래서 지구는 지금 많이 아프단다."
            ,"⋅⋅⋅⋅⋅⋅.","하지만 그 별이 망가져 가는 걸 보고만 있고 싶지 않아요...", "제가 지구에 가봐야할 것 같아요."
            , "어린 너한테는 너무 길고 위험한 여정이 될 거야.", "엄마, 지구에 가는 건 제가 처음으로 가지게 된 꿈이에요."
            , "저도 지구의 흙을 만져보고, 물을 느껴보고, 공기를 마셔보고, \n초원 위에서 구름도 구경하고 싶어요."
            ,"⋅⋅⋅⋅⋅⋅.","아무리 말해도 너를 말릴 수 없을 것 같구나.","그 대신 지금 가지게 된 꿈을 잊지 말렴." };

    void Start()
    {
        arrayIndex = 0;
        DialogueUpdate();
    }

    public void DialogueUpdate()
    {
        Debug.Log(arrayIndex);
        if (arrayIndex < nameArray.Length)
        {
            textName.text = nameArray[arrayIndex];
            textSentence.text = sentenceArray[arrayIndex];
            arrayIndex++;
        }
        else
            DialogueEnd();

    }
    void DialogueEnd()
    {
        gameObject.SetActive(false);
        Invoke("next", 2.5f);
    }

    void next()
    {
        SceneManager.LoadScene("Narration");
    }
}

