// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerScripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""2a65e4ab-82a6-4acf-aacb-e6a8b52bc453"",
            ""actions"": [
                {
                    ""name"": ""Walking"",
                    ""type"": ""Button"",
                    ""id"": ""b8943717-b9bb-49d2-87d2-dc99a205dd55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5e01fd79-16d3-4cb2-8041-09158d3e2303"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4f2dcb4e-e617-4d8f-94bd-7e645e5a606a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ca83b06b-7b7e-497a-aba0-7fe5c16f5d59"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58c710fc-0263-485f-9b1b-7c52e3e09822"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0f6b5f52-677e-4fce-8cdb-538988bbf798"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4ca2d40f-84ed-4645-b47d-659bebdf9a58"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e78ffb4b-a3fe-4cb2-9bb1-c5c33b159475"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Chatting"",
            ""id"": ""6c979e85-658e-4782-8410-3f91a7bbb1fe"",
            ""actions"": [
                {
                    ""name"": ""SkipText"",
                    ""type"": ""Button"",
                    ""id"": ""a3bfa239-ed9e-471b-a5ad-360bd812ed7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7acee2da-13a7-4cbb-861e-0c3f2198268e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkipText"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Walking = m_Land.FindAction("Walking", throwIfNotFound: true);
        m_Land_Interact = m_Land.FindAction("Interact", throwIfNotFound: true);
        // Chatting
        m_Chatting = asset.FindActionMap("Chatting", throwIfNotFound: true);
        m_Chatting_SkipText = m_Chatting.FindAction("SkipText", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Walking;
    private readonly InputAction m_Land_Interact;
    public struct LandActions
    {
        private @PlayerControls m_Wrapper;
        public LandActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walking => m_Wrapper.m_Land_Walking;
        public InputAction @Interact => m_Wrapper.m_Land_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Walking.started -= m_Wrapper.m_LandActionsCallbackInterface.OnWalking;
                @Walking.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnWalking;
                @Walking.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnWalking;
                @Interact.started -= m_Wrapper.m_LandActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walking.started += instance.OnWalking;
                @Walking.performed += instance.OnWalking;
                @Walking.canceled += instance.OnWalking;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public LandActions @Land => new LandActions(this);

    // Chatting
    private readonly InputActionMap m_Chatting;
    private IChattingActions m_ChattingActionsCallbackInterface;
    private readonly InputAction m_Chatting_SkipText;
    public struct ChattingActions
    {
        private @PlayerControls m_Wrapper;
        public ChattingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SkipText => m_Wrapper.m_Chatting_SkipText;
        public InputActionMap Get() { return m_Wrapper.m_Chatting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChattingActions set) { return set.Get(); }
        public void SetCallbacks(IChattingActions instance)
        {
            if (m_Wrapper.m_ChattingActionsCallbackInterface != null)
            {
                @SkipText.started -= m_Wrapper.m_ChattingActionsCallbackInterface.OnSkipText;
                @SkipText.performed -= m_Wrapper.m_ChattingActionsCallbackInterface.OnSkipText;
                @SkipText.canceled -= m_Wrapper.m_ChattingActionsCallbackInterface.OnSkipText;
            }
            m_Wrapper.m_ChattingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SkipText.started += instance.OnSkipText;
                @SkipText.performed += instance.OnSkipText;
                @SkipText.canceled += instance.OnSkipText;
            }
        }
    }
    public ChattingActions @Chatting => new ChattingActions(this);
    public interface ILandActions
    {
        void OnWalking(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IChattingActions
    {
        void OnSkipText(InputAction.CallbackContext context);
    }
}
