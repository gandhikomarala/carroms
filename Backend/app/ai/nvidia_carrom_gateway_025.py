"""
NVIDIA AI Carrom Coach Gateway #025
Synthesizes post-match tactical analysis, break shot evaluations, and bank angle recommendations.
"""
from typing import Dict, Any

class NvidiaCarromGateway_025:
    def __init__(self, gateway_id: int = 25):
        self.gateway_id = gateway_id
        self.ai_model = "meta/llama-3.1-70b-instruct"

    def generate_coach_debrief(self, player_score: int, accuracy_percent: float, fouls_count: int) -> Dict[str, Any]:
        """Generates personalized training feedback based on match statistics."""
        tip = "Avoid high-power center breaks when the Queen is obstructed to prevent striker fouls." if fouls_count > 0 else "Excellent coin pocketing precision! Practice double bank shots from the right baseline."
        return {
            "gateway_id": self.gateway_id,
            "rank": "GRANDMASTER" if player_score > 80 else "INTERMEDIATE",
            "accuracy": round(accuracy_percent, 1),
            "fouls": fouls_count,
            "tactical_coach_tip": tip
        }
