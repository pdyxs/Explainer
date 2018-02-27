using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using PDYXS.Skins;

namespace PDYXS.Explainer
{
    [RequireComponent(typeof(Draggable))]
    public class FocusOnDraggable : MonoBehaviour
    {
        //private SkinnedObjectProvider<Focusable> _focusable;
        //public Focusable focusable {
        //    get {
        //        return _focusable.obj;
        //    }
        //}

        private Draggable _draggable;
        public Draggable draggable {
            get {
                if (_draggable == null) {
                    _draggable = GetComponent<Draggable>();
                }
                return _draggable;
            }
        }

        private void Start()
        {
            //_focusable = this.Provide<Focusable>();
            draggable.OnDragBegun.AddListener(OnDragBegun);
        }

        private void OnDragBegun(Draggable arg0)
        {
            //focusable.Focus();
        }
    }
}