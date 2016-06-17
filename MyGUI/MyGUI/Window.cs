using UnityEngine;

namespace MyGUI
{
    public abstract class Window : MonoBehaviour
    {

        protected virtual void Awake() {}

        public abstract void Init();

        public abstract bool Enter();

        public abstract bool Refresh();

        public abstract void Leave();


    }
}
