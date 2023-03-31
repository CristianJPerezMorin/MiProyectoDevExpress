using MiProyecto.Debugging;

namespace MiProyecto
{
    public class MiProyectoConsts
    {
        public const string LocalizationSourceName = "MiProyecto";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "51aff451f0ce4bc7a33f5d7a47cdb9d0";
    }
}
