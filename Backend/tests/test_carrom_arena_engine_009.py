"""
Automated Pytest Matrix #009 for Carrom Arena
Validates shot impulse physics, Queen scoring invariants, and AI coach debriefs.
"""
import pytest
from Backend.app.repositories.carrom_match_repo_009 import CarromMatchRepository_009
from Backend.app.ai.nvidia_carrom_gateway_009 import NvidiaCarromGateway_009

def test_shot_packet_validation_009():
    repo = CarromMatchRepository_009()
    assert repo.validate_shot_packet(impulse_force=35.0, turn_duration_s=3.5) is True
    # Impossible impulse force (150 > 60.0 max)
    assert repo.validate_shot_packet(impulse_force=150.0, turn_duration_s=3.5) is False

def test_score_calculation_009():
    repo = CarromMatchRepository_009()
    # 5 White (50) + 4 Black (40) + Queen (30) = 120
    score = repo.calculate_match_score(white_coins=5, black_coins=4, queen_secured=True)
    assert score == 120

def test_nvidia_carrom_gateway_009():
    gw = NvidiaCarromGateway_009()
    debrief = gw.generate_coach_debrief(player_score=95, accuracy_percent=88.5, fouls_count=0)
    assert debrief["rank"] == "GRANDMASTER"
    assert "precision" in debrief["tactical_coach_tip"].lower()
