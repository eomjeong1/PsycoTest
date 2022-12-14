using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIChapter : MonoBehaviour
{




    [SerializeField] List<Button> btnGenre;
    Quiz quiz;

    void Start()
    {
        SetBtnGenre();
    }


    private void SetBtnGenre()
    {
        for (int i = 0; i < btnGenre.Count; i++)
        {
            int idx = i;
            btnGenre[i].onClick.AddListener(() => { OnClickGenre(idx); });
        }
    }

    private void OnClickGenre(int value)
    {
        quiz = (Quiz)value;
        TestManager.GetInstance().quiztype = quiz;
        SceneManager.LoadScene("Test");
    }
}
