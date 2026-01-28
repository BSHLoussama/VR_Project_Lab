# VR Laboratory & Neurorehabilitation Project

![VR Project](https://img.shields.io/badge/Unity-VR-blue?style=flat-square)
![Contributors](https://img.shields.io/badge/Contributors-2-brightgreen?style=flat-square)
![Status](https://img.shields.io/badge/Status-Active-success?style=flat-square)

## 📋 Overview

A comprehensive **Virtual Reality (VR) project** built with **Unity**, combining educational laboratory environments, neurorehabilitation frameworks, and interactive 3D assets. This project leverages advanced VR technologies to create immersive experiences for scientific education and therapeutic applications.

### 🎯 Key Features

- **3D Laboratory Environment** - Fully detailed laboratory setting with apparatus and equipment
- **DNA Visualization** - Interactive 3D DNA model for educational purposes
- **Microscope Simulation** - Realistic microscope interaction and visualization
- **Neurorehabilitation Framework** - Therapeutic VR environment for rehabilitation exercises
- **Dynamic UI Elements** - Floating text and dynamic visual feedback systems
- **Oculus Integration** - Full VR controller support and headset compatibility
- **Character System** - Configurable character models for user representation
- **Audio Support** - Background audio and sound effects integration

## 📁 Project Structure

### Assets Overview

```
Assets/
├── 3D Laboratory Environment with Apparatus/    # Primary laboratory scene with equipment
├── Character/                                    # Character models and rigs
├── DNA/                                         # DNA visualization models (3D models: DNA.fbx)
├── Dynamic Floating Text/                       # UI text rendering system
├── Free Furniture Set/                          # Furniture assets for environment decoration
├── FreeLabAssets/                              # Laboratory equipment and materials
├── JustPlay/                                    # Gameplay mechanics and controllers
├── Materials/                                   # Shader materials and visual effects
├── Models/                                      # 3D model assets
│   └── Microscope.fbx                          # Detailed microscope model
│   └── sequenceur.fbx                          # DNA sequencer model
├── Neurorehab/                                 # Neurorehabilitation therapy modules
├── Oculus/                                     # Oculus VR SDK and integration
├── Resources/                                  # Runtime-loaded resources
├── Scenes/                                     # Unity scenes
│   └── Kbh_skel.unity                         # Main laboratory scene
├── StreamingAssets/                            # Audio and data files
│   └── lounge-bar-233471.mp3                  # Background audio
├── TextMesh Pro/                               # Text rendering engine
└── Unity Technologies/                         # Official Unity packages
```

### Core Scripts

| Script | Purpose |
|--------|---------|
| `Camera Move.cs` | Camera control and movement mechanics |
| `move.cs` | Player/object movement and locomotion |
| `dna.cs` | DNA model interactions and visualization |
| `mizan.cs` | Balancing/measurement system for neurorehab |
| `InputSystem_Actions.inputactions` | VR input configuration and controls |

### 3D Models & Assets

- **DNA.fbx** - 3D DNA double helix model
- **Microscope.fbx** - High-detail microscope for interactive examination
- **sequenceur.fbx** - DNA sequencing apparatus
- **Weight.asset** - Physics weight configuration asset

## 🛠️ Technical Stack

- **Engine**: Unity (C#)
- **VR Platform**: Oculus/Meta Quest
- **Input System**: Unity's New Input System
- **UI Framework**: TextMesh Pro
- **Graphics**: Built-in Render Pipeline
- **Physics**: Unity Physics Engine

## 🎮 Getting Started

### Prerequisites

- **Unity** 2020 LTS or later (recommended 2022 LTS)
- **Oculus SDK** integrated with your Unity installation
- **Visual Studio** or Rider for C# development
- **VR Headset** (Oculus Quest 2/3 or compatible device) for testing

### Installation

1. **Clone the Repository**
   ```bash
   git clone <repository-url>
   cd "My project (1)"
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Click "Open" and navigate to the project directory
   - Wait for Unity to import all assets (this may take several minutes on first load)

3. **Configure VR Settings**
   - Go to **Edit > Project Settings > XR Plug-in Management**
   - Ensure **Oculus** plugin is enabled
   - Configure your VR device settings

4. **Load the Main Scene**
   - Open `Assets/Scenes/Kbh_skel.unity`
   - Press **Play** (Ctrl+P) to run in editor

### Building for VR

1. **Switch to Android/Standalone Platform**
   - File > Build Settings
   - Select your target platform (Android for Quest, PC for Rift)
   - Click "Switch Platform"

2. **Configure Build Settings**
   - Product Name: "VR Laboratory"
   - Company Name: "Your Organization"
   - Ensure XR Plugin (Oculus) is enabled

3. **Build & Deploy**
   - Click "Build" to generate APK or executable
   - For Oculus Quest: Enable Developer Mode and deploy via ADB

## 📖 Usage Guide

### Camera & Navigation
- Use **WASD** or analogue stick for movement
- Look around using **mouse/VR controllers**
- **Interact** with objects using designated buttons

### Interactive Elements
- **DNA Model** - Rotate and zoom to examine structure
- **Microscope** - Focus and adjust magnification
- **Laboratory Equipment** - Follow on-screen prompts for operation

### Audio & Ambiance
- Background music plays automatically (lounge-bar-233471.mp3)
- Adjustable volume through settings menu

## 🤝 Contributors

| Name | Role |
|------|------|
| **Oussama BOUSSAHLA** | Lead Developer & VR Integration |
| **Souhil MOKEDDEM** | Development & 3D Asset Design |

## 📝 License

This project is proprietary and intended for educational and therapeutic use. Unauthorized distribution or modification is prohibited.

## 🔧 Development Notes

### Adding New Assets
1. Import models/textures into appropriate `Assets/` subdirectory
2. Configure import settings for VR optimization
3. Add `.meta` files (auto-generated by Unity)
4. Test in VR environment before committing

### Optimization Tips
- Use LOD (Level of Detail) for complex 3D models
- Optimize textures for mobile VR (if deploying to Quest)
- Profile performance with Oculus Performance Profiler
- Keep draw calls under 100 for optimal frame rate

### Troubleshooting

| Issue | Solution |
|-------|----------|
| Assets not loading | Regenerate Library folder (Library > Delete, reopen project) |
| VR tracking issues | Ensure Oculus service is running and headset is calibrated |
| Input not responding | Verify InputSystem_Actions are properly configured in XR settings |
| Low frame rate | Use Profiler (Window > Analysis > Profiler) to identify bottlenecks |

## 📦 Dependencies

- **Oculus Integration SDK** - VR hardware support
- **TextMesh Pro** - Advanced text rendering
- **Input System Package** - Modern input handling
- **Unity UI** - User interface framework

## 🚀 Future Enhancements

- [ ] Multiplayer support via Netcode for GameObjects
- [ ] Advanced neural simulation for enhanced rehabilitation
- [ ] Enhanced analytics dashboard
- [ ] Mobile app companion interface
- [ ] Improved haptic feedback integration

## 📞 Support & Contact

For questions, issues, or contributions, please contact:
- **Oussama BOUSSAHLA**
- **Souhil MOKEDDEM**

---

**Last Updated**: January 28, 2026  
**Project Status**: Active Development

