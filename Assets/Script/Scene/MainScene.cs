using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainScene : MonoBehaviour
{

    void Start()
    {
        UIManager uimanager = UIManager.GetInstance();
        uimanager.SetEventSystem();
        uimanager.OpenUI("MainUI");

        
        ResultManager.GetInstance();
        TestManager.GetInstance();
        ResultManager.instance.totalScore = 0;
    }

}
