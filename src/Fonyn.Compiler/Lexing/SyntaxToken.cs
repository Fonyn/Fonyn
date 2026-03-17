namespace Fonyn.Compiler.Lexing;

/// <summary>
/// トークンの基本クラス。すべてのトークンはこのクラスを継承する必要がある。
/// </summary>
internal abstract class SyntaxToken
{
    /// <summary>
    /// トークンの種類を表すプロパティ。SyntaxKind列挙型の値を返す。
    /// </summary>
    public SyntaxKind Kind { get; }

    /// <summary>
    /// トークンのテキストを表すプロパティ。トークンが表す文字列を返す。
    /// </summary>
    public string Text { get; }

    /// <summary>
    /// トークンの位置と幅を示すプロパティ。
    /// </summary>
    public Span TextSpan { get; }

    protected SyntaxToken(SyntaxKind kind, string text, Span span)
    {
        Kind = kind;
        Text = text;
        TextSpan = span;
    }
}

internal class EndOfFileToken : SyntaxToken
{
    public override string ToString() => "EndOfFileToken";

    public EndOfFileToken(Span span) : base(SyntaxKind.EndOfFile, string.Empty, span) { }
}

internal class IdentifierToken : SyntaxToken
{
    public override string ToString() => $"IdentifierToken: {Text}";
    public virtual string Value => Text;

    public IdentifierToken(string text, Span span) : base(SyntaxKind.Identifier, text, span) { }
}

internal class NumberToken : SyntaxToken
{
    public override string ToString() => $"NumberToken: {Text}";
    public virtual double Value => double.Parse(Text);
    public NumberToken(string text, Span span) : base(SyntaxKind.Number, text, span) { }
}

internal class StringToken : SyntaxToken
{
    public override string ToString() => $"StringToken: {Text}";
    public virtual string Value => Text;
    public StringToken(string text, Span span) : base(SyntaxKind.String, text, span) { }
}

internal class PlusToken : SyntaxToken
{
    public override string ToString() => "PlusToken: +";
    public PlusToken(Span span) : base(SyntaxKind.Plus, "+", span) { }
}

internal class MinusToken : SyntaxToken
{
    public override string ToString() => "MinusToken: -";
    public MinusToken(Span span) : base(SyntaxKind.Minus, "-", span) { }
}

internal class AsteriskToken : SyntaxToken
{
    public override string ToString() => "AsteriskToken: *";
    public AsteriskToken(Span span) : base(SyntaxKind.Asterisk, "*", span) { }
}

internal class SlashToken : SyntaxToken
{
    public override string ToString() => "SlashToken: /";
    public SlashToken(Span span) : base(SyntaxKind.Slash, "/", span) { }
}

internal class OpenParenToken : SyntaxToken
{
    public override string ToString() => "OpenParenToken: (";
    public OpenParenToken(Span span) : base(SyntaxKind.OpenParen, "(", span) { }
}

internal class CloseParenToken : SyntaxToken
{
    public override string ToString() => "CloseParenToken: )";
    public CloseParenToken(Span span) : base(SyntaxKind.CloseParen, ")", span) { }
}

internal class OpenBraceToken : SyntaxToken
{
    public override string ToString() => "OpenBraceToken: {";
    public OpenBraceToken(Span span) : base(SyntaxKind.OpenBrace, "{", span) { }
}

internal class CloseBraceToken : SyntaxToken
{
    public override string ToString() => "CloseBraceToken: }";
    public CloseBraceToken(Span span) : base(SyntaxKind.CloseBrace, "}", span) { }
}

internal class OpenBracketToken : SyntaxToken
{
    public override string ToString() => "OpenBracketToken: [";
    public OpenBracketToken(Span span) : base(SyntaxKind.OpenBracket, "[", span) { }
}

internal class CloseBracketToken : SyntaxToken
{
    public override string ToString() => "CloseBracketToken: ]";
    public CloseBracketToken(Span span) : base(SyntaxKind.CloseBracket, "]", span) { }
}

internal class CommaToken : SyntaxToken
{
    public override string ToString() => "CommaToken: ,";
    public CommaToken(Span span) : base(SyntaxKind.Comma, ",", span) { }
}

internal class SemicolonToken : SyntaxToken
{
    public override string ToString() => "SemicolonToken: ;";
    public SemicolonToken(Span span) : base(SyntaxKind.Semicolon, ";", span) { }
}

internal class EqualsToken : SyntaxToken
{
    public override string ToString() => "EqualsToken: =";
    public EqualsToken(Span span) : base(SyntaxKind.Equals, "=", span) { }
}

internal class IfKeywordToken : SyntaxToken
{
    public override string ToString() => "IfKeywordToken: if";
    public IfKeywordToken(Span span) : base(SyntaxKind.IfKeyword, "if", span) { }
}

internal class ElseKeywordToken : SyntaxToken
{
    public override string ToString() => "ElseKeywordToken: else";
    public ElseKeywordToken(Span span) : base(SyntaxKind.ElseKeyword, "else", span) { }
}

internal class WhileKeywordToken : SyntaxToken
{
    public override string ToString() => "WhileKeywordToken: while";
    public WhileKeywordToken(Span span) : base(SyntaxKind.WhileKeyword, "while", span) { }
}

internal class ForKeywordToken : SyntaxToken
{
    public override string ToString() => "ForKeywordToken: for";
    public ForKeywordToken(Span span) : base(SyntaxKind.ForKeyword, "for", span) { }
}

internal class ReturnKeywordToken : SyntaxToken
{
    public override string ToString() => "ReturnKeywordToken: return";
    public ReturnKeywordToken(Span span) : base(SyntaxKind.ReturnKeyword, "return", span) { }
}

internal class WhitespaceToken : SyntaxToken
{
    public override string ToString() => $"WhitespaceToken: '{Text}'";
    public WhitespaceToken(string text, Span span) : base(SyntaxKind.Whitespace, text, span) { }
}

internal class InvalidToken : SyntaxToken
{
    public override string ToString() => $"InvalidToken: {Text}";
    public InvalidToken(string text, Span span) : base(SyntaxKind.Invalid, text, span) { }
}