﻿using Content.Shared.Actions;
using Content.Shared.Chat;
using Robust.Shared.Prototypes;

namespace Content.Shared.Magic.Events;

public sealed partial class InstantSpawnSpellEvent : InstantActionEvent, ISpeakSpell
{
    /// <summary>
    /// What entity should be spawned.
    /// </summary>
    [DataField(required: true)]
    public EntProtoId Prototype;

    [DataField]
    public bool PreventCollideWithCaster = true;

    [DataField]
    public string? Speech { get; private set; }

    public InGameICChatType ChatType { get; } = InGameICChatType.Speak;

    /// <summary>
    /// Gets the targeted spawn positons; may lead to multiple entities being spawned.
    /// </summary>
    [DataField]
    public MagicInstantSpawnData PosData = new TargetCasterPos();
}
