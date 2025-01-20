namespace ConsoleApp;

public interface IAdmin
{
    bool Login(string username, string password);
    bool Verification(string code);

    // ManageEmployees
    Task<List<Employee>> GetALLEmployee();
    Task<Employee> GetOneEmployee(long nationalID);
    Task CreateEmployee(long nationalID, string name, string email, string password);
    Task UpdateEmployee(long nationalID, string name, string email, string password);
    Task DeleteEmployee(Employee employeeToDelete);

    // Mange Car
    Task<List<Car>> GetALLCar();
    Task<Car> GetOneCar(int plateNumber);
    Task CreateCar(long nationalID, string name, string email, string password);
    Task UpdateCar(long nationalID, string name, string email, string password);
    Task DeleteCar(Car employeeToDelete);


}
