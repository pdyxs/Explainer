using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace PDYXS.Explainer
{
    public class Focusable : MonoBehaviour, 
                             IPointerClickHandler, 
                             IPointerEnterHandler,
                             IPointerExitHandler
    {
        public static Focusable FocusedObject {
            get {
                if (HoveredObject != null) {
                    return HoveredObject;
                }
                return ClickedObject;
            }
        }

        private static Focusable HoveredObject {
            get; set;
        }
        private static Focusable ClickedObject {
            get; set;
        }

        public class FocusEvent : UnityEvent {}
        public FocusEvent OnFocusGained = new FocusEvent();
        public FocusEvent OnFocusLost = new FocusEvent();

        public void OnPointerClick(PointerEventData eventData)
        {
            if (FocusedObject != this) {
                if (FocusedObject != null)
                {
                    FocusedObject.OnFocusLost.Invoke();
                }
                OnFocusGained.Invoke();
            }
            HoveredObject = null;
            ClickedObject = this;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (FocusedObject != this) {
                if (FocusedObject != null) {
                    FocusedObject.OnFocusLost.Invoke();
                }
                HoveredObject = this;
                OnFocusGained.Invoke();
            }
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (HoveredObject == this) {
                OnFocusLost.Invoke();
                HoveredObject = null;
                if (ClickedObject != null) {
                    ClickedObject.OnFocusGained.Invoke();
                }
            }
        }
    }
}