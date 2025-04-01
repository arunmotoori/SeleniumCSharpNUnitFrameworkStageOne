using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TutorialsNinjaProject.Config
{
    internal class ConfigReader
    {

        public static dynamic LoadConfigFile()
        {
            string ConfigFilePath = "./Config/config.json";
            string JSONText = File.ReadAllText(ConfigFilePath);
            return JsonConvert.DeserializeObject<dynamic>(JSONText);

        }




    }
}
