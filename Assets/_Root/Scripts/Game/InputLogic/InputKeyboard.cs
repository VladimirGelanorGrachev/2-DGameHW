using JoostenProductions;
using UnityEngine;

namespace Game.InputLogic
{
    internal class InputKeyboard : BaseInputView
    {
        private const string Horizontal = nameof(Horizontal);
        private const string Vertical = nameof(Vertical);

        [SerializeField]
        private float _speedCar = 0.08f;

        private void Start() =>
            UpdateManager.SubscribeToUpdate(Move);

        private void OnDestroy() =>
            UpdateManager.UnsubscribeFromUpdate(Move);


        private void Move()
        {
            var xAxisInput = Input.GetAxis(Horizontal);
            var yAxisInput = Input.GetAxis(Vertical);

            if (xAxisInput > 0)
            {
                Vector3 movment = new Vector3(xAxisInput, 0, 0) * Time.deltaTime;
            }           
        }
    }
}
