
temperatura = int(input("Ingresa la temperatura de Barranquilla solo en numero entero: "))

if temperatura < 10 : 
    print("Raro, en Barranquilla no hace frio")
elif temperatura < 30 :
    print("Fresco para ser Barranquilla")
elif 30 <= temperatura <= 34 :
    print("Calor normal, lleve agua")
elif 35 <= temperatura <= 49  : 
    print("Nevera obligatoria")
elif temperatura >= 50 : 
    print("temperatuara extrema")
else: 
    print("error")
