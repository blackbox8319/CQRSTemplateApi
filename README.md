# CQRS Pattern with MediatR in ASP.NET Core Web API

This project demonstrates how to implement the CQRS (Command Query Responsibility Segregation) pattern using MediatR in an ASP.NET Core Web API.

## What is CQRS?

CQRS stands for **Command Query Responsibility Segregation**. It’s a design pattern that separates the responsibilities of reading (querying) and writing (commanding) data. By segregating these operations, you can optimize and scale the read and write sides independently, resulting in better performance and maintainability.

- **Command Model**: Handles write operations like Create, Update, and Delete. This model is responsible for changing the state of the application.
  
- **Query Model**: Handles read operations. This model is optimized for retrieving data without modifying it.

## MediatR Overview

[MediatR](https://github.com/jbogard/MediatR) is a simple mediator library for .NET. It implements the Mediator pattern, helping to decouple the sender and receiver of requests, which is ideal for implementing the CQRS pattern.

## Getting Started

### Prerequisites

- [.NET 7](https://dotnet.microsoft.com/download/dotnet/7.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later

### Installing MediatR

To get started, install the required packages via NuGet:

```bash
dotnet add package MediatR.Extensions.Microsoft.DependencyInjection
```

### Project Structure

- **Commands**: Represent actions that modify the state of the system.
- **Queries**: Represent actions that retrieve data from the system.
- **Handlers**: Process the commands and queries.

### Example Implementation

#### 1. Command and Query Models

```csharp
// Command for creating a new item
public class CreateItemCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
}

// Query for fetching an item by ID
public class GetItemByIdQuery : IRequest<Item>
{
    public int Id { get; set; }
}
```

#### 2. Command and Query Handlers

```csharp
// Command Handler
public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, int>
{
    private readonly ApplicationDbContext _context;

    public CreateItemCommandHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        var item = new Item
        {
            Name = request.Name,
            Description = request.Description
        };

        _context.Items.Add(item);
        await _context.SaveChangesAsync(cancellationToken);

        return item.Id;
    }
}

// Query Handler
public class GetItemByIdQueryHandler : IRequestHandler<GetItemByIdQuery, Item>
{
    private readonly ApplicationDbContext _context;

    public GetItemByIdQueryHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Item> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
    {
        return await _context.Items.FindAsync(new object[] { request.Id }, cancellationToken);
    }
}
```

#### 3. Register MediatR

In `Startup.cs` or `Program.cs`, register MediatR in the dependency injection container:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddMediatR(typeof(Startup).Assembly);
    // other services
}
```

#### 4. Using MediatR in Controllers

Inject `IMediator` in your controller to send commands and queries:

```csharp
[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ItemsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateItem(CreateItemCommand command)
    {
        var itemId = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetItemById), new { id = itemId }, command);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItemById(int id)
    {
        var item = await _mediator.Send(new GetItemByIdQuery { Id = id });
        if (item == null)
            return NotFound();

        return Ok(item);
    }
}
```

## Benefits of CQRS with MediatR

- **Separation of Concerns**: Clear division between command and query logic.
- **Scalability**: Independent scaling of read and write operations.
- **Maintainability**: Clean, organized code that’s easy to understand and maintain.
- **Flexibility**: Ability to use different data stores or models for read and write operations.

## Conclusion

Implementing the CQRS pattern with MediatR in ASP.NET Core Web API helps in creating scalable, maintainable, and flexible applications. This pattern is particularly useful in complex domains where read and write operations need to be optimized independently.

Feel free to explore the code and adapt it to your specific needs!

