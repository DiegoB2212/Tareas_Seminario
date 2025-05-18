# Computacion cuantica - Qiskit

Descripción breve del proyecto: qué hace, para qué sirve y quién lo desarrolló.

## Tabla de contenidos

- [Computacion cuantica](#Computacion_Cuantica)
- [Conceptos_Clave](#Conceptos_Clave)
- [Qiskit](#Qiskit)
- [Modulos Principales](#Modulos_Principales)
- [Créditos](#créditos)
- [Licencia](#licencia)

# Computacion_Cuantica

La computación cuántica es una nueva forma de procesamiento de información que se basa en las leyes de la mecánica cuántica. A diferencia de la computación clásica, que utiliza bits con valores de 0 o 1, en la computación cuántica se utilizan qubits, que pueden estar en una superposición de ambos estados al mismo tiempo.

# Conceptos_Clave

- **[Qubit]**: Es la unidad básica de información cuántica. A diferencia del bit clásico, puede estar en una combinación de 0 y 1 al mismo tiempo gracias a la superposición. 

*Imagina un interruptor que no solo está encendido o apagado, sino también en algo intermedio.*

- **[Superposicion]**: Es la capacidad de un qubit de estar en múltiples estados a la vez. 

*Como lanzar una moneda y que esté girando en el aire: aún no sabes si es cara o cruz, pero está en ambas posibilidades.*

- **[Entrelazamiento]**: Es una conexión entre qubits que hace que el estado de uno afecte directamente al otro, sin importar la distancia. 

*Si dos monedas están entrelazadas, lanzar una y obtener cara implica automáticamente que la otra saldrá cruz, incluso si está en otro país.*

- **[Medición]**: Es el proceso de leer el valor de un qubit. Cuando se mide, colapsa a un valor clásico (0 o 1).

*Como detener la moneda en el aire y ver qué cara tiene.*

- **[Puerta cuantica]**: Son operaciones matemáticas que transforman el estado de los qubits.

*Equivalente a las compuertas lógicas (AND, OR, NOT) en computación clásica.*

# Qiskit

Qiskit es una biblioteca de código abierto desarrollada por IBM para escribir, simular y ejecutar algoritmos cuánticos en computadoras cuánticas reales o simuladores. Su nombre proviene de “Quantum Information Software Kit”.

<img src="Tarea_9 Presentacion Computacion Cuantica (Qiskit)/Img/Historia.png"/>


## Modulos_Principales

- [Qiskit Terra](#Terra)
- [Qiskit Aer](#Aer)
- [Qiskit Providers](#Providers)
- [Qiskit Visualization](#Visualization)
- [Metrica de Error](#Error)

# Terra

Es el núcleo del framework, donde se construyen y visualizan los circuitos cuánticos.

### Funciones destacadas

**- QuantumCircuit**: define un circuito cuántico.

**- QuantumCircuit.h(qubit)**: aplica una puerta Hadamard.

**- QuantumCircuit.cx(control, target)**: aplica una compuerta CNOT (entre qubits).

```python
from qiskit import QuantumCircuit

qc = QuantumCircuit(2)
qc.h(0)            # Superposición en el primer qubit
qc.cx(0, 1)        # Entrelazamiento con el segundo
qc.measure_all()   # Medición

qc.draw('mpl')
```

# Aer

Permite ejecutar circuitos en un simulador en tu propio computador.

### Funciones destacadas

**- AerSimulator**: crea un simulador.

**- execute**:  ejecuta el circuito en el simulador.

```python
from qiskit import Aer, execute

simulator = Aer.get_backend('aer_simulator')
result = execute(qc, simulator, shots=1024).result()
counts = result.get_counts()

print(counts)
```

# Providers

Permite correr circuitos en computadores cuánticos reales a través de IBM Quantum.

### Funciones destacadas

**- IBMProvider()**: conecta con tu cuenta IBM.

**- exeprovider.get_backend("nombre_backend")cute**:  selecciona un computador cuántico real.

```python
from qiskit_ibm_provider import IBMProvider

provider = IBMProvider(token="TU_TOKEN")
backend = provider.get_backend('ibmq_qasm_simulator')
job = backend.run(qc, shots=1024)
result = job.result()
print(result.get_counts())

```

# Visualization

Permite graficar los resultados y los circuitos de forma clara.

### Funciones destacadas

**- plot_histogram**: muestra los resultados de mediciones.

```python
from qiskit.visualization import plot_histogram

plot_histogram(counts)

```

# Error

En computación cuántica, los errores son comunes debido a la fragilidad de los qubits. Una métrica importante es:

### Funciones destacadas

**- Fidelity**: mide qué tan cercano está el resultado real al resultado esperado. Entre más cerca a 1, mejor.

**- Gate Error**: porcentaje de error al aplicar una puerta cuántica específica.

**- Readout Error**: probabilidad de error al medir un qubit.

```python
from qiskit.quantum_info import state_fidelity, Statevector

# Estado ideal
ideal = Statevector.from_label('00')

# Estado resultante del circuito (por ejemplo, simulado o real)
result = Statevector.from_label('00')

# Calcular la fidelidad
fidelity = state_fidelity(ideal, result)
print("Fidelity:", fidelity)

backend.configuration().gate_errors
backend.properties().readout_error(0)

```

# Proyectos

**1. Quantum Volume Benchmarking**– Para medir la capacidad de un computador cuántico.

**2. Qiskit Nature** – Simulaciones químicas y problemas de física de materiales.

**3. Qiskit Finance** – Simulación de modelos financieros, como optimización de portafolios.

**4. Qiskit Machine Learning** – Aplicaciones de aprendizaje cuántico.

**5. Quantum Education** – Uso académico en universidades y bootcamps de IBM Quantum.