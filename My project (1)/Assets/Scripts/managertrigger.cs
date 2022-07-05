using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace aa
{
    public class managertrigger : MonoBehaviour
    {
        [SerializeField, Header("目標")]
        private string target = "NINJA";

        [SerializeField]JUMP js;
        [SerializeField]player ps;
        [SerializeField, Header("結束畫面")]
        final fi;






        private void OnTriggerEnter2D(Collider2D collision)
        {
            print(collision.name);
           if(collision.name.Contains(target))
            {
                js.enabled = false;
                ps.enabled = false;
                fi.enabled = true;
                fi.title = "恭喜過關";
            }

        }
    }

}
