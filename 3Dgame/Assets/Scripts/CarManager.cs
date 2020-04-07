
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public Car car1;

    private void Start()
    {
        // 使用選填式參數可以用 參數: 指定想要使用的選填式參數
        car1.Drive(99, "888");         //呼叫方法(引述)
        car1.Drive(999.9f, dir: "0");
        car1.Drive(123.5f,"扣扣扣");
    }
}
