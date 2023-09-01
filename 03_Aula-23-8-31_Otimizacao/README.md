# nomes:
- Jonathan Bergson
- Rafael Madureira

1. [x] Prefab "Ball" estava com 5 slots de materiais associados
2. [x] No Script Cannon.cs está criando novo máteriais no method SwapMaterial, poderia existir um array com todos os materiais ja criados
3. [x] No Script Cannon.cs no method SwapMaterial, está criando um array de materias mas só utiliza um material
4. [x] No Script Cube.cs o método Update() pode ser substituido por FixedUpdate() para fazer a comparação de vida do objeto
5. [x] Script Cube.cs está dando um GetComponent<ProjetilCannon>() enquanto poderia usar uma tag para comparar se é o objeto correto
6. Script ProjetilCannon.cs está destruindo os objetos enquanto poderia criar um pool para reaproveitar


3. Clipping Planes -> Far está no valor default da Unity de 1000