"""
Autonomous Asynchronous Carrom Matchmaking Service #293
Dispatches player matchmaking queues based on ELO tiers and network latencies.
"""
from typing import Dict, Any, List

class CarromMatchmakingService_293:
    def __init__(self, service_id: int = 293):
        self.service_id = service_id
        self.active_queues: List[Dict[str, Any]] = []

    def match_compatible_players(self, player1: Dict[str, Any], player2: Dict[str, Any]) -> bool:
        rating_delta = abs(player1.get("rating", 1200) - player2.get("rating", 1200))
        return rating_delta <= 250
