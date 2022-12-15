using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIResult : MonoBehaviour
{

    [SerializeField] Text grade;
    [SerializeField] Text Answer;
    [SerializeField] Button btnToMain;

    void Start()
    {
        UIManager.GetInstance().SetEventSystem();
        GetScore();
        btnToMain.onClick.AddListener(OnClickMain);
        
    }

    public void GetScore()
    {
        grade.text = $"{ResultManager.instance.totalScore}Á¡!{ResultManager.GetInstance().Grade()}";
        Answer.text = $"{ResultManager.GetInstance().Answer()}";
            
    }

    public void OnClickMain()
    {
        UIManager.GetInstance().ClearList();
        SceneManager.LoadScene("Main");
    }
}
