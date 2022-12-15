using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

[System.Serializable]
public class Sound  // 컴포넌트 추가 불가능.  MonoBehaviour 상속 안 받아서. 그냥 C# 클래스.
{
    public string name;  // 곡 이름
    public AudioClip clip;  // 곡
}

public class SoundManager : MonoBehaviour
{
    public AudioSource bgm;
    public Sound[] bgmSounds;

   
    #region singleton
    static public SoundManager instance;  // 자기 자신을 공유 자원으로. static은 씬이 바뀌어도 유지된다.

    private void Awake()  // 객체 생성시 최초 실행 (그래서 싱글톤을 여기서 생성)
    {
        if (instance == null)  // 단 하나만 존재하게끔
        {
            instance = this;  // 객체 생성시 instance에 자기 자신을 넣어줌
            DontDestroyOnLoad(gameObject);  // 씬 바뀔 때 자기 자신 파괴 방지
        }
        else
            Destroy(this.gameObject);
    }
    #endregion singleton
    // Start is called before the first frame update
    public void PlayBGM(string _name)
    {
        for (int i = 0; i < bgmSounds.Length; i++)
        {
            if (_name == bgmSounds[i].name)
            {
                bgm.clip = bgmSounds[i].clip;
                bgm.Play();
                return;
            }
        }
        Debug.Log(_name + "사운드가 SoundManager에 등록되지 않았습니다.");
    }

}
