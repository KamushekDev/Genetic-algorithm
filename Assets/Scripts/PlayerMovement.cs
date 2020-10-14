// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""3552685f-f8ab-40e0-84f0-ace7c4453b0e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4c6bd3a8-6377-4756-aadb-d99c0ddffea5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""dbf22a29-8335-4ba4-b749-f304d5f3b226"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Hold(duration=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1726ef4f-4d34-4692-bd2e-9d7ce113f6ce"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""442b36f0-1993-44d1-a2f8-7cf9d055c02e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3730fc98-9531-4e40-979a-5218f0703d90"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""db60c9dd-a770-44ff-8014-82940906bd5e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""d6dda07a-95d8-4fcd-a5d5-4ac73dff8d06"",
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
                    ""id"": ""7678b8bb-9bbb-4942-a26f-03377ebd88c7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""74ec6ea3-e3d0-42a8-9f6d-fd178351f6db"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""95403410-9691-4760-b426-2f2453405155"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2d7ea6ef-556d-4be4-8edc-c77481591b30"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""BotActions"",
            ""id"": ""6e4ed1b6-04b7-4d0c-92d7-5732ab77e3ad"",
            ""actions"": [
                {
                    ""name"": ""MoveU"",
                    ""type"": ""Button"",
                    ""id"": ""7b598256-feac-4158-88d6-883bbec3251b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveL"",
                    ""type"": ""Button"",
                    ""id"": ""cf7043ee-1196-4722-8f48-75701800310a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveR"",
                    ""type"": ""Button"",
                    ""id"": ""8e0967fc-8aea-4145-892f-8fe81c9d82c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveD"",
                    ""type"": ""Button"",
                    ""id"": ""159435ea-f089-4916-9ee7-984c52e5840d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLU"",
                    ""type"": ""Button"",
                    ""id"": ""2b5e05c8-dbc5-4bcd-96c9-ad16cc96406d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRU"",
                    ""type"": ""Button"",
                    ""id"": ""664deae6-f0aa-4446-b693-9104e5e14767"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLD"",
                    ""type"": ""Button"",
                    ""id"": ""8f8bd4a0-06c8-439f-8364-b650aefee570"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRD"",
                    ""type"": ""Button"",
                    ""id"": ""35b6439c-b0a4-4c52-9b2b-052c4fc962e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7c12fb6d-8b73-4730-ac2b-483ff7d4d49a"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveU"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8efe33cd-e10a-4c49-8b90-3ce3bf9cf5e4"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dca9cc7-ed2b-4979-9915-d6be6bb344d2"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05e3f816-da40-4408-bbb3-002af3e13b35"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85d07d47-1562-4fef-87e8-843e8ecd142a"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLU"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0971ae9a-bdf4-4a86-8d05-11040dc6910d"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRU"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86962606-389c-4814-8507-b558156c3720"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2256989f-7463-40dc-a020-bd9ca2d6f998"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRD"",
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
        m_Land_Move = m_Land.FindAction("Move", throwIfNotFound: true);
        // BotActions
        m_BotActions = asset.FindActionMap("BotActions", throwIfNotFound: true);
        m_BotActions_MoveU = m_BotActions.FindAction("MoveU", throwIfNotFound: true);
        m_BotActions_MoveL = m_BotActions.FindAction("MoveL", throwIfNotFound: true);
        m_BotActions_MoveR = m_BotActions.FindAction("MoveR", throwIfNotFound: true);
        m_BotActions_MoveD = m_BotActions.FindAction("MoveD", throwIfNotFound: true);
        m_BotActions_MoveLU = m_BotActions.FindAction("MoveLU", throwIfNotFound: true);
        m_BotActions_MoveRU = m_BotActions.FindAction("MoveRU", throwIfNotFound: true);
        m_BotActions_MoveLD = m_BotActions.FindAction("MoveLD", throwIfNotFound: true);
        m_BotActions_MoveRD = m_BotActions.FindAction("MoveRD", throwIfNotFound: true);
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
    private readonly InputAction m_Land_Move;
    public struct LandActions
    {
        private @PlayerActionControls m_Wrapper;
        public LandActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Land_Move;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public LandActions @Land => new LandActions(this);

    // BotActions
    private readonly InputActionMap m_BotActions;
    private IBotActionsActions m_BotActionsActionsCallbackInterface;
    private readonly InputAction m_BotActions_MoveU;
    private readonly InputAction m_BotActions_MoveL;
    private readonly InputAction m_BotActions_MoveR;
    private readonly InputAction m_BotActions_MoveD;
    private readonly InputAction m_BotActions_MoveLU;
    private readonly InputAction m_BotActions_MoveRU;
    private readonly InputAction m_BotActions_MoveLD;
    private readonly InputAction m_BotActions_MoveRD;
    public struct BotActionsActions
    {
        private @PlayerActionControls m_Wrapper;
        public BotActionsActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveU => m_Wrapper.m_BotActions_MoveU;
        public InputAction @MoveL => m_Wrapper.m_BotActions_MoveL;
        public InputAction @MoveR => m_Wrapper.m_BotActions_MoveR;
        public InputAction @MoveD => m_Wrapper.m_BotActions_MoveD;
        public InputAction @MoveLU => m_Wrapper.m_BotActions_MoveLU;
        public InputAction @MoveRU => m_Wrapper.m_BotActions_MoveRU;
        public InputAction @MoveLD => m_Wrapper.m_BotActions_MoveLD;
        public InputAction @MoveRD => m_Wrapper.m_BotActions_MoveRD;
        public InputActionMap Get() { return m_Wrapper.m_BotActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BotActionsActions set) { return set.Get(); }
        public void SetCallbacks(IBotActionsActions instance)
        {
            if (m_Wrapper.m_BotActionsActionsCallbackInterface != null)
            {
                @MoveU.started -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveU;
                @MoveU.performed -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveU;
                @MoveU.canceled -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveU;
                @MoveL.started -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveL;
                @MoveL.performed -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveL;
                @MoveL.canceled -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveL;
                @MoveR.started -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveR;
                @MoveR.performed -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveR;
                @MoveR.canceled -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveR;
                @MoveD.started -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveD;
                @MoveD.performed -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveD;
                @MoveD.canceled -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveD;
                @MoveLU.started -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveLU;
                @MoveLU.performed -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveLU;
                @MoveLU.canceled -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveLU;
                @MoveRU.started -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveRU;
                @MoveRU.performed -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveRU;
                @MoveRU.canceled -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveRU;
                @MoveLD.started -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveLD;
                @MoveLD.performed -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveLD;
                @MoveLD.canceled -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveLD;
                @MoveRD.started -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveRD;
                @MoveRD.performed -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveRD;
                @MoveRD.canceled -= m_Wrapper.m_BotActionsActionsCallbackInterface.OnMoveRD;
            }
            m_Wrapper.m_BotActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveU.started += instance.OnMoveU;
                @MoveU.performed += instance.OnMoveU;
                @MoveU.canceled += instance.OnMoveU;
                @MoveL.started += instance.OnMoveL;
                @MoveL.performed += instance.OnMoveL;
                @MoveL.canceled += instance.OnMoveL;
                @MoveR.started += instance.OnMoveR;
                @MoveR.performed += instance.OnMoveR;
                @MoveR.canceled += instance.OnMoveR;
                @MoveD.started += instance.OnMoveD;
                @MoveD.performed += instance.OnMoveD;
                @MoveD.canceled += instance.OnMoveD;
                @MoveLU.started += instance.OnMoveLU;
                @MoveLU.performed += instance.OnMoveLU;
                @MoveLU.canceled += instance.OnMoveLU;
                @MoveRU.started += instance.OnMoveRU;
                @MoveRU.performed += instance.OnMoveRU;
                @MoveRU.canceled += instance.OnMoveRU;
                @MoveLD.started += instance.OnMoveLD;
                @MoveLD.performed += instance.OnMoveLD;
                @MoveLD.canceled += instance.OnMoveLD;
                @MoveRD.started += instance.OnMoveRD;
                @MoveRD.performed += instance.OnMoveRD;
                @MoveRD.canceled += instance.OnMoveRD;
            }
        }
    }
    public BotActionsActions @BotActions => new BotActionsActions(this);
    public interface ILandActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IBotActionsActions
    {
        void OnMoveU(InputAction.CallbackContext context);
        void OnMoveL(InputAction.CallbackContext context);
        void OnMoveR(InputAction.CallbackContext context);
        void OnMoveD(InputAction.CallbackContext context);
        void OnMoveLU(InputAction.CallbackContext context);
        void OnMoveRU(InputAction.CallbackContext context);
        void OnMoveLD(InputAction.CallbackContext context);
        void OnMoveRD(InputAction.CallbackContext context);
    }
}