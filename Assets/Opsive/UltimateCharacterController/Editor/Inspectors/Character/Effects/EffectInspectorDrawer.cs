﻿/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.Editor.Inspectors.Character
{
    using Opsive.Shared.Editor.Inspectors;
    using Opsive.UltimateCharacterController.Character.Effects;
    using Opsive.UltimateCharacterController.Editor.Inspectors.Utility;
    using UnityEngine;

    /// <summary>
    /// Draws a custom inspector for the base Effect type.
    /// </summary>
    [InspectorDrawer(typeof(Effect))]
    public class EffectInspectorDrawer : InspectorDrawer
    {
        /// <summary>
        /// Called when the object should be drawn to the inspector.
        /// </summary>
        /// <param name="target">The object that is being drawn.</param>
        /// <param name="parent">The Unity Object that the object belongs to.</param>
        public override void OnInspectorGUI(object target, Object parent)
        {
            DrawInspectorDrawerFields(target, parent);

            InspectorUtility.DrawField(target, "m_InspectorDescription");
        }

        /// <summary>
        /// Draws the fields related to the inspector drawer.
        /// </summary>
        /// <param name="target">The object that is being drawn.</param>
        /// <param name="parent">The Unity Object that the object belongs to.</param>
        protected virtual void DrawInspectorDrawerFields(object target, Object parent)
        {
            Shared.Editor.Inspectors.Utility.ObjectInspector.DrawFields(target, false);
        }
    }
}