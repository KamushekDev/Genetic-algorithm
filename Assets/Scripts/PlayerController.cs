using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerActionControls _playerActionControls;

    private Action<InputAction.CallbackContext> _moveU;
    private Action<InputAction.CallbackContext> _moveD;
    private Action<InputAction.CallbackContext> _moveL;
    private Action<InputAction.CallbackContext> _moveR;
    private Action<InputAction.CallbackContext> _moveLU;
    private Action<InputAction.CallbackContext> _moveRU;
    private Action<InputAction.CallbackContext> _moveLD;
    private Action<InputAction.CallbackContext> _moveRD;

    // private void Awake()
    // {
    //     _playerActionControls = new PlayerActionControls();
    //     _collider = GetComponent<Collider2D>();
    //
    //     _moveU = context => MoveUp();
    //     _moveD = context => MoveDown();
    //     _moveL = context => MoveLeft();
    //     _moveR = context => MoveRight();
    //     _moveLU = context => MoveLeftUp();
    //     _moveRU = context => MoveRightUp();
    //     _moveRD = context => MoveRightDown();
    //     _moveLD = context => MoveLeftDown();
    //
    //     // _playerActionControls.Land.Move.performed += OnMove;
    //     _playerActionControls.BotActions.MoveU.performed += _moveU;
    //     _playerActionControls.BotActions.MoveD.performed += _moveD;
    //     _playerActionControls.BotActions.MoveL.performed += _moveL;
    //     _playerActionControls.BotActions.MoveR.performed += _moveR;
    //     _playerActionControls.BotActions.MoveLU.performed += _moveLU;
    //     _playerActionControls.BotActions.MoveRU.performed += _moveRU;
    //     _playerActionControls.BotActions.MoveLD.performed += _moveLD;
    //     _playerActionControls.BotActions.MoveRD.performed += _moveRD;
    // }
    //
    // private void OnDestroy()
    // {
    //     _playerActionControls.BotActions.MoveU.performed -= _moveU;
    //     _playerActionControls.BotActions.MoveD.performed -= _moveD;
    //     _playerActionControls.BotActions.MoveL.performed -= _moveL;
    //     _playerActionControls.BotActions.MoveR.performed -= _moveR;
    //     _playerActionControls.BotActions.MoveLU.performed -= _moveLU;
    //     _playerActionControls.BotActions.MoveRU.performed -= _moveRU;
    //     _playerActionControls.BotActions.MoveLD.performed -= _moveLD;
    //     _playerActionControls.BotActions.MoveRD.performed -= _moveRD;
    //     // _playerActionControls.Land.Move.performed -= OnMove;
    // }

    private void OnEnable()
    {
        _playerActionControls.Enable();
    }

    private void OnDisable()
    {
        _playerActionControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}