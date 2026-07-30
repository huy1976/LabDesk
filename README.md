# 🚀 LabDesk - Architecture & Folder Structure

Tài liệu hướng dẫn cấu trúc dự án và chức năng các thư mục trong solution **LabDesk**. Dự án được thiết kế theo kiến trúc **Clean Architecture / Domain-Driven Design (DDD)**.

---

## 📐 Sơ đồ kiến trúc (Architecture Diagram)

```mermaid
graph TD
    subgraph LabDesk Solution
        App[LabDesk.SeedWork.Application]
        Dom[LabDesk.SeedWork.Domain]
        Infra[LabDesk.SeedWork.Infrastructure]
        
        App -->|Sử dụng / Phụ thuộc| Dom
        Infra -->|Triển khai / Implement| Dom
    end

    subgraph Infrastructure Detail [LabDesk.SeedWork.Infrastructure.Persistence]
        BaseDB[BaseDbContext.cs]
        Interceptor[DispatchDomainEventsInterceptor.cs]
        
        BaseDB .->|Implement| IUnitOfWork[IUnitOfWork]
        Interceptor .->|Bắt sự kiện trước khi Save| BaseDB
    end
