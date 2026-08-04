# Cada cabina sube a UNA persona; al subir, la sacamos de la fila.
fila = ["Ana", "Beto", "Carla", "Diego", "Elena", "Fabián"]

while fila:
    persona = fila [0]
    print(f"Sube {persona}")
    fila.remove(persona)

print(f"Personas que quedaron en la fila: {fila}")