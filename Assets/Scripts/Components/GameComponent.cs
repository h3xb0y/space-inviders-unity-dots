using Unity.Entities;

namespace Components
{
    public struct GameComponent : IComponentData
    {
        private State _prePauseState;
        private bool _isPaused;

        public bool IsPaused
        {
            get => _isPaused;
            set
            {
                if (value == _isPaused || State == State.Menu || State == State.Dead)
                    return;

                _isPaused = value;
                State = _isPaused ? State.Paused : State.Play;
            }
        }

        public Entity Enemy;
        public int CurrentEnemies;
        public State State;
    }

    public enum State
    {
        Menu,
        Play,
        Dead,
        Paused
    }
}