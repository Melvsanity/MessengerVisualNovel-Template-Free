using UnityEngine;
using ChatSim.Core;

public class SimpleFPS : MonoBehaviour
{
    public static SimpleFPS Instance;

    private float _deltaTime;
    private bool _show;
    private GUIStyle _style;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        _style = new GUIStyle();
    }

    private void Start()
    {
        // Read initial state from GameConfig
        _show = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
            _show = !_show;

        _deltaTime += (Time.unscaledDeltaTime - _deltaTime) * 0.1f;
    }

    private void OnGUI()
    {
        if (!_show) return;

        _style.fontSize = Screen.height * 2 / 50;
        _style.normal.textColor = Color.yellow;

        float ms = _deltaTime * 1000.0f;
        float fps = 1.0f / _deltaTime;

        GUI.Label(
            new Rect(10, 10, 300, 40),
            $"FPS: {Mathf.Ceil(fps)} ({ms:0.0} ms)",
            _style
        );
    }
}