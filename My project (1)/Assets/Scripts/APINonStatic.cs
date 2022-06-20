using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace auther
{
    public class APINonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject tt;
        [SerializeField]
        private Transform st;


        private void Start()
        {
            print("狀態" + tt.activeInHierarchy);
            print("圖層" + tt.layer);
            tt.tag = "Player";
            tt.layer = 4;
            tt.SetActive(false);


            print("開始位置"+st.position);
            st.position = new Vector3(0,-1.5f,0f);
        }
        private void Update()
        {
            st.Translate(new Vector3(0.1f,0,0));
            st.Rotate(new Vector3(0,0,5f));
        }
    }



}
