
import random

# --- Esto funciona bien: NO lo modifiques ---
zonas = ["A", "B", "C"]
umbrales = [7, 8, 6]              # umbral de cada zona (mismo índice)
intensidad = random.randint(1, 10)
zona = random.choice(zonas)
hora_pico = random.choice([True, False])
    # --------------------------------------------

print(f"Intensidad: {intensidad} | Zona: {zona} | Hora pico: {hora_pico}")

posicion = zonas.index(zona)
umbral_zona = umbrales[posicion]

    # La zona A es la más crítica: su umbral efectivo debe BAJAR en 1.
if zona == "A":
        umbral_zona = umbral_zona + 1

    # Reglas:
    #  - "Alta probabilidad": la intensidad alcanza o supera el umbral Y es hora pico.
    #  - "Posible trancón": alcanza el umbral pero NO es hora pico.
    #  - "Vías despejadas": en cualquier otro caso.
if intensidad < umbral_zona and hora_pico:
        print("Alta probabilidad de trancón")
elif intensidad >= umbral_zona or hora_pico == False:
        print("Posible trancón, salga con tiempo")
else:
        print("Vías despejadas")



#EL FALLO ERA DE IDENTACION, EL CODIGO ESTA MAL IDENTADO