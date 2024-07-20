using SimpleCrudApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ParkingSystem.Repositories
{
    public class InMemoryParkingLotRepository : IParkingLotRepository
    {
        private readonly List<ParkingLot> _parkingLots = new List<ParkingLot>();

        public IEnumerable<ParkingLot> GetAll()
        {
            return _parkingLots;
        }

        public ParkingLot GetById(int id)
        {
            return _parkingLots.FirstOrDefault(parkingLot => parkingLot.Id == id);
        }

        public void Add(ParkingLot parkingLot)
        {
            parkingLot.Id = _parkingLots.Count > 0 ? _parkingLots.Max(p => p.Id) + 1 : 1;
            _parkingLots.Add(parkingLot);
        }

        public void Update(ParkingLot parkingLot)
        {
            var existingParkingLot = GetById(parkingLot.Id);
            if (existingParkingLot != null)
            {
                existingParkingLot.Car = parkingLot.Car;
                existingParkingLot.Motorcycle = parkingLot.Motorcycle;
            }
        }
    }
}
