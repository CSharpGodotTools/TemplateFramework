using Godot;

namespace GodotUtils;

public static class GWindow
{
    public static void SetTitle(string title)
    {
        DisplayServer.WindowSetTitle(title);
    }

    public static Vector2 GetCenter()
    {
        return new Vector2(GetWidth() / 2f, GetHeight() / 2f);
    }

    public static int GetWidth()
    {
        return DisplayServer.WindowGetSize().X;
    }

    public static int GetHeight()
    {
        return DisplayServer.WindowGetSize().Y;
    }
}

