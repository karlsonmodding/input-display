using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEditor;
using UnityEngine;

namespace InputDisplay
{
    public class Class1 : MelonMod
    {
        public override void OnGUI()
        {
            float xOffset = 100;
            float yOffset = -100;
            int textureQuality = 1;
            var texture1 = new Texture2D(textureQuality, textureQuality, TextureFormat.ARGB32, false);
            texture1.SetPixel(1, 1, new Color(1f, 1f, 1f, 0.2f));
            texture1.Apply();
            GUIStyle style1 = new GUIStyle();
            style1.normal.background = texture1;
            style1.alignment = TextAnchor.MiddleCenter;
            style1.fontSize = 20;
            style1.normal.textColor = new Color(1f, 1f, 1f, 0.5f);

            var texture2 = new Texture2D(textureQuality, textureQuality, TextureFormat.ARGB32, false);
            texture2.SetPixel(1, 1, new Color(1f, 1f, 1f, 0.2f));
            texture2.Apply();
            GUIStyle style2 = new GUIStyle();
            style2.normal.background = texture2;
            style2.alignment = TextAnchor.MiddleCenter;
            style2.fontSize = 20;
            style2.normal.textColor = new Color(1f, 1f, 1f, 0.5f);


            GUI.Box(new Rect(120 + xOffset, Screen.height - 100 + yOffset, 40, 40), "W", style2);
            GUI.Box(new Rect(80 + xOffset, Screen.height - 100 + yOffset, 40, 40), "Q", style2);
            GUI.Box(new Rect(160 + xOffset, Screen.height - 100 + yOffset, 40, 40), "E", style2);
            GUI.Box(new Rect(80 + xOffset, Screen.height - 60 + yOffset, 40, 40), "A", style2);
            GUI.Box(new Rect(120 + xOffset, Screen.height - 60 + yOffset, 40, 40), "S", style2);
            GUI.Box(new Rect(160 + xOffset, Screen.height - 60 + yOffset, 40, 40), "D", style2);
            GUI.Box(new Rect(80 + xOffset, Screen.height - 20 + yOffset, 120, 40), "Jump", style2);
            GUI.Box(new Rect(0 + xOffset, Screen.height - 100 + yOffset, 80, 40), "Caps", style2);
            GUI.Box(new Rect(0 + xOffset, Screen.height - 60 + yOffset, 80, 40), "Shift", style2);
            GUI.Box(new Rect(0 + xOffset, Screen.height - 20 + yOffset, 80, 40), "Ctrl", style2);
            GUI.Box(new Rect(200 + xOffset, Screen.height - 100 + yOffset, 40, 120), "LM", style2);
            GUI.Box(new Rect(240 + xOffset, Screen.height - 100 + yOffset, 40, 120), "RM", style2);


            if (Input.GetKey(KeyCode.W))
            {
                GUI.Box(new Rect(120 + xOffset, Screen.height - 100 + yOffset, 40, 40), "W", style1);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                GUI.Box(new Rect(80 + xOffset, Screen.height - 100 + yOffset, 40, 40), "Q", style1);
            }
            if (Input.GetKey(KeyCode.E))
            {
                GUI.Box(new Rect(160 + xOffset, Screen.height - 100 + yOffset, 40, 40), "E", style1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                GUI.Box(new Rect(80 + xOffset, Screen.height - 60 + yOffset, 40, 40), "A", style1);
            }
            if (Input.GetKey(KeyCode.S))
            {
                GUI.Box(new Rect(120 + xOffset, Screen.height - 60 + yOffset, 40, 40), "S", style1);
            }
            if (Input.GetKey(KeyCode.D))
            {
                GUI.Box(new Rect(160 + xOffset, Screen.height - 60 + yOffset, 40, 40), "D", style1);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                GUI.Box(new Rect(80 + xOffset, Screen.height - 20 + yOffset, 120, 40), "Jump", style1);
            }
            if (Input.GetKey(KeyCode.CapsLock))
            {
                GUI.Box(new Rect(0 + xOffset, Screen.height - 100 + yOffset, 80, 40), "Caps", style1);
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                GUI.Box(new Rect(0 + xOffset, Screen.height - 60 + yOffset, 80, 40), "Shift", style1);
            }
            if (Input.GetKey(KeyCode.LeftControl))
            {
                GUI.Box(new Rect(0 + xOffset, Screen.height - 20 + yOffset, 80, 40), "Ctrl", style1);
            }
            if (Input.GetKey(KeyCode.Mouse0))
            {
                GUI.Box(new Rect(200 + xOffset, Screen.height - 100 + yOffset, 40, 120), "LM", style1);
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                GUI.Box(new Rect(240 + xOffset, Screen.height - 100 + yOffset, 40, 120), "RM", style1);
            }
            UnityEngine.Object.Destroy(texture1);
            UnityEngine.Object.Destroy(texture2);
        }
    }
}
