using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace aa
{
    public class final : MonoBehaviour
    {
        [SerializeField, Header("�e���e��")]
        CanvasGroup groupfinal;
        [SerializeField, Header("�������D")]
        TextMeshProUGUI textfinal;
        /// <summary>
        /// ������D
        /// </summary>
        /// <param name="collision"></param>
      public string title;
        private void Start()
        {
            textfinal.text = title;
            InvokeRepeating("Fade", 0, 0.2f);
            
        }
        public void QuitG()
        {
            print("����");
            Application.Quit();
        }
        private void Update()
        {
          
        }
        void Fade()
        {

            groupfinal.alpha += 0.1f;
               print("�H�J");
            if (groupfinal.alpha>=1)
            {
             
                groupfinal.interactable = true;
                groupfinal.blocksRaycasts = true;
                CancelInvoke("Fade");
            }
        }
       public void Restart()
        {
            SceneManager.LoadScene(0);
        }
    }

}
