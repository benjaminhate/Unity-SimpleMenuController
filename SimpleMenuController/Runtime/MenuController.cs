using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SimpleMenuController.Runtime
{
    [AddComponentMenu("Simple Menu Controller/Menu Controller")]
    public class MenuController : MonoBehaviour
    {
        [Header("Auto detect")]
        [Tooltip("This option will automatically detect Menu classes from children of MenuController")]
        public bool autoDetectMenus;
        
        [Header("Menus")]
        [Tooltip("The first Menu will be considered as MainMenu and will be opened first")]
        public List<Menu> menus;
        private Menu MainMenu => menus.FirstOrDefault();

        private void Start()
        {
            if(autoDetectMenus) AutoDetectMenus();
            ActivateMainMenu();
        }

        private void AutoDetectMenus()
        {
            var childrenMenus = transform.GetComponentsInChildren<Menu>(true);
            menus = childrenMenus.ToList();
        }

        private void ActivateMainMenu()
        {
            menus.ForEach(m => m.Close());
            if(MainMenu != null) MainMenu.Open(null);
        }
    }
}