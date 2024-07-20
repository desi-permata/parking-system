using SimpleCrudApp.Models;
using System.Collections.Generic;

namespace ParkingSystem.Repositories
{
    public interface IParkingLotRepository
    {
        IEnumerable<ParkingLot> GetAll();
        ParkingLot GetById(int id);
        void Add(ParkingLot parkingLot);
        void Update(ParkingLot parkingLot);
    }
}
