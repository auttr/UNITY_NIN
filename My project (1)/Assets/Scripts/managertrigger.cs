using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace aa
{
    public class managertrigger : MonoBehaviour
    {
        [SerializeField, Header("�ؼ�")]
        private string target = "NINJA";

        [SerializeField]JUMP js;
        [SerializeField]player ps;
        [SerializeField, Header("�����e��")]
        final fi;






        private void OnTriggerEnter2D(Collider2D collision)
        {
            print(collision.name);
           if(collision.name.Contains(target))
            {
                js.enabled = false;
                ps.enabled = false;
                fi.enabled = true;
                fi.title = "���߹L��";
            }

        }
    }

}
