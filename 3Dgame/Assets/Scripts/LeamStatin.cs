
using UnityEngine;

public class LeamStatin : MonoBehaviour
{
    private void Start()
    {
        float a = 0.5f;
        int b = 70;
        bool c = true;
        bool d = false;
        string e = "我是字串";
        
    
        print(Random.value);

        Time.timeScale = 0.5f;

        print(Random.Range(0.1f, 99.9f));
        print(Random.Range(100f, 500f));

        //練習一//靜態成員-取得數學 PI 3.14159:Mathf(Math Function)

        print(Mathf.PI);

        //練習二//靜態方法-數學.絕對值 -999:Mathf

        print(Mathf.Abs(-999f));
        //camera
       

    }
    //面板
    public int score = 10;

    private int speen = 99;

    //

    public Camera cam;

    private void Start()
    {
        print("攝影機數量:" + Camera.allCamerasCount);

        print(cam.depth);
    }


}
