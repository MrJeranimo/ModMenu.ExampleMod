using StarMap.API;
using ModMenu;
using Brutal.ImGuiApi;

namespace ModMenu.ExampleMod
{
    [StarMapMod]
    public class ExampleMod
    {
        [ModMenuEntry("ModMenu ExampleMod")]
        public void DrawSubMenuEntry()
        {
            ImGui.Text("The test worked!");
        }
    }
}
