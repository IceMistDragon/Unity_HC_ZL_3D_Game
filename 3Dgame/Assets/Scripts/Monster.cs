using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("怪物資料")]
    public MonsterData Data;

    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }

    //private void Start()
    //{
    //    print("Zomble:" + Data.hp); 
    //}

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收到的傷害值</param>
    public void Damage(float damage)
    {
        Data.hp -= damage;

        if (Data.hp <= 0) Deed();
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Deed()
    {
        ani.SetBool("死亡", true);
    }
}
