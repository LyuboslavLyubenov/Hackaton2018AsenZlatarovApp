namespace HakatonApp.Services.Vauchers
{
    using System.Collections.Generic;

    public interface IVaucherService
    {
        bool GenerateVauchers(int questId);
    }
}
