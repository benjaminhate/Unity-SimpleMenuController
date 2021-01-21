using SimpleMenuController.Runtime;
using UnityEditor;
using UnityEngine;

namespace SimpleMenuController.Editor
{
    [CustomEditor(typeof(MenuController))]
    public class MenuControllerEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var menuController = (MenuController) target;
            
            var property = serializedObject.GetIterator();
            property.NextVisible(true);
            do
            {
                if (property.name == "m_Script")
                {
                    GUI.enabled = false;
                    EditorGUILayout.PropertyField(property);
                    GUI.enabled = true;
                    continue;
                }

                if (property.name != nameof(menuController.menus))
                {
                    EditorGUILayout.PropertyField(property);
                }
                else
                {
                    if (!menuController.autoDetectMenus)
                    {
                        EditorGUILayout.PropertyField(property);
                    }
                }
            } while (property.NextVisible(false));

            serializedObject.ApplyModifiedProperties();
        }
    }
}