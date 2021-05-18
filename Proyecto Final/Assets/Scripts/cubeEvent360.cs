using UnityEngine;
using UnityEngine.EventSystems;
public class cubeEvent360 : EventTrigger
{
    public override void OnPointerEnter(PointerEventData eventData)
    {
        GameObject.Find("Puntero").GetComponent<puntero360>().Activo();
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        GameObject.Find("Puntero").GetComponent<puntero360>().Reinicio();
    }
}
