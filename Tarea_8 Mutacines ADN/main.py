import pandas as pd

def leer_secuencia_txt(ruta_txt):
    with open(ruta_txt, 'r') as archivo:
        secuencia = archivo.read().strip().upper()
    return secuencia

def cargar_mutaciones_excel(ruta_excel):
    df = pd.read_excel(ruta_excel)
    # Asegurarse de que las columnas estén bien nombradas
    if 'Mutacion' not in df.columns or 'Enfermedad' not in df.columns:
        raise ValueError("El archivo Excel debe tener columnas llamadas 'Mutacion' y 'Enfermedad'")
    return df

def buscar_mutaciones(secuesncia_adn, df_mutaciones):
    mutaciones_encontradas = []

    for _, fila in df_mutaciones.iterrows():
        mutacion = fila['Mutacion'].upper()
        enfermedad = fila['Enfermedad']
        if mutacion in secuesncia_adn:
            mutaciones_encontradas.append((mutacion, enfermedad))
    
    return mutaciones_encontradas

def main():
    ruta_txt = "secuencia.txt"
    ruta_excel = "mutaciones.xlsx"

    try:
        print("INICIANDO LECTURA DE ARCHIVOS DE MUTACIONES Y ENFEREMDADES")
        secuencia = leer_secuencia_txt(ruta_txt)
        df_mutaciones = cargar_mutaciones_excel(ruta_excel)
        resultados = buscar_mutaciones(secuencia, df_mutaciones)

        if resultados:
            print("\nMutaciones encontradas en la secuencia:\n")
            for mutacion, enfermedad in resultados:
                print(f"-> Mutación: {mutacion} - Enfermedad: {enfermedad}")
        else:
            print("\nNo se encontraron mutaciones registradas en la secuencia.")
    except Exception as e:
        print(f"\nError: {e}")

if __name__ == "__main__":
    main()
