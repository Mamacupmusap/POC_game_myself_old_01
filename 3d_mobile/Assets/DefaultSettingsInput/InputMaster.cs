// GENERATED AUTOMATICALLY FROM 'Assets/DefaultSettingsInput/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1f73b662-b326-4602-92e2-a99c131014b9"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""1ce9a723-7a86-4095-829b-089e9bd50fcd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""627c4454-b551-42e1-a923-a2e766c200b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""868eceea-6b15-4420-8d66-67471f96bcd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""781e8122-67b2-4637-8d6c-b0af66a3fafe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill"",
                    ""type"": ""Button"",
                    ""id"": ""c89fd9cf-4cc4-4cd6-ade6-44b026de0928"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ulti"",
                    ""type"": ""Button"",
                    ""id"": ""ff8344ae-ebac-4cf6-8b79-b5029bb169aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wasd move"",
                    ""id"": ""df05af65-7e9b-4804-8c6a-76c2d8bf27a5"",
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
                    ""id"": ""041dfdb4-7807-4cf9-ad61-d6692a9cd527"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f7ef230b-b8e0-42e4-9c1d-0c092def7b38"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""740a2053-2543-47f8-9f85-88ec63d29c00"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""86d0585f-602e-4967-8483-75ca9065680a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrow move"",
                    ""id"": ""8c50d8b3-ab11-483f-bf9b-0c94eab255b2"",
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
                    ""id"": ""fab1e167-633e-4e90-a60b-33b2f4c4e352"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2030f2da-982f-4630-b539-8cd6d7eb3dfc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4baaa767-588b-405f-b843-48ee757c29b5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""10cce703-d390-434d-bfd7-ab07b755de7d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""492e36f9-9756-45ca-bf4d-4907aa170fa9"",
                    ""path"": ""<Touchscreen>/touch0/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93681c8e-9d41-4f3e-b9c6-adab8f209856"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0c0eadc-9376-4bcd-9a80-b66f1a23cd84"",
                    ""path"": ""<Touchscreen>/touch1/tap"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""faef0fa0-f167-473a-b8fa-e8a33619a4e9"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1048dedf-d738-49f8-8eac-b86d7f6be141"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8bf40a6-406f-48db-9611-232b3e23b020"",
                    ""path"": ""<Touchscreen>/touch2/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1a9df0a-09ea-4b06-adeb-2a42ae16be04"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7c525ea-f85c-4eb8-bf0c-ef2959fa7fd7"",
                    ""path"": ""<Touchscreen>/touch2/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1658e51-eac5-459a-8466-1d358dad0e7f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""757db14d-8960-4245-8296-eba97e000a73"",
                    ""path"": ""<Touchscreen>/touch2/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32f6cac1-d8c9-47ed-9d63-a7fccfa29bcc"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Ulti"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b065389b-8650-42c9-b8f3-32a873ffd087"",
                    ""path"": ""<Touchscreen>/touch2/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Ulti"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI_Gameplay"",
            ""id"": ""45b8e984-829b-45d8-a1a6-fb9221895984"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""72cd0b5e-8cc7-493d-9a46-99999a958b42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gacha"",
                    ""type"": ""Button"",
                    ""id"": ""97197889-a48f-473c-8b59-bfbd0ebce71d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""7b707c8a-97e9-4c28-95c1-4b10c0b76e17"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d1099bba-3978-4b0a-abf0-b27c58ea6afc"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29b2b844-0b94-4024-a8f7-455fa7c80abe"",
                    ""path"": ""<Touchscreen>/touch3/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be738ca8-184b-42bd-9d11-39a8942d909a"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Gacha"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cdd5142-0d9c-46d6-9a8e-2daba8c9b0ec"",
                    ""path"": ""<Touchscreen>/touch3/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Gacha"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79979a7b-a992-4c57-a352-316c6bfd175f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfec0624-e929-484a-9b73-f8769d3a6b99"",
                    ""path"": ""<Touchscreen>/touch3/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Phone"",
            ""bindingGroup"": ""Phone"",
            ""devices"": [
                {
                    ""devicePath"": ""<AndroidJoystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Skill = m_Player.FindAction("Skill", throwIfNotFound: true);
        m_Player_Ulti = m_Player.FindAction("Ulti", throwIfNotFound: true);
        // UI_Gameplay
        m_UI_Gameplay = asset.FindActionMap("UI_Gameplay", throwIfNotFound: true);
        m_UI_Gameplay_Menu = m_UI_Gameplay.FindAction("Menu", throwIfNotFound: true);
        m_UI_Gameplay_Gacha = m_UI_Gameplay.FindAction("Gacha", throwIfNotFound: true);
        m_UI_Gameplay_Inventory = m_UI_Gameplay.FindAction("Inventory", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Skill;
    private readonly InputAction m_Player_Ulti;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Skill => m_Wrapper.m_Player_Skill;
        public InputAction @Ulti => m_Wrapper.m_Player_Ulti;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Skill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkill;
                @Skill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkill;
                @Skill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkill;
                @Ulti.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUlti;
                @Ulti.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUlti;
                @Ulti.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUlti;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Skill.started += instance.OnSkill;
                @Skill.performed += instance.OnSkill;
                @Skill.canceled += instance.OnSkill;
                @Ulti.started += instance.OnUlti;
                @Ulti.performed += instance.OnUlti;
                @Ulti.canceled += instance.OnUlti;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI_Gameplay
    private readonly InputActionMap m_UI_Gameplay;
    private IUI_GameplayActions m_UI_GameplayActionsCallbackInterface;
    private readonly InputAction m_UI_Gameplay_Menu;
    private readonly InputAction m_UI_Gameplay_Gacha;
    private readonly InputAction m_UI_Gameplay_Inventory;
    public struct UI_GameplayActions
    {
        private @InputMaster m_Wrapper;
        public UI_GameplayActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu => m_Wrapper.m_UI_Gameplay_Menu;
        public InputAction @Gacha => m_Wrapper.m_UI_Gameplay_Gacha;
        public InputAction @Inventory => m_Wrapper.m_UI_Gameplay_Inventory;
        public InputActionMap Get() { return m_Wrapper.m_UI_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UI_GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IUI_GameplayActions instance)
        {
            if (m_Wrapper.m_UI_GameplayActionsCallbackInterface != null)
            {
                @Menu.started -= m_Wrapper.m_UI_GameplayActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_UI_GameplayActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_UI_GameplayActionsCallbackInterface.OnMenu;
                @Gacha.started -= m_Wrapper.m_UI_GameplayActionsCallbackInterface.OnGacha;
                @Gacha.performed -= m_Wrapper.m_UI_GameplayActionsCallbackInterface.OnGacha;
                @Gacha.canceled -= m_Wrapper.m_UI_GameplayActionsCallbackInterface.OnGacha;
                @Inventory.started -= m_Wrapper.m_UI_GameplayActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_UI_GameplayActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_UI_GameplayActionsCallbackInterface.OnInventory;
            }
            m_Wrapper.m_UI_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Gacha.started += instance.OnGacha;
                @Gacha.performed += instance.OnGacha;
                @Gacha.canceled += instance.OnGacha;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
            }
        }
    }
    public UI_GameplayActions @UI_Gameplay => new UI_GameplayActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_PhoneSchemeIndex = -1;
    public InputControlScheme PhoneScheme
    {
        get
        {
            if (m_PhoneSchemeIndex == -1) m_PhoneSchemeIndex = asset.FindControlSchemeIndex("Phone");
            return asset.controlSchemes[m_PhoneSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSkill(InputAction.CallbackContext context);
        void OnUlti(InputAction.CallbackContext context);
    }
    public interface IUI_GameplayActions
    {
        void OnMenu(InputAction.CallbackContext context);
        void OnGacha(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
    }
}
