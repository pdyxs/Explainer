using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PDYXS.Explainer
{
    [RequireComponent(typeof(Focusable))]
    public abstract class Explainable : MonoBehaviour
    {
        public abstract string Explanation();

        protected virtual void Start()
        {
            var focusable = GetComponent<Focusable>();
            focusable.OnFocusGained.AddListener(OnFocusGained);
            focusable.OnFocusLost.AddListener(OnFocusLost);
        }

        private void OnFocusGained()
        {
            ExplainerText.SetText(Explanation());
        }

        private void OnFocusLost()
        {
            ExplainerText.SetText("");
        }
    }
}