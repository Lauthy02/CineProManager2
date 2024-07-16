# Reglas para tener en cuenta
## En el código
- El nombre de las clases van a estar escritas en mayúsculas, si es necesario más de una palabra se separa con _
	- Ejemplo: BE_USUARIO, BE_MAPPER_USUARIO
- El nombre de los atributos privados van en minúsuclas
  	- Ejemplo: nombredeusuario
- El nombre de los atributos públcios van escritos con la primer letra en mayúsucla, si es necesario mas de una palabra estas se separan con la prmier letra en mayúsucla
	- Ejemplo: NombreDeUsuario
- El nombre de los métodos van escritos con la primer letra en Mayúsucla, si es necesario mas de una palabra estas se separan con la prmier letra en mayúsucla y si es necesario que ingrese un objeto dentro del método, el nombre de este va en minúsucla
	- Ejemplo: AltaUsuario(BE_USUARIO usuario)

## En la base de datos
- El nombre de las tablas van en mayúsculas, si es necesario más de una palabra se separa con _ y en singular
	- Ejemplo: USUARIO, USUARIO_PERMISO
- El nombre de las columnas van en minúsuclas, si es necesario más de una palabra se escribe todo junto y en singular
	- Ejemplo: id, nombre, nombredeusuario
- El nombre de los parámetros van a estar escritos igual que las columnas
	- Ejemplo: @nombre
- El nombre de los procedimientos almacenados van a estar escritos en mayúsculas, si es necesario más de una palabra se separa con _ y el nombre va a estar en singular
	- Ejemplo: ALTA_USUARIO

# Para mejorar
La cartelera puede ser creada con las películas que están en una función
Levantar un nuevo idioma y con una query traer las etiquetas que ya tengo y crearlas en la tabla idioma, y en traducción poner un texto default como "falta traducir"
hacer mejor reservar más de una entrada

# Permisos
- Administrador 3
	- Cliente
	- Cliente
	- Taquillero
	- Control de acceso
	- Gerente de cine
- Cliente 1010
	- ReservarEntradas
- Taquillero 4
	- PagarEntradas	
	- EmitirEntradas
- Control de acceso 1011
	- MarcarEntradas
- Gerente de cine 1006
	- ABMUsuarios
	- ABMPeliculas
	- ABMCines
	- ABMSalas
	- ABMFunciones
	- GestionarCines

 # Usuarios
 - Administrador
 	- Nombre de usuario: Lauta
  	- Contraseña: 1234
 - Cliente
 	- Nombre de usuario: Nano
  	- Contraseña: 1234
 - Taquillero
 	- Nombre de usuario: CharLec
  	- Contraseña: 1234
- Control de acceso
 	- Nombre de usuario: Checo
  	- Contraseña: 1234
- Gerente de cine 
 	- Nombre de usuario: MaxV 
  	- Contraseña: 1234
