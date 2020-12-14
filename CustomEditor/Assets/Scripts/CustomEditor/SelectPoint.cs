using UnityEditor;
using UnityEngine;

namespace CustomEditor
{
    [CreateAssetMenu(menuName = "Config/NodesCollectionAction/SelectPoint", fileName = "SelectPoint")]
    public class SelectPoint : AbstractNodeAction
    {
        [SerializeField]
        Color _color;
        
        [SerializeField] float _handleSize = 0.04f;
        [SerializeField] private float _pickSize = 0.06f;
            
        
        public override void Visualize(Line line)
        {
            var handleTransform = line.transform;
            var handleRotation = Tools.pivotRotation == PivotRotation.Local
                ? handleTransform.rotation
                : Quaternion.identity;

            var points = line.GetPoints();
            Handles.color = _color;

            for (var index = 0; index < points.Length; index++)
            {
                var point = points[index];
                if (Handles.Button(point, handleRotation, _handleSize, _pickSize, Handles.DotHandleCap))
                {
                    line.SelectedPoint = index;
                }
            }
        }
    }
}