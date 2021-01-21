using UnityEngine;

namespace SimpleMenuController.Runtime
{
    [AddComponentMenu("Simple Menu Controller/Menu")]
    public class Menu : MonoBehaviour
    {
        [Header("Self contained menu")]
        [Tooltip("If enabled, the GameObject with the Menu component will be used for activation")]
        public bool isSelfContained = true;
        
        [Header("Menu")]
        [Tooltip("The GameObject used for activation")]
        public GameObject menuGameObject;

        private void OnEnable()
        {
            if (isSelfContained)
            {
                menuGameObject = gameObject;   
            }
        }

        public Menu PreviousMenu { get; private set; }
        
        public virtual void Open(Menu previousMenu)
        {
            if (previousMenu != null) previousMenu.Close();
            PreviousMenu = previousMenu;
            
            Activate(true);
        }

        public virtual void Close()
        {
            Activate(false);
        }

        private void Activate(bool active)
        {
            menuGameObject.SetActive(active);
        }
        
        public virtual void Return()
        {
            if (PreviousMenu == null) return;
            
            Close();
            PreviousMenu.Open(PreviousMenu.PreviousMenu);
        }
    }
}