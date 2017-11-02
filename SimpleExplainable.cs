using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PDYXS.Explainer
{
    public class SimpleExplainable : Explainable
    {
        [TextArea]
        public string explanation;

        public override string Explanation()
        {
            return explanation;
        }
    }
}