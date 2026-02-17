using Supabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVA_Launcher_Private.Services
{
    class SupabaseService
    {
        private static Client? _client;
        public static Client Client => _client ?? throw new Exception("Supabase no ha inicializado.");

        public static async Task Initialize(string url, string key)
        {
            if (_client != null) return;

            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true,
            };

            _client = new Client(url, key, options);
            await _client.InitializeAsync();
        }

        public static async Task<bool> TestConnection()
        {
            if (_client == null) return false;
            try
            {
                // Obtener sesuin actual aunque sea nulo, para confirmar conexion
                var state = _client.Auth.CurrentSession;
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error de conexión: {ex.Message}");
                return false;
            }
        }
    }
}
