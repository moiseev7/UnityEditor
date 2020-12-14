#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace CustomEditor
{
    [CreateAssetMenu(menuName = "Config/NodesCollectionAction/DrawLine", fileName = "DrawLine")]
    public class DrawLine : AbstractNodeAction
    {
        [SerializeField] private Color _color;
        public override void Visualize(Line line)
        {
#if UNITY_EDITOR
            Handles.color = _color;
            var points = line.GetPoints();
            for (int i = 0; i < points.Length-1; i++)
            {
                Handles.DrawLine(points[i], points[i+1]);
            }
#endif
        }
    }
}