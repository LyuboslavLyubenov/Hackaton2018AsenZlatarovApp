namespace HakatonApp.Services.Vauchers
{
    using System.Collections.Generic;

    public interface IVaucherService
    {
        bool GenerateVauchers(int questId);

        IEnumerable<string> GetCodes(int questId);

        bool UseVoucher(string code);
    }
}
