using UnityEngine;
using UnityEngine.InputSystem;

namespace StarterAssets
{
    [DisallowMultipleComponent]
    public sealed class PlayerSpotlight : MonoBehaviour
    {
        [SerializeField] private Light _spotlight;
        [SerializeField] private Vector3 _mountOffset = new Vector3(0f, 1.5f, 0.35f);

        private void Awake()
        {
            if (_spotlight == null)
            {
                return;
            }

            _spotlight.enabled = false;

            Transform mount = _spotlight.transform;
            mount.SetParent(transform, false);
            mount.SetLocalPositionAndRotation(_mountOffset, Quaternion.identity);
        }

        private void Update()
        {
            if (_spotlight != null && Keyboard.current?.fKey.wasPressedThisFrame == true)
            {
                _spotlight.enabled = !_spotlight.enabled;
            }
        }
    }
}
