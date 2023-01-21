namespace Project;

[Serializable]
public class ControlProperties
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Text { get; set; }
    public Point Location { get; set; }
    public Size Size { get; set; }
    public bool AutoSize { get; set; }
    public bool Visiable { get; set; }
}
