using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PT_lab_1
{
    /// <summary>
    /// Класс-хранидище парковок
    /// </summary>
    public class MultiLevelParking
    {
        /// <summary>
        /// Список с уровнями парковки
        /// </summary>
        List<Parking<ITransport>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 20;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
               
            parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
                pictureHeight));
            }
        }
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                //Записываем количество уровней
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var transport = level[i];
                        if (transport != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (transport.GetType().Name == "WarCar")
                            {
                                sw.Write(i + ":WarCar:");
                            }
                            if (transport.GetType().Name == "Tank")
                            {
                                sw.Write(i + ":Tank:");
                            }
                            //Записываемые параметры
                            sw.WriteLine(transport);
                        }
                    }
                }
            }
            return true;
        }


        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            int level = -1;
            using (StreamReader fs = new StreamReader(filename))
            {
                string temp = fs.ReadLine();
                if (temp.Contains("CountLeveles:"))
                {
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>();
                }
                else
                {
                    return false;
                }

                while (!fs.EndOfStream)
                {
                    temp = fs.ReadLine();
                    if (temp.Contains("Level"))
                    {
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        level++;
                    }
                    else
                    {
                        int index = Convert.ToInt32(temp.Split(':')[0]);
                        ITransport mashine = null;
                        if (temp.Contains("Tank"))
                        {
                            mashine = new Tank(temp.Split(':')[2]);
                        }
                        else
                        {
                            mashine = new WarCar(temp.Split(':')[2]);
                        }
                        parkingStages[level][index] = mashine;
                    }
                }
            }
            return true;
        }
        public void Sort()
        {
            parkingStages.Sort();
        }

    }
}




