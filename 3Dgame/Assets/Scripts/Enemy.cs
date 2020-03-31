using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    ///<summary>
    /// 這是怪物的血量
    ///</summary>
    [Header("血量")]
    public float HP = 50;
    //get 取得
    //set 設定

    /// <summary>
    /// 攻擊力
    /// </summary>
    public int attack { get; set; }

    
}
