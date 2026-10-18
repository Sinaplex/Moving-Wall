# 🧱 Moving Wall — Unity 2D

A simple and customizable moving wall system for 2D Unity games.

یک سیستم ساده و قابل تنظیم برای ساخت دیوارها و موانع متحرک در بازی‌های دوبعدی Unity.

---

## 🇮🇷 فارسی

### 📌 معرفی

این اسکریپت به شما اجازه می‌دهد دیوارها و موانع متحرکی بسازید که به سمت یک نقطه مشخص حرکت می‌کنند، مدتی در آنجا می‌مانند و سپس به موقعیت اولیه خود برمی‌گردند.

### ✨ قابلیت‌ها

- حرکت خودکار دیوار به سمت نقطه هدف (Target)
- تعیین مدت‌زمان حرکت به مقصد و بازگشت
- تنظیم زمان مکث در مقصد و نقطه شروع
- تعیین تأخیر قبل از شروع حرکت
- مناسب برای ساخت موانع متحرک در بازی‌های دوبعدی

### 🛠️ نحوه استفاده

#### مرحله ۱: ساخت نقطه هدف (Target)

1. در پنجره `Hierarchy` یونیتی راست‌کلیک کنید.
2. گزینه `Create Empty` را انتخاب کنید تا یک GameObject خالی ساخته شود.
3. نام آن را مثلاً `WallTarget` بگذارید.
4. موقعیت این آبجکت را به نقطه‌ای تغییر دهید که می‌خواهید دیوار به آنجا حرکت کند.

#### مرحله ۲: تنظیم دیوار

1. اسکریپت `MovingWall.cs` را به GameObject دیوار خود اضافه کنید.
2. آبجکت `WallTarget` را از پنجره Hierarchy به فیلد targetPoint در Inspector بکشید.
3. مقادیر تنظیمات اسکریپت را مطابق نیاز خود تغییر دهید.
4. بازی را اجرا کنید و حرکت دیوار را بررسی کنید.

### ⚙️ توضیح تنظیمات

| متغیر | کاربرد |
|---|---|
| `startDelay = 0f` | مدت‌زمان انتظار قبل از شروع حرکت. مقدار `0` یعنی حرکت بلافاصله شروع می‌شود. |
| `moveToTargetTime = 2f` | مدت‌زمان لازم برای حرکت از نقطه شروع به سمت Target. |
| `waitAtTarget = 1f` | مدت‌زمان مکث دیوار پس از رسیدن به Target. |
| `moveBackTime = 2f` | مدت‌زمان لازم برای بازگشت دیوار به موقعیت اولیه. |
| `waitAtStart = 1f` | مدت‌زمان مکث در نقطه شروع قبل از آغاز چرخه بعدی. |

**نکته:** مقادیر زمانی بر حسب ثانیه هستند. برای مثال، مقدار `2` یعنی دو ثانیه.

### 💡 مثال با تنظیمات پیش‌فرض

با تنظیمات پیش‌فرض، دیوار:

1. بدون تأخیر شروع به حرکت می‌کند.
2. طی ۲ ثانیه به Target می‌رسد.
3. به مدت ۱ ثانیه در مقصد مکث می‌کند.
4. طی ۲ ثانیه به موقعیت اولیه بازمی‌گردد.
5. به مدت ۱ ثانیه در نقطه شروع می‌ماند.
6. سپس چرخه حرکت را دوباره تکرار می‌کند.

---

## 🇬🇧 English

### 📌 About

This script allows you to create moving walls and obstacles in 2D Unity games. The wall moves toward a target position, waits for a specified amount of time, and then returns to its starting position.

### ✨ Features

- Automatic movement toward a target GameObject
- Customizable movement and return durations
- Adjustable waiting times at the target and starting positions
- Configurable delay before movement starts
- Suitable for moving obstacles in 2D games

### 🛠️ How to Use

#### Step 1: Create a Target

1. Right-click in the Unity `Hierarchy` window.
2. Select `Create Empty` to create an empty GameObject.
3. Rename it to `WallTarget`.
4. Move it to the position where you want the wall to move.

#### Step 2: Set Up the Wall

1. Attach `MovingWall.cs` to your wall GameObject.
2. Drag `WallTarget` from the Hierarchy into the targetPoint field in the Inspector.
3. Adjust the script settings to fit your needs.
4. Run the game and test the wall movement.

### ⚙️ Script Settings

| Variable | Description |
|---|---|
| `startDelay = 0f` | The delay before the wall starts moving. `0` means it starts immediately. |
| `moveToTargetTime = 2f` | The time required for the wall to move from its starting position to the target. |
| `waitAtTarget = 1f` | How long the wall waits after reaching the target. |
| `moveBackTime = 2f` | The time required for the wall to return to its starting position. |
| `waitAtStart = 1f` | How long the wall waits at its starting position before the next movement cycle. |

**Note:** All time values are measured in seconds. For example, a value of `2` means two seconds.

### 💡 Default Behavior Example

With the default settings, the wall:

1. Starts moving immediately.
2. Reaches the target in 2 seconds.
3. Waits at the target for 1 second.
4. Returns to its starting position in 2 seconds.
5. Waits at the starting position for 1 second.
6. Repeats the movement cycle.

---

## 👨‍💻 Created by SinaPlex

🎮 Unity Game Development

- **GitHub:** https://github.com/Sinaplex
- **YouTube:** https://www.youtube.com/@Sina_Plex

Feel free to use this script in your Unity projects!
