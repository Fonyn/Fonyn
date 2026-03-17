# Fonyn
[日本語のREADMEはこちら](docs/ja/README-ja.md)

Fonyn is a **general-purpose programming language**.
## Project Structure
- Fonyn.Compiler : Core compiler implementation

### This project is in early development and may change significantly.

It aims to make program structure clearer by explicitly separating the concepts of **entities**, **state**, and **behavior**, and by making each of them reusable.

Fonyn is not designed for a single specific domain.  
It is intended to be usable for general application development as well.

However, this design also works **particularly well for game development**, so we plan to provide a game development framework as part of the standard ecosystem.

---

# Design Philosophy

Fonyn is built around the following three core concepts.

```

actor   = entity
state   = reusable data
action  = reusable behavior

````

This model allows programs to express their structure more clearly.

---

# Core Concepts

Fonyn introduces the following main concepts.

| Concept | Description |
|--------|-------------|
| actor | An entity that owns state and behavior |
| state | A reusable data structure |
| action | A reusable behavior that can be attached to actors |
| contract | A capability contract visible from the outside |
| process | External logic not belonging to an actor |
| template | A template for creating actors |

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
* `Player` is an entity composed from those parts

---

# Project Status

Fonyn is currently in the **design and prototype stage**.

The language specification is still evolving, and the compiler implementation is experimental.

The current compiler is being developed using **C# / .NET**.

---

# Repository Structure

```
Fonyn/
├─ src/        compiler implementation
├─ tests/      test code
├─ docs/       documentation
├─ examples/   example programs
└─ README.md
```

Main documentation:

* Language specification → `docs/spec`
* Development roadmap → `docs/roadmap.md`

---

# Development

The Fonyn compiler is implemented in **C# / .NET**.

Requirements

```
.NET SDK
Git
```

Build

```
dotnet build
```

Run tests

```
dotnet test
```

---

# Development Roadmap

Planned implementation stages:

1. Lexer
2. Parser
3. AST
4. Semantic Analysis
5. C# Code Generation
6. Runtime

---

# Contributing

Fonyn is an open source project.

Contributions are welcome, including:

* Opening issues
* Language design discussions
* Pull requests
* Documentation improvements

In particular, **discussions about the language design are highly encouraged**.

---

# License

MIT License
