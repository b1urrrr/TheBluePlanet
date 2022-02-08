using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int textIndex;

    GameObject myText1;
    GameObject myText2;
    GameObject myText3;
    GameObject myText4;
    GameObject nextDialogue;

    void Start()
    {
        textIndex = 0;

        myText1 = GameObject.Find("Book").transform.Find("bookText1").gameObject;
        myText2 = GameObject.Find("Book").transform.Find("bookText2").gameObject;
        myText3 = GameObject.Find("Book").transform.Find("bookText3").gameObject;
        myText4 = GameObject.Find("Book").transform.Find("bookText4").gameObject;

        nextDialogue = GameObject.Find("Canvas").transform.Find("dialogue").gameObject;
    }

    public void Show()
    {
        Debug.Log(textIndex);

        if (textIndex == 0)
        {
            myText1.SetActive(false);
            myText2.SetActive(true);
            GetComponent<AudioSource>().Play();
        }
        else if (textIndex == 1)
        {
            myText2.SetActive(false);
            myText3.SetActive(true);
            GetComponent<AudioSource>().Play();
        }
        else if (textIndex == 2)
        {
            myText3.SetActive(false);
            myText4.SetActive(true);
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GameObject.Find("Book").SetActive(false);
            GameObject.Find("nextButton").SetActive(false);
            Invoke("NextDialogue", 0.2f);

        }
        textIndex++;
    }

    public void NextDialogue()
    {
        nextDialogue.SetActive(true);
    }
}
