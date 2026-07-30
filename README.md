# 📦 LabDesk - SeedWork Module

Tài liệu cấu trúc và liên kết chi tiết cho các thư mục trong module **SeedWork**.

---

## 📁 Cấu trúc thư mục & Link tài liệu
 **`LabDesk.SeedWork`** — [🔗 Xem Docs Application](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/seedwork-domain-model-base-classes-interfaces)


* 🔶 **`LabDesk.SeedWork.Application/`** — [🔗 Xem Docs Application](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/seedwork-domain-model-base-classes-interfaces)
  * 📁 `Behaviors/` — [🔗 Link Docs](https://your-link-here.com) *(MediatR Pipeline Behaviors)*
  * 📁 `CQRS/` — [🔗 Link Docs](https://your-link-here.com) *(Commands, Queries & Handlers)*
  * 📁 `Interfaces/` — [🔗 Link Docs](https://your-link-here.com) *(Application Interfaces)*
  * 📁 `Results/` — [🔗 Link Docs](https://your-link-here.com) *(Result Pattern Wrapper)*
  * 📄 `DependencyInjection.cs` *(Đăng ký IoC/DI Container)*

* 🔷 **`LabDesk.SeedWork.Domain/`** — [🔗 Xem Docs Domain](https://your-link-here.com)
  * 📁 `Interfaces/` — [🔗 Link Docs](https://your-link-here.com) *(Core Interfaces: IRepository, IUnitOfWork)*
  * 📄 `AggregateRoot.cs` *(Base class Aggregate Root)*
  * 📄 `Entity.cs` *(Base class Entity)*
  * 📄 `ValueObject.cs` *(Base class Value Object)*

* 🟢 **`LabDesk.SeedWork.Infrastructure/`** — [🔗 Xem Docs Infrastructure](https://your-link-here.com)
  * 📁 `Persistence/` — [🔗 Link Docs](https://your-link-here.com)
    * 📄 `BaseDbContext.cs` *(EF Core DbContext)*
    * 📄 `DispatchDomainEventsInterceptor.cs` *(Interceptor bắn Domain Events)*
