// GENERATED AUTOMATICALLY FROM 'Assets/Input System/CarController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CarController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CarController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CarController"",
    ""maps"": [
        {
            ""name"": ""Car"",
            ""id"": ""60bcbde9-f7d3-4eff-bd1a-09bdb62c00a6"",
            ""actions"": [
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""d610e4ae-655c-4c88-9584-26714b17328f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""3c17cd74-733e-449d-831a-23fcfd6b9cfb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d226c631-22df-405c-9dfa-6bdbba6b7e2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""b74f553c-5dbf-403a-a9c8-93b8471cdfc3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""d4aef835-24d1-4049-b947-76c448bb91fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drift"",
                    ""type"": ""Button"",
                    ""id"": ""4d332aad-8668-4d9d-b254-938862b4caf5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""31a3c004-2d3e-4a2c-ae59-63583cf0a39e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ab54988f-2a37-4b89-9750-a29439da1c56"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0e79adee-5659-46df-bc07-81c59f702cf8"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8a093e3f-6c56-474b-85cd-5e0c71390951"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4778ce85-0746-4f43-9a45-bd23e4522b40"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5b12e7c2-70da-40fc-99cc-efa39b683900"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""eea14519-2383-45ae-8658-346d9b76d7a4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ff3f3707-6538-4cd3-a237-a0505d41bf90"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3ea9f4eb-2298-4f91-924a-125e93259e24"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cffdb965-26a0-4f1a-92fc-591bbb215570"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b96b9b27-1269-43ba-87fe-e80c3f688be5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0f08cecc-f608-40c3-bd53-f2b1ba434936"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""79a2a550-ac32-4678-aafe-4b330db3e1cc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60f226ee-4c9c-4d88-b2f4-0b14eeda4a73"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""796aa41a-18e2-4213-8605-fe2db8c28fb7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a46d3783-82c8-4d09-a57e-0233fce2302d"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f79bc164-f34a-473c-8299-919943f85dbc"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9f991c1-7f8c-4620-b970-09a8bcd248e0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3684e82-7658-4473-a60f-e3a65b3781be"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31092a9b-6ff3-4b67-8411-9851bc1314bc"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controls"",
            ""bindingGroup"": ""Controls"",
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
        // Car
        m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
        m_Car_Vertical = m_Car.FindAction("Vertical", throwIfNotFound: true);
        m_Car_Horizontal = m_Car.FindAction("Horizontal", throwIfNotFound: true);
        m_Car_Jump = m_Car.FindAction("Jump", throwIfNotFound: true);
        m_Car_Reset = m_Car.FindAction("Reset", throwIfNotFound: true);
        m_Car_Boost = m_Car.FindAction("Boost", throwIfNotFound: true);
        m_Car_Drift = m_Car.FindAction("Drift", throwIfNotFound: true);
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

    // Car
    private readonly InputActionMap m_Car;
    private ICarActions m_CarActionsCallbackInterface;
    private readonly InputAction m_Car_Vertical;
    private readonly InputAction m_Car_Horizontal;
    private readonly InputAction m_Car_Jump;
    private readonly InputAction m_Car_Reset;
    private readonly InputAction m_Car_Boost;
    private readonly InputAction m_Car_Drift;
    public struct CarActions
    {
        private @CarController m_Wrapper;
        public CarActions(@CarController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vertical => m_Wrapper.m_Car_Vertical;
        public InputAction @Horizontal => m_Wrapper.m_Car_Horizontal;
        public InputAction @Jump => m_Wrapper.m_Car_Jump;
        public InputAction @Reset => m_Wrapper.m_Car_Reset;
        public InputAction @Boost => m_Wrapper.m_Car_Boost;
        public InputAction @Drift => m_Wrapper.m_Car_Drift;
        public InputActionMap Get() { return m_Wrapper.m_Car; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
        public void SetCallbacks(ICarActions instance)
        {
            if (m_Wrapper.m_CarActionsCallbackInterface != null)
            {
                @Vertical.started -= m_Wrapper.m_CarActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnVertical;
                @Horizontal.started -= m_Wrapper.m_CarActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnHorizontal;
                @Jump.started -= m_Wrapper.m_CarActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnJump;
                @Reset.started -= m_Wrapper.m_CarActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnReset;
                @Boost.started -= m_Wrapper.m_CarActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnBoost;
                @Drift.started -= m_Wrapper.m_CarActionsCallbackInterface.OnDrift;
                @Drift.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnDrift;
                @Drift.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnDrift;
            }
            m_Wrapper.m_CarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Drift.started += instance.OnDrift;
                @Drift.performed += instance.OnDrift;
                @Drift.canceled += instance.OnDrift;
            }
        }
    }
    public CarActions @Car => new CarActions(this);
    private int m_ControlsSchemeIndex = -1;
    public InputControlScheme ControlsScheme
    {
        get
        {
            if (m_ControlsSchemeIndex == -1) m_ControlsSchemeIndex = asset.FindControlSchemeIndex("Controls");
            return asset.controlSchemes[m_ControlsSchemeIndex];
        }
    }
    public interface ICarActions
    {
        void OnVertical(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnDrift(InputAction.CallbackContext context);
    }
}
