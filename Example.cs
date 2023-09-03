using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Tagrize
{
    public class Example : MonoBehaviour
    {
        [SerializeField] Text text_1;
        [SerializeField] Text text_2;

        readonly WaitForSeconds wait_0_3s = new WaitForSeconds(0.3f);
        readonly WaitForSeconds wait_0_1s = new WaitForSeconds(0.1f);

        public void OnClick_Btn_1()
        {
            StartCoroutine(_IETyping());

            IEnumerator _IETyping()
            {
                string text = "갈릭<color=#333333>버<color=#555555>터감</color><color=#777777>자</color></color><size=50>튀김</size>";
                foreach (string s in new Tagrize.String(text))
                {
                    text_1.text = s;
                    yield return wait_0_1s;
                }
            }
        }

        public void OnClick_Btn_2()
        {
            StartCoroutine(_IETyping());

            IEnumerator _IETyping()
            {
                string text = "<size=40>Z</size><size=50>Z</size><size=60>Z</size>...";
                foreach (string s in new Tagrize.String(text))
                {
                    text_2.text = s;
                    yield return wait_0_3s;
                }
            }
        }
    }
}
