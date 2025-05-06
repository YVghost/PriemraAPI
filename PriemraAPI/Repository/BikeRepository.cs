using PriemraAPI.Models;

namespace PriemraAPI.Repository
{
    public class BikeRepository
    {
        public IEnumerable<Bike> obtenerListaBikes()
        {
            List<Bike> bikes = new List<Bike>();
            Bike bikes1 = new Bike()
            {
                bikeId = 1,
                marca = "Trek",
                material = "Aluminio",
                costo = 1000,
                esNueva = true
            };
            Bike bikes2 = new Bike()
            {
                bikeId = 2,
                marca = "Giant",
                material = "Carbono",
                costo = 2000,
                esNueva = false
            };



            bikes.Add(bikes1);
            bikes.Add(bikes2);
            return bikes;
        }

        public Bike obtenerBike(int id)
        {
            var bikes = obtenerListaBikes();
            return bikes.FirstOrDefault(item => item.bikeId == id);
        }
    }
}

    
