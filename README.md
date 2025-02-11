# DI_Gestion Comercial
 Práctica basada en el supuesto de una aplicación para una tienda de música.

 ### Gestión del SQL
 Se han creado tablas nuevas para ayudar a la organización del proyecto y el manejo de datos. Inicialmente se dieron éstas tablas en el enunciado:
 1. Cliente
 2. Factura
 3. Detalle
 4. Producto
 5. Proveedor

Posteriormente se agregaron las tablas:
1. Autores
2. Géneros

Y a la tabla producto se le agregaron los campos "Fecha", "Formato", "Autor" y "Género", que referencian a las tablas extras que hemos hecho para tener un listado más claro del stock de la tienda.

Se ha creado un archivo .sql para poder importar la estructura de la base de datos en un ordenador externo.

### Consideraciones de la base de datos
>[!CAUTION]
>Para poder generar un producto es importante crear primero el autor, proveedor y género en la base de datos. 

