using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("怪物資料")]
    public MonsterData Data;
    [Header("補血藥水")]
    public GameObject propHP;
    [Header("加速藥水")]
    public GameObject propcd;
    [Header("發射物件")]
    public GameObject bullet;

    private Animator ani;
    private float hp;
    private float timer;        //j計時器

    private void Start()
    {
        hp = Data.hp;
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        Attaack();
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
        hp -= damage;

        if (hp <= 0) Deed();
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Deed()
    {
        ani.SetBool("死亡", true);
        DropProp();
        Destroy(gameObject, 0.1f);

    }

    /// <summary>
    /// 掉落道具
    /// </summary>
    private void DropProp()
    {
        float rHP = Random.Range(0f, 1f);
        if (rHP <= Data.propHP) Instantiate(propHP, transform.position, Quaternion.identity);
        float rcd = Random.Range(0f, 1f);
        if (rcd <= Data.propHP) Instantiate(propcd, transform.position, Quaternion.identity);

        //print("掉落補血藥機率:" + rHP);

    }

    /// <summary>
    /// 發射物件
    /// </summary>
    private void Attaack()
    {
        timer += Time.deltaTime;

        if (timer >= Data.cd)
        {
            timer = 0;
            GameObject temp = Instantiate(bullet, transform.position + transform.forward, Quaternion.identity);
            temp.AddComponent<Move>().speed = Data.bulletSpeedZ;
            
            temp.AddComponent<Ball>().damage = Data.attack;

            temp.GetComponent<Ball>().type = "怪物";

        }

    }

}
