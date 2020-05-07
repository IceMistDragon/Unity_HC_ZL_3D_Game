using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("移動速度"), Range(0.1f,30f)]
    public float speed;

    private void MoveMethod()
    {
        transform.Translate(   0,   0,   -speed * Time.deltaTime, Space.World);
    }                    //(X左右,Y上下,Z前後)

    private void Update()
    {
        MoveMethod();
    }
}
