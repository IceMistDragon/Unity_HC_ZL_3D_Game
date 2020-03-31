
//  1. 隱藏滑鼠  類別：Cursor  屬性：visible

//  2. 翻轉圖片  類別：SpriteRenderer  屬性：filpX

//  3. 去小數點  類別：Mathf  方法：Floor

//  4. 旋轉物件  類別：Transform  方法：Rotate

using UnityEngine;
using System.Collections;

public class CursorScript : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }
}


  