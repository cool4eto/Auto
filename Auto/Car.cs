using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Car
    {
        private int carID;
        private string make;
        private string model;
        private string color;
        private string VIN;
        private string condition;
        private string price;
        private int dealership;
        public int getCarID()
        {
            return carID;
        }
        public void setCarID(int carID)
        {
            this.carID = carID;
        }
        public String getMake()
        {
            return make;
        }
        public void setMake(String make)
        {
            this.make = make;
        }
        public String getModel()
        {
            return model;
        }
        public void setModel(String model)
        {
            this.model = model;
        }
        public String getColor()
        {
            return color;
        }
        public void setColor(String color)
        {
            this.color = color;
        }
        public String getVIN()
        {
            return VIN;
        }
        public void setVIN(String vIN)
        {
            VIN = vIN;
        }
        public String getCondition()
        {
            return condition;
        }
        public void setCondition(String condition)
        {
            this.condition = condition;
        }
        public String getPrice()
        {
            return price;
        }
        public void setPrice(String price)
        {
            this.price = price;
        }
        public int getDealership()
        {
            return dealership;
        }
        public void setDealership(int dealership)
        {
            this.dealership = dealership;
        }
        public Car(int carID, String make, String model, String color, String vIN, String condition, String price,
			int dealership) {
		this.carID = carID;
		this.make = make;
		this.model = model;
		this.color = color;
		VIN = vIN;
		this.condition = condition;
		this.price = price;
		this.dealership = dealership;
	}
        public Car()
        {
        
        }
    
    }
}
