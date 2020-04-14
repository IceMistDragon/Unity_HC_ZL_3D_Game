
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [Header("移動速度"), Range(1, 1000)]
    public float speed = 300;
    [Header("虛擬搖桿")]
    public Joystick joy;

    /// <summary>
    /// 移動方向
    /// </summary>
    public void Move()
    {
        print("移動中~");

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        transform.Translate(speed * Time.deltaTime * h, 0, speed * Time.deltaTime * v);

        float joyV = joy.Vertical;
        float joyH = joy.Horizontal;

        transform.Translate(speed * Time.deltaTime * joyH, 0, speed * Time.deltaTime * joyV);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, 17, 80);
        transform.position = pos;
    }

    private void Update()
    {
        Move();
    }
}
