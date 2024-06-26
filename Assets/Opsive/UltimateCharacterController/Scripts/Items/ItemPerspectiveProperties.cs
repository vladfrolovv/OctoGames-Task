﻿/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.Items
{
    using Opsive.Shared.Game;
    using Opsive.Shared.StateSystem;
    using Opsive.Shared.Utility;
    using Opsive.UltimateCharacterController.Character;
    using UnityEngine;

    /// <summary>
    /// Describes any perspective dependent properties for the ItemAction.
    /// </summary>
    public abstract class ItemPerspectiveProperties : StateBehavior
    {
        [Tooltip("The corresponding ID of the action component that this object belongs to.")]
        [SerializeField] protected int m_ActionID;

        [NonSerialized] public int ActionID { get { return m_ActionID; } set { m_ActionID = value; } }

        protected GameObject m_Object;
        protected GameObject m_Character;
        protected UltimateCharacterLocomotion m_CharacterLocomotion;
        protected Transform m_CharacterTransform;

        public abstract bool FirstPersonItem { get; }

        /// <summary>
        /// Initialize the default values.
        /// </summary>
        protected override void Awake()
        {
            base.Awake();

            var perspectiveItems = GetComponents<PerspectiveItem>();
            for (int i = 0; i < perspectiveItems.Length; ++i) {
                if (perspectiveItems[i].FirstPersonItem == FirstPersonItem) {
                    m_Object = perspectiveItems[i].Object;
                    break;
                }
            }

            m_CharacterLocomotion = gameObject.GetCachedParentComponent<UltimateCharacterLocomotion>();
            m_Character = m_CharacterLocomotion.gameObject;
            m_CharacterTransform = m_Character.transform;
        }
    }
}