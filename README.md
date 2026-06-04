# FlaUInspect (简体中文版)

![FlaUInspect](src/FlaUInspect/FlaUInspect.png)

> **注意**：本项目为 [FlaUI/FlaUInspect](https://github.com/FlaUI/FlaUInspect) 的简体中文本地化版本。

## 最新版本 3.0.0

新版本已发布！点击[此处](https://github.com/FlaUI/FlaUInspect/releases/tag/v3.0.0)下载。

这是一个包含大量更改的重大更新：
- 进程选择使用独立窗口
- 全新界面 (UI)
- 支持深色和浅色主题
- 实现设置功能
- 全新图标
- 全新应用选择边界
- 重新设计了：
  - 属性网格 (Property Grid)
  - 控件树
  - 菜单按钮
  - 鼠标悬停控件选择
- 提升了性能
- 修复并重新设计了选定控件的三态高亮显示

#### 新 UI 截图：

主窗口及应用选择高亮。

<img width="600" alt="Image" src="https://github.com/user-attachments/assets/f0a23f20-f994-4a17-b83b-3da6c96e337f" />

主窗口显示应用程序，并允许用户从列表中选择，或按住“查找窗口”按钮并将鼠标拖动到应用程序上。FlaUInspect 将高亮显示鼠标光标下的应用程序并在列表中选中它。

悬停模式 (Hover mode)

<img width="600" alt="Image" src="https://github.com/user-attachments/assets/53fbcd61-cd93-4f09-9962-13be900f4c95" />

选择“悬停模式”按钮，按住 Ctrl 键并将鼠标移动到应用程序窗口上。FlaUInspect 将高亮显示鼠标光标下的控件并在树中选中它。

高亮选定项 (Highlight selection)

<img width="600" alt="Image" src="https://github.com/user-attachments/assets/7e5c8767-e75f-449b-adb5-cbd55522f405" />

选择“选择模式”按钮并点击应用程序中的任何控件。FlaUInspect 将在应用程序中高亮显示选定的控件。

高亮选定项与深色主题

<img width="600" alt="Image" src="https://github.com/user-attachments/assets/7b9db566-6e3b-459d-bc49-1715a172a189" />

FlaUInspect 目前支持浅色和深色主题。

### 2.0.0

点击[此处](https://github.com/FlaUI/FlaUInspect/releases/tag/v2.0.0)下载。

这是一个包含大量更改的重大更新：

* 应用程序完全重写
* 全新 UI
* 新功能
* 更加稳定
* 基于 .NET 8
* 提供三个独立版本：UIA2、UIA3 以及在启动时选择的默认版本

### 安装

要安装 FlaUInspect，您可以自行构建，或从 GitHub 的发布页面 (https://github.com/FlaUI/FlaUInspect/releases) 获取 zip 压缩包。

### 项目说明

目前有各种工具可以帮助检查需要进行 UI 测试或自动化的应用程序。其中一些包括：

* VisualUIAVerify
* Inspect
* UISpy
* 可能还有其他

其中大多数工具都比较陈旧，有时不太稳定，而且（如果是开源的）代码维护起来很麻烦。

FlaUInspect 旨在成为一个基于 [FlaUI](https://github.com/Roemer/FlaUI) 的现代替代方案。

在 FlaUInspect 启动时，您可以选择使用 UIA2 还是 UIA3（请参阅 [FAQ](https://github.com/Roemer/FlaUI/wiki/FAQ) 了解为什么不能同时使用两者）。
如果您想使用特定版本的 UIA，可以使用预构建的 FlaUInspect.UIA2 和 FlaUInspect.UIA3 版本。

###### 主屏幕

![主屏幕](https://github.com/user-attachments/assets/6212341b-9776-4907-9edc-acc00073c92e)

##### 工具按钮

| 按钮 | 说明 |
|----------------|-----------------------------------------------------------------------------------------------------------|
| 悬停模式 | 启用此模式后，当按住 Ctrl 键时，FlaUInspect 会立即选中鼠标下方的项目 |
| 选择模式 | 在树中选中的项目将在屏幕上高亮显示 |
| 焦点跟踪 | 启用此模式后，焦点所在的元素将始终在 FlaUInspect 中被自动选中 |
| 显示 XPath | 启用此选项后，将在 FlaUInspect 的状态栏中显示当前选定元素的简单 XPath |

### 2.0.0 发行说明

* 发布了硬编码 UIA2 或 UIA3 选择的 FlaUInspect、FlaUInspect.UIA2 和 FlaUInspect.UIA3 应用程序。
* 重构了代码并实现了异步操作。
* 重新设计了属性网格；在选择另一个控件后，折叠的组将保持折叠状态。
* 增加了第三种选择状态：在高亮显示应用程序中选中的控件。
* 为树中的每个项目添加了刷新按钮。
* 优化了图标。

---

**原仓库引用链接：** [https://github.com/FlaUI/FlaUInspect](https://github.com/FlaUI/FlaUInspect)
