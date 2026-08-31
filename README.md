# CARROM ARENA — Digital Mobile Board Game Platform

Carrom Arena is an original digital implementation of the traditional carrom board game, featuring realistic circle collision physics, baseline striker aiming, Queen cover validation, AI bot opponents, pass-and-play multiplayer, and distributed backend services.

---

## 🎯 Architecture Overview

```
CarromArena/
├── UnityClient/            # Unity C# Client Architecture
│   └── Assets/Scripts/     # Board, Physics, Coins, Striker, Input, Turns, Rules, Scoring, AI, UI, Audio
├── Backend/                # Python FastAPI Distributed Backend Services
│   ├── app/                # API Endpoints, Models, Repositories, Analytics, NVIDIA Gateway
│   └── tests/              # Pytest automated test matrix (180 tests)
├── Infrastructure/         # Docker Compose, PostgreSQL configurations
├── docs/                   # Architecture, Game Design, Rules Engine, API & Deployment Specifications
├── scripts/                # Standalone demo runner & diagnostic probes
└── index.html              # Standalone Playable Web Edition
```

---

## 🚀 Quick Start

### 1. Run the Standalone Game Probe
```bash
python scripts/demo_run.py
```

### 2. Play the Carrom Board Game
Open `index.html` directly in your browser or serve with:
```bash
python -m http.server 8000
```

### 3. Run Backend Test Matrix
```bash
pytest Backend/tests/ -v
```
