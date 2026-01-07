using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WareHouse.Models;
using System.IO;
using WareHouse.Confing;

namespace WareHouse.Infrastructure.Storage
{
    public static class WalletStorage
    {
        public static WalletData Load()
        {
            if (!File.Exists(PathConfing.WalletFile))
                return new WalletData { Balance = 0 };
            var json = File.ReadAllText(PathConfing.WalletFile);
            return JsonConvert.DeserializeObject<WalletData>(json) ?? new WalletData { Balance = 0};
        }

        public static void Save(decimal balance)
        {
            var data = new WalletData { Balance = balance };
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(PathConfing.WalletFile, json);
        }
    }
}
