using System;
using UnityEngine;

namespace CustomEditor
{
    [Serializable]
    public class Node
    {
        [SerializeField] private bool _isEnabled = true;
        [SerializeField] private AbstractNodeAction _action;

        public void Visualize(Line line)
        {
            if(!_isEnabled)
                return;
            _action.Visualize(line);
        }
    }
}