using System.Net;
using UnityEditor;
using UnityEngine;

namespace CustomEditor
{
    [CreateAssetMenu(menuName = "Config/NodesCollectionAction/MovePoint", fileName = "MovePoint")]
    public class MovePoint : AbstractNodeAction
    {
        public override void Visualize(Line line)
        {
            var handleTransform = line.transform;
            var handleRotation = Tools.pivotRotation == PivotRotation.Local
                ? handleTransform.rotation
                : Quaternion.identity;

            var points = line.GetPoints();

            var index = line.SelectedPoint;
            if(index < 0 || index>=points.Length )
                return;

            var point = points[index];
            EditorGUI.BeginChangeCheck();

            point = Handles.DoPositionHandle(point, handleRotation);
            
            if (EditorGUI.EndChangeCheck())
            {
                EditorUtility.SetDirty(line);
                points[index] = point;
                line.SetPoints(points,"Move point");
            }

        }
    }
}