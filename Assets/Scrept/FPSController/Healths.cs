using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace System.Healths
{
    public class Healths : MonoBehaviour
    {
        [SerializeField] private float MaxHP = 1000;
        [SerializeField] private float CurentHP;
        [SerializeField] private TextMeshProUGUI _HPDebugText;
        [SerializeField] private Image _HPDebugImage;
        [SerializeField] private bool _destroyObjectOnNullHP;
        [SerializeField] private GameObject _mainGameObject;

        public void Awake()
        {
            CurentHP = MaxHP;
            if (_HPDebugText) _HPDebugText.text = CurentHP.ToString();
        }

        public void TakeDamage(int Damage)
        {
            if (CurentHP - Damage > 0)
            {
                CurentHP -= Damage;
                if (_HPDebugText) _HPDebugText.text = CurentHP.ToString();
                _HPDebugImage.fillAmount = CurentHP / MaxHP;
            }
            else
            {
                if (_destroyObjectOnNullHP)
                {
                    Destroy(_mainGameObject);
                }
                else
                {
                    if (_HPDebugText) _HPDebugText.text = "0";
                    _HPDebugImage.fillAmount = 0;
                }
            }
        }

        public void Regenerate(int Amount)
        {
            if (CurentHP + Amount < MaxHP)
            {
                CurentHP += Amount;
                if (_HPDebugText) _HPDebugText.text = CurentHP.ToString();
                _HPDebugImage.fillAmount = CurentHP / MaxHP;
            }
            else
            {
                if (_HPDebugText) _HPDebugText.text = MaxHP.ToString();
                _HPDebugImage.fillAmount = 1;
            }
        }
    }
}
