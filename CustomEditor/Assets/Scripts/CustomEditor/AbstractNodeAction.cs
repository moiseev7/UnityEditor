using UnityEngine;

namespace CustomEditor
{
    public abstract class AbstractNodeAction : ScriptableObject
    {
        public abstract void Visualize(Line line);
    }
}