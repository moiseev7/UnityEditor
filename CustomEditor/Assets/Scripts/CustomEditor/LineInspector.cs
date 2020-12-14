using UnityEditor;

namespace CustomEditor
{
    [UnityEditor.CustomEditor(typeof(Line))]
    public class LineInspector : Editor
    {
        private void OnSceneGUI()
        {
            Line line = target as Line;
            
            if(line==null)
                return;
            
            line.DrawEditor();
        }
    }
}