using System;
using UnityEngine;

namespace CustomEditor
{
    public class Line : MonoBehaviour
    {
        [Header("Reference")] [SerializeField] private LineRenderer _lineRenderer;

        [Header("Mode")] [SerializeField] private EditorModes _modes;

        [SerializeField] private NodesCollection _move;

        public int SelectedPoint = -1;
            
        
        /// <summary>
        /// Returns line renderer's points
        /// </summary>
        /// <returns>Points</returns>
        public Vector3[] GetPoints()
        {
            var result = new Vector3[_lineRenderer.positionCount];
            _lineRenderer.GetPositions(result);
            return result;
        }

        public void SetPoints(Vector3[] positions)
        {
            _lineRenderer.SetPositions(positions);
        }

        public void DrawEditor()
        {
            switch (_modes)
            {
                case EditorModes.Move:
                    _move.Visualize(this);
                    break;
                case EditorModes.Add:
                    break;
                case EditorModes.Delete:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
