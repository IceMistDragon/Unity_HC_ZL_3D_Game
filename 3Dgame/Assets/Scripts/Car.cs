
using UnityEngine;

public class Car : MonoBehaviour
{
    //方法
    /// <summary>
    /// 開車
    /// </summary>
    /// <param name="speed">時速</param>
    /// <param name="sound">音效</param>
    public void Drive(float speed, string sound = "咻咻咻",string dir = "前方")
    { 

        print("開車囉~ 時速" + speed);
        print("開車音效:" + sound);
        print("開車方向:" + dir);

    }

    public bool Cool()
    {
        print("開啟空調");
        return true;

    }

}
