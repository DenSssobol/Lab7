using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab6
{
    abstract class Plane : IComparable<Plane>
    {
        protected int countPlace;
        protected int carryingCapacity;
        protected int rangeOfFlight;
        protected double gasolinePerKilometer;
        protected string model;
        public abstract int CountPlace { set; get; }
        public abstract int CarryingCapacity { set; get; }
        public abstract int RangeOfFlight { set; get; }
        public abstract double GasolinePerKilometer { set; get; }
        public abstract string Model { set; get; }
        public abstract void Fly();
        public abstract void Land();
        int IComparable<Plane>.CompareTo(Plane other)
        {
            int compare = this.RangeOfFlight.CompareTo(other.RangeOfFlight);
            return compare;
        }
    }
    class Boing360 : Plane
    {
        public Boing360(int countPlace, int carryingCapacity, int rangeOfFlight, double gasolinePerKilometer, string model)
        {
            this.CountPlace = countPlace;
            this.CarryingCapacity = carryingCapacity;
            this.RangeOfFlight = rangeOfFlight;
            this.GasolinePerKilometer = gasolinePerKilometer;
            this.Model = model;
        }
        public override int CountPlace
        {
            set
            {
                if (value > 0)
                {
                    countPlace = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return countPlace; }
        }
        public override int CarryingCapacity
        {
            set
            {
                if (value > 0)
                {
                    carryingCapacity = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return carryingCapacity; }
        }
        public override int RangeOfFlight
        {
            set
            {
                if (value > 0)
                {
                    rangeOfFlight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return rangeOfFlight; }
        }
        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasolinePerKilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return gasolinePerKilometer; }
        }
        public override string Model
        {
            set { model = value; }
            get { return model; }
        }
        public override void Fly()
        {
            Console.WriteLine("Летит самолет модели {0}", model);
        }
        public override void Land()
        {
            Console.WriteLine("Приземляется самолет модели {0}", model);
        }
    }
    class L29 : Plane
    {
        public L29(int countPlace, int carryingCapacity, int rangeOfFlight, double gasolinePerKilometer, string model)
        {
            this.CountPlace = countPlace;
            this.CarryingCapacity = carryingCapacity;
            this.RangeOfFlight = rangeOfFlight;
            this.GasolinePerKilometer = gasolinePerKilometer;
            this.Model = model;
        }
        public override int CountPlace
        {
            set
            {
                if (value > 0)
                {
                    countPlace = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return countPlace; }
        }
        public override int CarryingCapacity
        {
            set
            {
                if (value > 0)
                {
                    carryingCapacity = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return carryingCapacity; }
        }
        public override int RangeOfFlight
        {
            set
            {
                if (value > 0)
                {
                    rangeOfFlight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return rangeOfFlight; }
        }
        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasolinePerKilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return gasolinePerKilometer; }
        }
        public override string Model
        {
            set { model = value; }
            get { return model; }
        }
        public override void Fly()
        {
            Console.WriteLine("Летит самолет модели {0}", model);
        }
        public override void Land()
        {
            Console.WriteLine("Приземляется самолет модели {0}", model);
        }
    }
    class MO981 : Plane
    {
        public MO981(int countPlace, int carryingCapacity, int rangeOfFlight, double gasolinePerKilometer, string model)
        {
            this.CountPlace = countPlace;
            this.CarryingCapacity = carryingCapacity;
            this.RangeOfFlight = rangeOfFlight;
            this.GasolinePerKilometer = gasolinePerKilometer;
            this.Model = model;
        }
        public override int CountPlace
        {
            set
            {
                if (value > 0)
                {
                    countPlace = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return countPlace; }
        }
        public override int CarryingCapacity
        {
            set
            {
                if (value > 0)
                {
                    carryingCapacity = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return carryingCapacity; }
        }
        public override int RangeOfFlight
        {
            set
            {
                if (value > 0)
                {
                    rangeOfFlight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return rangeOfFlight; }
        }
        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasolinePerKilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get { return gasolinePerKilometer; }
        }
        public override string Model
        {
            set { model = value; }
            get { return model; }
        }
        public override void Fly()
        {
            Console.WriteLine("Летит самолет модели {0}", model);
        }
        public override void Land()
        {
            Console.WriteLine("Приземляется самолет модели {0}", model);
        }
    }
    class MyCollection : IEnumerable, IEnumerator
    {
        private int count = 15;
        private int position = -1;
        private int startIndex = 0;
        private int countPlace;
        private int carryingCapacity;
        private double minGasoline, maxGasoline;
        private List<Plane> planes;
        public MyCollection(double minGasoline, double maxGasoline)
        {
            planes = new List<Plane>(count);
            for (int i = 0; i < count; i++)
            {
                planes.Add(null);
            }
            this.minGasoline = minGasoline;
            this.maxGasoline = maxGasoline;
        }
        public MyCollection(Plane elem, double minGasoline, double maxGasoline) :
            this(minGasoline, maxGasoline)
        {
            planes[startIndex] = elem;
            startIndex += 1;
        }
        public MyCollection(List<Plane> array, double minGasoline, double maxGasoline) :
            this(minGasoline, maxGasoline)
        {
            if (array.Count <= planes.Count)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    planes[i] = array[i];
                    startIndex += 1;
                }
            }
            else
            {
                int temp = planes.Count;
                bool flag = true;
                while (flag)
                {
                    temp += Convert.ToInt32(0.3 * planes.Count);
                    if (temp < array.Count)
                        continue;
                    else
                        flag = false;
                }
                planes = new List<Plane>(temp);
                //int difference = temp - array.Count;
                //хрень что б работало, потому что изначально Лист пустой и чтоб с ним можно было работать его надо заполнить, заполняем по умолчанию
                for (int i = 0; i < array.Count; i++)
                {
                    planes.Add(null);
                }
                for (int i = 0; i < array.Count; i++)
                {
                    planes[i] = array[i];
                    startIndex += 1;
                }
            }
        }
        public int GetCountOfPlace()
        {
            for (int i = 0; i < planes.Count; i++)
            {
                countPlace += planes[i].CountPlace;
            }
            return countPlace;
        }
        public int GetCarryingCapacity()
        {
            for (int i = 0; i < planes.Count; i++)
            {
                carryingCapacity += planes[i].CarryingCapacity;
            }
            return carryingCapacity;
        }
        public List<Plane> SortByRangeOfFlight()
        {
            planes.Sort();
            return planes;
        }
        public List<Plane> GetRightPlanesByGasoline()
        {
            List<Plane> rightPlanesByGasoline = new List<Plane>();
            for (int i = 0; i < planes.Count; i++)
            {
                if (planes[i].GasolinePerKilometer >= minGasoline & planes[i].GasolinePerKilometer <= maxGasoline)
                {
                    rightPlanesByGasoline.Add(planes[i]);
                }
            }
            return rightPlanesByGasoline;
        }
        //индексатор на всякий случай(это в шарпе есть такая тема, что можно к коллекции как к массиву обращаться)
        public Plane this[int index]
        {
            set
            {
                if (startIndex > 0)
                {
                    if (index >= startIndex && index < planes.Count)
                    {
                        planes[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Индекс вне диапазона");
                    }
                }
                else
                {
                    if (index >= 0 && index < planes.Count)
                    {
                        planes[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Индекс вне диапазона");
                    }
                }
            }
            get
            {
                if (index >= 0 && index < planes.Count)
                {
                    return planes[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }
            }
        }
        //реализация интерфейсов что б можно было форычем проходиться по коллекции
        bool IEnumerator.MoveNext()
        {
            if (position < planes.Count - 1)
            {
                position++;
                return true;
            }
            else
            {
                IEnumerator help = this;
                help.Reset();
                return false;
            }
        }
        void IEnumerator.Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get { return planes[position]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Plane> planes = new List<Plane>();
            Boing360[] arrayBoing360 = new Boing360[6];
            for (int i = 0; i < arrayBoing360.Length; i++)
            {
                arrayBoing360[i] = new Boing360(360, 500, 20, 34.5, "Boing360");
                planes.Add((Plane)arrayBoing360[i]);
            }

            L29[] arrayL29 = new L29[6];
            for (int i = 0; i < arrayL29.Length; i++)
            {
                arrayL29[i] = new L29(300, 420, 25, 29.8, "L29");
                planes.Add((Plane)arrayL29[i]);
            }

            MO981[] arrayMO981 = new MO981[6];
            for (int i = 0; i < arrayMO981.Length; i++)
            {
                arrayMO981[i] = new MO981(400, 700, 30, 50.4, "MO981");
                planes.Add((Plane)arrayMO981[i]);
            }

            double minGasoline = 15.7;
            double maxGasoline = 35.2;
            MyCollection myCollection = new MyCollection(planes, minGasoline, maxGasoline);
            myCollection[30] = arrayBoing360[0];
            
            int countPlace = myCollection.GetCountOfPlace();
            Console.WriteLine("Количество мест - {0}", countPlace);

            int carryingCapacity = myCollection.GetCarryingCapacity();
            Console.WriteLine("Общая грузоподъемность - {0}", carryingCapacity);

            Console.WriteLine("Нужные самолеты по бензину за километр:");
            List<Plane> rightPlanesByGasoline = myCollection.GetRightPlanesByGasoline();
            foreach (Plane plane in rightPlanesByGasoline)
            {
                Console.WriteLine("Модель самолета - {0}, беззин за километр - {1}", plane.Model, plane.GasolinePerKilometer);
            }

            Console.WriteLine("Сортировка по дальности полета:");
            List<Plane> sortedPlanes = myCollection.SortByRangeOfFlight();
            foreach (Plane plane in sortedPlanes)
            {
                Console.WriteLine("Модель самолета - {0}, дальность полета - {1}", plane.Model, plane.RangeOfFlight);
            }
            Console.ReadKey();
        }
    }
}
