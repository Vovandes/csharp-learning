# C# Zero

Курс C# с нуля по программе из `cs-zero-02-program.md`. 15 модулей.

## Структура

```
cs-zero/
  module-01-start/
    lesson-01-hello/        проект урока (свой .csproj)
    project-calculator/     мини-проект модуля
  module-02-data/
  ...
```

## Как это устроено в C#

- `.csproj` это файл одного проекта. Один проект собирается в один `.exe` или `.dll`. Аналог CMakeLists для одной цели.
- В папке проекта лежат `.cs` файлы с кодом. Файл `Program.cs` это точка входа.
- `.sln` (solution) группирует несколько проектов, чтобы открыть их в Visual Studio разом. Пока у нас каждый урок это отдельный проект, solution добавим позже, когда проектов станет много.
- Папки `bin/` и `obj/` создаются при сборке, в git не попадают (есть в `.gitignore`).

## Запуск

```
cd cs-zero/module-01-start/lesson-01-hello
dotnet run
```

Или открыть `.csproj` в Visual Studio и нажать Ctrl+F5.

## Правила именования

- Папки: `module-NN-name`, `lesson-NN-name`, `project-name` (строчными, через дефис).
- Проекты и классы: PascalCase.
