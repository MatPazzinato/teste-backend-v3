using TheatricalPlayers.Domain.Enums;
using TheatricalPlayers.Domain.Utils;

namespace TheatricalPlayers.Domain.Entidades;

public class Play
{
    public string Name { get; private set; }
    public int Lines { get; private set; }
    public PlayTypeEnum Type { get; private set; }


    public Play(string name, int lines, PlayTypeEnum type)
    {
        Name = name;
        Lines = lines;
        Type = type;
    }

    public bool IsValid()
    {
        return Lines >= EnvironmentValues.MINIMUM_LINES_VALUE &&
               Lines <= EnvironmentValues.MAXIMUM_LINES_VALUE;
    }
}
