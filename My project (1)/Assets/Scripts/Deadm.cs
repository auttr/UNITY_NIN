using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace aa
{
    public class Deadm : MonoBehaviour
    {
       /// <summary>
       /// NINININININNIN
       /// </summary>
        [SerializeField, Header("target")]
        private string target = "NINJA";
        [SerializeField, Header("final")]
        final finalm;
        [SerializeField, Header("CM��v������")]
        GameObject cmc;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.name.Contains(target))
            {
                finalm.enabled = true;
                cmc.SetActive(false);
                finalm.title = "���ߥ���";
            }
        }

    }
}


