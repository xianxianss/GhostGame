using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed;

    public float h;
    private Rigidbody2D rig;

    #endregion

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
       
    }


    #region 方法

    
     



    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
     
        float v = Input.GetAxis("Vertical"); 
        float h = Input.GetAxis("Horizontal");
       
        rig.MovePosition(transform.position + transform.forward * v * speed * Time.deltaTime + transform.right * h * speed * Time.deltaTime);

    }





        #endregion
    }
