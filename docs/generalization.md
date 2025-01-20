# Generalization

1. make All Operation Awaitable but use the async / await keyword only inside class
2. Classes must have default properties (As best practice) (ID, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy, IsDeleted)

### Default Properties

1.  ID (int/long/string): Unique Identifier for each copy of the class
2.  CreatedAt (DateTime): Date and Time of the creation of the object
3.  CreatedBy (string): Name of the user who created the object
4.  UpdatedAt (DateTime): Date and Time of the last update of the object
5.  UpdatedBy (string): Name of the user who last updated the object
6.  IsDeleted (bool): Soft delete flag (we don't use hard delete in web applications)

- Generalization is the process of extracting shared characteristics from two or more classes, and combining them into a generalized superclass.
- Bring the shared components between group of entities and put them in a shared class.

> Shared Components: (Datatype, name, usage, ScopeValue, constraints, etc.)

Name: Shared, Entity, MainEntity, BaseEntity

```bash
dotnet new class -o ./Entities/ -n Entity
```

```csharp
public class Entity
{
    public int ID { get; set; }
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string UpdatedBy { get; set; }
    public bool IsDeleted { get; set; }
}
```

- Admin, Client, and Employee all have the same properties (name, email, password) so we can create a shared class for them.
- we can create a shared class called Person, User, or Actor.
- and all of them will inherit from this class.
- or we can create a role field in the shared class and use it to differentiate between them.

```bash
dotnet new class -o ./Entities/ -n Person
```

```csharp
public class Person : Entity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
```

> C# doesn't support multiple inheritance, so we can't inherit from more than one class. <br>
> Inheritance is a mechanism in which one class acquires the properties and behavior of another class.
