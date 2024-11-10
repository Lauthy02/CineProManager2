using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_SERIALZIAR
    {
        public void Serializar<T>(T entidad, string path)
        {
            //Serializar el objeto a JSON
            string json = JsonSerializer.Serialize(entidad);
            File.WriteAllText(path, json);
        }

        public T Deserializar<T>(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                T deserialized = JsonSerializer.Deserialize<T>(json);
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
