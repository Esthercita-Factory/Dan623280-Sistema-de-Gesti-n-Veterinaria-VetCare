import random

zona = random.choice(["A", "B", "C"])
umbral = 7

print(f"Monitoreo de 6 horas en la zona {zona}")

horas_con_trancon = 0

#Para monitorearse las 6 horas completas, se debia hacer el rango (1-7), cuando antes estaba (1-6) y por eso corria mal
for hora in range(1, 7):
    intensidad = random.randint(1, 10)
    print(f"Hora {hora}: intensidad {intensidad}")

    #para que la intensidad sea igual al umbral se debia colocar el signo "==", el error estaba aqui (if intensidad > umbral:)
    if intensidad == umbral:
        horas_con_trancon += 1
        print("   -> Trancón")

    if horas_con_trancon >= 3:
        print("¡Día crítico de movilidad!")

    else:
        print(f"Por ahora: {horas_con_trancon} hora(s) con trancón")