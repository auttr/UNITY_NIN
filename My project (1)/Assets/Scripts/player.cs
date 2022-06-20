
using UnityEngine;


    namespace aa 
{
    public class player : MonoBehaviour
    {
        #region 資料
        [SerializeField , Tooltip("跑速"),Range(0,20)    ]
        private float speed = 3.5f;
        [SerializeField]
        private float JH = 350;
        private Rigidbody2D rig;
        private Animator ani;

        #endregion
        #region 運行
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        void RusS()
        {
            rig.velocity = new Vector2(speed,rig.velocity.y);
        }
        private void Start()
        {

        }
        private void Update()
        {
            RusS();
        }
        #endregion
        #region 資料
        #endregion
        #region 資料
        #endregion


    }

}

