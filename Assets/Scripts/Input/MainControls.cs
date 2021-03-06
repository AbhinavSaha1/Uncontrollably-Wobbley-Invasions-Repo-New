//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/Input/MainControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MainControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ecf1c81b-60db-4f19-b678-084013d7b3fa"",
            ""actions"": [
                {
                    ""name"": ""Move Main"",
                    ""type"": ""Value"",
                    ""id"": ""fbe0a5bd-0ae6-4a18-bf2a-e4a7b8c88cf7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Move Secondary"",
                    ""type"": ""Value"",
                    ""id"": ""3b026ab0-f58f-421c-8816-4e6de309be6c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Left Main"",
                    ""type"": ""Button"",
                    ""id"": ""165d1f9d-68da-48f5-a547-ce61b5325643"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right Main"",
                    ""type"": ""Button"",
                    ""id"": ""6e1c14c0-7412-4c18-acde-99223a83a9f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""1a192f57-7cb3-4907-805b-af286010f49d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a543ee69-26e7-47a1-986b-4f28524c35e9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cef9682d-7d15-45d8-b08b-60f0433bfd7b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1700c390-6ed7-4004-8c17-e509bc8da3e1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cebe7d84-195c-4514-b59c-01a6fd788f8d"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c88600b4-94a9-4c4a-9bc4-a7955390f117"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Main"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e03d8fb9-88e7-4577-a62f-ffa75494acbf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""88e624fc-320f-43c3-9eb7-d58c817a8744"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3a5967d8-fef2-43c0-a2e1-8ccf6ebfcd7e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8dc0b4a6-171c-414f-8fff-744d9df41329"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c2e51f92-3cd6-4b45-baf8-1a6f6fd7aaa9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5e50f90-17ff-4c87-aedf-ccf1ac36a0db"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05)"",
                    ""groups"": """",
                    ""action"": ""Move Secondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c94346-92b9-4ef6-85a2-cf6d0f0e7a12"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Secondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75e365ba-cff1-4197-b2da-65369e2180a6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14b63ec9-c6e3-47b6-a2f0-f8f47ea473c8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21fe1f97-219b-471b-83ad-3de5919dee53"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveMain = m_Player.FindAction("Move Main", throwIfNotFound: true);
        m_Player_MoveSecondary = m_Player.FindAction("Move Secondary", throwIfNotFound: true);
        m_Player_LeftMain = m_Player.FindAction("Left Main", throwIfNotFound: true);
        m_Player_RightMain = m_Player.FindAction("Right Main", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveMain;
    private readonly InputAction m_Player_MoveSecondary;
    private readonly InputAction m_Player_LeftMain;
    private readonly InputAction m_Player_RightMain;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @MainControls m_Wrapper;
        public PlayerActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveMain => m_Wrapper.m_Player_MoveMain;
        public InputAction @MoveSecondary => m_Wrapper.m_Player_MoveSecondary;
        public InputAction @LeftMain => m_Wrapper.m_Player_LeftMain;
        public InputAction @RightMain => m_Wrapper.m_Player_RightMain;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveMain.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveMain;
                @MoveMain.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveMain;
                @MoveMain.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveMain;
                @MoveSecondary.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveSecondary;
                @MoveSecondary.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveSecondary;
                @MoveSecondary.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveSecondary;
                @LeftMain.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftMain;
                @LeftMain.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftMain;
                @LeftMain.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftMain;
                @RightMain.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightMain;
                @RightMain.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightMain;
                @RightMain.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightMain;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveMain.started += instance.OnMoveMain;
                @MoveMain.performed += instance.OnMoveMain;
                @MoveMain.canceled += instance.OnMoveMain;
                @MoveSecondary.started += instance.OnMoveSecondary;
                @MoveSecondary.performed += instance.OnMoveSecondary;
                @MoveSecondary.canceled += instance.OnMoveSecondary;
                @LeftMain.started += instance.OnLeftMain;
                @LeftMain.performed += instance.OnLeftMain;
                @LeftMain.canceled += instance.OnLeftMain;
                @RightMain.started += instance.OnRightMain;
                @RightMain.performed += instance.OnRightMain;
                @RightMain.canceled += instance.OnRightMain;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMoveMain(InputAction.CallbackContext context);
        void OnMoveSecondary(InputAction.CallbackContext context);
        void OnLeftMain(InputAction.CallbackContext context);
        void OnRightMain(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
