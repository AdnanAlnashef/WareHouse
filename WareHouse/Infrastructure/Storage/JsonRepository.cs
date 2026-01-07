using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Interfaces;
using Newtonsoft.Json;

namespace WareHouse.Infrastructure.Storage
{
    public class JsonRepository<T> : IRepository<T> where T : class
    {
        private readonly string _path;
        public JsonRepository(string path)
        {
            _path = path;
            if (!File.Exists(_path))
            {
                File.WriteAllText(_path, "[]");
            }
        }

        public List<T> GetAll()
        {
            var json = File.ReadAllText(_path);
            return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }

        public T GetById(Guid id)
        {
            return GetAll()
                .FirstOrDefault(x => GetId(x) == id);
        }

        public void Add(T item)
        {
            var items = GetAll();
            items.Add(item);
            Save(items);
        }

        public void Update(T item)
        {
            var items = GetAll();
            var index = items.FindIndex(x => GetId(x) == GetId(item));

            if (index == -1)
                throw new Exception("Item not found");

            items[index] = item;
            Save(items);
        }

        public void Delete(Guid id)
        {
            var items = GetAll();
            var item = items.FirstOrDefault(x => GetId(x) == id);

            if (item != null)
            {
                items.Remove(item);
                Save(items);
            }
        }

        private void Save(List<T> items)
        {
            var json = JsonConvert.SerializeObject(items, Formatting.Indented);

            File.WriteAllText(_path, json);
        }

        private Guid GetId(T item)
        {
            var prop = typeof(T).GetProperty("Id");

            if (prop == null)
                throw new Exception("Type must have Id property");

            return (Guid)prop.GetValue(item);
        }
    }
}
