Полный проект и его описание можно скачать с ulearn.me (Основы программирования на примере C#. Часть 1)

В этом проекте проектировали манипулятор

В первой задаче в классе AnglesToCoordinatesTask вычисляли координаты соответствующих суставов, по величине углов shoulder, elbow и wrist. Были написаны модульные тесты
Во второй задаче в файле VisualizerTask.cs дорабатывали визуализацию. Реализовывали методы: KeyDown, MouseMove, MouseWheel, UpdateManipulator, DrawManipulator
В классе TriangleTask.cs решали вспомоготельную задачу. Реализовывали метод GetABAngle, он должен был возвращать угол в радианах между сторонами a и b в треугольнике со сторонами, a, b, c.
В классе ManipulatorTask реализовавали метод MoveManipulatorTo. Он должен возвращать массив углов new[] {shoulder, elbow, wrist}, необходимых для приведения эффектора манипулятора в точку (x, y) относительно крепления манипулятора к столу, и с углом между последним суставом и горизонталью равному alpha в радианах
