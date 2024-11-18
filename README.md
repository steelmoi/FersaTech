# FersaTech

FersaTech, es una solución creado en Visual Studio 2022, el cual contiene un Web Api y un We Site.

* FersaTech.Domain

Proyecto  Class Library, contiene todo el modelado de Datos 

* FersaTech.Services

Proyecto  Class Library, contiene los servicios de las funcionalidades tales como, manipulación de datos en SQL, procesamienro de archivos de excel

* FersaTech.Server

Proyecto Web API, usando net core 6

* FersaTech.client

Proyecto Web que expone la funcionalidad requerida usando Angular

# Requisitos

* npm https://www.npmjs.com/package/npm
* Angular CLI https://angular.dev/tools/cli

## Usage

Web API

1.- Crear la base de datos usando el script ubicada en:
 ./FersaTech/SQL/FersaTech.sql
2.- Ingresar al directorio ./FersaTech/FersaTech.Server
3.- abrir el archivo appsettings.json y modificar la cadena de conexión a SQL

```json
"ConnectionStrings": {
    "DefaultConnection": "Data Source=DESKTOP-GG4EKVH\\SQLEXPRESS;Initial Catalog=FersaTesh;Integrated Security=SSPI;"
  }
```
4.- Modificar los archivos de la siguiente carpeta FersaTech\fersatech.client\src\environments actualizando la url del api en caso de ser diferente
```bash
export const environment = {
  URL_API: 'https://localhost:7202/'
};
```
5.- ejecutar el sigiente comando


```bash
dotnet run
```

Building...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7202
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5092
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Others\azure\FersaTech\FersaTech.Server\

5.- Abrir en el navegador

https://localhost:7202/swagger

para el web
https://localhost:4200


# Ejecutar solo el cliente

1.- Ingresara a ./FersaTech/FersaTech.client
2.- Modificar los archivos de la siguiente carpeta FersaTech\fersatech.client\src\environments actualizando la url del api en caso de ser diferente
```bash
export const environment = {
  URL_API: 'https://localhost:7202/'
};
```
3.- ejecutar el sigiente comando

```bash
ng serve --ssl --ssl-cert "%APPDATA%\ASP.NET\https\%npm_package_name%.pem" --ssl-key "%APPDATA%\ASP.NET\https\%npm_package_name%.key" --host=127.0.0.1
```