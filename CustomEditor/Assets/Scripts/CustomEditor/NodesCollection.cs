using System.Collections.Generic;
using UnityEngine;

namespace CustomEditor
{
    [CreateAssetMenu(menuName = "Config/NodesCollection", fileName = "NodesCollection")]
    public class NodesCollection : ScriptableObject
    {
        [SerializeField] private List<Node> _nodes;

        public void Visualize(Line line)
        {
            foreach (var node in _nodes)
            {
                node.Visualize(line);
            }
        }
    }
}
