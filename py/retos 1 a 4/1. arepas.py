#Arepas
preciounidad = 3500 
cantidad = int(input("Que cantidad deseas llevar?: "))
if cantidad < 0 :
    print("no se puede ingresar un numero negativo")
if  cantidad == 0 : 
    print("no se puede ingreasar 0")
else: 
    print("el dinero total que deber pagar es: ",(preciounidad * cantidad))