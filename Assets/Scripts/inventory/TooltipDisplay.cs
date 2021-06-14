using UnityEngine;
 
public class TooltipDisplay : MonoBehaviour {
    public float stillTime = 1f;    // how long the mouse must be still to show a tip
    public float maxTipWidth = 150f;
    Vector2 lastMousePos;
    float timeOfLastMove;
    public static Rect mouseOverRect;
    public static string mouseOverCaption;
    public static string mouseOverTooltip;
    
    static public void ClearMouseOver() {
        mouseOverRect.Set(0, 0, 0, 0);
        mouseOverCaption = "";
        mouseOverTooltip = "";
    }
    
    void OnGUI() {
        Vector2 mousePos = Event.current.mousePosition;
        if ((mousePos - lastMousePos).sqrMagnitude > 4) {
            lastMousePos = mousePos;
            timeOfLastMove = Time.time;
        }
        if (Time.time - timeOfLastMove < stillTime) return;
 
        Rect r = mouseOverRect;
        if (r.width < 1) return;
 
        
        GUIStyle style = GUI.skin.GetStyle("Label");
        GUIContent tip = new GUIContent(mouseOverTooltip);
        
 
        float minWidth, maxWidth;
        style.CalcMinMaxWidth(tip, out minWidth, out maxWidth);
        r.yMin = r.yMax + 5;
        r.width = Mathf.Min(maxWidth, maxTipWidth);
        r.height = style.CalcHeight(tip, r.width);
        GUI.Label(r, tip);
    }
 
    void LateUpdate() {
        ClearMouseOver();
    }
}