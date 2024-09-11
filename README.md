# Descripción del Sistema

Este sistema de punto de venta está diseñado para gestionar las transacciones comerciales de un negocio, específicamente una tienda de productos electrónicos, como se deduce de los productos listados en la factura y las interfaces.

## ¿Qué hace el sistema?

- **Registro de Ventas**: Permite registrar las ventas de productos, calculando totales, impuestos y descuentos.
- **Gestión de Productos**: Mantiene un catálogo de productos con información detallada como código, descripción, precio y categoría.
- **Gestión de Clientes**: Almacena información de los clientes, como nombre, dirección, teléfono y historial de compras.
- **Generación de Facturas**: Emite facturas detalladas de cada venta, incluyendo los productos comprados, cantidades, precios y totales.
- **Gestión de Usuarios**: Permite crear y gestionar usuarios del sistema con diferentes niveles de acceso para realizar diversas tareas (cajeros, administradores, etc.).
- **Inventario**: (Inferido) Probablemente lleva un control del inventario de productos, actualizando las existencias cada vez que se realiza una venta.

## Componentes del Sistema

- **Interfaz de usuario**: La parte visible del sistema con la que interactúa el usuario. Incluye interfaces para gestionar productos, clientes, ventas y usuarios.
- **Base de datos**: Almacena la información de productos, clientes, ventas y usuarios en tablas organizadas.
- **Lógica de negocio**: Conjunto de reglas y cálculos que determinan el funcionamiento del sistema, como el cálculo de totales, la aplicación de descuentos y la generación de facturas.
- **Módulo de informes**: (Posible) Permite generar reportes sobre las ventas, el inventario, los clientes, etc., para realizar análisis y tomar decisiones.

<br><br>


