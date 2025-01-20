# Folder Structure

- Entities
- Contracts
- Services

```bash
mkdir Entities Contract Service
```

## Entities Folder

```bash
dotnet new class -o ./Entities/ -n Admin
dotnet new class -o ./Entities/ -n Car
dotnet new class -o ./Entities/ -n Client
dotnet new class -o ./Entities/ -n Contract
dotnet new class -o ./Entities/ -n Employee
dotnet new class -o ./Entities/ -n Insurance
dotnet new class -o ./Entities/ -n Invoice
dotnet new class -o ./Entities/ -n Rate
```

### Actors

| Class    | fields                            |
| -------- | --------------------------------- |
| Admin    | name, email, password             |
| Client   | nationalID, name, email, password |
| Employee | nationalID, name, email, password |

### Objects

| Class     | fields                                                     |
| --------- | ---------------------------------------------------------- |
| Car       | plateNumber, brand, model, makeYear, color, price          |
| Contract  | contractID, startDate, endDate, description                |
| Insurance | insuranceID, startDate, endDate, type, amount, description |
| Invoice   | invoiceID, amount, tax, discount, date                     |
| Rate      | rateID, comment, rateAmount                                |

## Contracts Folder

- IAmin
- IClient
- IEmployee

```bash
dotnet new interface -o ./Contract/ -n IAdmin
dotnet new interface -o ./Contract/ -n IClient
dotnet new interface -o ./Contract/ -n IEmployee
```

> Manage: CRUD operations (Create, Read (GetAll, GetOne), Update, Delete) \
> Explore: Read operations (GetAll, GetOne) \
> Create: Just Create operation

| Interface | methods                                                                              |
| --------- | ------------------------------------------------------------------------------------ |
| IAdmin    | MangeEmployees, ManageCar, MangeContract, ManageInsurance, ManageInvoice, ManageRate |
| IClient   | ManageCar, CreateContract, CreateInvoice , CreateInsurance                           |
| IEmployee | ExploreContract, ExploreInvoices, ExploreInsurance, ManageRating                     |

### ManageEmployees

| Method Name | Parameters              | Return Type    |
| ----------- | ----------------------- | -------------- |
| GetAll      |                         | List<Employee> |
| GetOne      | nationalID              | Employee       |
| Create      | Employee                | Employee       |
| Update      | nationalID, newEmployee | Employee       |
| Delete      | nationalID              | bool           |

### ManageCar

| Method Name | Parameters          | Return Type |
| ----------- | ------------------- | ----------- |
| GetAll      |                     | List<Car>   |
| GetOne      | plateNumber         | Car         |
| Create      | Car                 | Car         |
| Update      | plateNumber, newCar | Car         |
| Delete      | plateNumber         | bool        |

### MangeContract

| Method Name | Parameters              | Return Type    |
| ----------- | ----------------------- | -------------- |
| GetAll      |                         | List<Contract> |
| GetOne      | contractID              | Contract       |
| Create      | Contract                | Contract       |
| Update      | contractID, newContract | Contract       |
| Delete      | contractID              | bool           |

### ManageInsurance

| Method Name | Parameters                | Return Type     |
| ----------- | ------------------------- | --------------- |
| GetAll      |                           | List<Insurance> |
| GetOne      | insuranceID               | Insurance       |
| Create      | Insurance                 | Insurance       |
| Update      | insuranceID, newInsurance | Insurance       |
| Delete      | insuranceID               | bool            |

### ManageInvoice

| Method Name | Parameters            | Return Type   |
| ----------- | --------------------- | ------------- |
| GetAll      |                       | List<Invoice> |
| GetOne      | invoiceID             | Invoice       |
| Create      | Invoice               | Invoice       |
| Update      | invoiceID, newInvoice | Invoice       |
| Delete      | invoiceID             | bool          |

### ManageRate

| Method Name | Parameters      | Return Type |
| ----------- | --------------- | ----------- |
| GetAll      |                 | List<Rate>  |
| GetOne      | rateID          | Rate        |
| Create      | Rate            | Rate        |
| Update      | rateID, newRate | Rate        |
| Delete      | rateID          | bool        |

### ManageClient

| Method Name | Parameters            | Return Type  |
| ----------- | --------------------- | ------------ |
| GetAll      |                       | List<Client> |
| GetOne      | nationalID            | Client       |
| Create      | Client                | Client       |
| Update      | nationalID, newClient | Client       |
| Delete      | nationalID            | bool         |
