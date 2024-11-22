using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DAL
{
    public class DAL_SERIALZIAR
    {
        public void Serializar<T>(T entidad, string path)
        {
            //Serializar el objeto a JSON con System.Text.Json
            //string json = JsonSerializer.Serialize(entidad);
            //File.WriteAllText(path, json);

            //Serializar el objeto a JSON con Newtonsoft.Json
            string json = JsonConvert.SerializeObject(entidad);
            File.WriteAllText(path, json);
        }

        public T Deserializar<T>(string path)
        {
            if (File.Exists(path))
            {
                //Deserializar el objeto con System.Text.Json
                //var json = File.ReadAllText(path);
                //T deserialized = JsonSerializer.Deserialize<T>(json);
                //return deserialized;

                //Deserializar el objeto con Newtonsoft.Json
                var json = File.ReadAllText(path);
                T deserialized = JsonConvert.DeserializeObject<T>(json);
                return deserialized;
            }
            else
            {
                MessageBox.Show("El archivo de serialización no existe.");
                return default(T);
            }
        }
    }
}
