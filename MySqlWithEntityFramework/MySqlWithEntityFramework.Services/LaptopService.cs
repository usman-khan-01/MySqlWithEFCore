using MySqlWithEntityFramework.EF;
using MySqlWithEntityFramework.EF.Models;

namespace MySqlWithEntityFramework.Service;
public class LaptopService {
    private readonly ApplicationContext _context;
    public LaptopService(ApplicationContext context) {
        _context = context;
    }
    public Laptop[] GetLaptops() {
        return _context.Laptops.ToArray();
    }
}