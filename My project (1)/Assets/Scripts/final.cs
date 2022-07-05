using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace aa
{
    public class final : MonoBehaviour
    {
        [SerializeField, Header("畫布畫面")]
        CanvasGroup groupfinal;
        [SerializeField, Header("結束標題")]
        TextMeshProUGUI textfinal;
        /// <summary>
        /// 控制標題
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
            print("結束");
            Application.Quit();
        }
        private void Update()
        {
          
        }
        void Fade()
        {

            groupfinal.alpha += 0.1f;
               print("淡入");
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
