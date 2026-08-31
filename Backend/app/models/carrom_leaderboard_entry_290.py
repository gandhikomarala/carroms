"""
Carrom Arena Match Ranking Entity #290
Represents tournament rating shards, Queen cover stats, and ELO leaderboards.
"""
from typing import Dict, Any
from datetime import datetime

class CarromLeaderboardEntry_290:
    def __init__(self, entry_id: int = 290):
        self.entry_id = entry_id
        self.recorded_at = datetime.utcnow()

    def serialize_player_rank(self, player_id: int, rating: int, wins: int, queens_secured: int) -> Dict[str, Any]:
        return {
            "entry_id": self.entry_id,
            "player_id": player_id,
            "elo_rating": rating,
            "wins": wins,
            "queens_secured": queens_secured,
            "tier": "GRANDMASTER" if rating > 2200 else "CHALLENGER",
            "timestamp": self.recorded_at.isoformat()
        }
