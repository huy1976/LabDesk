# 📦 LabDesk - SeedWork Module

Tài liệu cấu trúc và liên kết chi tiết cho các thư mục trong module **SeedWork**.

---

## 📁 Cấu trúc thư mục & Link tài liệu
* 🏷️ **`LabDesk.SeedWork`** — [🔗 SeedWork](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/seedwork-domain-model-base-classes-interfaces)
* 🏷️ **`DomainEvent`** — [🔗 DomainEvent](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/domain-events-design-implementation)
* 🔷 **`LabDesk.SeedWork.Domain/`** 
  * 📁 `Interfaces/` — [🔗 Repository/UnitOfWork](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design) *(Core Interfaces: IRepository, IUnitOfWork)*
  * 📄 `AggregateRoot.cs` 
  * 📄 `Entity.cs` _
  * 📄 `ValueObject.cs` 
<br> ↳[🔗 Entity/ValueObject/AggregateRoot](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/microservice-domain-model)
* 🔶 **`LabDesk.SeedWork.Application/`** — [🔗Application/Structor/Autofac/CQRS Implement Command,Query,Handler,Mediator,MessageQueue](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/microservice-application-layer-implementation-web-api).
  * 📁 `Behaviors/` — [🔗 Link Docs](https://your-link-here.com) *(MediatR Pipeline Behaviors)*
  * 📁 `CQRS/` — [🔗 Link Docs](https://your-link-here.com) *(Commands, Queries & Handlers)*
  * 📁 `Interfaces/` — [🔗 Link Docs](https://your-link-here.com) *(Application Interfaces)*
  * 📁 `Results/` — [🔗 Link Docs](https://your-link-here.com) *(Result Pattern Wrapper)*
  * 📄 `DependencyInjection.cs` *(Đăng ký IoC/DI Container)*

* 🟢 **`LabDesk.SeedWork.Infrastructure/`** — [🔗 Xem Docs Infrastructure](https://your-link-here.com)
  * 📁 `Persistence/` — [🔗 Link Docs](https://your-link-here.com)
    * 📄 `BaseDbContext.cs` *(EF Core DbContext)*
    * 📄 `DispatchDomainEventsInterceptor.cs` *(Interceptor bắn Domain Events)*
