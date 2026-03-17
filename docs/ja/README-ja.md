# Fonyn
[English README is here](../README.md)

Fonynは**汎用プログラミング言語**です。

### このプロジェクトは開発初期段階です！！！！！！！

「実体」「状態」「振る舞い」を明確に分離する設計により、
それぞれの概念を再利用可能にすることを目指しています。

Fonynは特定用途専用の言語ではないため、
一般的なアプリケーション開発にも使用できるよう設計します。
一方で、この設計は **ゲーム開発と非常に相性が良い**ため、
ゲーム開発のためのフレームワークを標準で提供したいと考えています。

---

# 設計思想

Fonyn は次の 3 つの概念を中心に設計されています。

```
actor   = 実体
state   = 再利用可能なデータ
action  = 再利用可能な振る舞い
````

このモデルにより、プログラムの構造をより明確に表現できます。

---

# コア概念

Fonyn には次の主要概念があります。

| 概念 | 説明 |
|-----|-----|
| actor | 状態と振る舞いを持つ実体 |
| state | 再利用可能なデータ構造 |
| action | actor に付与できる再利用可能な振る舞い |
| contract | 外部から見える能力の約束 |
| process | actor に属さない外部処理 |
| template | actor の雛形 |

---

# 簡単な例

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

この例では

* `Health` は再利用可能なデータ
* `Damage` は再利用可能な振る舞い
* `Player` はそれらを組み合わせた実体

を表しています。

---

# プロジェクトの状態

Fonyn は現在 **設計および試作段階**です。

言語仕様はまだ発展途中であり、
コンパイラも実験的な実装となっています。

現在のコンパイラは **C# / .NET** を用いて開発されています。

---

# リポジトリ構成

```
Fonyn/
├─ src/        コンパイラ実装
├─ tests/      テストコード
├─ docs/       ドキュメント
├─ examples/   サンプルコード
└─ README.md
```

主なドキュメント:

* 言語仕様 → `docs/spec`
* 開発ロードマップ → `docs/roadmap.md`

---

# 開発

Fonynのコンパイラは**C# / .NET**で実装されています。

必要な環境

```
.NET SDK
Git
```

ビルド

```
dotnet build
```

テスト

```
dotnet test
```

---

# 開発ロードマップ

現在予定している実装段階

1. Lexer
2. Parser
3. AST
4. Semantic Analysis
5. C# Code Generation
6. Runtime

---

# コントリビューション

Fonyn はオープンソースプロジェクトです。

以下の貢献を歓迎します。

* Issue の作成
* 言語設計の議論
* Pull Request
* ドキュメント改善

特に **言語仕様の設計議論**は大歓迎です。

---

# ライセンス

MIT License
