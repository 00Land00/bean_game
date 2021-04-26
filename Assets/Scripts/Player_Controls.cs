// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player_Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player_Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b9fa3722-c5fc-49d0-969a-67c7cf693933"",
            ""actions"": [
                {
                    ""name"": ""Move_Horizontal"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e48e70cc-d687-4c33-9618-a932f5718ed1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move_Vertical"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c241ca26-e939-46c6-b14d-5a8ff770a893"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""b48212ac-2473-4728-ae7e-605837d504e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""d121131b-5015-4bae-9549-7b3ff0943bd2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8f8001c1-bedd-40cf-9322-63d690e12d75"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""59ae55b7-aaf0-4316-abd2-5e494e9d6b1c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""344718d2-6991-4e25-99d4-e1d32189f96c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""c0b51a42-b8be-4de9-ab0b-de5de29a3c70"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2abd38e0-55e6-48f2-b08c-916989801f7a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""027e1c39-0e59-4595-bd2f-c71d8805ec75"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move_Horizontal = m_Player.FindAction("Move_Horizontal", throwIfNotFound: true);
        m_Player_Move_Vertical = m_Player.FindAction("Move_Vertical", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move_Horizontal;
    private readonly InputAction m_Player_Move_Vertical;
    private readonly InputAction m_Player_Interact;
    public struct PlayerActions
    {
        private @Player_Controls m_Wrapper;
        public PlayerActions(@Player_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move_Horizontal => m_Wrapper.m_Player_Move_Horizontal;
        public InputAction @Move_Vertical => m_Wrapper.m_Player_Move_Vertical;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move_Horizontal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_Horizontal;
                @Move_Horizontal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_Horizontal;
                @Move_Horizontal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_Horizontal;
                @Move_Vertical.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_Vertical;
                @Move_Vertical.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_Vertical;
                @Move_Vertical.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_Vertical;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move_Horizontal.started += instance.OnMove_Horizontal;
                @Move_Horizontal.performed += instance.OnMove_Horizontal;
                @Move_Horizontal.canceled += instance.OnMove_Horizontal;
                @Move_Vertical.started += instance.OnMove_Vertical;
                @Move_Vertical.performed += instance.OnMove_Vertical;
                @Move_Vertical.canceled += instance.OnMove_Vertical;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove_Horizontal(InputAction.CallbackContext context);
        void OnMove_Vertical(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
