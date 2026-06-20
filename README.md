# Catálogo de Artículos

Aplicación de escritorio desarrollada en **C# / Windows Forms (.NET Framework 4.8)** que permite gestionar un catálogo de productos con sus marcas y categorías, conectada a una base de datos SQL Server Express.

## Características

- **CRUD completo de artículos**: agregar, modificar y eliminar productos con código, nombre, descripción, precio e imagen.
- **Gestión de marcas y categorías**: altas y bajas desde formularios dedicados, con validación de duplicados.
- **Filtro rápido**: búsqueda en tiempo real por marca o categoría (mínimo 3 caracteres).
- **Filtro avanzado**: filtrado por Código, Nombre, Descripción o Precio con criterios (comienza con, termina con, contiene, mayor/menor/igual a).
- **Vista de imágenes**: previsualización del artículo seleccionado con soporte para rutas locales y URLs externas.

## Arquitectura

El proyecto sigue una arquitectura en tres capas separadas en proyectos distintos dentro de la misma solución:

```
catalogo.sln
├── Dominio/          # Entidades: Articulo, Marca, Categoria
├── Datos/            # Acceso a datos con ADO.NET (AccesoDatos.cs)
├── Negocio/          # Lógica de negocio: ArticuloNegocio, MarcaNegocio, CategoriaNegocio
└── formularios/      # Capa de presentación (Windows Forms)
    ├── FrmCatalogo          # Pantalla principal con listado y filtros
    ├── FrmNuevoArticulo     # Alta y modificación de artículos
    ├── FrmNuevaCategoria    # ABM de categorías
    └── FrmNuevaMarca        # ABM de marcas
```

## Requisitos previos

- Windows con **.NET Framework 4.8** instalado
- **SQL Server Express** corriendo en la instancia local `.\SQLEXPRESS`
- Visual Studio 2019 o superior (para compilar desde el código fuente)

## Configuración de la base de datos

1. Abrir SQL Server Management Studio y conectarse a `.\SQLEXPRESS`.
2. Crear la base de datos `CATALOGO_DB`.
3. Ejecutar el script de creación de tablas (disponible en el directorio `scriptCatalogo/` del proyecto).

Las tablas esperadas son:

| Tabla       | Columnas principales                                                     |
|-------------|--------------------------------------------------------------------------|
| `ARTICULOS` | Id, Codigo, Nombre, Descripcion, Precio, ImagenUrl, IdMarca, IdCategoria |
| `MARCAS`    | Id, Descripcion                                                          |
| `CATEGORIAS`| Id, Descripcion                                                          |

La cadena de conexión está definida en `Datos/AccesoDatos.cs`:

```csharp
"server=.\SQLEXPRESS; database=CATALOGO_DB; integrated security=true"
```

Usa autenticación de Windows (Integrated Security), por lo que no se requiere usuario ni contraseña.

## Compilación y ejecución

1. Clonar el repositorio.
2. Abrir `catalogo.sln` en Visual Studio.
3. Asegurarse de que la base de datos esté creada y accesible.
4. Compilar la solución (`Ctrl+Shift+B`).
5. Establecer `formularios` como proyecto de inicio y ejecutar (`F5`).

## Uso

### Pantalla principal (FrmCatalogo)
- La grilla muestra todos los artículos al iniciar.
- Seleccionar una fila carga la imagen y los datos del artículo en el panel lateral.
- **Agregar**: abre el formulario de nuevo artículo.
- **Modificar**: abre el formulario con los datos del artículo seleccionado precargados.
- **Eliminar**: solicita confirmación antes de borrar.
- **Filtro rápido**: escribir al menos 3 caracteres para filtrar por marca o categoría.
- **Filtro avanzado**: seleccionar campo y criterio, luego hacer clic en "Filtrar".

### Gestión de marcas y categorías
- Los botones "Agregar Marca" y "Agregar Categoría" abren formularios donde se puede ver el listado actual, agregar nuevas entradas o eliminar existentes.
- No se permiten nombres duplicados ni valores que contengan números.

## Licencia

MIT — ver [LICENSE](LICENSE).
