
using UnityEngine;


    namespace aa 
{
    public class player : MonoBehaviour
    {
        #region ���
        [SerializeField , Tooltip("�]�t"),Range(0,20)    ]
        private float speed = 3.5f;
        [SerializeField]
        //private float JH = 350;
        private Rigidbody2D rig;
        private Animator ani;
        bool clickR;
        #endregion
        #region �B��
        private void FixedUpdate()
        {
        
        }
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        void RusS()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow ))
            {

                rig.velocity = new Vector2(speed, rig.velocity.y);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rig.velocity = new Vector2(-speed, rig.velocity.y);
            }
         
         
        }
       
        private void Start()
        {

        }
        private void Update()
        {
            RusS();
        }
        #endregion
        #region ���
        #endregion
        #region ���
        #endregion
        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
        }

    }
    

}

