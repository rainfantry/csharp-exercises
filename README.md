# csharp-exercises 
# [THIS README WAS WRITTEN BY AN AI MODEL - PLEASE FORGIVE THIS TRANSGRESSION]
Live document - Warmup exercises using "subsumption pruning" and "spaced repetition" training method
### File layout

| File | Purpose |
|---|---|
| `Program.cs` (or equivalent) | Scratchpad. Experimental, iterative, disposable. |
| `CHEATSHEET.cs` | Runnable reference. Every learned concept labelled and demonstrated as executable code. Rebuilt by the learner each session. |
| `EXERCISES_DAYN.cs` | The following morning's warmup. Prompts authored by the AI, answered by the learner. |
| `PLAN.md` | Architecture sketch for the underlying project the exercises are supporting. |

---

## Division of labour

### AI responsibilities
- Explain new concepts using analogies matched to the learner's existing domain knowledge.
- Design exercises based on the session's actual content, not a pre-built curriculum.
- Review learner submissions, identify errors, explain the reasoning behind corrections.
- Prune subsumed exercises from the active list.
- Maintain continuity with the overall project architecture across sessions.

### Learner responsibilities
- Write every line of code in the scratchpad, the exercises, and the cheatsheet. No generated code is copied in.
- Build the cheatsheet from understood material. Inability to articulate a concept in the cheatsheet is a signal the concept has not been internalised.
- Run warmups without AI assistance. Retrieval is the point; assistance defeats the mechanism.
- Decide when to stop, when to push, and when to un-prune. The AI advises; the learner owns the outcome.

---

## Why not standard tools

**Anki / SuperMemo** — These tools excel at flashcard-based recognition but do not train code production and cannot automatically prune prerequisite skills when they are subsumed by harder material. They are complementary, not equivalent.

**Textbooks and video courses** — Linear curricula assume a fixed pace and do not adapt to what the learner has already understood or still struggles with. They also rely on reading comprehension as the primary delivery mechanism, which is inefficient for learners who retain better through conversation and active construction.

**Code-along tutorials** — These produce completed artifacts without building transferable skill, because the learner never has to recall or reconstruct anything.

**LeetCode-style grind** — Volume without subsumption logic and without a project context. Effective for interview preparation after skills are already acquired; ineffective for initial acquisition.

---

## Limitations

- **Requires learner discipline.** The AI cannot verify that warmups are run honestly. Looking up the cheatsheet silently during a drill collapses the retrieval mechanism.
- **Requires an active project.** Exercises in a vacuum lose motivational context within one to two weeks. The exercises must serve a concrete build.
- **Pacing is variable.** Some sessions cover multiple concepts; others cover fractions of one. The system tolerates variance but requires honest self-reporting to the AI about which concepts landed.
- **Consolidation requires sleep.** Sessions run while fatigued or impaired produce weaker retention regardless of engagement. The protocol assumes reasonable rest.

---

## Current application

This repository hosts the C# learning track currently in progress. The underlying project is `WinRecon`, a Windows reconnaissance and audit tool built from scratch in C#. Each phase of the build drills a specific C# concept, with exercises and cheatsheets produced at each phase.

The tool is defensive in scope: it enumerates system state on a host the operator owns. It does not attack, modify, or compromise anything. The learning value is in the depth of Windows internals, networking, and C# standard library coverage required to build it properly.

---

## Repository contents

- `README.md` — this document
- `CHEATSHEET.cs` — current reference cheatsheet
- `EXERCISES_DAYN.cs` — current and historical exercise sets
- `WINRECON_PLAN.md` — architecture and phase plan for the underlying project
- Project source files, added as phases are completed

---

## License

MIT.

## License

MIT.
```

---
