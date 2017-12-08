using System;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using Object = UnityEngine.Object;

namespace UnityEditor.VFX.UI
{
    class VFXBlockPresenter : VFXContextSlotContainerPresenter
    {
        public void Init(VFXBlock model, VFXContextPresenter contextPresenter)
        {
            base.Init(model, contextPresenter);
        }

        public VFXBlock block
        {
            get { return model as VFXBlock; }
        }

        public int index
        {
            get { return contextPresenter.FindBlockIndexOf(this); }
        }

        bool ShouldIgnoreMember(Type type, FieldInfo field)
        {
            return typeof(ISpaceable).IsAssignableFrom(type) && field.Name == "space";
        }
    }
}
