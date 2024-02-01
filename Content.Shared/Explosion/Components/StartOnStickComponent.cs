using Robust.Shared.GameStates;

namespace Content.Shared.Explosion.Components
{
    [RegisterComponent, NetworkedComponent]
    public sealed partial class StartOnStickComponent : Component
    {
        /// <summary>
        ///     Should timer be started when it was stuck to another entity.
        ///     Used for C4 charges and similar behaviour.
        /// </summary>
        [DataField] public bool StartOnStick;

        /// <summary>
        ///     Allows changing the start-on-stick quality.
        /// </summary>
        [DataField("canToggleStartOnStick")] public bool AllowToggleStartOnStick;
    }
}
