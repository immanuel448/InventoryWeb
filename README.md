# InventoryWeb

Cliente web desarrollado con **Blazor WebAssembly** para consumir y administrar los productos de una API REST.

## Tecnologías

* C#
* .NET 8
* Blazor WebAssembly
* Bootstrap
* HTTP / REST API

## Funcionalidades

* Listar productos
* Crear productos
* Editar productos
* Eliminar productos
* Validación de formularios
* Manejo básico de errores
* Estados de carga
* Confirmación antes de eliminar
* Navegación entre páginas

## Integración con la API

La aplicación consume una API REST mediante `HttpClient`.

```text
InventoryWeb
     ↓
 HTTP
     ↓
InventoryApi
```

La aplicación web no se conecta directamente a SQL Server.

## Estructura principal

```text
InventoryWeb
│
├── Models
│   ├── ProductDto.cs
│   ├── CreateProductDto.cs
│   └── UpdateProductDto.cs
│
├── Pages
│   ├── Products.razor
│   ├── CreateProduct.razor
│   └── EditProduct.razor
│
├── Services
│   └── ProductApiService.cs
│
└── Layout
    └── NavMenu.razor
```

## Ejecución

1. Tener instalado el **.NET 8 SDK**.
2. Ejecutar primero la API `InventoryApi`.
3. Ejecutar después el proyecto `InventoryWeb`.
4. Abrir la aplicación en el navegador.

La URL de la API debe estar configurada en `Program.cs`:

```csharp
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7242")
});
```

## Objetivo

Proyecto práctico desarrollado para demostrar el consumo de una API REST desde una aplicación **Blazor WebAssembly**, implementando las operaciones básicas de gestión de productos mediante un CRUD.
