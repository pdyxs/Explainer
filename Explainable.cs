using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PDYXS.Explainer
{
    public abstract class Explainable : MonoBehaviour, IPointerClickHandler
    {
        public abstract string Explanation();

        public void OnPointerClick(PointerEventData eventData)
        {
            ExplainerText.SetText(Explanation());
        }
    }
}