# Pantalla de "USER LOGIN"
![UserLogin](https://github.com/AdamilAbreu/Sistema-de-Ventas-/blob/main/Imagen/User%20login.png)


Indica claramente el propósito de la pantalla: permitir el ingreso de un usuario al sistema.

## Campos de texto:
- **Nombre**: Aquí el usuario introduce su nombre de usuario.
- **Contraseña**: Este campo es para ingresar la contraseña asociada al nombre de usuario.

## Botones:
- **Login**: Al presionar este botón, el sistema verifica si la combinación de nombre de usuario y contraseña es válida en la base de datos. Si lo es, permite el acceso al sistema.
- **Salir**: Cierra la aplicación o ventana actual.
- **Crear Nuevo Usuario**: Abre una nueva pantalla o ventana donde se pueden registrar nuevos usuarios.

## Funcionamiento General del Sistema de Login

1. **El usuario ingresa sus credenciales**: Escribe su nombre de usuario y contraseña en los campos correspondientes.
2. **C# captura los datos**: Al hacer clic en el botón "Login", C# obtiene los valores de los campos de texto.
3. **C# se conecta a Oracle**: Establece una conexión con la base de datos Oracle.
4. **C# ejecuta una consulta SQL**: Envía una consulta a Oracle para buscar un usuario con las credenciales proporcionadas.
5. **Oracle devuelve los resultados**: Si se encuentra un usuario, Oracle devuelve la información correspondiente. Si no, devuelve un resultado vacío.
6. **C# procesa los resultados**:
   - **Si se encontró un usuario**: C# verifica si la contraseña almacenada en la base de datos coincide con la contraseña ingresada por el usuario. Si es así, se permite el acceso al sistema y se carga la pantalla principal.
   - **Si no se encontró un usuario**: Se muestra un mensaje de error indicando que las credenciales son incorrectas.


<br><br>

# Pantalla de "Creacion de Usuario"
![Creacion de Usuario](https://github.com/AdamilAbreu/Sistema-de-Ventas-/blob/main/Imagen/Creacion%20de%20usuarios.png)

Una vez que un usuario ha sido creado a través de esta interfaz, se desencadena una serie de acciones tanto en la aplicación como en la base de datos:

1. **Validación de Datos**: Verifica que los datos introducidos por el usuario sean correctos y cumplan con las reglas establecidas.
2. **Inserción en la Base de Datos**: Los datos del nuevo usuario se almacenan en la base de datos, creando un registro para futuras autenticaciones.
3. **Confirmación al Usuario**: Se notifica al usuario que su cuenta ha sido creada exitosamente.
4. **Retorno a la Pantalla de Login o Siguiente Paso**: El sistema redirige al usuario a la pantalla de inicio de sesión o procede al siguiente paso del proceso, dependiendo del flujo de la aplicación.

<br><br>

# Pantalla de "Sistema View"
![View Sistema](https://github.com/AdamilAbreu/Sistema-de-Ventas-/blob/main/Imagen/View%20sistema.png)

# Características Principales de Punto de Venta

- **Interfaz de Usuario Intuitiva**: La interfaz parece diseñada para ser fácil de usar, con botones claramente etiquetados y campos de entrada intuitivos.
- **Funcionalidades Básicas**: El sistema incluye las funciones esenciales de un punto de venta:
  - **Registro de Ventas**: Permite registrar la venta de productos, calculando el subtotal, impuestos, descuentos y total final.
  - **Gestión de Clientes**: Permite buscar clientes por código y probablemente almacena información básica sobre ellos.
  - **Gestión de Productos**: Aunque no se muestra en la imagen completa, se puede inferir que el sistema permite buscar productos por código y agregarlos a la factura.
  - **Facturación**: Genera facturas con los detalles de la venta, incluyendo productos, cantidades, precios y totales.
- **Cálculos Automáticos**: Realiza cálculos automáticos de subtotales, impuestos, descuentos y totales, lo que agiliza el proceso de venta.

## Elementos Identificados en la Interfaz

- **Número de Factura**: Muestra un número único asignado a cada factura.
- **Código de Cliente**: Campo para ingresar el código del cliente para buscarlo en la base de datos.
- **Botón Buscar**: Permite buscar al cliente ingresado.
- **Tabla de Productos**: Muestra los productos agregados a la factura, incluyendo código, producto, precio unitario, cantidad, descuento y precio total.
- **SubTotal, Impuesto, Descuento y Total**: Muestran los cálculos correspondientes de la venta.
- **Código de Producto y Cantidad**: Campos para ingresar el código y cantidad de un producto a agregar a la factura.
- **Botón Agregar Producto**: Agrega el producto seleccionado a la factura.
- **Botón Factura**: Probablemente imprime o muestra en pantalla la factura final.
- **Botón Cerrar**: Cierra la venta actual y reinicia el sistema para una nueva venta.

# "Estado Actual de las Ventas"
![View sistema](https://github.com/AdamilAbreu/Sistema-de-Ventas-/blob/main/Imagen/View%20sistema2.png)



- **Número de Factura**: 164. Indica que esta es la factura número 164 generada por el sistema.
- **Cliente**: ADAMIL ABREU DESC: 20. Se ha registrado un cliente con este nombre y posiblemente un descuento del 20%.
- **Productos**: Se han agregado varios productos a la venta, incluyendo bocinas, teclados gamer, laptops, mesas gamer y sillas.
- **Cantidades y Precios**: Se han especificado las cantidades de cada producto y sus respectivos precios unitarios.
- **Descuentos**: Se ha aplicado un descuento del 10% a cada producto, además del posible descuento general del cliente.
- **Subtotal e Impuesto**: El subtotal de la venta es de 5268.26. Se observa un impuesto del 10% aplicado a la venta.
- **Total**: El total a pagar, considerando el subtotal, el impuesto y los descuentos, es de 4222.608.

# Pantalla de "View Usuarios"
![View usuarios](https://github.com/AdamilAbreu/Sistema-de-Ventas-/blob/main/Imagen/View%20usuarios.png)
# Análisis de la Interfaz de Usuarios

## Funcionalidad
Esta pantalla se utiliza para administrar los usuarios del sistema. Permite:
- **Visualizar**: Mostrar una lista de los usuarios registrados, incluyendo su ID, nombre y contraseña.
- **Insertar**: Agregar nuevos usuarios al sistema.
- **Modificar**: Editar la información de un usuario existente.
- **Eliminar**: Eliminar un usuario del sistema.
- **Salir**: Cerrar la ventana de gestión de usuarios.

## Campos
Los campos "Nombre" y "Contraseña" en la parte inferior de la pantalla se utilizan para ingresar los datos de un nuevo usuario o modificar los datos de un usuario existente.

## Seguridad
Es probable que las contraseñas se almacenen en la base de datos de forma encriptada para garantizar la seguridad de los datos.


<br><br>

# Pantalla de "Inventario"
![View inventario](https://github.com/AdamilAbreu/Sistema-de-Ventas-/blob/main/Imagen/View%20inventario.png)

# Análisis de la Interfaz de Usuario

## Elementos Principales

- **Tabla de Productos**: La parte central de la interfaz muestra una tabla que contiene información detallada sobre los productos:
  - **ID de Inventario**: Un identificador único para cada producto.
  - **Producto**: El nombre o descripción del producto.
  - **Categoría**: La categoría a la que pertenece el producto.
  - **Precio**: El precio unitario del producto.

- **Campos de Búsqueda**: Los campos "Producto", "Categoría" y "Precio" en la parte superior izquierda de la tabla probablemente se utilizan para filtrar los productos que se muestran en la tabla. Al ingresar un valor en cualquiera de estos campos, la tabla se filtrará para mostrar solo los productos que coincidan con el criterio de búsqueda.

- **Botones de Acción**: Los botones "Ingresar", "Eliminar", "Modificar" y "Salir" permiten realizar las siguientes acciones:
  - **Ingresar**: Agregar un nuevo producto a la base de datos.
  - **Eliminar**: Eliminar un producto existente de la base de datos.
  - **Modificar**: Editar la información de un producto existente.
  - **Salir**: Cerrar la ventana o el sistema.

- **Campos de ID y Precio (derecha)**: Estos campos probablemente se utilizan para mostrar la información del producto seleccionado en la tabla. Al hacer clic en una fila de la tabla, los valores correspondientes de ID y precio se muestran en estos campos.
<br><br>

# Pantalla de "Clientes"
![View Clientes](https://github.com/AdamilAbreu/Sistema-de-Ventas-/blob/main/Imagen/View%20clientes.png)

# Análisis de la Interfaz de Usuarios

## Elementos Principales

- **Tabla de Clientes**: La parte central de la interfaz muestra una tabla que contiene información detallada sobre los clientes:
  - **ID_CLIENTES**: Un identificador único para cada cliente.
  - **NOMBRE_CLIENTE**: El nombre del cliente.
  - **APELLIDO_CLIENTE**: El apellido del cliente.
  - **TELEFONO_CLIENTE**: El número de teléfono del cliente.
  - **CORREO_CLIENTE**: El correo electrónico del cliente.
  - **CODIGO_CLIENTE**: Un código de cliente adicional (posiblemente utilizado para otros sistemas o identificación interna).
  - **DESCUENTO**: El descuento que se aplica a las compras de este cliente.
  - **CANTIDAD_COMPRA**: La cantidad total de compras realizadas por el cliente (o quizás la última compra).

- **Botón Salir**: Este botón permite cerrar la ventana o salir de esta sección del sistema.
<br><br>

# Pantalla de "Facturas"
![View inventario](https://github.com/AdamilAbreu/Sistema-de-Ventas-/blob/main/Imagen/View%20Factura2.png)

# Análisis de la Factura en PDF

## Elementos Claves

- **Encabezado**:
  - **PUNTO DE VENTA**: Indica claramente que este documento es una factura emitida por un punto de venta.
  - **FACTURA#**: Asigna un número único a la factura para su identificación y seguimiento. En este caso, el número de factura es 189.
  - **CLIENTE**: Muestra el nombre del cliente al que se emite la factura.

- **Cuerpo**:
  - **Productos**: Se detalla cada producto comprado, incluyendo:
    - **Código de Producto**: Un código único para identificar cada producto (por ejemplo, 83, 84, etc.).
    - **Descripción del Producto**: El nombre del producto (por ejemplo, BOCINA, TECLADO GAMER, etc.).
    - **Precio Unitario**: El precio individual de cada producto.
    - **Cantidad (Implícita)**: Aunque no se muestra explícitamente, la cantidad de cada producto se puede inferir de la repetición del código de producto y del total calculado. Por ejemplo, el producto con código 87 (MESA GAMER) aparece dos veces, lo que indica que se compraron dos unidades.

- **Totales**:
  - **SUBTOTAL**: Muestra el valor total de los productos sin incluir impuestos ni descuentos.
  - **TOTAL**: Muestra el valor total a pagar, incluyendo cualquier impuesto o descuento aplicado.
<br><br>

# "Conclusión"

El sistema de punto de venta diseñado para una tienda de productos electrónicos ofrece una solución integral para la gestión de transacciones comerciales. Con una interfaz de usuario intuitiva, facilita la realización de ventas, la administración de productos y clientes, y la generación de facturas detalladas.

### Características Clave:
- **Registro de Ventas**: Permite registrar transacciones de ventas, aplicando automáticamente cálculos de subtotales, impuestos y descuentos.
- **Gestión de Productos y Clientes**: Administra la información de productos y clientes, manteniendo un catálogo actualizado y detallado.
- **Generación de Facturas**: Emite facturas con información completa sobre las ventas realizadas.
- **Gestión de Usuarios**: Incluye funcionalidades para crear, modificar y eliminar usuarios, con diferentes niveles de acceso.

### Interfaz de Usuario y Seguridad:
- La interfaz de usuario está diseñada para ser fácil de usar, con opciones para buscar, agregar, modificar y eliminar productos y clientes.
- Las contraseñas se manejan de manera segura, almacenándolas encriptadas en la base de datos.

### Sistema de Login:
- Permite el ingreso de usuarios mediante una validación de credenciales en la base de datos, con opciones para registrar nuevos usuarios.

### Facturación y Reportes:
- El sistema genera facturas con detalles precisos de las compras, incluyendo códigos de producto, descripciones, precios y cantidades.
- Los cálculos de totales y subtotales se realizan de manera automática, simplificando el proceso de venta.
