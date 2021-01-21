using UnityEditor;
using UnityEngine;
using Menu = SimpleMenuController.Runtime.Menu;

namespace SimpleMenuController.Editor
{
    [CustomEditor(typeof(Menu), true)]
    public class MenuEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var menu = (Menu) target;
            
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

                if (property.name != nameof(menu.menuGameObject))
                {
                    EditorGUILayout.PropertyField(property);
                }
                else
                {
                    if (!menu.isSelfContained)
                    {
                        EditorGUILayout.PropertyField(property);
                    }
                    else
                    {
                        menu.menuGameObject = menu.gameObject;
                    }
                }
            } while (property.NextVisible(false));
            
            serializedObject.ApplyModifiedProperties();
        }
    }
}