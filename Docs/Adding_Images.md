
```markdown
# How to Use Images in .bub Files

This guide assumes your Addressable keys are already set up.
If not, see [Adding CGs for a New Character](Adding_CGs.md) first.

---

## Basic Image Bubble

Displays an image in the chat without saving it to the gallery.

```
>> media npc type:image path:Luxanna/CG1
```

---

## Unlockable Image (Saves to Gallery)

Displays the image and permanently unlocks it in the player's gallery.

```
>> media npc type:image unlock:true path:Luxanna/CG1
```

> `unlock:true` must come before `path:`. Use this for story CGs you want the player to keep.

---

## Placement Rules

Place `>> media` on its own line. It goes between dialogue lines like any other message.

```
Luxanna: "check this out 😊"

>> media npc type:image unlock:true path:Luxanna/CG1

Luxanna: "cute right?"
```

---

## Inside a Choice Option

Media can appear inside a choice option as a pre-jump message. Must be at indent 2, before `<<jump>>`.

```
>> choice
    -> "Send her something back"
        >> media npc type:image path:Luxanna/CG2
        <<jump Node_Reply>>
>> endchoice
```

---

## Rules

- `path:` must always come last
- `unlock:true` must come before `path:` if used
- Keys are case-sensitive — `Luxanna/CG1` is not the same as `luxanna/cg1`
- No file extension — `path:Luxanna/CG1` not `path:Luxanna/CG1.png`
- Cannot appear inside `>> choice` at indent 0 — must be inside a choice option at indent 2

---

## Common Mistakes

**Image doesn't appear**
The `path:` key doesn't match the address in the Addressables Groups window exactly. Check spelling and case.

**CG doesn't show in gallery**
Missing `unlock:true` in the media command, or the key isn't added to `cgAddressableKeys` on the `ConversationAsset`.

**`InvalidKeyException` in Console**
Addressables build is outdated. Run **Build → Update a Previous Build** in the Addressables Groups window.
```

---

With this added, all four files are complete and all links in the Quick Start table resolve correctly:

| File | Status |
|---|---|
| `QuickStart.md` | ✓ |
| `Addressable_Setup.md` | ✓ |
| `Adding_CGs.md` | ✓ |
| `Adding_Images.md` | ✓ now |