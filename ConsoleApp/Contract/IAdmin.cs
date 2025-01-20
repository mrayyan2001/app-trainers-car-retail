namespace ConsoleApp;

public interface IAdmin
{
    bool Login(string username, string password);
    bool Verification(string code);

    // ManageEmployees
    List<Employee> GetALLEmployee();
    Employee GetOneEmployee(long nationalID);
    void CreateEmployee(long nationalID, string name, string email, string password);
    void UpdateEmployee(long nationalID, string name, string email, string password);
    void DeleteEmployee(Employee employeeToDelete);

    // Mange Car
    List<Car> GetALLCar();
    Car GetOneCar(int plateNumber);
    void CreateCar(long nationalID, string name, string email, string password);
    void UpdateCar(long nationalID, string name, string email, string password);
    void DeleteCar(Car employeeToDelete);


}
