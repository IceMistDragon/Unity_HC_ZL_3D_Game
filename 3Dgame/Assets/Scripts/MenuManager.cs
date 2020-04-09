
using UnityEngine;
using UnityEngine.UI;                  //引用 介面API
using UnityEngine.SceneManagement;     //引用 場景管理API
using System.Collections;              //引用 系統.集合 API (協程)

//協同程式 : 非同步處理

public class MenuManager : MonoBehaviour
{
    [Header("載入畫面")]
    /// <summary>
    /// 載入畫面
    /// </summary>
    public GameObject panelLoading;
    [Header("載入畫面文字")]
    /// <summary>
    /// 載入畫面
    /// </summary>
    public Text textLoading;
    [Header("載入畫面吧條")]
    /// <summary>
    /// 載入畫面
    /// </summary>
    public Image imgLoading;
    
    /// <summary>
    /// 開始載入遊戲場景
    /// </summary>
    public void StsrtLoading()
    {

        print("開始載入...");

        panelLoading.SetActive(true);       //顯示載入畫面

        StartCoroutine(Loading());          //啟動協程
       
    }

    /// <summary>
    /// 協同方法 : 載入
    /// </summary>
   
    private IEnumerator Loading()
    {
        //SceneManager.LoadScene("關卡1");       //載入場景
        AsyncOperation ao = SceneManager.LoadSceneAsync("關卡1");

        ao.allowSceneActivation = false;        //關閉自動載入場景

        // 迴圈 while(布林植) { 當布林植為 true 實執行敘述}

        while (ao.progress < 1)
        {
            textLoading.text = (ao.progress / 0.9f * 100).ToString("F4") + " %";   // 更新載入文字
            
            imgLoading.fillAmount = ao.progress / 0.9f;           // 更新載入吧條

            yield return null;                             //等待

            //判斷式
            if (ao.progress == 0.9f)
            {
                ao.allowSceneActivation = true;
            }

        }
    }
}
