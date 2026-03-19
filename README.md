# Fonyn
[日本語版はこちら](./docs/ja/README-ja.md)

### ⚠ This project is in an early stage of development

Fonyn is a **general-purpose programming language**.

It aims to make programs more modular and reusable by clearly separating the concepts of:
**entities**, **state**, and **behavior**.

Fonyn is not designed for a specific domain,
and it is intended to be usable for general application development.

However, this design is **particularly well-suited for game development**,
and in the future, we plan to provide a built-in framework for game development as part of the ecosystem.

---

# Design Philosophy

Fonyn is built around the following three core concepts:

```

actor   = entity
state   = reusable data
action  = reusable behavior

````

This model enables clearer representation of program structure
by separating responsibilities into distinct, composable components.

---

# Core Concepts

Fonyn introduces the following key concepts:

| Concept | Description |
|--------|------------|
| actor | An entity that owns state and behavior |
| state | Reusable data structures |
| action | Reusable behavior that can be attached to actors |
| contract | A declaration of externally visible capabilities |
| process | External logic not bound to an actor |
| template | A blueprint for creating actors |

---

# Example

```fonyn
state Health
{
    int hp
    int maxHp
}

action Damage needs Health
{
    void takeDamage(int amount)
    {
        health.hp -= amount
    }
}

actor Player
{
    states: Health
    actions: Damage
}
````

In this example:

* `Health` represents reusable data
* `Damage` represents reusable behavior
* `Player` is an entity composed of both

---

# Project Status

Fonyn is currently in the **design and prototyping phase**.

The language specification is still evolving,
and the compiler implementation is experimental.

The compiler is being developed in **C# / .NET**.

## Current Implementation Status

* Lexer: In progress
* Parser: Not implemented
* AST: Not implemented
* Semantic analysis: Not implemented
* Code generation / Runtime: Not implemented

Both the specification and implementation are subject to significant changes.

---

# Repository Structure

```
Fonyn/
├─ src/
│  ├─ Fonyn.CLI/        CLI entry point
│  └─ Fonyn.Compiler/   Compiler core
├─ tests/
│  └─ Fonyn.Tests/      Test code
├─ docs/
│  ├─ ja/               Japanese documents
│  └─ en/               English documents
└─ README.md
```

`Fonyn.Compiler` is currently divided into the following components:

* **Lexing**: Tokenization
* **Parsing**: Syntax analysis
* **Syntax**: Syntax definitions
* **Diagnostics**: Error and diagnostic handling

Planned documentation:
(not written yet)

* Language specification → `docs/spec`
* Development roadmap → `docs/roadmap.md`

---

# Development

The Fonyn compiler is implemented in **C# / .NET**.

## Requirements

```
.NET SDK
Git
```

## Build

```
dotnet build
```

## Test

```
dotnet test
```

---

# Roadmap

Development is planned in the following order:

1. Lexer
2. Parser
3. AST
4. Semantic Analysis
5. Code Generation
6. Runtime

---

# About This Project

Fonyn is an ongoing project that explores both
programming language design and compiler implementation.

At this stage, it should be considered a work-in-progress
focused on evolving both the design and implementation.

---

# Contribution

Issues, pull requests, and design discussions are welcome.

Especially:

* Feedback on language design
* Suggestions for naming or syntax
* Documentation improvements
* Discussions on implementation strategy

---

# License

MIT License
