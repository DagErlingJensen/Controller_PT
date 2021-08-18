// GENERATED AUTOMATICALLY FROM 'Assets/Input/ClickableObjects.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ClickableObjects : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ClickableObjects()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ClickableObjects"",
    ""maps"": [
        {
            ""name"": ""ClickableObj"",
            ""id"": ""4f06dceb-b4c8-4395-ab86-86186f564558"",
            ""actions"": [
                {
                    ""name"": ""MouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""a4ab6509-0e54-4289-9a02-e225026dda15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosistion"",
                    ""type"": ""PassThrough"",
                    ""id"": ""93cdf47a-a883-4d5e-9d9f-4928b6f40c24"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""b4f9d054-f200-4357-bb5b-f14b6e59106e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""02c5becf-32f1-4462-b735-9b8b97db778c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02dd3aa5-9792-4933-9eda-a37897eae5df"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosistion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8951d52-c85a-4c06-b02f-773627d687c7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ClickableObj
        m_ClickableObj = asset.FindActionMap("ClickableObj", throwIfNotFound: true);
        m_ClickableObj_MouseClick = m_ClickableObj.FindAction("MouseClick", throwIfNotFound: true);
        m_ClickableObj_MousePosistion = m_ClickableObj.FindAction("MousePosistion", throwIfNotFound: true);
        m_ClickableObj_RightMouseClick = m_ClickableObj.FindAction("RightMouseClick", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // ClickableObj
    private readonly InputActionMap m_ClickableObj;
    private IClickableObjActions m_ClickableObjActionsCallbackInterface;
    private readonly InputAction m_ClickableObj_MouseClick;
    private readonly InputAction m_ClickableObj_MousePosistion;
    private readonly InputAction m_ClickableObj_RightMouseClick;
    public struct ClickableObjActions
    {
        private @ClickableObjects m_Wrapper;
        public ClickableObjActions(@ClickableObjects wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseClick => m_Wrapper.m_ClickableObj_MouseClick;
        public InputAction @MousePosistion => m_Wrapper.m_ClickableObj_MousePosistion;
        public InputAction @RightMouseClick => m_Wrapper.m_ClickableObj_RightMouseClick;
        public InputActionMap Get() { return m_Wrapper.m_ClickableObj; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ClickableObjActions set) { return set.Get(); }
        public void SetCallbacks(IClickableObjActions instance)
        {
            if (m_Wrapper.m_ClickableObjActionsCallbackInterface != null)
            {
                @MouseClick.started -= m_Wrapper.m_ClickableObjActionsCallbackInterface.OnMouseClick;
                @MouseClick.performed -= m_Wrapper.m_ClickableObjActionsCallbackInterface.OnMouseClick;
                @MouseClick.canceled -= m_Wrapper.m_ClickableObjActionsCallbackInterface.OnMouseClick;
                @MousePosistion.started -= m_Wrapper.m_ClickableObjActionsCallbackInterface.OnMousePosistion;
                @MousePosistion.performed -= m_Wrapper.m_ClickableObjActionsCallbackInterface.OnMousePosistion;
                @MousePosistion.canceled -= m_Wrapper.m_ClickableObjActionsCallbackInterface.OnMousePosistion;
                @RightMouseClick.started -= m_Wrapper.m_ClickableObjActionsCallbackInterface.OnRightMouseClick;
                @RightMouseClick.performed -= m_Wrapper.m_ClickableObjActionsCallbackInterface.OnRightMouseClick;
                @RightMouseClick.canceled -= m_Wrapper.m_ClickableObjActionsCallbackInterface.OnRightMouseClick;
            }
            m_Wrapper.m_ClickableObjActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseClick.started += instance.OnMouseClick;
                @MouseClick.performed += instance.OnMouseClick;
                @MouseClick.canceled += instance.OnMouseClick;
                @MousePosistion.started += instance.OnMousePosistion;
                @MousePosistion.performed += instance.OnMousePosistion;
                @MousePosistion.canceled += instance.OnMousePosistion;
                @RightMouseClick.started += instance.OnRightMouseClick;
                @RightMouseClick.performed += instance.OnRightMouseClick;
                @RightMouseClick.canceled += instance.OnRightMouseClick;
            }
        }
    }
    public ClickableObjActions @ClickableObj => new ClickableObjActions(this);
    public interface IClickableObjActions
    {
        void OnMouseClick(InputAction.CallbackContext context);
        void OnMousePosistion(InputAction.CallbackContext context);
        void OnRightMouseClick(InputAction.CallbackContext context);
    }
}
