# Fonyn

## ___*This readme is in progress___

Fonyn is a programming language designed primarily for **game development**.

The goal of Fonyn is to provide a language where common game concepts can be expressed directly and naturally in code.

Instead of forcing game logic into traditional object-oriented structures, Fonyn introduces several first-class concepts designed specifically for games.

Core concepts include:

- `actor`
- `state`
- `action`
- `process`
- `template`
- `contract`

These allow game systems to be expressed in a more natural way.

---

# Project Status

⚠️ Fonyn is currently in **early design and prototype stage**.

The language specification is still evolving and the compiler implementation is experimental.

The current implementation is written in **C#**.

---

# Design Philosophy

Fonyn is built around three key principles:
```
actor = individuality
action = ability
process = world logic
```

### actor
Represents an entity in the world.

Examples:

- Player
- Enemy
- NPC
- Door

### state
Represents reusable data attached to actors.

Example:
```
state Health
{
  int hp;
  int maxHp;
}
```

### action
Represents reusable abilities that actors can perform.

Example:
```
action Move needs Transform
{
  void move(Vec3 dir)
  {
    transform.position += dir;
  }
}
```

### process
Represents world-level logic that operates across actors.

Example:
```
process Physics
{
  void update(float dt)
  {
    // world update logic
  }
}
```
---

# Example
```
state Health
{
  int hp;
  int maxHp;
}

action Damage needs Health
{
  void takeDamage(int amount)
  {
    health.hp -= amount;
  }
}

actor Player
{
  states: Health;
  actions: Damage;
}
```
---

# Repository Structure
```
Fonyn/
├─ src/
│ ├─ Fonyn.Compiler
│ └─ Fonyn.Cli
│
├─ tests/
│ └─ Fonyn.Compiler.Tests
│
├─ docs/
│ └─ spec
│
├─ examples/
│
└─ README.md
```

- `src` – compiler and CLI implementation
- `tests` – unit tests
- `docs` – language specification
- `examples` – sample Fonyn programs

---

# Development

Fonyn is implemented using **.NET / C#**.

Requirements:
.NET SDK
Git

Build:
dotnet build


Run tests:
dotnet test


---

# Roadmap

Planned development stages:

1. Lexer
2. Parser
3. AST
4. Semantic analysis
5. C# code generation
6. Runtime

---

# Contributing

Contributions are welcome.

Since the language is still evolving, discussions about language design are especially valuable.

Feel free to open:

- Issues
- Pull requests
- Design discussions

---

# License

This project is licensed under the MIT License.

---
