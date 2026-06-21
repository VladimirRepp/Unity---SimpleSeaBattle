# ⚓ Simple Sea Battle (Unity)

> **Учебный проект.** Финальная итерация — перенос ядра «Морского боя» на игровой движок Unity.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 📖 О проекте

Данный проект — **очередная итерация** разработки игры «Морской бой», демонстрирующая **перенос игровой логики на Unity**.

Проект создан в обучающих целях и наглядно показывает: **ядро игры остаётся неизменным** независимо от платформы — консоль, WinForms, WPF или Unity. Меняется только способ взаимодействия с пользователем.

---

## 🎯 Цели и задачи

- ✅ Перенести существующее ядро игры «Морской бой» на игровой движок **Unity**
- ✅ Показать, что логика игры **не зависит от платформы**
- ✅ Продемонстрировать, как одно и то же ядро работает в разных окружениях
- ✅ Завершить цикл: **Консоль → WinForms → WinForms (MVP) → Unity**

---

## 🧱 Архитектура

Проект использует **то же ядро**, что и все предыдущие итерации:

| Сущность | Назначение |
|----------|------------|
| `GameMap` | Игровое поле 5×5, случайная генерация корабля, проверка клеток |
| `GameLogic` | Обработка выстрелов, проверка попадания, определение победы |
| `CellView` | Хранит координату объекта, визуализирует попадание или промах |
| `GameController` | Обработка игровой логики на игровой сцене |

**Главный принцип:**  
Ядро игры **не зависит от платформы**. Оно было написано один раз для консоли и без изменений используется в WinForms, WinForms MVP и Unity.

---

## 🔄 Эволюция проекта

| Итерация | Проект | Архитектура |
|----------|--------|-------------|
| 1 | [Console App](https://github.com/VladimirRepp/WinForms---Samples/tree/main/SimpleSeaBatlle/GameCoreSimpleSeaBattle) | Ядро игры, разделение логики и интерфейса |
| 2 | [WinForm V_0](https://github.com/VladimirRepp/WinForms---Samples/tree/main/SimpleSeaBatlle/SimpleSeaBattle%20-%20WinForm%20V0) | Быстрый перенос без паттернов |
| 3 | [WinForms MVP](https://github.com/VladimirRepp/WinForms---Samples/tree/main/SimpleSeaBatlle/SimpleSeaBattle%20-%20WinForm%20MVP) | Model-View-Presenter|
| **4** | **Unity** *(текущая версия)* | Пример переноса логики на Unity |


---

## 🎮 Правила игры

| Параметр | Описание |
|----------|----------|
| Размер поля | 5×5 клеток |
| Корабли | Один однопалубный корабль |
| Генерация | Случайная расстановка |
| Управление | Клик мышью по клетке |
| Победа | При первом попадании в корабль |

---

## 🚀 Быстрый старт

```bash
git clone https://github.com/VladimirRepp/Unity---SimpleSeaBattle.git
# Открыть проект в Unity Hub
# Запустить сцену Main в редакторе
```

## 📸 Скриншоты

Примеры работы программы доступны в папке `Img`.

---

## 🔗 Ссылки

- **Репозиторий проекта:** [Unity — SimpleSeaBattle](https://github.com/VladimirRepp/Unity---SimpleSeaBattle)
- **Исходное ядро логики:** [GameCoreSimpleSeaBattle](https://github.com/VladimirRepp/WinForms---Samples/tree/main/SimpleSeaBatlle/GameCoreSimpleSeaBattle)
- **WinForms версия (без паттернов):** [SimpleSeaBattle - WinForm V0](https://github.com/VladimirRepp/WinForms---Samples/tree/main/SimpleSeaBatlle/SimpleSeaBattle%20-%20WinForm%20V0)
- **WinForms версия (MVP):** [SimpleSeaBattle - WinForm MVP](https://github.com/VladimirRepp/WinForms---Samples/tree/main/SimpleSeaBatlle/SimpleSeaBattle%20-%20WinForm%20MVP)

---

## 📝 Лицензия

Проект распространяется под лицензией MIT. Подробнее в файле [LICENSE](LICENSE).

---

> *«Одно ядро — много интерфейсов. В этом и есть сила грамотной архитектуры.»*
