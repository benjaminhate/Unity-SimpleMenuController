using System.Collections;
using SimpleMenuController.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Sample.Menus
{
    public class MainMenu : Menu
    {
        [Header("Buttons")]
        public Button subMenuButton;
        public Button baseMenuButton;
        public Button quitButton;

        public void Quit()
        {
            Application.Quit();
        }
        
        public override void Open(Menu previousMenu)
        {
            base.Open(previousMenu);

            ShowButtons(false);
            StartCoroutine(ShowButtonsDelayed());
        }

        private IEnumerator ShowButtonsDelayed()
        {
            yield return new WaitForSeconds(1f);
            ShowButtons(true);
        }

        private void ShowButtons(bool show)
        {
            subMenuButton.gameObject.SetActive(show);
            baseMenuButton.gameObject.SetActive(show);
            quitButton.gameObject.SetActive(show);
        }
    }
}
