using System;
using System.Collections.Generic;
using System.Text;

namespace Fonyn.Compiler.Lexing
{
    /// <summary>
    /// 範囲を記録する型
    /// </summary>
    internal struct Span
    {
        public Span(int offset, int length)
        {
            Offset = offset;
            Length = length;
        }

        /// <summary>
        /// はじめの位置
        /// </summary>
        int Offset;

        /// <summary>
        /// 大きさ
        /// </summary>
        int Length;
    }
}
