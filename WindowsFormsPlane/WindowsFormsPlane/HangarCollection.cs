using System;
using System.Collections.Generic;
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
	}
}
