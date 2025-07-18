using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Car
    {
        private int id;
        private string model;
        private int speed;

        //public Car() //not required
        //{
        //    id = default;
        //    speed = default;
        //    model = default;
        //}

        public Car(int id, int speed, string model) : this(id, speed)
        {
            //Or using property
            //this.id = id; //Id = id
            //this.speed = speed; //Speed = speed
            this.model = model; //Model = model
        }

        public Car(int id, int speed) :this(id)
        {
            //Id = id;
            Speed = speed;
        }

        public Car(int id)
        {
            Id = id;
           
        }


        public int Id
        {
            set
            {
                id = value;
            }

            get
            {
                return id;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }

        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public override string ToString()
        {
            return $"Id: {id} ::: Speed: {speed} ::: Model: {model}";
        }


    } 
}
