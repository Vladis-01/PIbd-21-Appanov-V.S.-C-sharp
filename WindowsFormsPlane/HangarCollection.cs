using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class HangarCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Hangar<Vehicle>> hangarStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => hangarStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        private readonly char separator = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public HangarCollection(int pictureWidth, int pictureHeight)
        {
            hangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddHangar(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                return;
            }
            hangarStages.Add(name, new Hangar<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelHangar(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                hangarStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Hangar<Vehicle> this[string ind]
        {
            get
            {
                if (hangarStages.ContainsKey(ind))
                {
                    return hangarStages[ind];
                }
                return null;
            }
        }

        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.WriteLine($"HangarCollection");
            foreach (var level in hangarStages)
            {
                //Начинаем парковку
                streamWriter.WriteLine($"Hangar{separator}{level.Key}");
                ITransport plane = null;
                for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                {
                    if (plane != null)
                    {
                        //если место не пустое
                        //Записываем тип машины
                        if (plane.GetType().Name == "Plane")
                        {
                            streamWriter.Write($"Plane{separator}");
                        }
                        if (plane.GetType().Name == "BomberPlane")
                        {
                            streamWriter.Write($"BomberPlane{separator}");
                        }
                        //Записываемые параметры
                        streamWriter.WriteLine(plane);
                    }
                }
            }
            streamWriter.Close();
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            StreamReader streamReader = new StreamReader(filename);
            String str = streamReader.ReadLine();

            if (str.Contains("HangarCollection"))
            {
                //очищаем записи
                hangarStages.Clear();
            }
            else
            {
                //если нет такой записи, то это не те данные
                throw new FileFormatException();
            }
            Vehicle plane = null;
            string key = string.Empty;
            while ((str = streamReader.ReadLine()) != null)
            {
                //идем по считанным записям
                if (str.Contains("Hangar"))
                {
                    //начинаем новую парковку
                    key = str.Split(separator)[1];
                    hangarStages.Add(key, new Hangar<Vehicle>(pictureWidth,
                    pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(str))
                {
                    continue;
                }
                if (str.Split(separator)[0] == "Plane")
                {
                    plane = new Plane(str.Split(separator)[1]);
                }
                else if (str.Split(separator)[0] == "BomberPlane")
                {
                    plane = new BomberPlane(str.Split(separator)[1]);
                }
                var result = hangarStages[key] + plane;
                if (!result)
                {
                    throw new NullReferenceException();
                }
            }
        }
    }
}
