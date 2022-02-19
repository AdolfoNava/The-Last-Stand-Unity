// GENERATED AUTOMATICALLY FROM 'Assets/Controls/MainControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControl"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""b1365e49-44d4-4713-9b46-678c26607df8"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""0b59bce1-b120-41fd-a7ac-7852c524a09a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f580da9a-f550-429d-9368-cebea5b6951a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""b18b70c0-2ae1-4716-8f99-d7144f752740"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e302e209-3e5b-4c75-99bc-fd7a3f434bbb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""99095668-2dd7-4e30-a46e-1bcfda56c2f8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd9fb361-7595-43f7-84fb-ecd32188d39c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""44ed9f76-de70-4859-9cae-19436f5685ab"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""40347828-406b-414d-93d0-ced7ac2ee7f5"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6d55c56b-86b7-48d6-9984-47995e98b1d0"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bc86c003-c2bd-4c2c-82bf-6af21ef7cd47"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bcd0c68a-4795-4353-af71-e50ca9d07dcd"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KB"",
                    ""id"": ""7ef00241-4f9f-4d1e-965f-61c731746bac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eaa2e538-e2d7-4766-8b9f-bd90770b6009"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4e8bec80-8fe0-4c00-9cbd-e2fb3b6f9ee3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""169b34cd-6e8e-49aa-8344-ca17f6b52981"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b0e31f4c-9776-4549-b6cb-b288e04cd143"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e9389ad0-9c72-4f50-8da2-6411efb5b5bd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8c3f905a-000d-4fb4-9ea6-fb5f1cefb360"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""93aea9cd-2021-41db-acff-55334b9b888b"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""23fc9f4c-b912-4890-997e-ef1438dc2984"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""667cfce4-f07e-4c8b-acc3-c939d6de8338"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4e42dbc4-dcee-4ad4-84f9-acb42d9fb0b0"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""331d80da-b7ed-40bf-ad58-9b3fdc7b1731"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4a7fc16a-aa13-4799-a254-f0a85a7e01de"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""21a9375a-57f1-47e0-ab79-8f76fbf52be0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1e39c918-e23a-4deb-9179-df2af8e7cbf0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b4ee3036-7adb-4bf0-a895-574054771426"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""87ac0b29-502e-44df-82ab-ecbd62dbb023"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Main"",
            ""bindingGroup"": ""Main"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
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
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Shoot = m_Gameplay.FindAction("Shoot", throwIfNotFound: true);
        m_Gameplay_Aim = m_Gameplay.FindAction("Aim", throwIfNotFound: true);
        m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Shoot;
    private readonly InputAction m_Gameplay_Aim;
    private readonly InputAction m_Gameplay_Movement;
    public struct GameplayActions
    {
        private @MainControl m_Wrapper;
        public GameplayActions(@MainControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputAction @Shoot => m_Wrapper.m_Gameplay_Shoot;
        public InputAction @Aim => m_Wrapper.m_Gameplay_Aim;
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Shoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Aim.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAim;
                @Movement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_MainSchemeIndex = -1;
    public InputControlScheme MainScheme
    {
        get
        {
            if (m_MainSchemeIndex == -1) m_MainSchemeIndex = asset.FindControlSchemeIndex("Main");
            return asset.controlSchemes[m_MainSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
