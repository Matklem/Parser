namespace MoloParser.Constants
{
    enum SymbolConstants : int
    {
        SYMBOL_EOF            =  0, // (EOF)
        SYMBOL_ERROR          =  1, // (Error)
        SYMBOL_COMMENT        =  2, // Comment
        SYMBOL_NEWLINE        =  3, // NewLine
        SYMBOL_WHITESPACE     =  4, // Whitespace
        SYMBOL_TIMESDIV       =  5, // '*/'
        SYMBOL_DIVTIMES       =  6, // '/*'
        SYMBOL_DIVDIV         =  7, // '//'
        SYMBOL_MINUS          =  8, // '-'
        SYMBOL_EXCLAM         =  9, // '!'
        SYMBOL_EXCLAMEQ       = 10, // '!='
        SYMBOL_LPAREN         = 11, // '('
        SYMBOL_RPAREN         = 12, // ')'
        SYMBOL_TIMES          = 13, // '*'
        SYMBOL_COMMA          = 14, // ','
        SYMBOL_DIV            = 15, // '/'
        SYMBOL_SEMI           = 16, // ';'
        SYMBOL_LBRACE         = 17, // '{'
        SYMBOL_RBRACE         = 18, // '}'
        SYMBOL_PLUS           = 19, // '+'
        SYMBOL_LT             = 20, // '<'
        SYMBOL_LTEQ           = 21, // '<='
        SYMBOL_EQ             = 22, // '='
        SYMBOL_EQEQ           = 23, // '=='
        SYMBOL_GT             = 24, // '>'
        SYMBOL_GTEQ           = 25, // '>='
        SYMBOL_AND            = 26, // and
        SYMBOL_BOOL           = 27, // bool
        SYMBOL_BOOLEANLITERAL = 28, // BooleanLiteral
        SYMBOL_CONST          = 29, // const
        SYMBOL_ELSE           = 30, // else
        SYMBOL_FLOATLITERAL   = 31, // FloatLiteral
        SYMBOL_ID             = 32, // Id
        SYMBOL_IF             = 33, // if
        SYMBOL_MOD            = 34, // mod
        SYMBOL_NUM            = 35, // num
        SYMBOL_OR             = 36, // or
        SYMBOL_PROGRAM        = 37, // program
        SYMBOL_REPEAT         = 38, // repeat
        SYMBOL_STRING         = 39, // string
        SYMBOL_STRINGLITERAL  = 40, // StringLiteral
        SYMBOL_VOID           = 41, // void
        SYMBOL_BODY           = 42, // <body>
        SYMBOL_BODYPART       = 43, // <bodypart>
        SYMBOL_BOOL_OPR       = 44, // <bool_opr>
        SYMBOL_CALC_OPR       = 45, // <calc_opr>
        SYMBOL_CMPR_OPR       = 46, // <cmpr_opr>
        SYMBOL_CONST2         = 47, // <const>
        SYMBOL_CONST_PART     = 48, // <const_part>
        SYMBOL_CONSTS         = 49, // <consts>
        SYMBOL_CTRL_STMT      = 50, // <ctrl_stmt>
        SYMBOL_EXPR           = 51, // <expr>
        SYMBOL_EXPR_LIST      = 52, // <expr_list>
        SYMBOL_FIRST_TYPEID   = 53, // <first_typeid>
        SYMBOL_FUNC_CALL      = 54, // <func_call>
        SYMBOL_FUNC_DECL      = 55, // <func_decl>
        SYMBOL_FUNC_DECLS     = 56, // <Func_decls>
        SYMBOL_IF_EXP         = 57, // <if_exp>
        SYMBOL_OPERATOR       = 58, // <operator>
        SYMBOL_OPT_EXPRS      = 59, // <opt_exprs>
        SYMBOL_OPT_PARA       = 60, // <opt_para>
        SYMBOL_PROGRAM2       = 61, // <Program>
        SYMBOL_TYPE           = 62, // <type>
        SYMBOL_TYPEID         = 63, // <typeid>
        SYMBOL_VALUE          = 64, // <value>
        SYMBOL_VAR_DECL       = 65  // <var_decl>
    };
}