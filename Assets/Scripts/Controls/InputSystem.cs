// GENERATED AUTOMATICALLY FROM 'Assets/Objects/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystem : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""2cfa261b-5467-4a37-b09c-c4a8ea864318"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""6c134622-f826-4004-9987-09139fd1b177"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accept"",
                    ""type"": ""Value"",
                    ""id"": ""542f0f02-40ab-4d4d-b502-bb97e7892d73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Decline"",
                    ""type"": ""Value"",
                    ""id"": ""e93d13b4-e125-4529-aea6-aad3c6f475e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""dd662b2d-aea8-4f6d-ba0f-d5b44ba0749a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""30b10b1c-12ba-4774-a83f-29ff0bf31dff"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a4c0d06b-637e-4847-8598-afd3bae435f8"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""becb7025-f9d8-472d-ad0e-ce85101e2ff5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cef22f66-8e98-44d9-8cea-dd0bff9c7071"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KB"",
                    ""id"": ""e810dff2-3b47-49f6-98c4-a37c667e8ed5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0a7d0acc-6429-46de-85dd-9064fbccd760"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""099110cf-dbd1-47ad-90dd-1e409a53e6fd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4b25b1a0-3c1d-448a-9713-ad184671f5d0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""18507771-cf4f-4740-bb89-7dc6e6b44b93"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""2f98cb20-59ed-485f-b527-ec0557eed00c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""084a1f0d-0fa1-4067-b40e-16f091f7eb6a"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5ac6875f-4980-492d-80fe-41ac07eb8be8"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7138e295-b64f-4bbb-8136-d66d8f2af560"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d9f27680-f173-4f97-9936-4a2ed73f3d53"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2acdefde-f023-4e90-ae5b-2be280a1213d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcdd9f7e-d749-4643-a07e-bb69b0ca0fab"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f561a7cf-0e21-4c02-acc1-2004990da51e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d2661d5-1d2b-4549-b63a-37617519c469"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Decline"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ingame"",
            ""id"": ""0418303a-89eb-419e-8a45-09e762b13392"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f059060e-3413-4af8-8f6e-84e90f5c613d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""870e19b6-9455-4fd5-8909-bc8a38a2f10b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ca143d1e-cfe2-434a-9e75-7fb9f3d0d63a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""839332d3-bbea-42df-add1-423ac8d761ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Value"",
                    ""id"": ""67664105-2679-4cea-b225-64c04251a092"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""RightStick"",
                    ""id"": ""6148cde4-b4fb-4d2f-83c6-4bfa7e099290"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""069b4a61-061f-4a21-90e3-507f7b905e03"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9367ac64-0ec6-44c8-af6b-28816ddefccb"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5aa390ce-ae93-41f3-8108-64f77c35aef2"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e67ad578-f287-4535-84a1-f4d69c87271e"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""MouseLook"",
                    ""id"": ""7658768a-8f6c-424f-9550-647d8c7ea93c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8761c4c0-9f22-42df-bd54-5ef4b9f19b75"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""89f6fa86-e26e-498d-827d-b6542835791e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e5c7b77c-d9d7-43f2-9454-ecd347287b6b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2a636256-8607-4233-843e-5db737c5d12d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""9ea14d98-fc80-46a7-acb1-eda1d7f3ed6d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2eff7672-4cfe-4375-9890-8ceeb07755cc"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""207e79e2-d838-4181-b23c-47ad04e57450"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a36eb1d4-0ae3-446d-81f0-bb67ea42e815"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0651decb-09c2-4124-a9db-bc37e1b563ed"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KB"",
                    ""id"": ""c66e2b3a-841c-4d0e-b9e0-e38f18b4c101"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""50d30ad9-8a94-4734-8b86-de0137cc99e7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""103b28ce-442d-4592-86c5-d2a482a92ce1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d643e437-444e-4946-87ba-a21b18da2808"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""55d1ec6c-c8d9-4166-b41f-ff59cb009fb5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8a25660c-4004-48b8-a9fd-c6826910ddf2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4da2315d-f904-4db5-8fc3-0dc4f28feab7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d58120b8-e0fa-4edf-b997-4da75e9e2696"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KB&M"",
            ""bindingGroup"": ""KB&M"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Navigate = m_Menu.FindAction("Navigate", throwIfNotFound: true);
        m_Menu_Accept = m_Menu.FindAction("Accept", throwIfNotFound: true);
        m_Menu_Decline = m_Menu.FindAction("Decline", throwIfNotFound: true);
        // Ingame
        m_Ingame = asset.FindActionMap("Ingame", throwIfNotFound: true);
        m_Ingame_Look = m_Ingame.FindAction("Look", throwIfNotFound: true);
        m_Ingame_Move = m_Ingame.FindAction("Move", throwIfNotFound: true);
        m_Ingame_Jump = m_Ingame.FindAction("Jump", throwIfNotFound: true);
        m_Ingame_Sprint = m_Ingame.FindAction("Sprint", throwIfNotFound: true);
        m_Ingame_Pause = m_Ingame.FindAction("Pause", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Navigate;
    private readonly InputAction m_Menu_Accept;
    private readonly InputAction m_Menu_Decline;
    public struct MenuActions
    {
        private @InputSystem m_Wrapper;
        public MenuActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_Menu_Navigate;
        public InputAction @Accept => m_Wrapper.m_Menu_Accept;
        public InputAction @Decline => m_Wrapper.m_Menu_Decline;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNavigate;
                @Accept.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnAccept;
                @Accept.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnAccept;
                @Accept.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnAccept;
                @Decline.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDecline;
                @Decline.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDecline;
                @Decline.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDecline;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Accept.started += instance.OnAccept;
                @Accept.performed += instance.OnAccept;
                @Accept.canceled += instance.OnAccept;
                @Decline.started += instance.OnDecline;
                @Decline.performed += instance.OnDecline;
                @Decline.canceled += instance.OnDecline;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Ingame
    private readonly InputActionMap m_Ingame;
    private IIngameActions m_IngameActionsCallbackInterface;
    private readonly InputAction m_Ingame_Look;
    private readonly InputAction m_Ingame_Move;
    private readonly InputAction m_Ingame_Jump;
    private readonly InputAction m_Ingame_Sprint;
    private readonly InputAction m_Ingame_Pause;
    public struct IngameActions
    {
        private @InputSystem m_Wrapper;
        public IngameActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Ingame_Look;
        public InputAction @Move => m_Wrapper.m_Ingame_Move;
        public InputAction @Jump => m_Wrapper.m_Ingame_Jump;
        public InputAction @Sprint => m_Wrapper.m_Ingame_Sprint;
        public InputAction @Pause => m_Wrapper.m_Ingame_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Ingame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(IngameActions set) { return set.Get(); }
        public void SetCallbacks(IIngameActions instance)
        {
            if (m_Wrapper.m_IngameActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnLook;
                @Move.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnSprint;
                @Pause.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_IngameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public IngameActions @Ingame => new IngameActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KB&M");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    public interface IMenuActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnAccept(InputAction.CallbackContext context);
        void OnDecline(InputAction.CallbackContext context);
    }
    public interface IIngameActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
