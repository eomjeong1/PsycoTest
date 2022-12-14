using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{
    Button startBtn;

    void Start()
    {
        startBtn = GetComponentInChildren<Button>();
        startBtn.onClick.AddListener(OnClickBtn);

    }
    private void OnClickBtn()
    {

        SceneManager.LoadScene("Chapter");
    }
}
