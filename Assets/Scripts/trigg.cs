using UnityEngine;

public class trigg : MonoBehaviour
{
    public bool repeat = false;
    public string triggerName = "Slash";
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (repeat || Input.GetMouseButtonDown(0))
        {
            anim.ResetTrigger(triggerName);
            anim.SetTrigger(triggerName);
        }
    }
}