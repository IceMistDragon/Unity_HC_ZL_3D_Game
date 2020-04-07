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

    /// <summary>
    /// 防禦力
    ///</summary>
    //public float def { get;}
    public float def
    {
        get
        {
            return 77.5f;
        }
    }

public int lv = 5;

//錯誤:不能在欄位指定後方使用欄位
//public int MP = lv * 8; 
public int mp
{
    get
    {
        return lv * 8;
    }

}
private float _damage;

public float damage
{
    set
    {
        _damage = Mathf.Clamp(value - def, 1, 999999); 
    }
    get
    {
        return _damage;
    }
}

}

