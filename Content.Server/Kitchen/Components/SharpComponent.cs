// SPDX-FileCopyrightText: 2022 Leon Friedrich
// SPDX-FileCopyrightText: 2022 mirrorcult
// SPDX-FileCopyrightText: 2023 DrSmugleaf
// SPDX-FileCopyrightText: 2024 gluesniffler
// SPDX-FileCopyrightText: 2025 Winkarst-cpu
// SPDX-FileCopyrightText: 2025 sleepyyapril
// SPDX-FileCopyrightText: 2026 Asa
//
// SPDX-License-Identifier: AGPL-3.0-or-later AND MIT

namespace Content.Server.Kitchen.Components;

/// <summary>
///     Applies to items that are capable of butchering entities, or
///     are otherwise sharp for some purpose.
/// </summary>
[RegisterComponent]
public sealed partial class SharpComponent : Component
{
    // TODO just make this a tool type.
    public HashSet<EntityUid> Butchering = new();

    [DataField("butcherDelayModifier")]
    public float ButcherDelayModifier = 1.0f;

    
    /// <summary>
    ///     Shitmed: Whether this item had <c>ScalpelComponent</c> before sharp was added.
    /// </summary>
    [DataField]
    public bool HadScalpel;

    /// <summary>
    ///     Shitmed: Whether this item had <c>BoneSawComponent</c> before sharp was added.
    /// </summary>
    [DataField]
    public bool HadBoneSaw;
}
