
using UnityEngine;

public class EnemyManage : MonoBehaviour
{
    public Enemy enemy1, enemy2;

    private void Start()
    
    {
        //取得
        print(enemy1.HP);
        //設定
        enemy2.HP = 200;
        //設定屬性
        enemy1.attack = 999;
        //取得屬性
        print("怪物 1 號的攻擊力:" + enemy1.attack);

        //設定屬性
        print("怪物 2 號的防禦力:" + enemy2.def);
        enemy2.lv = 999;
        print("怪物 2 號的MP:" + enemy2.mp);

        enemy2.damage = 10;
        print("對怪物 2 造成傷害:" + enemy2.damage);


             

    }
}
