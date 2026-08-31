# Carrom Arena — Engineering Rules & Guidelines

## Core Principles
1. **Inspect Before Modifying**: Verify existing systems and configurations before making changes.
2. **Modular Board Physics Architecture**: Decouple Striker aiming/power controls, 2D circle-circle collision solvers, Corner pocket triggers, Turn state machine, and Backend services.
3. **Verified Results**: Never claim test results without executing automated test suites.
4. **Zero Leaked Credentials**: Never commit API keys, private keys, or credentials.
5. **No MIT License Badges**: Do not include MIT license badges or standalone LICENSE files.
6. **TrainPlex Compliance**: Maintain structured commits, active PRs with 100% green CI, and standalone demo runners.
