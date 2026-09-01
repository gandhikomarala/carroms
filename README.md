# Royal Carrom Club — 2D Rigid Body Physics Simulation

Royal Carrom Club is a production-grade 2D rigid body physics simulation of professional carrom board gameplay. It implements precision vector impulse striker mechanics, coefficient of friction & restitution collisions, queen cover validation rules, audio feedback synthesis, and offline-first client-side state synchronization.

---

## Dependencies

* **Python Engine**: Python 3.10+
* **Backend Framework**: FastAPI, Uvicorn, Pydantic v2
* **Testing Suite**: Pytest, Pytest-cov
* **Frontend HUD**: Modern HTML5 Canvas, Vanilla ES6 JavaScript, Web Audio API

---

## Installation

### 1. Clone & Set Up Python Virtual Environment
```bash
git clone git@github.com:gandhikomarala/carroms.git
cd carroms
python -m venv venv
# Activate on Windows:
.\venv\Scripts\activate
# Activate on Linux/macOS:
source venv/bin/activate
```

### 2. Install Project Dependencies
```bash
python -m pip install --upgrade pip
pip install -r requirements.txt
```

---

## Build

Build the containerized production image locally using Docker:
```bash
docker build -t royal-carrom-club:latest .
```

---

## Run

### Local Microservice Mode
```bash
python -m uvicorn Backend.main:app --host 0.0.0.0 --port 8004 --reload
```

### Containerized Deployment
```bash
docker-compose up -d --build
```

### Static Web Client
Open `index.html` directly in any modern web browser or serve via:
```bash
python -m http.server 8004
```

---

## Usage

1. Launch the interactive canvas in your browser.
2. Select game mode (*Single Player Practice, Local 2-Player, Tournament Mode*).
3. Drag the mouse on the striker to adjust impulse angle and power meter gauge.
4. Release to shoot and pocket coins according to ICF (International Carrom Federation) tournament rules.

---

## Testing

Execute the automated test suite with coverage report:
```bash
pytest tests/ -v --cov=Backend/
```
