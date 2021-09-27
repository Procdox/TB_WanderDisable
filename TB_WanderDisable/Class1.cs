using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_WanderDisable
{
    public class Patcher
    {
        var harmony = new Harmony("com.example.patch");
        harmony.PatchAll();
    }
    [BepInPlugin("org.bepinex.plugins.exampleplugin", "Example Plug-In", "1.0.0.0")]
    public class ExamplePlugin : BaseUnityPlugin
    {
        void Awake()
        {
            UnityEngine.Debug.Log("Hello, world!");
            MyPatcher.DoPatching();
        }
    }
}
