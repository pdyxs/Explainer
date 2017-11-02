using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ExplainerText : MonoMultiton<ExplainerText> {

    public Text text {
        get {
            if (_text == null) {
                _text = GetComponent<Text>();
            }
            return _text;
        }
    }
    private Text _text;

    public static void SetText(string t) {
        foreach (var et in instances) {
            et.text.text = t;
        }
    }
}
