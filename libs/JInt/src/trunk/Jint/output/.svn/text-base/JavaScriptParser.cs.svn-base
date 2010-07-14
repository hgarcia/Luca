// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g 2009-10-26 11:22:16


using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Jint.Expressions;
using Jint.Debugger;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;


using Antlr.Runtime.Tree;

public class JavaScriptParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"LBRACK", 
		"RBRACK", 
		"LPAREN", 
		"RPAREN", 
		"NUMBER", 
		"STRING", 
		"ID", 
		"REGEXP", 
		"TRUE", 
		"FALSE", 
		"LETTER", 
		"DIGIT", 
		"E", 
		"EscapeSequenceSingle", 
		"EscapeSequenceDouble", 
		"UnicodeEscape", 
		"HexDigit", 
		"WS", 
		"COMMENT", 
		"LINE_COMMENT", 
		"';'", 
		"'continue'", 
		"'break'", 
		"'var'", 
		"','", 
		"'='", 
		"'if'", 
		"'else'", 
		"'function'", 
		"'return'", 
		"'do'", 
		"'while'", 
		"'for'", 
		"'each'", 
		"'in'", 
		"'case'", 
		"':'", 
		"'switch'", 
		"'default'", 
		"'throw'", 
		"'try'", 
		"'catch'", 
		"'finally'", 
		"'+='", 
		"'-='", 
		"'*='", 
		"'/='", 
		"'>>='", 
		"'<<='", 
		"'>>>='", 
		"'&='", 
		"'|='", 
		"'^='", 
		"'?'", 
		"'||'", 
		"'&&'", 
		"'=='", 
		"'==='", 
		"'!='", 
		"'!=='", 
		"'<'", 
		"'<='", 
		"'>'", 
		"'>='", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'/'", 
		"'%'", 
		"'--'", 
		"'++'", 
		"'!'", 
		"'typeof'", 
		"'instanceof'", 
		"'['", 
		"']'", 
		"'.'", 
		"'new'"
    };

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int LBRACK = 4;
    public const int T__64 = 64;
    public const int T__29 = 29;
    public const int T__65 = 65;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__62 = 62;
    public const int T__26 = 26;
    public const int T__63 = 63;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int LETTER = 14;
    public const int EscapeSequenceDouble = 18;
    public const int ID = 10;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int HexDigit = 20;
    public const int LPAREN = 6;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int RPAREN = 7;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__59 = 59;
    public const int REGEXP = 11;
    public const int DIGIT = 15;
    public const int COMMENT = 22;
    public const int T__50 = 50;
    public const int RBRACK = 5;
    public const int T__42 = 42;
    public const int E = 16;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__80 = 80;
    public const int T__46 = 46;
    public const int T__81 = 81;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int LINE_COMMENT = 23;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int NUMBER = 8;
    public const int EscapeSequenceSingle = 17;
    public const int TRUE = 12;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 21;
    public const int T__71 = 71;
    public const int T__33 = 33;
    public const int T__72 = 72;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__70 = 70;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 19;
    public const int T__76 = 76;
    public const int FALSE = 13;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int T__79 = 79;
    public const int STRING = 9;
    public const int T__78 = 78;
    public const int T__77 = 77;

    // delegates
    // delegators



        public JavaScriptParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public JavaScriptParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return JavaScriptParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g"; }
    }


    private const char BS = '\\';
    private static NumberFormatInfo numberFormatInfo = new NumberFormatInfo();

    private string extractRegExpPattern(string text) {
        return text.Substring(1, text.Length-2);
    }

    private string extractRegExpOption(string text) {
        int index = text.LastIndexOf('/');
        if(index != text.Length - 1) {
            return text.Substring(text.LastIndexOf('/')+1);
        }
        return String.Empty;
    }

    private string extractString(string text) {
        
        StringBuilder sb = new StringBuilder(text);
        int startIndex = 1; // Skip initial quote
        int slashIndex = -1;

        while ((slashIndex = sb.ToString().IndexOf(BS, startIndex)) != -1)
        {
            char escapeType = sb[slashIndex + 1];
            switch (escapeType)
            {
                case 'u':
                  string hcode = String.Concat(sb[slashIndex+4], sb[slashIndex+5]);
                  string lcode = String.Concat(sb[slashIndex+2], sb[slashIndex+3]);
                  char unicodeChar = Encoding.Unicode.GetChars(new byte[] { System.Convert.ToByte(hcode, 16), System.Convert.ToByte(lcode, 16)} )[0];
                  sb.Remove(slashIndex, 6).Insert(slashIndex, unicodeChar); 
                  break;
                case 'n': sb.Remove(slashIndex, 2).Insert(slashIndex, '\n'); break;
                case 'r': sb.Remove(slashIndex, 2).Insert(slashIndex, '\r'); break;
                case 't': sb.Remove(slashIndex, 2).Insert(slashIndex, '\t'); break;
                case '\'': sb.Remove(slashIndex, 2).Insert(slashIndex, '\''); break;
                case '"': sb.Remove(slashIndex, 2).Insert(slashIndex, '"'); break;
                case '\\': sb.Remove(slashIndex, 2).Insert(slashIndex, '\\'); break;
                default: throw new RecognitionException("Unvalid escape sequence: \\" + escapeType);
            }

            startIndex = slashIndex + 1;

        }

        sb.Remove(0, 1);
        sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }

    public List<string> Errors { get; private set; }

    public override void DisplayRecognitionError(String[] tokenNames, RecognitionException e) {
        
        base.DisplayRecognitionError(tokenNames, e);
        
        if(Errors == null)
        {
        	Errors = new List<string>();
        }
        
        String hdr = GetErrorHeader(e);
        String msg = GetErrorMessage(e, tokenNames);
        Errors.Add(msg + " at " + hdr);
    }

    public FileLocation GetStartFileLocation(CommonToken token) {
        return new FileLocation(token.Line, token.CharPositionInLine);
    }

    public FileLocation GetStopFileLocation(CommonToken token) {
        return new FileLocation(token.Line, token.CharPositionInLine + token.Text.Length);
    }



    public class program_return : ParserRuleReturnScope
    {
        public Program value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "program"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:143:1: program returns [Program value] : (follow= statement )* EOF ;
    public JavaScriptParser.program_return program() // throws RecognitionException [1]
    {   
        JavaScriptParser.program_return retval = new JavaScriptParser.program_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EOF1 = null;
        JavaScriptParser.statement_return follow = null;


        CommonTree EOF1_tree=null;


        Program program = new Program();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:147:2: ( (follow= statement )* EOF )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:147:4: (follow= statement )* EOF
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:147:4: (follow= statement )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == LBRACK || LA1_0 == LPAREN || (LA1_0 >= NUMBER && LA1_0 <= FALSE) || (LA1_0 >= 24 && LA1_0 <= 27) || LA1_0 == 30 || (LA1_0 >= 32 && LA1_0 <= 38) || LA1_0 == 41 || (LA1_0 >= 43 && LA1_0 <= 44) || (LA1_0 >= 68 && LA1_0 <= 69) || (LA1_0 >= 73 && LA1_0 <= 78) || LA1_0 == 81) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:147:5: follow= statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_program78);
            			    	follow = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, follow.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   program.Statements.Add(((follow != null) ? follow.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	EOF1=(IToken)Match(input,EOF,FOLLOW_EOF_in_program84); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  program; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class statement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:150:1: statement returns [Statement value] : ( emptyStatement | expressionStatement | blockStatement | variableDeclaration | ifStatement | functionDeclarationStatement | returnStatement | iterationStatement | continueStatement | breakStatement | switchStatement | throwStatement | tryStatement );
    public JavaScriptParser.statement_return statement() // throws RecognitionException [1]
    {   
        JavaScriptParser.statement_return retval = new JavaScriptParser.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        JavaScriptParser.emptyStatement_return emptyStatement2 = null;

        JavaScriptParser.expressionStatement_return expressionStatement3 = null;

        JavaScriptParser.blockStatement_return blockStatement4 = null;

        JavaScriptParser.variableDeclaration_return variableDeclaration5 = null;

        JavaScriptParser.ifStatement_return ifStatement6 = null;

        JavaScriptParser.functionDeclarationStatement_return functionDeclarationStatement7 = null;

        JavaScriptParser.returnStatement_return returnStatement8 = null;

        JavaScriptParser.iterationStatement_return iterationStatement9 = null;

        JavaScriptParser.continueStatement_return continueStatement10 = null;

        JavaScriptParser.breakStatement_return breakStatement11 = null;

        JavaScriptParser.switchStatement_return switchStatement12 = null;

        JavaScriptParser.throwStatement_return throwStatement13 = null;

        JavaScriptParser.tryStatement_return tryStatement14 = null;



        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:151:2: ( emptyStatement | expressionStatement | blockStatement | variableDeclaration | ifStatement | functionDeclarationStatement | returnStatement | iterationStatement | continueStatement | breakStatement | switchStatement | throwStatement | tryStatement )
            int alt2 = 13;
            alt2 = dfa2.Predict(input);
            switch (alt2) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:151:4: emptyStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_emptyStatement_in_statement102);
                    	emptyStatement2 = emptyStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, emptyStatement2.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((emptyStatement2 != null) ? emptyStatement2.value : null); 
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:152:4: expressionStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expressionStatement_in_statement109);
                    	expressionStatement3 = expressionStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressionStatement3.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((expressionStatement3 != null) ? expressionStatement3.value : null); 
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:153:4: blockStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_blockStatement_in_statement116);
                    	blockStatement4 = blockStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement4.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((blockStatement4 != null) ? blockStatement4.value : null); 
                    	}

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:154:4: variableDeclaration
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableDeclaration_in_statement123);
                    	variableDeclaration5 = variableDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaration5.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((variableDeclaration5 != null) ? variableDeclaration5.value : null); 
                    	}

                    }
                    break;
                case 5 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:155:4: ifStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement130);
                    	ifStatement6 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifStatement6.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((ifStatement6 != null) ? ifStatement6.value : null); 
                    	}

                    }
                    break;
                case 6 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:156:4: functionDeclarationStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionDeclarationStatement_in_statement137);
                    	functionDeclarationStatement7 = functionDeclarationStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionDeclarationStatement7.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((functionDeclarationStatement7 != null) ? functionDeclarationStatement7.value : null); 
                    	}

                    }
                    break;
                case 7 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:157:4: returnStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_returnStatement_in_statement144);
                    	returnStatement8 = returnStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnStatement8.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((returnStatement8 != null) ? returnStatement8.value : null); 
                    	}

                    }
                    break;
                case 8 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:158:4: iterationStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_iterationStatement_in_statement151);
                    	iterationStatement9 = iterationStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, iterationStatement9.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((iterationStatement9 != null) ? iterationStatement9.value : null); 
                    	}

                    }
                    break;
                case 9 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:159:4: continueStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_continueStatement_in_statement158);
                    	continueStatement10 = continueStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, continueStatement10.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((continueStatement10 != null) ? continueStatement10.value : null); 
                    	}

                    }
                    break;
                case 10 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:160:4: breakStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_breakStatement_in_statement165);
                    	breakStatement11 = breakStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, breakStatement11.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((breakStatement11 != null) ? breakStatement11.value : null); 
                    	}

                    }
                    break;
                case 11 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:161:4: switchStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_switchStatement_in_statement172);
                    	switchStatement12 = switchStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, switchStatement12.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((switchStatement12 != null) ? switchStatement12.value : null); 
                    	}

                    }
                    break;
                case 12 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:162:4: throwStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_throwStatement_in_statement179);
                    	throwStatement13 = throwStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, throwStatement13.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((throwStatement13 != null) ? throwStatement13.value : null); 
                    	}

                    }
                    break;
                case 13 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:163:4: tryStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tryStatement_in_statement186);
                    	tryStatement14 = tryStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tryStatement14.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((tryStatement14 != null) ? tryStatement14.value : null); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class emptyStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "emptyStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:166:1: emptyStatement returns [Statement value] : ';' ;
    public JavaScriptParser.emptyStatement_return emptyStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.emptyStatement_return retval = new JavaScriptParser.emptyStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal15 = null;

        CommonTree char_literal15_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:167:2: ( ';' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:167:4: ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal15=(IToken)Match(input,24,FOLLOW_24_in_emptyStatement203); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal15_tree = (CommonTree)adaptor.Create(char_literal15);
            		adaptor.AddChild(root_0, char_literal15_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new EmptyStatement(); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "emptyStatement"

    public class blockStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "blockStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:170:1: blockStatement returns [Statement value] : LBRACK ( statement )* RBRACK ;
    public JavaScriptParser.blockStatement_return blockStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.blockStatement_return retval = new JavaScriptParser.blockStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LBRACK16 = null;
        IToken RBRACK18 = null;
        JavaScriptParser.statement_return statement17 = null;


        CommonTree LBRACK16_tree=null;
        CommonTree RBRACK18_tree=null;


        BlockStatement s = new BlockStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:179:2: ( LBRACK ( statement )* RBRACK )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:179:4: LBRACK ( statement )* RBRACK
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LBRACK16=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_blockStatement229); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LBRACK16_tree = (CommonTree)adaptor.Create(LBRACK16);
            		adaptor.AddChild(root_0, LBRACK16_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:179:11: ( statement )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == LBRACK || LA3_0 == LPAREN || (LA3_0 >= NUMBER && LA3_0 <= FALSE) || (LA3_0 >= 24 && LA3_0 <= 27) || LA3_0 == 30 || (LA3_0 >= 32 && LA3_0 <= 38) || LA3_0 == 41 || (LA3_0 >= 43 && LA3_0 <= 44) || (LA3_0 >= 68 && LA3_0 <= 69) || (LA3_0 >= 73 && LA3_0 <= 78) || LA3_0 == 81) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:179:12: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_blockStatement232);
            			    	statement17 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement17.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   s.Statements.Add(((statement17 != null) ? statement17.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	RBRACK18=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_blockStatement238); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RBRACK18_tree = (CommonTree)adaptor.Create(RBRACK18);
            		adaptor.AddChild(root_0, RBRACK18_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  s; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
            if ( (state.backtracking==0) )
            {

              retval.value.Start = GetStartFileLocation((CommonToken)retval.Start);
              retval.value.Stop = new FileLocation(retval.value.Start.Line, retval.value.Start.Char + 1);

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "blockStatement"

    public class continueStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "continueStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:182:1: continueStatement returns [Statement value] : 'continue' ';' ;
    public JavaScriptParser.continueStatement_return continueStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.continueStatement_return retval = new JavaScriptParser.continueStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal19 = null;
        IToken char_literal20 = null;

        CommonTree string_literal19_tree=null;
        CommonTree char_literal20_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:188:2: ( 'continue' ';' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:188:4: 'continue' ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal19=(IToken)Match(input,25,FOLLOW_25_in_continueStatement261); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal19_tree = (CommonTree)adaptor.Create(string_literal19);
            		adaptor.AddChild(root_0, string_literal19_tree);
            	}
            	char_literal20=(IToken)Match(input,24,FOLLOW_24_in_continueStatement263); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal20_tree = (CommonTree)adaptor.Create(char_literal20);
            		adaptor.AddChild(root_0, char_literal20_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new ContinueStatement(); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
            if ( (state.backtracking==0) )
            {

              retval.value.Start = GetStartFileLocation((CommonToken)retval.Start);
              retval.value.Stop = GetStopFileLocation((CommonToken)retval.Stop);


            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "continueStatement"

    public class breakStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "breakStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:191:1: breakStatement returns [Statement value] : 'break' ';' ;
    public JavaScriptParser.breakStatement_return breakStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.breakStatement_return retval = new JavaScriptParser.breakStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal21 = null;
        IToken char_literal22 = null;

        CommonTree string_literal21_tree=null;
        CommonTree char_literal22_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:197:2: ( 'break' ';' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:197:4: 'break' ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal21=(IToken)Match(input,26,FOLLOW_26_in_breakStatement285); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal21_tree = (CommonTree)adaptor.Create(string_literal21);
            		adaptor.AddChild(root_0, string_literal21_tree);
            	}
            	char_literal22=(IToken)Match(input,24,FOLLOW_24_in_breakStatement287); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal22_tree = (CommonTree)adaptor.Create(char_literal22);
            		adaptor.AddChild(root_0, char_literal22_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new BreakStatement(); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
            if ( (state.backtracking==0) )
            {

              retval.value.Start = GetStartFileLocation((CommonToken)retval.Start);
              retval.value.Stop = GetStopFileLocation((CommonToken)retval.Stop);

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "breakStatement"

    public class expressionStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expressionStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:200:1: expressionStatement returns [Statement value] : expression ';' ;
    public JavaScriptParser.expressionStatement_return expressionStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.expressionStatement_return retval = new JavaScriptParser.expressionStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal24 = null;
        JavaScriptParser.expression_return expression23 = null;


        CommonTree char_literal24_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:205:2: ( expression ';' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:205:4: expression ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionStatement308);
            	expression23 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression23.Tree);
            	char_literal24=(IToken)Match(input,24,FOLLOW_24_in_expressionStatement310); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal24_tree = (CommonTree)adaptor.Create(char_literal24);
            		adaptor.AddChild(root_0, char_literal24_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new ExpressionStatement(((expression23 != null) ? expression23.value : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
            if ( (state.backtracking==0) )
            {

              retval.value.Start = GetStartFileLocation((CommonToken)retval.Start);
              retval.value.Stop = GetStopFileLocation((CommonToken)retval.Stop);

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expressionStatement"

    public class variableDeclaration_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "variableDeclaration"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:208:1: variableDeclaration returns [Statement value] : 'var' first= variableDeclarationStatement ( ',' follow= variableDeclarationStatement )* ';' ;
    public JavaScriptParser.variableDeclaration_return variableDeclaration() // throws RecognitionException [1]
    {   
        JavaScriptParser.variableDeclaration_return retval = new JavaScriptParser.variableDeclaration_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal25 = null;
        IToken char_literal26 = null;
        IToken char_literal27 = null;
        JavaScriptParser.variableDeclarationStatement_return first = null;

        JavaScriptParser.variableDeclarationStatement_return follow = null;


        CommonTree string_literal25_tree=null;
        CommonTree char_literal26_tree=null;
        CommonTree char_literal27_tree=null;


        VariableDeclarationStatement current = null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:216:2: ( 'var' first= variableDeclarationStatement ( ',' follow= variableDeclarationStatement )* ';' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:216:4: 'var' first= variableDeclarationStatement ( ',' follow= variableDeclarationStatement )* ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal25=(IToken)Match(input,27,FOLLOW_27_in_variableDeclaration335); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal25_tree = (CommonTree)adaptor.Create(string_literal25);
            		adaptor.AddChild(root_0, string_literal25_tree);
            	}
            	PushFollow(FOLLOW_variableDeclarationStatement_in_variableDeclaration339);
            	first = variableDeclarationStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, first.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   current = first.value; current.Global = false; retval.value =  current; 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:216:114: ( ',' follow= variableDeclarationStatement )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 28) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:216:115: ',' follow= variableDeclarationStatement
            			    {
            			    	char_literal26=(IToken)Match(input,28,FOLLOW_28_in_variableDeclaration344); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal26_tree = (CommonTree)adaptor.Create(char_literal26);
            			    		adaptor.AddChild(root_0, char_literal26_tree);
            			    	}
            			    	PushFollow(FOLLOW_variableDeclarationStatement_in_variableDeclaration348);
            			    	follow = variableDeclarationStatement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, follow.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   current.Next = follow.value; current.Global = false; current = current.Next; 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	char_literal27=(IToken)Match(input,24,FOLLOW_24_in_variableDeclaration355); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal27_tree = (CommonTree)adaptor.Create(char_literal27);
            		adaptor.AddChild(root_0, char_literal27_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
            if ( (state.backtracking==0) )
            {

              retval.value.Start = GetStartFileLocation((CommonToken)retval.Start);
              retval.value.Stop = GetStopFileLocation((CommonToken)retval.Stop);

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableDeclaration"

    public class variableDeclarationStatement_return : ParserRuleReturnScope
    {
        public VariableDeclarationStatement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "variableDeclarationStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:219:1: variableDeclarationStatement returns [VariableDeclarationStatement value] : identifier ( '=' expression )? ;
    public JavaScriptParser.variableDeclarationStatement_return variableDeclarationStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.variableDeclarationStatement_return retval = new JavaScriptParser.variableDeclarationStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal29 = null;
        JavaScriptParser.identifier_return identifier28 = null;

        JavaScriptParser.expression_return expression30 = null;


        CommonTree char_literal29_tree=null;


        VariableDeclarationStatement statement = new VariableDeclarationStatement();
        statement.Global = true;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:229:2: ( identifier ( '=' expression )? )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:229:4: identifier ( '=' expression )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  statement; 
            	}
            	PushFollow(FOLLOW_identifier_in_variableDeclarationStatement383);
            	identifier28 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, identifier28.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   statement.Identifier = ((identifier28 != null) ? identifier28.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:229:85: ( '=' expression )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == 29) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:229:87: '=' expression
            	        {
            	        	char_literal29=(IToken)Match(input,29,FOLLOW_29_in_variableDeclarationStatement389); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal29_tree = (CommonTree)adaptor.Create(char_literal29);
            	        		adaptor.AddChild(root_0, char_literal29_tree);
            	        	}
            	        	PushFollow(FOLLOW_expression_in_variableDeclarationStatement391);
            	        	expression30 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression30.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   statement.Expression = ((expression30 != null) ? expression30.value : null); 
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
            if ( (state.backtracking==0) )
            {

              retval.value.Start = GetStartFileLocation((CommonToken)retval.Start);
              retval.value.Stop = GetStopFileLocation((CommonToken)retval.Stop);

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableDeclarationStatement"

    public class ifStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ifStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:232:1: ifStatement returns [Statement value] : 'if' LPAREN expression RPAREN then= statement ( 'else' els= statement )? ;
    public JavaScriptParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.ifStatement_return retval = new JavaScriptParser.ifStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal31 = null;
        IToken LPAREN32 = null;
        IToken RPAREN34 = null;
        IToken string_literal35 = null;
        JavaScriptParser.statement_return then = null;

        JavaScriptParser.statement_return els = null;

        JavaScriptParser.expression_return expression33 = null;


        CommonTree string_literal31_tree=null;
        CommonTree LPAREN32_tree=null;
        CommonTree RPAREN34_tree=null;
        CommonTree string_literal35_tree=null;


        IfStatement st = new IfStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:241:2: ( 'if' LPAREN expression RPAREN then= statement ( 'else' els= statement )? )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:241:4: 'if' LPAREN expression RPAREN then= statement ( 'else' els= statement )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal31=(IToken)Match(input,30,FOLLOW_30_in_ifStatement421); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal31_tree = (CommonTree)adaptor.Create(string_literal31);
            		adaptor.AddChild(root_0, string_literal31_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  st; 
            	}
            	LPAREN32=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_ifStatement425); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN32_tree = (CommonTree)adaptor.Create(LPAREN32);
            		adaptor.AddChild(root_0, LPAREN32_tree);
            	}
            	PushFollow(FOLLOW_expression_in_ifStatement427);
            	expression33 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression33.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   st.Expression = ((expression33 != null) ? expression33.value : null); 
            	}
            	RPAREN34=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_ifStatement431); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN34_tree = (CommonTree)adaptor.Create(RPAREN34);
            		adaptor.AddChild(root_0, RPAREN34_tree);
            	}
            	PushFollow(FOLLOW_statement_in_ifStatement439);
            	then = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, then.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   st.Then = ((then != null) ? then.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:242:46: ( 'else' els= statement )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == 31) )
            	{
            	    int LA6_1 = input.LA(2);

            	    if ( (synpred17_JavaScript()) )
            	    {
            	        alt6 = 1;
            	    }
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:242:47: 'else' els= statement
            	        {
            	        	string_literal35=(IToken)Match(input,31,FOLLOW_31_in_ifStatement444); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal35_tree = (CommonTree)adaptor.Create(string_literal35);
            	        		adaptor.AddChild(root_0, string_literal35_tree);
            	        	}
            	        	PushFollow(FOLLOW_statement_in_ifStatement448);
            	        	els = statement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, els.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   st.Else = ((els != null) ? els.value : null); 
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
            if ( (state.backtracking==0) )
            {

              retval.value.Start = GetStartFileLocation((CommonToken)retval.Start);
              retval.value.Stop = GetStopFileLocation((CommonToken)retval.Stop);

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ifStatement"

    public class functionDeclarationStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "functionDeclarationStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:245:1: functionDeclarationStatement returns [Statement value] : 'function' identifier formalParameterList blockStatement ;
    public JavaScriptParser.functionDeclarationStatement_return functionDeclarationStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.functionDeclarationStatement_return retval = new JavaScriptParser.functionDeclarationStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal36 = null;
        JavaScriptParser.identifier_return identifier37 = null;

        JavaScriptParser.formalParameterList_return formalParameterList38 = null;

        JavaScriptParser.blockStatement_return blockStatement39 = null;


        CommonTree string_literal36_tree=null;


        FunctionDeclarationStatement statement = new FunctionDeclarationStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:249:2: ( 'function' identifier formalParameterList blockStatement )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:249:4: 'function' identifier formalParameterList blockStatement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal36=(IToken)Match(input,32,FOLLOW_32_in_functionDeclarationStatement475); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal36_tree = (CommonTree)adaptor.Create(string_literal36);
            		adaptor.AddChild(root_0, string_literal36_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  statement; 
            	}
            	PushFollow(FOLLOW_identifier_in_functionDeclarationStatement479);
            	identifier37 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, identifier37.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   statement.Name = ((identifier37 != null) ? identifier37.value : null); 
            	}
            	PushFollow(FOLLOW_formalParameterList_in_functionDeclarationStatement488);
            	formalParameterList38 = formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterList38.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   statement.Parameters.AddRange(((formalParameterList38 != null) ? formalParameterList38.value : null)); 
            	}
            	PushFollow(FOLLOW_blockStatement_in_functionDeclarationStatement496);
            	blockStatement39 = blockStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement39.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   statement.Statement = ((blockStatement39 != null) ? blockStatement39.value : null); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functionDeclarationStatement"

    public class formalParameterList_return : ParserRuleReturnScope
    {
        public List<Identifier> value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "formalParameterList"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:254:1: formalParameterList returns [List<Identifier> value] : LPAREN (first= identifier ( ',' follow= identifier )* )? RPAREN ;
    public JavaScriptParser.formalParameterList_return formalParameterList() // throws RecognitionException [1]
    {   
        JavaScriptParser.formalParameterList_return retval = new JavaScriptParser.formalParameterList_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LPAREN40 = null;
        IToken char_literal41 = null;
        IToken RPAREN42 = null;
        JavaScriptParser.identifier_return first = null;

        JavaScriptParser.identifier_return follow = null;


        CommonTree LPAREN40_tree=null;
        CommonTree char_literal41_tree=null;
        CommonTree RPAREN42_tree=null;


        List<Identifier> identifiers = new List<Identifier>();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:258:2: ( LPAREN (first= identifier ( ',' follow= identifier )* )? RPAREN )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:258:4: LPAREN (first= identifier ( ',' follow= identifier )* )? RPAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LPAREN40=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_formalParameterList518); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN40_tree = (CommonTree)adaptor.Create(LPAREN40);
            		adaptor.AddChild(root_0, LPAREN40_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:258:11: (first= identifier ( ',' follow= identifier )* )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == ID || (LA8_0 >= 37 && LA8_0 <= 38)) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:258:12: first= identifier ( ',' follow= identifier )*
            	        {
            	        	PushFollow(FOLLOW_identifier_in_formalParameterList523);
            	        	first = identifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, first.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   identifiers.Add(((first != null) ? first.value : null)); 
            	        	}
            	        	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:258:64: ( ',' follow= identifier )*
            	        	do 
            	        	{
            	        	    int alt7 = 2;
            	        	    int LA7_0 = input.LA(1);

            	        	    if ( (LA7_0 == 28) )
            	        	    {
            	        	        alt7 = 1;
            	        	    }


            	        	    switch (alt7) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:258:66: ',' follow= identifier
            	        			    {
            	        			    	char_literal41=(IToken)Match(input,28,FOLLOW_28_in_formalParameterList529); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{char_literal41_tree = (CommonTree)adaptor.Create(char_literal41);
            	        			    		adaptor.AddChild(root_0, char_literal41_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_identifier_in_formalParameterList533);
            	        			    	follow = identifier();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, follow.Tree);
            	        			    	if ( (state.backtracking==0) )
            	        			    	{
            	        			    	   identifiers.Add(((follow != null) ? follow.value : null)); 
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop7;
            	        	    }
            	        	} while (true);

            	        	loop7:
            	        		;	// Stops C# compiler whining that label 'loop7' has no statements


            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  identifiers; 
            	}
            	RPAREN42=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_formalParameterList544); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN42_tree = (CommonTree)adaptor.Create(RPAREN42);
            		adaptor.AddChild(root_0, RPAREN42_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "formalParameterList"

    public class returnStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "returnStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:261:1: returnStatement returns [Statement value] : 'return' ( expression )? ';' ;
    public JavaScriptParser.returnStatement_return returnStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.returnStatement_return retval = new JavaScriptParser.returnStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal43 = null;
        IToken char_literal45 = null;
        JavaScriptParser.expression_return expression44 = null;


        CommonTree string_literal43_tree=null;
        CommonTree char_literal45_tree=null;


        Expression returnExp = null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:270:2: ( 'return' ( expression )? ';' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:270:4: 'return' ( expression )? ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal43=(IToken)Match(input,33,FOLLOW_33_in_returnStatement568); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal43_tree = (CommonTree)adaptor.Create(string_literal43);
            		adaptor.AddChild(root_0, string_literal43_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:270:13: ( expression )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == LBRACK || LA9_0 == LPAREN || (LA9_0 >= NUMBER && LA9_0 <= FALSE) || LA9_0 == 32 || (LA9_0 >= 37 && LA9_0 <= 38) || (LA9_0 >= 68 && LA9_0 <= 69) || (LA9_0 >= 73 && LA9_0 <= 78) || LA9_0 == 81) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:270:14: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_returnStatement571);
            	        	expression44 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression44.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   returnExp = ((expression44 != null) ? expression44.value : null); 
            	        	}

            	        }
            	        break;

            	}

            	char_literal45=(IToken)Match(input,24,FOLLOW_24_in_returnStatement578); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal45_tree = (CommonTree)adaptor.Create(char_literal45);
            		adaptor.AddChild(root_0, char_literal45_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new ReturnStatement(returnExp); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
            if ( (state.backtracking==0) )
            {

              retval.value.Start = GetStartFileLocation((CommonToken)retval.Start);
              retval.value.Stop = GetStopFileLocation((CommonToken)retval.Stop);

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "returnStatement"

    public class iterationStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "iterationStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:273:1: iterationStatement returns [Statement value] : ( doWhileStatement | whileStatement | forStatement | forEachInStatement );
    public JavaScriptParser.iterationStatement_return iterationStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.iterationStatement_return retval = new JavaScriptParser.iterationStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        JavaScriptParser.doWhileStatement_return doWhileStatement46 = null;

        JavaScriptParser.whileStatement_return whileStatement47 = null;

        JavaScriptParser.forStatement_return forStatement48 = null;

        JavaScriptParser.forEachInStatement_return forEachInStatement49 = null;



        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:274:2: ( doWhileStatement | whileStatement | forStatement | forEachInStatement )
            int alt10 = 4;
            alt10 = dfa10.Predict(input);
            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:274:4: doWhileStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_doWhileStatement_in_iterationStatement595);
                    	doWhileStatement46 = doWhileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, doWhileStatement46.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((doWhileStatement46 != null) ? doWhileStatement46.value : null); 
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:275:4: whileStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileStatement_in_iterationStatement602);
                    	whileStatement47 = whileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileStatement47.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((whileStatement47 != null) ? whileStatement47.value : null); 
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:276:4: forStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forStatement_in_iterationStatement609);
                    	forStatement48 = forStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forStatement48.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((forStatement48 != null) ? forStatement48.value : null); 
                    	}

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:277:4: forEachInStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forEachInStatement_in_iterationStatement616);
                    	forEachInStatement49 = forEachInStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forEachInStatement49.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((forEachInStatement49 != null) ? forEachInStatement49.value : null); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "iterationStatement"

    public class doWhileStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "doWhileStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:280:1: doWhileStatement returns [Statement value] : 'do' statement 'while' LPAREN expression RPAREN ;
    public JavaScriptParser.doWhileStatement_return doWhileStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.doWhileStatement_return retval = new JavaScriptParser.doWhileStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal50 = null;
        IToken string_literal52 = null;
        IToken LPAREN53 = null;
        IToken RPAREN55 = null;
        JavaScriptParser.statement_return statement51 = null;

        JavaScriptParser.expression_return expression54 = null;


        CommonTree string_literal50_tree=null;
        CommonTree string_literal52_tree=null;
        CommonTree LPAREN53_tree=null;
        CommonTree RPAREN55_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:281:2: ( 'do' statement 'while' LPAREN expression RPAREN )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:281:4: 'do' statement 'while' LPAREN expression RPAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal50=(IToken)Match(input,34,FOLLOW_34_in_doWhileStatement633); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal50_tree = (CommonTree)adaptor.Create(string_literal50);
            		adaptor.AddChild(root_0, string_literal50_tree);
            	}
            	PushFollow(FOLLOW_statement_in_doWhileStatement635);
            	statement51 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement51.Tree);
            	string_literal52=(IToken)Match(input,35,FOLLOW_35_in_doWhileStatement637); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal52_tree = (CommonTree)adaptor.Create(string_literal52);
            		adaptor.AddChild(root_0, string_literal52_tree);
            	}
            	LPAREN53=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_doWhileStatement639); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN53_tree = (CommonTree)adaptor.Create(LPAREN53);
            		adaptor.AddChild(root_0, LPAREN53_tree);
            	}
            	PushFollow(FOLLOW_expression_in_doWhileStatement641);
            	expression54 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression54.Tree);
            	RPAREN55=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_doWhileStatement643); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN55_tree = (CommonTree)adaptor.Create(RPAREN55);
            		adaptor.AddChild(root_0, RPAREN55_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new DoWhileStatement(((expression54 != null) ? expression54.value : null), ((statement51 != null) ? statement51.value : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "doWhileStatement"

    public class whileStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "whileStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:284:1: whileStatement returns [Statement value] : 'while' LPAREN expression RPAREN statement ;
    public JavaScriptParser.whileStatement_return whileStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.whileStatement_return retval = new JavaScriptParser.whileStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal56 = null;
        IToken LPAREN57 = null;
        IToken RPAREN59 = null;
        JavaScriptParser.expression_return expression58 = null;

        JavaScriptParser.statement_return statement60 = null;


        CommonTree string_literal56_tree=null;
        CommonTree LPAREN57_tree=null;
        CommonTree RPAREN59_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:285:2: ( 'while' LPAREN expression RPAREN statement )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:285:4: 'while' LPAREN expression RPAREN statement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal56=(IToken)Match(input,35,FOLLOW_35_in_whileStatement661); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal56_tree = (CommonTree)adaptor.Create(string_literal56);
            		adaptor.AddChild(root_0, string_literal56_tree);
            	}
            	LPAREN57=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_whileStatement663); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN57_tree = (CommonTree)adaptor.Create(LPAREN57);
            		adaptor.AddChild(root_0, LPAREN57_tree);
            	}
            	PushFollow(FOLLOW_expression_in_whileStatement665);
            	expression58 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression58.Tree);
            	RPAREN59=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_whileStatement667); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN59_tree = (CommonTree)adaptor.Create(RPAREN59);
            		adaptor.AddChild(root_0, RPAREN59_tree);
            	}
            	PushFollow(FOLLOW_statement_in_whileStatement669);
            	statement60 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement60.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new WhileStatement(((expression58 != null) ? expression58.value : null), ((statement60 != null) ? statement60.value : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "whileStatement"

    public class forStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:288:1: forStatement returns [Statement value] : 'for' LPAREN (init= forStatementInitialiserPart )? ';' (condition= expression )? ';' (increment= expression )? RPAREN instruction= statement ;
    public JavaScriptParser.forStatement_return forStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.forStatement_return retval = new JavaScriptParser.forStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal61 = null;
        IToken LPAREN62 = null;
        IToken char_literal63 = null;
        IToken char_literal64 = null;
        IToken RPAREN65 = null;
        JavaScriptParser.forStatementInitialiserPart_return init = null;

        JavaScriptParser.expression_return condition = null;

        JavaScriptParser.expression_return increment = null;

        JavaScriptParser.statement_return instruction = null;


        CommonTree string_literal61_tree=null;
        CommonTree LPAREN62_tree=null;
        CommonTree char_literal63_tree=null;
        CommonTree char_literal64_tree=null;
        CommonTree RPAREN65_tree=null;


        ForStatement forStatement = new ForStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:292:2: ( 'for' LPAREN (init= forStatementInitialiserPart )? ';' (condition= expression )? ';' (increment= expression )? RPAREN instruction= statement )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:292:4: 'for' LPAREN (init= forStatementInitialiserPart )? ';' (condition= expression )? ';' (increment= expression )? RPAREN instruction= statement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal61=(IToken)Match(input,36,FOLLOW_36_in_forStatement692); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal61_tree = (CommonTree)adaptor.Create(string_literal61);
            		adaptor.AddChild(root_0, string_literal61_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  forStatement; 
            	}
            	LPAREN62=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_forStatement696); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN62_tree = (CommonTree)adaptor.Create(LPAREN62);
            		adaptor.AddChild(root_0, LPAREN62_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:292:44: (init= forStatementInitialiserPart )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == LBRACK || LA11_0 == LPAREN || (LA11_0 >= NUMBER && LA11_0 <= FALSE) || LA11_0 == 27 || LA11_0 == 32 || (LA11_0 >= 37 && LA11_0 <= 38) || (LA11_0 >= 68 && LA11_0 <= 69) || (LA11_0 >= 73 && LA11_0 <= 78) || LA11_0 == 81) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:292:45: init= forStatementInitialiserPart
            	        {
            	        	PushFollow(FOLLOW_forStatementInitialiserPart_in_forStatement701);
            	        	init = forStatementInitialiserPart();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, init.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   forStatement.InitialisationStatement = ((init != null) ? init.value : null); 
            	        	}

            	        }
            	        break;

            	}

            	char_literal63=(IToken)Match(input,24,FOLLOW_24_in_forStatement710); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal63_tree = (CommonTree)adaptor.Create(char_literal63);
            		adaptor.AddChild(root_0, char_literal63_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:293:8: (condition= expression )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == LBRACK || LA12_0 == LPAREN || (LA12_0 >= NUMBER && LA12_0 <= FALSE) || LA12_0 == 32 || (LA12_0 >= 37 && LA12_0 <= 38) || (LA12_0 >= 68 && LA12_0 <= 69) || (LA12_0 >= 73 && LA12_0 <= 78) || LA12_0 == 81) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:293:9: condition= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forStatement715);
            	        	condition = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, condition.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   forStatement.ConditionExpression = ((condition != null) ? condition.value : null); 
            	        	}

            	        }
            	        break;

            	}

            	char_literal64=(IToken)Match(input,24,FOLLOW_24_in_forStatement725); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal64_tree = (CommonTree)adaptor.Create(char_literal64);
            		adaptor.AddChild(root_0, char_literal64_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:294:8: (increment= expression )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == LBRACK || LA13_0 == LPAREN || (LA13_0 >= NUMBER && LA13_0 <= FALSE) || LA13_0 == 32 || (LA13_0 >= 37 && LA13_0 <= 38) || (LA13_0 >= 68 && LA13_0 <= 69) || (LA13_0 >= 73 && LA13_0 <= 78) || LA13_0 == 81) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:294:9: increment= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forStatement730);
            	        	increment = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, increment.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   forStatement.IncrementExpression = ((increment != null) ? increment.value : null); 
            	        	}

            	        }
            	        break;

            	}

            	RPAREN65=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_forStatement737); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN65_tree = (CommonTree)adaptor.Create(RPAREN65);
            		adaptor.AddChild(root_0, RPAREN65_tree);
            	}
            	PushFollow(FOLLOW_statement_in_forStatement745);
            	instruction = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, instruction.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   forStatement.Statement = ((instruction != null) ? instruction.value : null); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forStatement"

    public class forStatementInitialiserPart_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forStatementInitialiserPart"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:298:1: forStatementInitialiserPart returns [Statement value] : ( ( 'var' )? first= variableDeclarationStatement ( ',' follow= variableDeclarationStatement )* | expression );
    public JavaScriptParser.forStatementInitialiserPart_return forStatementInitialiserPart() // throws RecognitionException [1]
    {   
        JavaScriptParser.forStatementInitialiserPart_return retval = new JavaScriptParser.forStatementInitialiserPart_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal66 = null;
        IToken char_literal67 = null;
        JavaScriptParser.variableDeclarationStatement_return first = null;

        JavaScriptParser.variableDeclarationStatement_return follow = null;

        JavaScriptParser.expression_return expression68 = null;


        CommonTree string_literal66_tree=null;
        CommonTree char_literal67_tree=null;


        VariableDeclarationStatement current = null;
        bool global = true;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:2: ( ( 'var' )? first= variableDeclarationStatement ( ',' follow= variableDeclarationStatement )* | expression )
            int alt16 = 2;
            switch ( input.LA(1) ) 
            {
            case 27:
            	{
                alt16 = 1;
                }
                break;
            case 37:
            	{
                int LA16_2 = input.LA(2);

                if ( (synpred29_JavaScript()) )
                {
                    alt16 = 1;
                }
                else if ( (true) )
                {
                    alt16 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d16s2 =
                        new NoViableAltException("", 16, 2, input);

                    throw nvae_d16s2;
                }
                }
                break;
            case 38:
            	{
                int LA16_3 = input.LA(2);

                if ( (synpred29_JavaScript()) )
                {
                    alt16 = 1;
                }
                else if ( (true) )
                {
                    alt16 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d16s3 =
                        new NoViableAltException("", 16, 3, input);

                    throw nvae_d16s3;
                }
                }
                break;
            case ID:
            	{
                int LA16_4 = input.LA(2);

                if ( (synpred29_JavaScript()) )
                {
                    alt16 = 1;
                }
                else if ( (true) )
                {
                    alt16 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d16s4 =
                        new NoViableAltException("", 16, 4, input);

                    throw nvae_d16s4;
                }
                }
                break;
            case LBRACK:
            case LPAREN:
            case NUMBER:
            case STRING:
            case REGEXP:
            case TRUE:
            case FALSE:
            case 32:
            case 68:
            case 69:
            case 73:
            case 74:
            case 75:
            case 76:
            case 77:
            case 78:
            case 81:
            	{
                alt16 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:4: ( 'var' )? first= variableDeclarationStatement ( ',' follow= variableDeclarationStatement )*
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:4: ( 'var' )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( (LA14_0 == 27) )
                    	{
                    	    alt14 = 1;
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:5: 'var'
                    	        {
                    	        	string_literal66=(IToken)Match(input,27,FOLLOW_27_in_forStatementInitialiserPart769); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal66_tree = (CommonTree)adaptor.Create(string_literal66);
                    	        		adaptor.AddChild(root_0, string_literal66_tree);
                    	        	}
                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	   global = false; 
                    	        	}

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_variableDeclarationStatement_in_forStatementInitialiserPart778);
                    	first = variableDeclarationStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, first.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	    current = first.value; current.Global = false; retval.value =  current; 
                    	}
                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:139: ( ',' follow= variableDeclarationStatement )*
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( (LA15_0 == 28) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:140: ',' follow= variableDeclarationStatement
                    			    {
                    			    	char_literal67=(IToken)Match(input,28,FOLLOW_28_in_forStatementInitialiserPart783); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{char_literal67_tree = (CommonTree)adaptor.Create(char_literal67);
                    			    		adaptor.AddChild(root_0, char_literal67_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_variableDeclarationStatement_in_forStatementInitialiserPart787);
                    			    	follow = variableDeclarationStatement();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, follow.Tree);
                    			    	if ( (state.backtracking==0) )
                    			    	{
                    			    	   current.Next = follow.value; current.Global = false; current = current.Next; 
                    			    	}

                    			    }
                    			    break;

                    			default:
                    			    goto loop15;
                    	    }
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements


                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:305:4: expression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_forStatementInitialiserPart797);
                    	expression68 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression68.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((expression68 != null) ? expression68.value : null); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forStatementInitialiserPart"

    public class forEachInStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forEachInStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:308:1: forEachInStatement returns [Statement value] : 'for' ( 'each' )? LPAREN ( 'var' )? identifier 'in' expression RPAREN statement ;
    public JavaScriptParser.forEachInStatement_return forEachInStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.forEachInStatement_return retval = new JavaScriptParser.forEachInStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal69 = null;
        IToken string_literal70 = null;
        IToken LPAREN71 = null;
        IToken string_literal72 = null;
        IToken string_literal74 = null;
        IToken RPAREN76 = null;
        JavaScriptParser.identifier_return identifier73 = null;

        JavaScriptParser.expression_return expression75 = null;

        JavaScriptParser.statement_return statement77 = null;


        CommonTree string_literal69_tree=null;
        CommonTree string_literal70_tree=null;
        CommonTree LPAREN71_tree=null;
        CommonTree string_literal72_tree=null;
        CommonTree string_literal74_tree=null;
        CommonTree RPAREN76_tree=null;


        bool globalDeclaration = true;
        bool isForEach = false;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:313:2: ( 'for' ( 'each' )? LPAREN ( 'var' )? identifier 'in' expression RPAREN statement )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:313:4: 'for' ( 'each' )? LPAREN ( 'var' )? identifier 'in' expression RPAREN statement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal69=(IToken)Match(input,36,FOLLOW_36_in_forEachInStatement820); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal69_tree = (CommonTree)adaptor.Create(string_literal69);
            		adaptor.AddChild(root_0, string_literal69_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:313:10: ( 'each' )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == 37) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:313:12: 'each'
            	        {
            	        	string_literal70=(IToken)Match(input,37,FOLLOW_37_in_forEachInStatement824); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal70_tree = (CommonTree)adaptor.Create(string_literal70);
            	        		adaptor.AddChild(root_0, string_literal70_tree);
            	        	}
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   isForEach = true; 
            	        	}

            	        }
            	        break;

            	}

            	LPAREN71=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_forEachInStatement832); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN71_tree = (CommonTree)adaptor.Create(LPAREN71);
            		adaptor.AddChild(root_0, LPAREN71_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:313:52: ( 'var' )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == 27) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:313:53: 'var'
            	        {
            	        	string_literal72=(IToken)Match(input,27,FOLLOW_27_in_forEachInStatement835); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal72_tree = (CommonTree)adaptor.Create(string_literal72);
            	        		adaptor.AddChild(root_0, string_literal72_tree);
            	        	}
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   globalDeclaration = false;
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_identifier_in_forEachInStatement842);
            	identifier73 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, identifier73.Tree);
            	string_literal74=(IToken)Match(input,38,FOLLOW_38_in_forEachInStatement844); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal74_tree = (CommonTree)adaptor.Create(string_literal74);
            		adaptor.AddChild(root_0, string_literal74_tree);
            	}
            	PushFollow(FOLLOW_expression_in_forEachInStatement846);
            	expression75 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression75.Tree);
            	RPAREN76=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_forEachInStatement848); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN76_tree = (CommonTree)adaptor.Create(RPAREN76);
            		adaptor.AddChild(root_0, RPAREN76_tree);
            	}
            	PushFollow(FOLLOW_statement_in_forEachInStatement850);
            	statement77 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement77.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new ForEachInStatement(((identifier73 != null) ? identifier73.value : null), ((expression75 != null) ? expression75.value : null), ((statement77 != null) ? statement77.value : null), globalDeclaration, isForEach); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forEachInStatement"

    public class caseClause_return : ParserRuleReturnScope
    {
        public CaseClause value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "caseClause"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:316:1: caseClause returns [CaseClause value] : 'case' expression ':' ( statement )* ;
    public JavaScriptParser.caseClause_return caseClause() // throws RecognitionException [1]
    {   
        JavaScriptParser.caseClause_return retval = new JavaScriptParser.caseClause_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal78 = null;
        IToken char_literal80 = null;
        JavaScriptParser.expression_return expression79 = null;

        JavaScriptParser.statement_return statement81 = null;


        CommonTree string_literal78_tree=null;
        CommonTree char_literal80_tree=null;


        CaseClause caseClause = new CaseClause();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:320:2: ( 'case' expression ':' ( statement )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:320:4: 'case' expression ':' ( statement )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal78=(IToken)Match(input,39,FOLLOW_39_in_caseClause872); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal78_tree = (CommonTree)adaptor.Create(string_literal78);
            		adaptor.AddChild(root_0, string_literal78_tree);
            	}
            	PushFollow(FOLLOW_expression_in_caseClause874);
            	expression79 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression79.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   caseClause.Expression = ((expression79 != null) ? expression79.value : null); 
            	}
            	char_literal80=(IToken)Match(input,40,FOLLOW_40_in_caseClause878); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal80_tree = (CommonTree)adaptor.Create(char_literal80);
            		adaptor.AddChild(root_0, char_literal80_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:320:73: ( statement )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == LBRACK || LA19_0 == LPAREN || (LA19_0 >= NUMBER && LA19_0 <= FALSE) || (LA19_0 >= 24 && LA19_0 <= 27) || LA19_0 == 30 || (LA19_0 >= 32 && LA19_0 <= 38) || LA19_0 == 41 || (LA19_0 >= 43 && LA19_0 <= 44) || (LA19_0 >= 68 && LA19_0 <= 69) || (LA19_0 >= 73 && LA19_0 <= 78) || LA19_0 == 81) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:320:74: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_caseClause881);
            			    	statement81 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement81.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   caseClause.Statements.Add(((statement81 != null) ? statement81.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  caseClause; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "caseClause"

    public class switchStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "switchStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:323:1: switchStatement returns [Statement value] : 'switch' LPAREN expression RPAREN LBRACK (first= caseClause )* (def= defaultClause (last= caseClause )* )? RBRACK ;
    public JavaScriptParser.switchStatement_return switchStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.switchStatement_return retval = new JavaScriptParser.switchStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal82 = null;
        IToken LPAREN83 = null;
        IToken RPAREN85 = null;
        IToken LBRACK86 = null;
        IToken RBRACK87 = null;
        JavaScriptParser.caseClause_return first = null;

        JavaScriptParser.defaultClause_return def = null;

        JavaScriptParser.caseClause_return last = null;

        JavaScriptParser.expression_return expression84 = null;


        CommonTree string_literal82_tree=null;
        CommonTree LPAREN83_tree=null;
        CommonTree RPAREN85_tree=null;
        CommonTree LBRACK86_tree=null;
        CommonTree RBRACK87_tree=null;


        SwitchStatement switchStatement = new SwitchStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:328:2: ( 'switch' LPAREN expression RPAREN LBRACK (first= caseClause )* (def= defaultClause (last= caseClause )* )? RBRACK )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:328:4: 'switch' LPAREN expression RPAREN LBRACK (first= caseClause )* (def= defaultClause (last= caseClause )* )? RBRACK
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal82=(IToken)Match(input,41,FOLLOW_41_in_switchStatement909); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal82_tree = (CommonTree)adaptor.Create(string_literal82);
            		adaptor.AddChild(root_0, string_literal82_tree);
            	}
            	LPAREN83=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_switchStatement911); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN83_tree = (CommonTree)adaptor.Create(LPAREN83);
            		adaptor.AddChild(root_0, LPAREN83_tree);
            	}
            	PushFollow(FOLLOW_expression_in_switchStatement913);
            	expression84 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression84.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   switchStatement.Expression = ((expression84 != null) ? expression84.value : null); 
            	}
            	RPAREN85=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_switchStatement918); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN85_tree = (CommonTree)adaptor.Create(RPAREN85);
            		adaptor.AddChild(root_0, RPAREN85_tree);
            	}
            	LBRACK86=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_switchStatement924); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LBRACK86_tree = (CommonTree)adaptor.Create(LBRACK86);
            		adaptor.AddChild(root_0, LBRACK86_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:329:11: (first= caseClause )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == 39) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:329:12: first= caseClause
            			    {
            			    	PushFollow(FOLLOW_caseClause_in_switchStatement929);
            			    	first = caseClause();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, first.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   switchStatement.CaseClauses.Add(((first != null) ? first.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:330:4: (def= defaultClause (last= caseClause )* )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == 42) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:330:5: def= defaultClause (last= caseClause )*
            	        {
            	        	PushFollow(FOLLOW_defaultClause_in_switchStatement942);
            	        	def = defaultClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, def.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   switchStatement.DefaultStatements.AddRange(((def != null) ? def.value : null)); 
            	        	}
            	        	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:330:83: (last= caseClause )*
            	        	do 
            	        	{
            	        	    int alt21 = 2;
            	        	    int LA21_0 = input.LA(1);

            	        	    if ( (LA21_0 == 39) )
            	        	    {
            	        	        alt21 = 1;
            	        	    }


            	        	    switch (alt21) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:330:84: last= caseClause
            	        			    {
            	        			    	PushFollow(FOLLOW_caseClause_in_switchStatement949);
            	        			    	last = caseClause();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, last.Tree);
            	        			    	if ( (state.backtracking==0) )
            	        			    	{
            	        			    	   switchStatement.CaseClauses.Add(((last != null) ? last.value : null)); 
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop21;
            	        	    }
            	        	} while (true);

            	        	loop21:
            	        		;	// Stops C# compiler whining that label 'loop21' has no statements


            	        }
            	        break;

            	}

            	RBRACK87=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_switchStatement957); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RBRACK87_tree = (CommonTree)adaptor.Create(RBRACK87);
            		adaptor.AddChild(root_0, RBRACK87_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  switchStatement; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "switchStatement"

    public class defaultClause_return : ParserRuleReturnScope
    {
        public List<Statement> value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "defaultClause"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:333:1: defaultClause returns [List<Statement> value] : 'default' ':' ( statement )* ;
    public JavaScriptParser.defaultClause_return defaultClause() // throws RecognitionException [1]
    {   
        JavaScriptParser.defaultClause_return retval = new JavaScriptParser.defaultClause_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal88 = null;
        IToken char_literal89 = null;
        JavaScriptParser.statement_return statement90 = null;


        CommonTree string_literal88_tree=null;
        CommonTree char_literal89_tree=null;


        List<Statement> statements = new List<Statement>();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:337:2: ( 'default' ':' ( statement )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:337:4: 'default' ':' ( statement )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal88=(IToken)Match(input,42,FOLLOW_42_in_defaultClause980); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal88_tree = (CommonTree)adaptor.Create(string_literal88);
            		adaptor.AddChild(root_0, string_literal88_tree);
            	}
            	char_literal89=(IToken)Match(input,40,FOLLOW_40_in_defaultClause982); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal89_tree = (CommonTree)adaptor.Create(char_literal89);
            		adaptor.AddChild(root_0, char_literal89_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:337:18: ( statement )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == LBRACK || LA23_0 == LPAREN || (LA23_0 >= NUMBER && LA23_0 <= FALSE) || (LA23_0 >= 24 && LA23_0 <= 27) || LA23_0 == 30 || (LA23_0 >= 32 && LA23_0 <= 38) || LA23_0 == 41 || (LA23_0 >= 43 && LA23_0 <= 44) || (LA23_0 >= 68 && LA23_0 <= 69) || (LA23_0 >= 73 && LA23_0 <= 78) || LA23_0 == 81) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:337:19: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_defaultClause985);
            			    	statement90 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement90.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   statements.Add(((statement90 != null) ? statement90.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  statements; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defaultClause"

    public class throwStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "throwStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:340:1: throwStatement returns [Statement value] : 'throw' ( expression )? ';' ;
    public JavaScriptParser.throwStatement_return throwStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.throwStatement_return retval = new JavaScriptParser.throwStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal91 = null;
        IToken char_literal93 = null;
        JavaScriptParser.expression_return expression92 = null;


        CommonTree string_literal91_tree=null;
        CommonTree char_literal93_tree=null;


        Expression thrown = null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:344:2: ( 'throw' ( expression )? ';' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:344:4: 'throw' ( expression )? ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal91=(IToken)Match(input,43,FOLLOW_43_in_throwStatement1012); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal91_tree = (CommonTree)adaptor.Create(string_literal91);
            		adaptor.AddChild(root_0, string_literal91_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:344:12: ( expression )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( (LA24_0 == LBRACK || LA24_0 == LPAREN || (LA24_0 >= NUMBER && LA24_0 <= FALSE) || LA24_0 == 32 || (LA24_0 >= 37 && LA24_0 <= 38) || (LA24_0 >= 68 && LA24_0 <= 69) || (LA24_0 >= 73 && LA24_0 <= 78) || LA24_0 == 81) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:344:13: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_throwStatement1015);
            	        	expression92 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression92.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   thrown = ((expression92 != null) ? expression92.value : null); 
            	        	}

            	        }
            	        break;

            	}

            	char_literal93=(IToken)Match(input,24,FOLLOW_24_in_throwStatement1022); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal93_tree = (CommonTree)adaptor.Create(char_literal93);
            		adaptor.AddChild(root_0, char_literal93_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new ThrowStatement(thrown); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "throwStatement"

    public class tryStatement_return : ParserRuleReturnScope
    {
        public Statement value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tryStatement"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:347:1: tryStatement returns [Statement value] : 'try' blockStatement catchClause ( finallyClause )? ;
    public JavaScriptParser.tryStatement_return tryStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.tryStatement_return retval = new JavaScriptParser.tryStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal94 = null;
        JavaScriptParser.blockStatement_return blockStatement95 = null;

        JavaScriptParser.catchClause_return catchClause96 = null;

        JavaScriptParser.finallyClause_return finallyClause97 = null;


        CommonTree string_literal94_tree=null;


        TryStatement tryStatement = new TryStatement();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:351:2: ( 'try' blockStatement catchClause ( finallyClause )? )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:351:4: 'try' blockStatement catchClause ( finallyClause )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal94=(IToken)Match(input,44,FOLLOW_44_in_tryStatement1043); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal94_tree = (CommonTree)adaptor.Create(string_literal94);
            		adaptor.AddChild(root_0, string_literal94_tree);
            	}
            	PushFollow(FOLLOW_blockStatement_in_tryStatement1045);
            	blockStatement95 = blockStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement95.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   tryStatement.Statement = ((blockStatement95 != null) ? blockStatement95.value : null); 
            	}
            	PushFollow(FOLLOW_catchClause_in_tryStatement1049);
            	catchClause96 = catchClause();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, catchClause96.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   tryStatement.Catch = ((catchClause96 != null) ? catchClause96.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:351:134: ( finallyClause )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == 46) )
            	{
            	    alt25 = 1;
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:351:136: finallyClause
            	        {
            	        	PushFollow(FOLLOW_finallyClause_in_tryStatement1055);
            	        	finallyClause97 = finallyClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, finallyClause97.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   tryStatement.Finally = ((finallyClause97 != null) ? finallyClause97.value : null); 
            	        	}

            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  tryStatement; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tryStatement"

    public class catchClause_return : ParserRuleReturnScope
    {
        public CatchClause value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "catchClause"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:354:1: catchClause returns [CatchClause value] : 'catch' ( LPAREN identifier RPAREN )? blockStatement ;
    public JavaScriptParser.catchClause_return catchClause() // throws RecognitionException [1]
    {   
        JavaScriptParser.catchClause_return retval = new JavaScriptParser.catchClause_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal98 = null;
        IToken LPAREN99 = null;
        IToken RPAREN101 = null;
        JavaScriptParser.identifier_return identifier100 = null;

        JavaScriptParser.blockStatement_return blockStatement102 = null;


        CommonTree string_literal98_tree=null;
        CommonTree LPAREN99_tree=null;
        CommonTree RPAREN101_tree=null;


        Identifier ident = null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:358:2: ( 'catch' ( LPAREN identifier RPAREN )? blockStatement )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:358:4: 'catch' ( LPAREN identifier RPAREN )? blockStatement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal98=(IToken)Match(input,45,FOLLOW_45_in_catchClause1089); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal98_tree = (CommonTree)adaptor.Create(string_literal98);
            		adaptor.AddChild(root_0, string_literal98_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:358:12: ( LPAREN identifier RPAREN )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == LPAREN) )
            	{
            	    alt26 = 1;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:358:13: LPAREN identifier RPAREN
            	        {
            	        	LPAREN99=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_catchClause1092); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LPAREN99_tree = (CommonTree)adaptor.Create(LPAREN99);
            	        		adaptor.AddChild(root_0, LPAREN99_tree);
            	        	}
            	        	PushFollow(FOLLOW_identifier_in_catchClause1094);
            	        	identifier100 = identifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, identifier100.Tree);
            	        	RPAREN101=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_catchClause1096); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{RPAREN101_tree = (CommonTree)adaptor.Create(RPAREN101);
            	        		adaptor.AddChild(root_0, RPAREN101_tree);
            	        	}
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   ident = ((identifier100 != null) ? identifier100.value : null); 
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_blockStatement_in_catchClause1103);
            	blockStatement102 = blockStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement102.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new CatchClause(ident, ((blockStatement102 != null) ? blockStatement102.value : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "catchClause"

    public class finallyClause_return : ParserRuleReturnScope
    {
        public FinallyClause value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "finallyClause"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:361:1: finallyClause returns [FinallyClause value] : 'finally' blockStatement ;
    public JavaScriptParser.finallyClause_return finallyClause() // throws RecognitionException [1]
    {   
        JavaScriptParser.finallyClause_return retval = new JavaScriptParser.finallyClause_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal103 = null;
        JavaScriptParser.blockStatement_return blockStatement104 = null;


        CommonTree string_literal103_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:362:2: ( 'finally' blockStatement )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:362:4: 'finally' blockStatement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal103=(IToken)Match(input,46,FOLLOW_46_in_finallyClause1121); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal103_tree = (CommonTree)adaptor.Create(string_literal103);
            		adaptor.AddChild(root_0, string_literal103_tree);
            	}
            	PushFollow(FOLLOW_blockStatement_in_finallyClause1123);
            	blockStatement104 = blockStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement104.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new FinallyClause(((blockStatement104 != null) ? blockStatement104.value : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "finallyClause"

    public class arguments_return : ParserRuleReturnScope
    {
        public List<Expression> value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arguments"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:365:1: arguments returns [List<Expression> value] : LPAREN (first= expression ( ',' follow= expression )* )? RPAREN ;
    public JavaScriptParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        JavaScriptParser.arguments_return retval = new JavaScriptParser.arguments_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LPAREN105 = null;
        IToken char_literal106 = null;
        IToken RPAREN107 = null;
        JavaScriptParser.expression_return first = null;

        JavaScriptParser.expression_return follow = null;


        CommonTree LPAREN105_tree=null;
        CommonTree char_literal106_tree=null;
        CommonTree RPAREN107_tree=null;


        List<Expression> arguments = new List<Expression>();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:369:2: ( LPAREN (first= expression ( ',' follow= expression )* )? RPAREN )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:369:4: LPAREN (first= expression ( ',' follow= expression )* )? RPAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LPAREN105=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_arguments1147); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN105_tree = (CommonTree)adaptor.Create(LPAREN105);
            		adaptor.AddChild(root_0, LPAREN105_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:369:11: (first= expression ( ',' follow= expression )* )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == LBRACK || LA28_0 == LPAREN || (LA28_0 >= NUMBER && LA28_0 <= FALSE) || LA28_0 == 32 || (LA28_0 >= 37 && LA28_0 <= 38) || (LA28_0 >= 68 && LA28_0 <= 69) || (LA28_0 >= 73 && LA28_0 <= 78) || LA28_0 == 81) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:369:12: first= expression ( ',' follow= expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_arguments1152);
            	        	first = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, first.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   arguments.Add(((first != null) ? first.value : null)); 
            	        	}
            	        	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:369:62: ( ',' follow= expression )*
            	        	do 
            	        	{
            	        	    int alt27 = 2;
            	        	    int LA27_0 = input.LA(1);

            	        	    if ( (LA27_0 == 28) )
            	        	    {
            	        	        alt27 = 1;
            	        	    }


            	        	    switch (alt27) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:369:63: ',' follow= expression
            	        			    {
            	        			    	char_literal106=(IToken)Match(input,28,FOLLOW_28_in_arguments1157); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{char_literal106_tree = (CommonTree)adaptor.Create(char_literal106);
            	        			    		adaptor.AddChild(root_0, char_literal106_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_expression_in_arguments1161);
            	        			    	follow = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, follow.Tree);
            	        			    	if ( (state.backtracking==0) )
            	        			    	{
            	        			    	   arguments.Add(((follow != null) ? follow.value : null)); 
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop27;
            	        	    }
            	        	} while (true);

            	        	loop27:
            	        		;	// Stops C# compiler whining that label 'loop27' has no statements


            	        }
            	        break;

            	}

            	RPAREN107=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_arguments1170); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN107_tree = (CommonTree)adaptor.Create(RPAREN107);
            		adaptor.AddChild(root_0, RPAREN107_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  arguments; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arguments"

    public class expression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:372:1: expression returns [Expression value] : left= ternaryExpression ( ( '=' ass= expression | '+=' ass= expression | '-=' ass= expression | '*=' ass= expression | '/=' ass= expression | '>>=' ass= expression | '<<=' ass= expression | '>>>=' ass= expression | '&=' ass= expression | '|=' ass= expression | '^=' ass= expression ) )? ;
    public JavaScriptParser.expression_return expression() // throws RecognitionException [1]
    {   
        JavaScriptParser.expression_return retval = new JavaScriptParser.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal108 = null;
        IToken string_literal109 = null;
        IToken string_literal110 = null;
        IToken string_literal111 = null;
        IToken string_literal112 = null;
        IToken string_literal113 = null;
        IToken string_literal114 = null;
        IToken string_literal115 = null;
        IToken string_literal116 = null;
        IToken string_literal117 = null;
        IToken string_literal118 = null;
        JavaScriptParser.ternaryExpression_return left = null;

        JavaScriptParser.expression_return ass = null;


        CommonTree char_literal108_tree=null;
        CommonTree string_literal109_tree=null;
        CommonTree string_literal110_tree=null;
        CommonTree string_literal111_tree=null;
        CommonTree string_literal112_tree=null;
        CommonTree string_literal113_tree=null;
        CommonTree string_literal114_tree=null;
        CommonTree string_literal115_tree=null;
        CommonTree string_literal116_tree=null;
        CommonTree string_literal117_tree=null;
        CommonTree string_literal118_tree=null;


        	Expression right = null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:381:2: (left= ternaryExpression ( ( '=' ass= expression | '+=' ass= expression | '-=' ass= expression | '*=' ass= expression | '/=' ass= expression | '>>=' ass= expression | '<<=' ass= expression | '>>>=' ass= expression | '&=' ass= expression | '|=' ass= expression | '^=' ass= expression ) )? )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:381:4: left= ternaryExpression ( ( '=' ass= expression | '+=' ass= expression | '-=' ass= expression | '*=' ass= expression | '/=' ass= expression | '>>=' ass= expression | '<<=' ass= expression | '>>>=' ass= expression | '&=' ass= expression | '|=' ass= expression | '^=' ass= expression ) )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_ternaryExpression_in_expression1198);
            	left = ternaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, left.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((left != null) ? left.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:382:3: ( ( '=' ass= expression | '+=' ass= expression | '-=' ass= expression | '*=' ass= expression | '/=' ass= expression | '>>=' ass= expression | '<<=' ass= expression | '>>>=' ass= expression | '&=' ass= expression | '|=' ass= expression | '^=' ass= expression ) )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == 29 || (LA30_0 >= 47 && LA30_0 <= 56)) )
            	{
            	    alt30 = 1;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:383:4: ( '=' ass= expression | '+=' ass= expression | '-=' ass= expression | '*=' ass= expression | '/=' ass= expression | '>>=' ass= expression | '<<=' ass= expression | '>>>=' ass= expression | '&=' ass= expression | '|=' ass= expression | '^=' ass= expression )
            	        {
            	        	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:383:4: ( '=' ass= expression | '+=' ass= expression | '-=' ass= expression | '*=' ass= expression | '/=' ass= expression | '>>=' ass= expression | '<<=' ass= expression | '>>>=' ass= expression | '&=' ass= expression | '|=' ass= expression | '^=' ass= expression )
            	        	int alt29 = 11;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case 29:
            	        		{
            	        	    alt29 = 1;
            	        	    }
            	        	    break;
            	        	case 47:
            	        		{
            	        	    alt29 = 2;
            	        	    }
            	        	    break;
            	        	case 48:
            	        		{
            	        	    alt29 = 3;
            	        	    }
            	        	    break;
            	        	case 49:
            	        		{
            	        	    alt29 = 4;
            	        	    }
            	        	    break;
            	        	case 50:
            	        		{
            	        	    alt29 = 5;
            	        	    }
            	        	    break;
            	        	case 51:
            	        		{
            	        	    alt29 = 6;
            	        	    }
            	        	    break;
            	        	case 52:
            	        		{
            	        	    alt29 = 7;
            	        	    }
            	        	    break;
            	        	case 53:
            	        		{
            	        	    alt29 = 8;
            	        	    }
            	        	    break;
            	        	case 54:
            	        		{
            	        	    alt29 = 9;
            	        	    }
            	        	    break;
            	        	case 55:
            	        		{
            	        	    alt29 = 10;
            	        	    }
            	        	    break;
            	        	case 56:
            	        		{
            	        	    alt29 = 11;
            	        	    }
            	        	    break;
            	        		default:
            	        		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        		    NoViableAltException nvae_d29s0 =
            	        		        new NoViableAltException("", 29, 0, input);

            	        		    throw nvae_d29s0;
            	        	}

            	        	switch (alt29) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:384:8: '=' ass= expression
            	        	        {
            	        	        	char_literal108=(IToken)Match(input,29,FOLLOW_29_in_expression1222); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal108_tree = (CommonTree)adaptor.Create(char_literal108);
            	        	        		adaptor.AddChild(root_0, char_literal108_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1226);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   right = ass.value; 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:385:6: '+=' ass= expression
            	        	        {
            	        	        	string_literal109=(IToken)Match(input,47,FOLLOW_47_in_expression1235); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal109_tree = (CommonTree)adaptor.Create(string_literal109);
            	        	        		adaptor.AddChild(root_0, string_literal109_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1239);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   right = new BinaryExpression( BinaryExpressionType.Plus, left.value, ass.value); 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:386:6: '-=' ass= expression
            	        	        {
            	        	        	string_literal110=(IToken)Match(input,48,FOLLOW_48_in_expression1248); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal110_tree = (CommonTree)adaptor.Create(string_literal110);
            	        	        		adaptor.AddChild(root_0, string_literal110_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1252);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   right = new BinaryExpression( BinaryExpressionType.Minus, left.value, ass.value); 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 4 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:387:6: '*=' ass= expression
            	        	        {
            	        	        	string_literal111=(IToken)Match(input,49,FOLLOW_49_in_expression1261); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal111_tree = (CommonTree)adaptor.Create(string_literal111);
            	        	        		adaptor.AddChild(root_0, string_literal111_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1265);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   right = new BinaryExpression( BinaryExpressionType.Times, left.value, ass.value); 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 5 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:388:6: '/=' ass= expression
            	        	        {
            	        	        	string_literal112=(IToken)Match(input,50,FOLLOW_50_in_expression1274); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal112_tree = (CommonTree)adaptor.Create(string_literal112);
            	        	        		adaptor.AddChild(root_0, string_literal112_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1278);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   right = new BinaryExpression( BinaryExpressionType.Div, left.value, ass.value); 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 6 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:389:6: '>>=' ass= expression
            	        	        {
            	        	        	string_literal113=(IToken)Match(input,51,FOLLOW_51_in_expression1287); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal113_tree = (CommonTree)adaptor.Create(string_literal113);
            	        	        		adaptor.AddChild(root_0, string_literal113_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1291);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   throw new NotImplementedException(">>="); 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 7 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:390:6: '<<=' ass= expression
            	        	        {
            	        	        	string_literal114=(IToken)Match(input,52,FOLLOW_52_in_expression1300); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal114_tree = (CommonTree)adaptor.Create(string_literal114);
            	        	        		adaptor.AddChild(root_0, string_literal114_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1304);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   throw new NotImplementedException(">>="); 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 8 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:391:6: '>>>=' ass= expression
            	        	        {
            	        	        	string_literal115=(IToken)Match(input,53,FOLLOW_53_in_expression1313); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal115_tree = (CommonTree)adaptor.Create(string_literal115);
            	        	        		adaptor.AddChild(root_0, string_literal115_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1317);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   throw new NotImplementedException(">>="); 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 9 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:392:6: '&=' ass= expression
            	        	        {
            	        	        	string_literal116=(IToken)Match(input,54,FOLLOW_54_in_expression1326); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal116_tree = (CommonTree)adaptor.Create(string_literal116);
            	        	        		adaptor.AddChild(root_0, string_literal116_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1330);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   right = new BinaryExpression( BinaryExpressionType.And, left.value, ass.value); 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 10 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:393:6: '|=' ass= expression
            	        	        {
            	        	        	string_literal117=(IToken)Match(input,55,FOLLOW_55_in_expression1339); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal117_tree = (CommonTree)adaptor.Create(string_literal117);
            	        	        		adaptor.AddChild(root_0, string_literal117_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1343);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   right = new BinaryExpression( BinaryExpressionType.Or, left.value, ass.value); 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 11 :
            	        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:394:6: '^=' ass= expression
            	        	        {
            	        	        	string_literal118=(IToken)Match(input,56,FOLLOW_56_in_expression1352); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{string_literal118_tree = (CommonTree)adaptor.Create(string_literal118);
            	        	        		adaptor.AddChild(root_0, string_literal118_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_expression_in_expression1356);
            	        	        	ass = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ass.Tree);
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   throw new NotImplementedException(">>="); 
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   AssignmentExpression s = new AssignmentExpression(); s.Left = ((left != null) ? left.value : null) as MemberExpression; s.Right = right; retval.value =  s; 
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
            if ( (state.backtracking==0) )
            {

              retval.value.Start = GetStartFileLocation((CommonToken)retval.Start);
              retval.value.Stop = ((CommonToken)retval.Stop);

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class ternaryExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ternaryExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:401:2: ternaryExpression returns [Expression value] : left= booleanOrExpression ( '?' middle= ternaryExpression ':' right= ternaryExpression )? ;
    public JavaScriptParser.ternaryExpression_return ternaryExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.ternaryExpression_return retval = new JavaScriptParser.ternaryExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal119 = null;
        IToken char_literal120 = null;
        JavaScriptParser.booleanOrExpression_return left = null;

        JavaScriptParser.ternaryExpression_return middle = null;

        JavaScriptParser.ternaryExpression_return right = null;


        CommonTree char_literal119_tree=null;
        CommonTree char_literal120_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:402:2: (left= booleanOrExpression ( '?' middle= ternaryExpression ':' right= ternaryExpression )? )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:402:4: left= booleanOrExpression ( '?' middle= ternaryExpression ':' right= ternaryExpression )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_booleanOrExpression_in_ternaryExpression1398);
            	left = booleanOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, left.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  left.value; 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:402:54: ( '?' middle= ternaryExpression ':' right= ternaryExpression )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == 57) )
            	{
            	    alt31 = 1;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:402:56: '?' middle= ternaryExpression ':' right= ternaryExpression
            	        {
            	        	char_literal119=(IToken)Match(input,57,FOLLOW_57_in_ternaryExpression1404); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal119_tree = (CommonTree)adaptor.Create(char_literal119);
            	        		adaptor.AddChild(root_0, char_literal119_tree);
            	        	}
            	        	PushFollow(FOLLOW_ternaryExpression_in_ternaryExpression1408);
            	        	middle = ternaryExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, middle.Tree);
            	        	char_literal120=(IToken)Match(input,40,FOLLOW_40_in_ternaryExpression1410); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal120_tree = (CommonTree)adaptor.Create(char_literal120);
            	        		adaptor.AddChild(root_0, char_literal120_tree);
            	        	}
            	        	PushFollow(FOLLOW_ternaryExpression_in_ternaryExpression1414);
            	        	right = ternaryExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, right.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   retval.value =  new TernaryExpression(left.value, middle.value, right.value); 
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ternaryExpression"

    public class booleanOrExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "booleanOrExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:406:1: booleanOrExpression returns [Expression value] : left= booleanAndExpression ( '||' right= booleanAndExpression )* ;
    public JavaScriptParser.booleanOrExpression_return booleanOrExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.booleanOrExpression_return retval = new JavaScriptParser.booleanOrExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal121 = null;
        JavaScriptParser.booleanAndExpression_return left = null;

        JavaScriptParser.booleanAndExpression_return right = null;


        CommonTree string_literal121_tree=null;


        BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:410:2: (left= booleanAndExpression ( '||' right= booleanAndExpression )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:410:4: left= booleanAndExpression ( '||' right= booleanAndExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_booleanAndExpression_in_booleanOrExpression1444);
            	left = booleanAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, left.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((left != null) ? left.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:410:56: ( '||' right= booleanAndExpression )*
            	do 
            	{
            	    int alt32 = 2;
            	    int LA32_0 = input.LA(1);

            	    if ( (LA32_0 == 58) )
            	    {
            	        alt32 = 1;
            	    }


            	    switch (alt32) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:411:4: '||' right= booleanAndExpression
            			    {
            			    	string_literal121=(IToken)Match(input,58,FOLLOW_58_in_booleanOrExpression1453); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal121_tree = (CommonTree)adaptor.Create(string_literal121);
            			    		adaptor.AddChild(root_0, string_literal121_tree);
            			    	}
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   type = BinaryExpressionType.Or; 
            			    	}
            			    	PushFollow(FOLLOW_booleanAndExpression_in_booleanOrExpression1463);
            			    	right = booleanAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, right.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new BinaryExpression(type, retval.value, ((right != null) ? right.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop32;
            	    }
            	} while (true);

            	loop32:
            		;	// Stops C# compiler whining that label 'loop32' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "booleanOrExpression"

    public class booleanAndExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "booleanAndExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:416:1: booleanAndExpression returns [Expression value] : left= equalityExpression ( '&&' right= booleanAndExpression )* ;
    public JavaScriptParser.booleanAndExpression_return booleanAndExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.booleanAndExpression_return retval = new JavaScriptParser.booleanAndExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal122 = null;
        JavaScriptParser.equalityExpression_return left = null;

        JavaScriptParser.booleanAndExpression_return right = null;


        CommonTree string_literal122_tree=null;


        BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:420:2: (left= equalityExpression ( '&&' right= booleanAndExpression )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:420:4: left= equalityExpression ( '&&' right= booleanAndExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_booleanAndExpression1497);
            	left = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, left.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((left != null) ? left.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:420:54: ( '&&' right= booleanAndExpression )*
            	do 
            	{
            	    int alt33 = 2;
            	    int LA33_0 = input.LA(1);

            	    if ( (LA33_0 == 59) )
            	    {
            	        int LA33_2 = input.LA(2);

            	        if ( (synpred55_JavaScript()) )
            	        {
            	            alt33 = 1;
            	        }


            	    }


            	    switch (alt33) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:421:4: '&&' right= booleanAndExpression
            			    {
            			    	string_literal122=(IToken)Match(input,59,FOLLOW_59_in_booleanAndExpression1506); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal122_tree = (CommonTree)adaptor.Create(string_literal122);
            			    		adaptor.AddChild(root_0, string_literal122_tree);
            			    	}
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   type = BinaryExpressionType.And; 
            			    	}
            			    	PushFollow(FOLLOW_booleanAndExpression_in_booleanAndExpression1516);
            			    	right = booleanAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, right.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new BinaryExpression(type, retval.value, ((right != null) ? right.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop33;
            	    }
            	} while (true);

            	loop33:
            		;	// Stops C# compiler whining that label 'loop33' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "booleanAndExpression"

    public class equalityExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "equalityExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:426:1: equalityExpression returns [Expression value] : left= relationalExpression ( ( ( '==' | '===' ) | ( '!=' | '!==' ) ) right= relationalExpression )* ;
    public JavaScriptParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.equalityExpression_return retval = new JavaScriptParser.equalityExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set123 = null;
        IToken set124 = null;
        JavaScriptParser.relationalExpression_return left = null;

        JavaScriptParser.relationalExpression_return right = null;


        CommonTree set123_tree=null;
        CommonTree set124_tree=null;


        BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:430:2: (left= relationalExpression ( ( ( '==' | '===' ) | ( '!=' | '!==' ) ) right= relationalExpression )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:430:4: left= relationalExpression ( ( ( '==' | '===' ) | ( '!=' | '!==' ) ) right= relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1548);
            	left = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, left.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((left != null) ? left.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:430:56: ( ( ( '==' | '===' ) | ( '!=' | '!==' ) ) right= relationalExpression )*
            	do 
            	{
            	    int alt35 = 2;
            	    int LA35_0 = input.LA(1);

            	    if ( ((LA35_0 >= 60 && LA35_0 <= 63)) )
            	    {
            	        alt35 = 1;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:431:4: ( ( '==' | '===' ) | ( '!=' | '!==' ) ) right= relationalExpression
            			    {
            			    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:431:4: ( ( '==' | '===' ) | ( '!=' | '!==' ) )
            			    	int alt34 = 2;
            			    	int LA34_0 = input.LA(1);

            			    	if ( ((LA34_0 >= 60 && LA34_0 <= 61)) )
            			    	{
            			    	    alt34 = 1;
            			    	}
            			    	else if ( ((LA34_0 >= 62 && LA34_0 <= 63)) )
            			    	{
            			    	    alt34 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    NoViableAltException nvae_d34s0 =
            			    	        new NoViableAltException("", 34, 0, input);

            			    	    throw nvae_d34s0;
            			    	}
            			    	switch (alt34) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:432:4: ( '==' | '===' )
            			    	        {
            			    	        	set123 = (IToken)input.LT(1);
            			    	        	if ( (input.LA(1) >= 60 && input.LA(1) <= 61) ) 
            			    	        	{
            			    	        	    input.Consume();
            			    	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set123));
            			    	        	    state.errorRecovery = false;state.failed = false;
            			    	        	}
            			    	        	else 
            			    	        	{
            			    	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	        	    throw mse;
            			    	        	}

            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.Equal; 
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:433:6: ( '!=' | '!==' )
            			    	        {
            			    	        	set124 = (IToken)input.LT(1);
            			    	        	if ( (input.LA(1) >= 62 && input.LA(1) <= 63) ) 
            			    	        	{
            			    	        	    input.Consume();
            			    	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set124));
            			    	        	    state.errorRecovery = false;state.failed = false;
            			    	        	}
            			    	        	else 
            			    	        	{
            			    	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	        	    throw mse;
            			    	        	}

            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.NotEqual; 
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1597);
            			    	right = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, right.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new BinaryExpression(type, retval.value, ((right != null) ? right.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "equalityExpression"

    public class relationalExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relationalExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:438:1: relationalExpression returns [Expression value] : left= additiveExpression ( ( '<' | '<=' | '>' | '>=' ) right= relationalExpression )* ;
    public JavaScriptParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.relationalExpression_return retval = new JavaScriptParser.relationalExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal125 = null;
        IToken string_literal126 = null;
        IToken char_literal127 = null;
        IToken string_literal128 = null;
        JavaScriptParser.additiveExpression_return left = null;

        JavaScriptParser.relationalExpression_return right = null;


        CommonTree char_literal125_tree=null;
        CommonTree string_literal126_tree=null;
        CommonTree char_literal127_tree=null;
        CommonTree string_literal128_tree=null;


        BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:442:2: (left= additiveExpression ( ( '<' | '<=' | '>' | '>=' ) right= relationalExpression )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:442:4: left= additiveExpression ( ( '<' | '<=' | '>' | '>=' ) right= relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1630);
            	left = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, left.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((left != null) ? left.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:442:54: ( ( '<' | '<=' | '>' | '>=' ) right= relationalExpression )*
            	do 
            	{
            	    int alt37 = 2;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 64:
            	    	{
            	        int LA37_2 = input.LA(2);

            	        if ( (synpred63_JavaScript()) )
            	        {
            	            alt37 = 1;
            	        }


            	        }
            	        break;
            	    case 65:
            	    	{
            	        int LA37_3 = input.LA(2);

            	        if ( (synpred63_JavaScript()) )
            	        {
            	            alt37 = 1;
            	        }


            	        }
            	        break;
            	    case 66:
            	    	{
            	        int LA37_4 = input.LA(2);

            	        if ( (synpred63_JavaScript()) )
            	        {
            	            alt37 = 1;
            	        }


            	        }
            	        break;
            	    case 67:
            	    	{
            	        int LA37_5 = input.LA(2);

            	        if ( (synpred63_JavaScript()) )
            	        {
            	            alt37 = 1;
            	        }


            	        }
            	        break;

            	    }

            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:443:4: ( '<' | '<=' | '>' | '>=' ) right= relationalExpression
            			    {
            			    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:443:4: ( '<' | '<=' | '>' | '>=' )
            			    	int alt36 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 64:
            			    		{
            			    	    alt36 = 1;
            			    	    }
            			    	    break;
            			    	case 65:
            			    		{
            			    	    alt36 = 2;
            			    	    }
            			    	    break;
            			    	case 66:
            			    		{
            			    	    alt36 = 3;
            			    	    }
            			    	    break;
            			    	case 67:
            			    		{
            			    	    alt36 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d36s0 =
            			    		        new NoViableAltException("", 36, 0, input);

            			    		    throw nvae_d36s0;
            			    	}

            			    	switch (alt36) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:443:6: '<'
            			    	        {
            			    	        	char_literal125=(IToken)Match(input,64,FOLLOW_64_in_relationalExpression1641); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal125_tree = (CommonTree)adaptor.Create(char_literal125);
            			    	        		adaptor.AddChild(root_0, char_literal125_tree);
            			    	        	}
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.Lesser; 
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:444:6: '<='
            			    	        {
            			    	        	string_literal126=(IToken)Match(input,65,FOLLOW_65_in_relationalExpression1651); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal126_tree = (CommonTree)adaptor.Create(string_literal126);
            			    	        		adaptor.AddChild(root_0, string_literal126_tree);
            			    	        	}
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.LesserOrEqual; 
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:445:6: '>'
            			    	        {
            			    	        	char_literal127=(IToken)Match(input,66,FOLLOW_66_in_relationalExpression1662); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal127_tree = (CommonTree)adaptor.Create(char_literal127);
            			    	        		adaptor.AddChild(root_0, char_literal127_tree);
            			    	        	}
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.Greater; 
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:446:6: '>='
            			    	        {
            			    	        	string_literal128=(IToken)Match(input,67,FOLLOW_67_in_relationalExpression1672); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal128_tree = (CommonTree)adaptor.Create(string_literal128);
            			    	        		adaptor.AddChild(root_0, string_literal128_tree);
            			    	        	}
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.GreaterOrEqual; 
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_relationalExpression1684);
            			    	right = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, right.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new BinaryExpression(type, retval.value, ((right != null) ? right.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relationalExpression"

    public class additiveExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:451:1: additiveExpression returns [Expression value] : left= multiplicativeExpression ( ( '+' | '-' ) right= additiveExpression )* ;
    public JavaScriptParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.additiveExpression_return retval = new JavaScriptParser.additiveExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal129 = null;
        IToken char_literal130 = null;
        JavaScriptParser.multiplicativeExpression_return left = null;

        JavaScriptParser.additiveExpression_return right = null;


        CommonTree char_literal129_tree=null;
        CommonTree char_literal130_tree=null;


        BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:455:2: (left= multiplicativeExpression ( ( '+' | '-' ) right= additiveExpression )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:455:4: left= multiplicativeExpression ( ( '+' | '-' ) right= additiveExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1716);
            	left = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, left.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((left != null) ? left.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:455:60: ( ( '+' | '-' ) right= additiveExpression )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == 68) )
            	    {
            	        int LA39_2 = input.LA(2);

            	        if ( (synpred65_JavaScript()) )
            	        {
            	            alt39 = 1;
            	        }


            	    }
            	    else if ( (LA39_0 == 69) )
            	    {
            	        int LA39_3 = input.LA(2);

            	        if ( (synpred65_JavaScript()) )
            	        {
            	            alt39 = 1;
            	        }


            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:456:4: ( '+' | '-' ) right= additiveExpression
            			    {
            			    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:456:4: ( '+' | '-' )
            			    	int alt38 = 2;
            			    	int LA38_0 = input.LA(1);

            			    	if ( (LA38_0 == 68) )
            			    	{
            			    	    alt38 = 1;
            			    	}
            			    	else if ( (LA38_0 == 69) )
            			    	{
            			    	    alt38 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    NoViableAltException nvae_d38s0 =
            			    	        new NoViableAltException("", 38, 0, input);

            			    	    throw nvae_d38s0;
            			    	}
            			    	switch (alt38) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:456:6: '+'
            			    	        {
            			    	        	char_literal129=(IToken)Match(input,68,FOLLOW_68_in_additiveExpression1727); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal129_tree = (CommonTree)adaptor.Create(char_literal129);
            			    	        		adaptor.AddChild(root_0, char_literal129_tree);
            			    	        	}
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.Plus; 
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:457:6: '-'
            			    	        {
            			    	        	char_literal130=(IToken)Match(input,69,FOLLOW_69_in_additiveExpression1737); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal130_tree = (CommonTree)adaptor.Create(char_literal130);
            			    	        		adaptor.AddChild(root_0, char_literal130_tree);
            			    	        	}
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.Minus; 
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_additiveExpression1749);
            			    	right = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, right.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new BinaryExpression(type, retval.value, ((right != null) ? right.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:462:1: multiplicativeExpression returns [Expression value] : left= unaryExpression ( ( '*' | '/' | '%' ) right= multiplicativeExpression )* ;
    public JavaScriptParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.multiplicativeExpression_return retval = new JavaScriptParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal131 = null;
        IToken char_literal132 = null;
        IToken char_literal133 = null;
        JavaScriptParser.unaryExpression_return left = null;

        JavaScriptParser.multiplicativeExpression_return right = null;


        CommonTree char_literal131_tree=null;
        CommonTree char_literal132_tree=null;
        CommonTree char_literal133_tree=null;


        BinaryExpressionType type = BinaryExpressionType.Unknown;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:466:2: (left= unaryExpression ( ( '*' | '/' | '%' ) right= multiplicativeExpression )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:466:4: left= unaryExpression ( ( '*' | '/' | '%' ) right= multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1781);
            	left = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, left.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((left != null) ? left.value : null); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:466:51: ( ( '*' | '/' | '%' ) right= multiplicativeExpression )*
            	do 
            	{
            	    int alt41 = 2;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 70:
            	    	{
            	        int LA41_2 = input.LA(2);

            	        if ( (synpred68_JavaScript()) )
            	        {
            	            alt41 = 1;
            	        }


            	        }
            	        break;
            	    case 71:
            	    	{
            	        int LA41_3 = input.LA(2);

            	        if ( (synpred68_JavaScript()) )
            	        {
            	            alt41 = 1;
            	        }


            	        }
            	        break;
            	    case 72:
            	    	{
            	        int LA41_4 = input.LA(2);

            	        if ( (synpred68_JavaScript()) )
            	        {
            	            alt41 = 1;
            	        }


            	        }
            	        break;

            	    }

            	    switch (alt41) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:467:4: ( '*' | '/' | '%' ) right= multiplicativeExpression
            			    {
            			    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:467:4: ( '*' | '/' | '%' )
            			    	int alt40 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 70:
            			    		{
            			    	    alt40 = 1;
            			    	    }
            			    	    break;
            			    	case 71:
            			    		{
            			    	    alt40 = 2;
            			    	    }
            			    	    break;
            			    	case 72:
            			    		{
            			    	    alt40 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d40s0 =
            			    		        new NoViableAltException("", 40, 0, input);

            			    		    throw nvae_d40s0;
            			    	}

            			    	switch (alt40) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:467:6: '*'
            			    	        {
            			    	        	char_literal131=(IToken)Match(input,70,FOLLOW_70_in_multiplicativeExpression1792); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal131_tree = (CommonTree)adaptor.Create(char_literal131);
            			    	        		adaptor.AddChild(root_0, char_literal131_tree);
            			    	        	}
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.Times; 
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:468:6: '/'
            			    	        {
            			    	        	char_literal132=(IToken)Match(input,71,FOLLOW_71_in_multiplicativeExpression1802); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal132_tree = (CommonTree)adaptor.Create(char_literal132);
            			    	        		adaptor.AddChild(root_0, char_literal132_tree);
            			    	        	}
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.Div; 
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:469:6: '%'
            			    	        {
            			    	        	char_literal133=(IToken)Match(input,72,FOLLOW_72_in_multiplicativeExpression1812); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal133_tree = (CommonTree)adaptor.Create(char_literal133);
            			    	        		adaptor.AddChild(root_0, char_literal133_tree);
            			    	        	}
            			    	        	if ( (state.backtracking==0) )
            			    	        	{
            			    	        	   type = BinaryExpressionType.Modulo; 
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_multiplicativeExpression1824);
            			    	right = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, right.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new BinaryExpression(type, ((left != null) ? left.value : null), ((right != null) ? right.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class unaryExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:474:1: unaryExpression returns [Expression value] : ( '-' neg= unaryExpression | '+' pos= unaryExpression | '--' a= primaryExpression | '++' b= primaryExpression | unaryExpressionNotPlusMinus );
    public JavaScriptParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.unaryExpression_return retval = new JavaScriptParser.unaryExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal134 = null;
        IToken char_literal135 = null;
        IToken string_literal136 = null;
        IToken string_literal137 = null;
        JavaScriptParser.unaryExpression_return neg = null;

        JavaScriptParser.unaryExpression_return pos = null;

        JavaScriptParser.primaryExpression_return a = null;

        JavaScriptParser.primaryExpression_return b = null;

        JavaScriptParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus138 = null;


        CommonTree char_literal134_tree=null;
        CommonTree char_literal135_tree=null;
        CommonTree string_literal136_tree=null;
        CommonTree string_literal137_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:475:6: ( '-' neg= unaryExpression | '+' pos= unaryExpression | '--' a= primaryExpression | '++' b= primaryExpression | unaryExpressionNotPlusMinus )
            int alt42 = 5;
            switch ( input.LA(1) ) 
            {
            case 69:
            	{
                alt42 = 1;
                }
                break;
            case 68:
            	{
                alt42 = 2;
                }
                break;
            case 73:
            	{
                alt42 = 3;
                }
                break;
            case 74:
            	{
                alt42 = 4;
                }
                break;
            case LBRACK:
            case LPAREN:
            case NUMBER:
            case STRING:
            case ID:
            case REGEXP:
            case TRUE:
            case FALSE:
            case 32:
            case 37:
            case 38:
            case 75:
            case 76:
            case 77:
            case 78:
            case 81:
            	{
                alt42 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d42s0 =
            	        new NoViableAltException("", 42, 0, input);

            	    throw nvae_d42s0;
            }

            switch (alt42) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:475:8: '-' neg= unaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal134=(IToken)Match(input,69,FOLLOW_69_in_unaryExpression1854); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal134_tree = (CommonTree)adaptor.Create(char_literal134);
                    		adaptor.AddChild(root_0, char_literal134_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1858);
                    	neg = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, neg.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new BinaryExpression(BinaryExpressionType.Minus,  new ValueExpression(0, TypeCode.Int32), ((neg != null) ? neg.value : null)); 
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:476:8: '+' pos= unaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal135=(IToken)Match(input,68,FOLLOW_68_in_unaryExpression1869); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal135_tree = (CommonTree)adaptor.Create(char_literal135);
                    		adaptor.AddChild(root_0, char_literal135_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1873);
                    	pos = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, pos.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value = new BinaryExpression(BinaryExpressionType.Plus, new ValueExpression(0, TypeCode.Int32), ((pos != null) ? pos.value : null)); 
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:477:8: '--' a= primaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal136=(IToken)Match(input,73,FOLLOW_73_in_unaryExpression1884); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal136_tree = (CommonTree)adaptor.Create(string_literal136);
                    		adaptor.AddChild(root_0, string_literal136_tree);
                    	}
                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpression1888);
                    	a = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new UnaryExpression(UnaryExpressionType.PrefixMinusMinus, a.value); 
                    	}

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:478:8: '++' b= primaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal137=(IToken)Match(input,74,FOLLOW_74_in_unaryExpression1899); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal137_tree = (CommonTree)adaptor.Create(string_literal137);
                    		adaptor.AddChild(root_0, string_literal137_tree);
                    	}
                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpression1903);
                    	b = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new UnaryExpression(UnaryExpressionType.PrefixPlusPlus, b.value); 
                    	}

                    }
                    break;
                case 5 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:479:8: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1914);
                    	unaryExpressionNotPlusMinus138 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpressionNotPlusMinus138.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((unaryExpressionNotPlusMinus138 != null) ? unaryExpressionNotPlusMinus138.value : null); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

    public class unaryExpressionNotPlusMinus_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryExpressionNotPlusMinus"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:483:1: unaryExpressionNotPlusMinus returns [Expression value] : ( '!' exp= unaryExpression | 'typeof' t= unaryExpression | 'instanceof' i= unaryExpression | primaryExpression ( selector )* ( '++' | '--' )? );
    public JavaScriptParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        JavaScriptParser.unaryExpressionNotPlusMinus_return retval = new JavaScriptParser.unaryExpressionNotPlusMinus_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal139 = null;
        IToken string_literal140 = null;
        IToken string_literal141 = null;
        IToken string_literal144 = null;
        IToken string_literal145 = null;
        JavaScriptParser.unaryExpression_return exp = null;

        JavaScriptParser.unaryExpression_return t = null;

        JavaScriptParser.unaryExpression_return i = null;

        JavaScriptParser.primaryExpression_return primaryExpression142 = null;

        JavaScriptParser.selector_return selector143 = null;


        CommonTree char_literal139_tree=null;
        CommonTree string_literal140_tree=null;
        CommonTree string_literal141_tree=null;
        CommonTree string_literal144_tree=null;
        CommonTree string_literal145_tree=null;


        Expression current = null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:487:6: ( '!' exp= unaryExpression | 'typeof' t= unaryExpression | 'instanceof' i= unaryExpression | primaryExpression ( selector )* ( '++' | '--' )? )
            int alt45 = 4;
            switch ( input.LA(1) ) 
            {
            case 75:
            	{
                alt45 = 1;
                }
                break;
            case 76:
            	{
                alt45 = 2;
                }
                break;
            case 77:
            	{
                alt45 = 3;
                }
                break;
            case LBRACK:
            case LPAREN:
            case NUMBER:
            case STRING:
            case ID:
            case REGEXP:
            case TRUE:
            case FALSE:
            case 32:
            case 37:
            case 38:
            case 78:
            case 81:
            	{
                alt45 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d45s0 =
            	        new NoViableAltException("", 45, 0, input);

            	    throw nvae_d45s0;
            }

            switch (alt45) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:487:8: '!' exp= unaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal139=(IToken)Match(input,75,FOLLOW_75_in_unaryExpressionNotPlusMinus1943); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal139_tree = (CommonTree)adaptor.Create(char_literal139);
                    		adaptor.AddChild(root_0, char_literal139_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1947);
                    	exp = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exp.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new UnaryExpression(UnaryExpressionType.Not, ((exp != null) ? exp.value : null)); 
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:488:8: 'typeof' t= unaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal140=(IToken)Match(input,76,FOLLOW_76_in_unaryExpressionNotPlusMinus1958); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal140_tree = (CommonTree)adaptor.Create(string_literal140);
                    		adaptor.AddChild(root_0, string_literal140_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1962);
                    	t = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, t.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new UnaryExpression(UnaryExpressionType.TypeOf, ((t != null) ? t.value : null)); 
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:489:8: 'instanceof' i= unaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal141=(IToken)Match(input,77,FOLLOW_77_in_unaryExpressionNotPlusMinus1973); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal141_tree = (CommonTree)adaptor.Create(string_literal141);
                    		adaptor.AddChild(root_0, string_literal141_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1977);
                    	i = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, i.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new UnaryExpression(UnaryExpressionType.InstanceOf, ((i != null) ? i.value : null)); 
                    	}

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:490:4: primaryExpression ( selector )* ( '++' | '--' )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpressionNotPlusMinus1984);
                    	primaryExpression142 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression142.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   current = ((primaryExpression142 != null) ? primaryExpression142.value : null); 
                    	}
                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:491:4: ( selector )*
                    	do 
                    	{
                    	    int alt43 = 2;
                    	    int LA43_0 = input.LA(1);

                    	    if ( (LA43_0 == LPAREN || LA43_0 == 78 || LA43_0 == 80) )
                    	    {
                    	        alt43 = 1;
                    	    }


                    	    switch (alt43) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:491:5: selector
                    			    {
                    			    	PushFollow(FOLLOW_selector_in_unaryExpressionNotPlusMinus1993);
                    			    	selector143 = selector();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selector143.Tree);
                    			    	if ( (state.backtracking==0) )
                    			    	{
                    			    	   current = new MemberExpression(((selector143 != null) ? selector143.value : null), current); 
                    			    	}

                    			    }
                    			    break;

                    			default:
                    			    goto loop43;
                    	    }
                    	} while (true);

                    	loop43:
                    		;	// Stops C# compiler whining that label 'loop43' has no statements

                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:492:4: ( '++' | '--' )?
                    	int alt44 = 3;
                    	int LA44_0 = input.LA(1);

                    	if ( (LA44_0 == 74) )
                    	{
                    	    alt44 = 1;
                    	}
                    	else if ( (LA44_0 == 73) )
                    	{
                    	    alt44 = 2;
                    	}
                    	switch (alt44) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:493:6: '++'
                    	        {
                    	        	string_literal144=(IToken)Match(input,74,FOLLOW_74_in_unaryExpressionNotPlusMinus2010); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal144_tree = (CommonTree)adaptor.Create(string_literal144);
                    	        		adaptor.AddChild(root_0, string_literal144_tree);
                    	        	}
                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	   current = new UnaryExpression(UnaryExpressionType.PostfixPlusPlus, current); 
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:494:6: '--'
                    	        {
                    	        	string_literal145=(IToken)Match(input,73,FOLLOW_73_in_unaryExpressionNotPlusMinus2020); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal145_tree = (CommonTree)adaptor.Create(string_literal145);
                    	        		adaptor.AddChild(root_0, string_literal145_tree);
                    	        	}
                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	   current = new UnaryExpression(UnaryExpressionType.PostfixMinusMinus, current); 
                    	        	}

                    	        }
                    	        break;

                    	}

                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  current; 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryExpressionNotPlusMinus"

    public class primaryExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "primaryExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:498:1: primaryExpression returns [Expression value] : ( LPAREN expression RPAREN | expr= value );
    public JavaScriptParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.primaryExpression_return retval = new JavaScriptParser.primaryExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LPAREN146 = null;
        IToken RPAREN148 = null;
        JavaScriptParser.value_return expr = null;

        JavaScriptParser.expression_return expression147 = null;


        CommonTree LPAREN146_tree=null;
        CommonTree RPAREN148_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:499:2: ( LPAREN expression RPAREN | expr= value )
            int alt46 = 2;
            int LA46_0 = input.LA(1);

            if ( (LA46_0 == LPAREN) )
            {
                alt46 = 1;
            }
            else if ( (LA46_0 == LBRACK || (LA46_0 >= NUMBER && LA46_0 <= FALSE) || LA46_0 == 32 || (LA46_0 >= 37 && LA46_0 <= 38) || LA46_0 == 78 || LA46_0 == 81) )
            {
                alt46 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d46s0 =
                    new NoViableAltException("", 46, 0, input);

                throw nvae_d46s0;
            }
            switch (alt46) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:499:4: LPAREN expression RPAREN
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LPAREN146=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_primaryExpression2053); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LPAREN146_tree = (CommonTree)adaptor.Create(LPAREN146);
                    		adaptor.AddChild(root_0, LPAREN146_tree);
                    	}
                    	PushFollow(FOLLOW_expression_in_primaryExpression2055);
                    	expression147 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression147.Tree);
                    	RPAREN148=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_primaryExpression2057); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{RPAREN148_tree = (CommonTree)adaptor.Create(RPAREN148);
                    		adaptor.AddChild(root_0, RPAREN148_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((expression147 != null) ? expression147.value : null); 
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:500:4: expr= value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_primaryExpression2067);
                    	expr = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((expr != null) ? expr.value : null); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "primaryExpression"

    public class value_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "value"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:503:1: value returns [Expression value] : ( NUMBER | STRING | boolean | functionExpression | json | regexp | newExpression | methodCall | arrayDeclaration );
    public JavaScriptParser.value_return value() // throws RecognitionException [1]
    {   
        JavaScriptParser.value_return retval = new JavaScriptParser.value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NUMBER149 = null;
        IToken STRING150 = null;
        JavaScriptParser.boolean_return boolean151 = null;

        JavaScriptParser.functionExpression_return functionExpression152 = null;

        JavaScriptParser.json_return json153 = null;

        JavaScriptParser.regexp_return regexp154 = null;

        JavaScriptParser.newExpression_return newExpression155 = null;

        JavaScriptParser.methodCall_return methodCall156 = null;

        JavaScriptParser.arrayDeclaration_return arrayDeclaration157 = null;


        CommonTree NUMBER149_tree=null;
        CommonTree STRING150_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:504:2: ( NUMBER | STRING | boolean | functionExpression | json | regexp | newExpression | methodCall | arrayDeclaration )
            int alt47 = 9;
            switch ( input.LA(1) ) 
            {
            case NUMBER:
            	{
                alt47 = 1;
                }
                break;
            case STRING:
            	{
                alt47 = 2;
                }
                break;
            case TRUE:
            case FALSE:
            	{
                alt47 = 3;
                }
                break;
            case 32:
            	{
                alt47 = 4;
                }
                break;
            case LBRACK:
            	{
                alt47 = 5;
                }
                break;
            case REGEXP:
            	{
                alt47 = 6;
                }
                break;
            case 81:
            	{
                alt47 = 7;
                }
                break;
            case ID:
            case 37:
            case 38:
            	{
                alt47 = 8;
                }
                break;
            case 78:
            	{
                alt47 = 9;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d47s0 =
            	        new NoViableAltException("", 47, 0, input);

            	    throw nvae_d47s0;
            }

            switch (alt47) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:504:4: NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	NUMBER149=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_value2085); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER149_tree = (CommonTree)adaptor.Create(NUMBER149);
                    		adaptor.AddChild(root_0, NUMBER149_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new ValueExpression(double.Parse(((NUMBER149 != null) ? NUMBER149.Text : null), NumberStyles.Float, numberFormatInfo), TypeCode.Double); 
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:505:4: STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING150=(IToken)Match(input,STRING,FOLLOW_STRING_in_value2093); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING150_tree = (CommonTree)adaptor.Create(STRING150);
                    		adaptor.AddChild(root_0, STRING150_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new ValueExpression(extractString(((STRING150 != null) ? STRING150.Text : null)), TypeCode.String); 
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:506:4: boolean
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_in_value2101);
                    	boolean151 = boolean();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolean151.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new ValueExpression(((boolean151 != null) ? boolean151.value : false), TypeCode.Boolean); 
                    	}

                    }
                    break;
                case 4 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:507:4: functionExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionExpression_in_value2109);
                    	functionExpression152 = functionExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionExpression152.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((functionExpression152 != null) ? functionExpression152.value : null); 
                    	}

                    }
                    break;
                case 5 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:508:4: json
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_json_in_value2116);
                    	json153 = json();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, json153.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((json153 != null) ? json153.value : null); 
                    	}

                    }
                    break;
                case 6 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:509:4: regexp
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_regexp_in_value2124);
                    	regexp154 = regexp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, regexp154.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((regexp154 != null) ? regexp154.value : null); 
                    	}

                    }
                    break;
                case 7 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:510:4: newExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_newExpression_in_value2132);
                    	newExpression155 = newExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newExpression155.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((newExpression155 != null) ? newExpression155.value : null); 
                    	}

                    }
                    break;
                case 8 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:511:4: methodCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodCall_in_value2139);
                    	methodCall156 = methodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall156.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((methodCall156 != null) ? methodCall156.value : null); 
                    	}

                    }
                    break;
                case 9 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:512:4: arrayDeclaration
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayDeclaration_in_value2146);
                    	arrayDeclaration157 = arrayDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayDeclaration157.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((arrayDeclaration157 != null) ? arrayDeclaration157.value : null); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value"

    public class selector_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selector"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:515:1: selector returns [Expression value] : ( '[' e= expression ']' | a= arguments | '.' identifier ( arguments )? );
    public JavaScriptParser.selector_return selector() // throws RecognitionException [1]
    {   
        JavaScriptParser.selector_return retval = new JavaScriptParser.selector_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal158 = null;
        IToken char_literal159 = null;
        IToken char_literal160 = null;
        JavaScriptParser.expression_return e = null;

        JavaScriptParser.arguments_return a = null;

        JavaScriptParser.identifier_return identifier161 = null;

        JavaScriptParser.arguments_return arguments162 = null;


        CommonTree char_literal158_tree=null;
        CommonTree char_literal159_tree=null;
        CommonTree char_literal160_tree=null;


        Expression current = null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:519:2: ( '[' e= expression ']' | a= arguments | '.' identifier ( arguments )? )
            int alt49 = 3;
            switch ( input.LA(1) ) 
            {
            case 78:
            	{
                alt49 = 1;
                }
                break;
            case LPAREN:
            	{
                alt49 = 2;
                }
                break;
            case 80:
            	{
                alt49 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d49s0 =
            	        new NoViableAltException("", 49, 0, input);

            	    throw nvae_d49s0;
            }

            switch (alt49) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:519:4: '[' e= expression ']'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal158=(IToken)Match(input,78,FOLLOW_78_in_selector2167); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal158_tree = (CommonTree)adaptor.Create(char_literal158);
                    		adaptor.AddChild(root_0, char_literal158_tree);
                    	}
                    	PushFollow(FOLLOW_expression_in_selector2170);
                    	e = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, e.Tree);
                    	char_literal159=(IToken)Match(input,79,FOLLOW_79_in_selector2172); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal159_tree = (CommonTree)adaptor.Create(char_literal159);
                    		adaptor.AddChild(root_0, char_literal159_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new Indexer(e.value); 
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:520:4: a= arguments
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arguments_in_selector2182);
                    	a = arguments();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   MethodCall m = new MethodCall(); m.Identifier = null; m.Arguments.AddRange(a.value); retval.value =  m;
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:521:4: '.' identifier ( arguments )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal160=(IToken)Match(input,80,FOLLOW_80_in_selector2189); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal160_tree = (CommonTree)adaptor.Create(char_literal160);
                    		adaptor.AddChild(root_0, char_literal160_tree);
                    	}
                    	PushFollow(FOLLOW_identifier_in_selector2191);
                    	identifier161 = identifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, identifier161.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   current = ((identifier161 != null) ? identifier161.value : null); 
                    	}
                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:521:52: ( arguments )?
                    	int alt48 = 2;
                    	alt48 = dfa48.Predict(input);
                    	switch (alt48) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:521:53: arguments
                    	        {
                    	        	PushFollow(FOLLOW_arguments_in_selector2196);
                    	        	arguments162 = arguments();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arguments162.Tree);
                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	   current = new MethodCall((Identifier)current, ((arguments162 != null) ? arguments162.value : null)); 
                    	        	}

                    	        }
                    	        break;

                    	}

                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  current; 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selector"

    public class identifier_return : ParserRuleReturnScope
    {
        public Identifier value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "identifier"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:524:1: identifier returns [Identifier value] : ( 'each' | 'in' | ID );
    public JavaScriptParser.identifier_return identifier() // throws RecognitionException [1]
    {   
        JavaScriptParser.identifier_return retval = new JavaScriptParser.identifier_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal163 = null;
        IToken string_literal164 = null;
        IToken ID165 = null;

        CommonTree string_literal163_tree=null;
        CommonTree string_literal164_tree=null;
        CommonTree ID165_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:525:2: ( 'each' | 'in' | ID )
            int alt50 = 3;
            switch ( input.LA(1) ) 
            {
            case 37:
            	{
                alt50 = 1;
                }
                break;
            case 38:
            	{
                alt50 = 2;
                }
                break;
            case ID:
            	{
                alt50 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d50s0 =
            	        new NoViableAltException("", 50, 0, input);

            	    throw nvae_d50s0;
            }

            switch (alt50) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:525:4: 'each'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal163=(IToken)Match(input,37,FOLLOW_37_in_identifier2216); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal163_tree = (CommonTree)adaptor.Create(string_literal163);
                    		adaptor.AddChild(root_0, string_literal163_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new Identifier("each"); 
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:526:4: 'in'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal164=(IToken)Match(input,38,FOLLOW_38_in_identifier2223); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal164_tree = (CommonTree)adaptor.Create(string_literal164);
                    		adaptor.AddChild(root_0, string_literal164_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new Identifier("in"); 
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:527:5: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID165=(IToken)Match(input,ID,FOLLOW_ID_in_identifier2231); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID165_tree = (CommonTree)adaptor.Create(ID165);
                    		adaptor.AddChild(root_0, ID165_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new Identifier(((ID165 != null) ? ID165.Text : null)); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "identifier"

    public class newExpression_return : ParserRuleReturnScope
    {
        public NewExpression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "newExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:530:1: newExpression returns [NewExpression value] : 'new' first= identifier ( '.' follow= identifier )* ( arguments )? ;
    public JavaScriptParser.newExpression_return newExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.newExpression_return retval = new JavaScriptParser.newExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal166 = null;
        IToken char_literal167 = null;
        JavaScriptParser.identifier_return first = null;

        JavaScriptParser.identifier_return follow = null;

        JavaScriptParser.arguments_return arguments168 = null;


        CommonTree string_literal166_tree=null;
        CommonTree char_literal167_tree=null;


        NewExpression e = new NewExpression();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:2: ( 'new' first= identifier ( '.' follow= identifier )* ( arguments )? )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:4: 'new' first= identifier ( '.' follow= identifier )* ( arguments )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal166=(IToken)Match(input,81,FOLLOW_81_in_newExpression2252); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal166_tree = (CommonTree)adaptor.Create(string_literal166);
            		adaptor.AddChild(root_0, string_literal166_tree);
            	}
            	PushFollow(FOLLOW_identifier_in_newExpression2256);
            	first = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, first.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   e.Identifiers.Add(((first != null) ? first.value : null)); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:64: ( '.' follow= identifier )*
            	do 
            	{
            	    int alt51 = 2;
            	    int LA51_0 = input.LA(1);

            	    if ( (LA51_0 == 80) )
            	    {
            	        switch ( input.LA(2) ) 
            	        {
            	        case 37:
            	        	{
            	            int LA51_3 = input.LA(3);

            	            if ( (synpred93_JavaScript()) )
            	            {
            	                alt51 = 1;
            	            }


            	            }
            	            break;
            	        case 38:
            	        	{
            	            int LA51_4 = input.LA(3);

            	            if ( (synpred93_JavaScript()) )
            	            {
            	                alt51 = 1;
            	            }


            	            }
            	            break;
            	        case ID:
            	        	{
            	            int LA51_5 = input.LA(3);

            	            if ( (synpred93_JavaScript()) )
            	            {
            	                alt51 = 1;
            	            }


            	            }
            	            break;

            	        }

            	    }


            	    switch (alt51) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:66: '.' follow= identifier
            			    {
            			    	char_literal167=(IToken)Match(input,80,FOLLOW_80_in_newExpression2262); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal167_tree = (CommonTree)adaptor.Create(char_literal167);
            			    		adaptor.AddChild(root_0, char_literal167_tree);
            			    	}
            			    	PushFollow(FOLLOW_identifier_in_newExpression2266);
            			    	follow = identifier();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, follow.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   e.Identifiers.Add(((follow != null) ? follow.value : null)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop51;
            	    }
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whining that label 'loop51' has no statements

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:129: ( arguments )?
            	int alt52 = 2;
            	alt52 = dfa52.Predict(input);
            	switch (alt52) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:130: arguments
            	        {
            	        	PushFollow(FOLLOW_arguments_in_newExpression2274);
            	        	arguments168 = arguments();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arguments168.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   e.Arguments.AddRange(((arguments168 != null) ? arguments168.value : null));  retval.value =  e; 
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "newExpression"

    public class arrayDeclaration_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arrayDeclaration"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:537:1: arrayDeclaration returns [Expression value] : '[' (first= expression ( ',' follow= expression )* )? ']' ;
    public JavaScriptParser.arrayDeclaration_return arrayDeclaration() // throws RecognitionException [1]
    {   
        JavaScriptParser.arrayDeclaration_return retval = new JavaScriptParser.arrayDeclaration_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal169 = null;
        IToken char_literal170 = null;
        IToken char_literal171 = null;
        JavaScriptParser.expression_return first = null;

        JavaScriptParser.expression_return follow = null;


        CommonTree char_literal169_tree=null;
        CommonTree char_literal170_tree=null;
        CommonTree char_literal171_tree=null;


        List<Expression> parameters = new List<Expression>();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:541:2: ( '[' (first= expression ( ',' follow= expression )* )? ']' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:541:4: '[' (first= expression ( ',' follow= expression )* )? ']'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal169=(IToken)Match(input,78,FOLLOW_78_in_arrayDeclaration2298); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal169_tree = (CommonTree)adaptor.Create(char_literal169);
            		adaptor.AddChild(root_0, char_literal169_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:541:8: (first= expression ( ',' follow= expression )* )?
            	int alt54 = 2;
            	int LA54_0 = input.LA(1);

            	if ( (LA54_0 == LBRACK || LA54_0 == LPAREN || (LA54_0 >= NUMBER && LA54_0 <= FALSE) || LA54_0 == 32 || (LA54_0 >= 37 && LA54_0 <= 38) || (LA54_0 >= 68 && LA54_0 <= 69) || (LA54_0 >= 73 && LA54_0 <= 78) || LA54_0 == 81) )
            	{
            	    alt54 = 1;
            	}
            	switch (alt54) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:541:9: first= expression ( ',' follow= expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_arrayDeclaration2303);
            	        	first = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, first.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   parameters.Add(first.value); 
            	        	}
            	        	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:541:59: ( ',' follow= expression )*
            	        	do 
            	        	{
            	        	    int alt53 = 2;
            	        	    int LA53_0 = input.LA(1);

            	        	    if ( (LA53_0 == 28) )
            	        	    {
            	        	        alt53 = 1;
            	        	    }


            	        	    switch (alt53) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:541:60: ',' follow= expression
            	        			    {
            	        			    	char_literal170=(IToken)Match(input,28,FOLLOW_28_in_arrayDeclaration2308); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{char_literal170_tree = (CommonTree)adaptor.Create(char_literal170);
            	        			    		adaptor.AddChild(root_0, char_literal170_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_expression_in_arrayDeclaration2312);
            	        			    	follow = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, follow.Tree);
            	        			    	if ( (state.backtracking==0) )
            	        			    	{
            	        			    	   parameters.Add(follow.value); 
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop53;
            	        	    }
            	        	} while (true);

            	        	loop53:
            	        		;	// Stops C# compiler whining that label 'loop53' has no statements


            	        }
            	        break;

            	}

            	char_literal171=(IToken)Match(input,79,FOLLOW_79_in_arrayDeclaration2320); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal171_tree = (CommonTree)adaptor.Create(char_literal171);
            		adaptor.AddChild(root_0, char_literal171_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   ArrayDeclaration ad = new ArrayDeclaration(); ad.Parameters.AddRange(parameters); retval.value =  ad; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arrayDeclaration"

    public class methodCall_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "methodCall"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:544:1: methodCall returns [Expression value] : mi= identifier (a= arguments )? ;
    public JavaScriptParser.methodCall_return methodCall() // throws RecognitionException [1]
    {   
        JavaScriptParser.methodCall_return retval = new JavaScriptParser.methodCall_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        JavaScriptParser.identifier_return mi = null;

        JavaScriptParser.arguments_return a = null;



        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:545:2: (mi= identifier (a= arguments )? )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:545:5: mi= identifier (a= arguments )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_identifier_in_methodCall2340);
            	mi = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mi.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new MemberExpression(mi.value); 
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:545:64: (a= arguments )?
            	int alt55 = 2;
            	alt55 = dfa55.Predict(input);
            	switch (alt55) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:545:65: a= arguments
            	        {
            	        	PushFollow(FOLLOW_arguments_in_methodCall2347);
            	        	a = arguments();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   MethodCall m = new MethodCall(); m.Identifier = mi.value; m.Arguments.AddRange(a.value); retval.value =  m; 
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "methodCall"

    public class functionExpression_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "functionExpression"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:548:1: functionExpression returns [Expression value] : 'function' a= formalParameterList b= blockStatement ;
    public JavaScriptParser.functionExpression_return functionExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.functionExpression_return retval = new JavaScriptParser.functionExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal172 = null;
        JavaScriptParser.formalParameterList_return a = null;

        JavaScriptParser.blockStatement_return b = null;


        CommonTree string_literal172_tree=null;


        FunctionExpression e = new FunctionExpression();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:552:2: ( 'function' a= formalParameterList b= blockStatement )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:552:4: 'function' a= formalParameterList b= blockStatement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal172=(IToken)Match(input,32,FOLLOW_32_in_functionExpression2373); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal172_tree = (CommonTree)adaptor.Create(string_literal172);
            		adaptor.AddChild(root_0, string_literal172_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  e; 
            	}
            	PushFollow(FOLLOW_formalParameterList_in_functionExpression2379);
            	a = formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   e.Parameters.AddRange(((a != null) ? a.value : null)) ;
            	}
            	PushFollow(FOLLOW_blockStatement_in_functionExpression2385);
            	b = blockStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   e.Statement = ((b != null) ? b.value : null); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functionExpression"

    public class expressionList_return : ParserRuleReturnScope
    {
        public List<Expression> value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expressionList"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:555:1: expressionList returns [List<Expression> value] : first= expression ( ',' follow= expression )* ;
    public JavaScriptParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        JavaScriptParser.expressionList_return retval = new JavaScriptParser.expressionList_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal173 = null;
        JavaScriptParser.expression_return first = null;

        JavaScriptParser.expression_return follow = null;


        CommonTree char_literal173_tree=null;


        List<Expression> expressions = new List<Expression>();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:559:2: (first= expression ( ',' follow= expression )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:559:4: first= expression ( ',' follow= expression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList2410);
            	first = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, first.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  expressions.Add(((first != null) ? first.value : null));
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:559:55: ( ',' follow= expression )*
            	do 
            	{
            	    int alt56 = 2;
            	    int LA56_0 = input.LA(1);

            	    if ( (LA56_0 == 28) )
            	    {
            	        alt56 = 1;
            	    }


            	    switch (alt56) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:559:57: ',' follow= expression
            			    {
            			    	char_literal173=(IToken)Match(input,28,FOLLOW_28_in_expressionList2417); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal173_tree = (CommonTree)adaptor.Create(char_literal173);
            			    		adaptor.AddChild(root_0, char_literal173_tree);
            			    	}
            			    	PushFollow(FOLLOW_expression_in_expressionList2421);
            			    	follow = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, follow.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	  expressions.Add(((follow != null) ? follow.value : null));
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop56;
            	    }
            	} while (true);

            	loop56:
            		;	// Stops C# compiler whining that label 'loop56' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  expressions; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expressionList"

    public class json_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "json"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:563:1: json returns [Expression value] : LBRACK (first= jsonPair ( ',' follow= jsonPair )* )? RBRACK ;
    public JavaScriptParser.json_return json() // throws RecognitionException [1]
    {   
        JavaScriptParser.json_return retval = new JavaScriptParser.json_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LBRACK174 = null;
        IToken char_literal175 = null;
        IToken RBRACK176 = null;
        JavaScriptParser.jsonPair_return first = null;

        JavaScriptParser.jsonPair_return follow = null;


        CommonTree LBRACK174_tree=null;
        CommonTree char_literal175_tree=null;
        CommonTree RBRACK176_tree=null;


        JsonExpression json = new JsonExpression();

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:567:2: ( LBRACK (first= jsonPair ( ',' follow= jsonPair )* )? RBRACK )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:567:4: LBRACK (first= jsonPair ( ',' follow= jsonPair )* )? RBRACK
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LBRACK174=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_json2449); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LBRACK174_tree = (CommonTree)adaptor.Create(LBRACK174);
            		adaptor.AddChild(root_0, LBRACK174_tree);
            	}
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:567:11: (first= jsonPair ( ',' follow= jsonPair )* )?
            	int alt58 = 2;
            	int LA58_0 = input.LA(1);

            	if ( ((LA58_0 >= STRING && LA58_0 <= ID) || (LA58_0 >= 37 && LA58_0 <= 38)) )
            	{
            	    alt58 = 1;
            	}
            	switch (alt58) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:567:13: first= jsonPair ( ',' follow= jsonPair )*
            	        {
            	        	PushFollow(FOLLOW_jsonPair_in_json2455);
            	        	first = jsonPair();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, first.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	  json.Values.Add(first.value.Key, first.value.Value); 
            	        	}
            	        	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:567:84: ( ',' follow= jsonPair )*
            	        	do 
            	        	{
            	        	    int alt57 = 2;
            	        	    int LA57_0 = input.LA(1);

            	        	    if ( (LA57_0 == 28) )
            	        	    {
            	        	        alt57 = 1;
            	        	    }


            	        	    switch (alt57) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:567:86: ',' follow= jsonPair
            	        			    {
            	        			    	char_literal175=(IToken)Match(input,28,FOLLOW_28_in_json2461); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{char_literal175_tree = (CommonTree)adaptor.Create(char_literal175);
            	        			    		adaptor.AddChild(root_0, char_literal175_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_jsonPair_in_json2465);
            	        			    	follow = jsonPair();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, follow.Tree);
            	        			    	if ( (state.backtracking==0) )
            	        			    	{
            	        			    	    json.Values.Add(follow.value.Key, follow.value.Value); 
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop57;
            	        	    }
            	        	} while (true);

            	        	loop57:
            	        		;	// Stops C# compiler whining that label 'loop57' has no statements


            	        }
            	        break;

            	}

            	RBRACK176=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_json2476); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RBRACK176_tree = (CommonTree)adaptor.Create(RBRACK176);
            		adaptor.AddChild(root_0, RBRACK176_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  json; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "json"

    public class jsonPair_return : ParserRuleReturnScope
    {
        public KeyValuePair<string, Expression> value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "jsonPair"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:570:1: jsonPair returns [KeyValuePair<string, Expression> value] : (s= STRING | i= identifier ) ':' v= expression ;
    public JavaScriptParser.jsonPair_return jsonPair() // throws RecognitionException [1]
    {   
        JavaScriptParser.jsonPair_return retval = new JavaScriptParser.jsonPair_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken s = null;
        IToken char_literal177 = null;
        JavaScriptParser.identifier_return i = null;

        JavaScriptParser.expression_return v = null;


        CommonTree s_tree=null;
        CommonTree char_literal177_tree=null;


        string key = String.Empty;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:574:2: ( (s= STRING | i= identifier ) ':' v= expression )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:574:4: (s= STRING | i= identifier ) ':' v= expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:574:4: (s= STRING | i= identifier )
            	int alt59 = 2;
            	int LA59_0 = input.LA(1);

            	if ( (LA59_0 == STRING) )
            	{
            	    alt59 = 1;
            	}
            	else if ( (LA59_0 == ID || (LA59_0 >= 37 && LA59_0 <= 38)) )
            	{
            	    alt59 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d59s0 =
            	        new NoViableAltException("", 59, 0, input);

            	    throw nvae_d59s0;
            	}
            	switch (alt59) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:574:5: s= STRING
            	        {
            	        	s=(IToken)Match(input,STRING,FOLLOW_STRING_in_jsonPair2501); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{s_tree = (CommonTree)adaptor.Create(s);
            	        		adaptor.AddChild(root_0, s_tree);
            	        	}
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   key = extractString(s.Text); 
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:574:49: i= identifier
            	        {
            	        	PushFollow(FOLLOW_identifier_in_jsonPair2509);
            	        	i = identifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, i.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   key = i.value.Text; 
            	        	}

            	        }
            	        break;

            	}

            	char_literal177=(IToken)Match(input,40,FOLLOW_40_in_jsonPair2515); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal177_tree = (CommonTree)adaptor.Create(char_literal177);
            		adaptor.AddChild(root_0, char_literal177_tree);
            	}
            	PushFollow(FOLLOW_expression_in_jsonPair2519);
            	v = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, v.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new KeyValuePair<string, Expression>(key, ((v != null) ? v.value : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "jsonPair"

    public class regexp_return : ParserRuleReturnScope
    {
        public Expression value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "regexp"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:577:1: regexp returns [Expression value] : REGEXP ;
    public JavaScriptParser.regexp_return regexp() // throws RecognitionException [1]
    {   
        JavaScriptParser.regexp_return retval = new JavaScriptParser.regexp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken REGEXP178 = null;

        CommonTree REGEXP178_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:578:2: ( REGEXP )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:578:5: REGEXP
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	REGEXP178=(IToken)Match(input,REGEXP,FOLLOW_REGEXP_in_regexp2537); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{REGEXP178_tree = (CommonTree)adaptor.Create(REGEXP178);
            		adaptor.AddChild(root_0, REGEXP178_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new RegexpExpression(extractRegExpPattern(((REGEXP178 != null) ? REGEXP178.Text : null)), extractRegExpOption(((REGEXP178 != null) ? REGEXP178.Text : null))); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "regexp"

    public class boolean_return : ParserRuleReturnScope
    {
        public bool value;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "boolean"
    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:581:1: boolean returns [bool value] : ( TRUE | FALSE );
    public JavaScriptParser.boolean_return boolean() // throws RecognitionException [1]
    {   
        JavaScriptParser.boolean_return retval = new JavaScriptParser.boolean_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken TRUE179 = null;
        IToken FALSE180 = null;

        CommonTree TRUE179_tree=null;
        CommonTree FALSE180_tree=null;

        try 
    	{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:582:2: ( TRUE | FALSE )
            int alt60 = 2;
            int LA60_0 = input.LA(1);

            if ( (LA60_0 == TRUE) )
            {
                alt60 = 1;
            }
            else if ( (LA60_0 == FALSE) )
            {
                alt60 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d60s0 =
                    new NoViableAltException("", 60, 0, input);

                throw nvae_d60s0;
            }
            switch (alt60) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:582:4: TRUE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	TRUE179=(IToken)Match(input,TRUE,FOLLOW_TRUE_in_boolean2554); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{TRUE179_tree = (CommonTree)adaptor.Create(TRUE179);
                    		adaptor.AddChild(root_0, TRUE179_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  true; 
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:583:4: FALSE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	FALSE180=(IToken)Match(input,FALSE,FOLLOW_FALSE_in_boolean2561); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FALSE180_tree = (CommonTree)adaptor.Create(FALSE180);
                    		adaptor.AddChild(root_0, FALSE180_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  false; 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "boolean"

    // $ANTLR start "synpred3_JavaScript"
    public void synpred3_JavaScript_fragment() {
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:152:4: ( expressionStatement )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:152:4: expressionStatement
        {
        	PushFollow(FOLLOW_expressionStatement_in_synpred3_JavaScript109);
        	expressionStatement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_JavaScript"

    // $ANTLR start "synpred4_JavaScript"
    public void synpred4_JavaScript_fragment() {
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:153:4: ( blockStatement )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:153:4: blockStatement
        {
        	PushFollow(FOLLOW_blockStatement_in_synpred4_JavaScript116);
        	blockStatement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_JavaScript"

    // $ANTLR start "synpred7_JavaScript"
    public void synpred7_JavaScript_fragment() {
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:156:4: ( functionDeclarationStatement )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:156:4: functionDeclarationStatement
        {
        	PushFollow(FOLLOW_functionDeclarationStatement_in_synpred7_JavaScript137);
        	functionDeclarationStatement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_JavaScript"

    // $ANTLR start "synpred17_JavaScript"
    public void synpred17_JavaScript_fragment() {
        JavaScriptParser.statement_return els = null;


        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:242:47: ( 'else' els= statement )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:242:47: 'else' els= statement
        {
        	Match(input,31,FOLLOW_31_in_synpred17_JavaScript444); if (state.failed) return ;
        	PushFollow(FOLLOW_statement_in_synpred17_JavaScript448);
        	els = statement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_JavaScript"

    // $ANTLR start "synpred29_JavaScript"
    public void synpred29_JavaScript_fragment() {
        JavaScriptParser.variableDeclarationStatement_return first = null;

        JavaScriptParser.variableDeclarationStatement_return follow = null;


        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:4: ( ( 'var' )? first= variableDeclarationStatement ( ',' follow= variableDeclarationStatement )* )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:4: ( 'var' )? first= variableDeclarationStatement ( ',' follow= variableDeclarationStatement )*
        {
        	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:4: ( 'var' )?
        	int alt62 = 2;
        	int LA62_0 = input.LA(1);

        	if ( (LA62_0 == 27) )
        	{
        	    alt62 = 1;
        	}
        	switch (alt62) 
        	{
        	    case 1 :
        	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:5: 'var'
        	        {
        	        	Match(input,27,FOLLOW_27_in_synpred29_JavaScript769); if (state.failed) return ;

        	        }
        	        break;

        	}

        	PushFollow(FOLLOW_variableDeclarationStatement_in_synpred29_JavaScript778);
        	first = variableDeclarationStatement();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:139: ( ',' follow= variableDeclarationStatement )*
        	do 
        	{
        	    int alt63 = 2;
        	    int LA63_0 = input.LA(1);

        	    if ( (LA63_0 == 28) )
        	    {
        	        alt63 = 1;
        	    }


        	    switch (alt63) 
        		{
        			case 1 :
        			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:304:140: ',' follow= variableDeclarationStatement
        			    {
        			    	Match(input,28,FOLLOW_28_in_synpred29_JavaScript783); if (state.failed) return ;
        			    	PushFollow(FOLLOW_variableDeclarationStatement_in_synpred29_JavaScript787);
        			    	follow = variableDeclarationStatement();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop63;
        	    }
        	} while (true);

        	loop63:
        		;	// Stops C# compiler whining that label 'loop63' has no statements


        }
    }
    // $ANTLR end "synpred29_JavaScript"

    // $ANTLR start "synpred55_JavaScript"
    public void synpred55_JavaScript_fragment() {
        JavaScriptParser.booleanAndExpression_return right = null;


        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:421:4: ( '&&' right= booleanAndExpression )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:421:4: '&&' right= booleanAndExpression
        {
        	Match(input,59,FOLLOW_59_in_synpred55_JavaScript1506); if (state.failed) return ;
        	PushFollow(FOLLOW_booleanAndExpression_in_synpred55_JavaScript1516);
        	right = booleanAndExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred55_JavaScript"

    // $ANTLR start "synpred63_JavaScript"
    public void synpred63_JavaScript_fragment() {
        JavaScriptParser.relationalExpression_return right = null;


        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:443:4: ( ( '<' | '<=' | '>' | '>=' ) right= relationalExpression )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:443:4: ( '<' | '<=' | '>' | '>=' ) right= relationalExpression
        {
        	if ( (input.LA(1) >= 64 && input.LA(1) <= 67) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}

        	PushFollow(FOLLOW_relationalExpression_in_synpred63_JavaScript1684);
        	right = relationalExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred63_JavaScript"

    // $ANTLR start "synpred65_JavaScript"
    public void synpred65_JavaScript_fragment() {
        JavaScriptParser.additiveExpression_return right = null;


        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:456:4: ( ( '+' | '-' ) right= additiveExpression )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:456:4: ( '+' | '-' ) right= additiveExpression
        {
        	if ( (input.LA(1) >= 68 && input.LA(1) <= 69) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}

        	PushFollow(FOLLOW_additiveExpression_in_synpred65_JavaScript1749);
        	right = additiveExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred65_JavaScript"

    // $ANTLR start "synpred68_JavaScript"
    public void synpred68_JavaScript_fragment() {
        JavaScriptParser.multiplicativeExpression_return right = null;


        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:467:4: ( ( '*' | '/' | '%' ) right= multiplicativeExpression )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:467:4: ( '*' | '/' | '%' ) right= multiplicativeExpression
        {
        	if ( (input.LA(1) >= 70 && input.LA(1) <= 72) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}

        	PushFollow(FOLLOW_multiplicativeExpression_in_synpred68_JavaScript1824);
        	right = multiplicativeExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred68_JavaScript"

    // $ANTLR start "synpred90_JavaScript"
    public void synpred90_JavaScript_fragment() {
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:521:53: ( arguments )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:521:53: arguments
        {
        	PushFollow(FOLLOW_arguments_in_synpred90_JavaScript2196);
        	arguments();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred90_JavaScript"

    // $ANTLR start "synpred93_JavaScript"
    public void synpred93_JavaScript_fragment() {
        JavaScriptParser.identifier_return follow = null;


        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:66: ( '.' follow= identifier )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:66: '.' follow= identifier
        {
        	Match(input,80,FOLLOW_80_in_synpred93_JavaScript2262); if (state.failed) return ;
        	PushFollow(FOLLOW_identifier_in_synpred93_JavaScript2266);
        	follow = identifier();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred93_JavaScript"

    // $ANTLR start "synpred94_JavaScript"
    public void synpred94_JavaScript_fragment() {
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:130: ( arguments )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:534:130: arguments
        {
        	PushFollow(FOLLOW_arguments_in_synpred94_JavaScript2274);
        	arguments();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred94_JavaScript"

    // $ANTLR start "synpred97_JavaScript"
    public void synpred97_JavaScript_fragment() {
        JavaScriptParser.arguments_return a = null;


        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:545:65: (a= arguments )
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:545:65: a= arguments
        {
        	PushFollow(FOLLOW_arguments_in_synpred97_JavaScript2347);
        	a = arguments();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred97_JavaScript"

    // Delegated rules

   	public bool synpred7_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred3_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred93_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred93_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred63_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred63_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred55_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred55_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred68_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred68_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred17_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred29_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred29_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred97_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred97_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred90_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred90_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred94_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred94_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred65_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred65_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred4_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA2 dfa2;
   	protected DFA10 dfa10;
   	protected DFA48 dfa48;
   	protected DFA52 dfa52;
   	protected DFA55 dfa55;
	private void InitializeCyclicDFAs()
	{
    	this.dfa2 = new DFA2(this);
    	this.dfa10 = new DFA10(this);
    	this.dfa48 = new DFA48(this);
    	this.dfa52 = new DFA52(this);
    	this.dfa55 = new DFA55(this);
	    this.dfa2.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA2_SpecialStateTransition);

	    this.dfa48.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA48_SpecialStateTransition);
	    this.dfa52.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA52_SpecialStateTransition);
	    this.dfa55.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA55_SpecialStateTransition);
	}

    const string DFA2_eotS =
        "\x23\uffff";
    const string DFA2_eofS =
        "\x23\uffff";
    const string DFA2_minS =
        "\x01\x04\x0d\uffff\x02\x00\x13\uffff";
    const string DFA2_maxS =
        "\x01\x51\x0d\uffff\x02\x00\x13\uffff";
    const string DFA2_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x13\uffff\x01\x04\x01\x05\x01\x07\x01"+
        "\x08\x02\uffff\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x06\x01"+
        "\x03";
    const string DFA2_specialS =
        "\x0e\uffff\x01\x00\x01\x01\x13\uffff}>";
    static readonly string[] DFA2_transitionS = {
            "\x01\x0f\x01\uffff\x01\x02\x01\uffff\x06\x02\x0a\uffff\x01"+
            "\x01\x01\x1c\x01\x1d\x01\x16\x02\uffff\x01\x17\x01\uffff\x01"+
            "\x0e\x01\x18\x03\x19\x02\x02\x02\uffff\x01\x1e\x01\uffff\x01"+
            "\x1f\x01\x20\x17\uffff\x02\x02\x03\uffff\x06\x02\x02\uffff\x01"+
            "\x02",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
    static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
    static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
    static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
    static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
    static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
    static readonly short[][] DFA2_transition = DFA.UnpackEncodedStringArray(DFA2_transitionS);

    protected class DFA2 : DFA
    {
        public DFA2(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 2;
            this.eot = DFA2_eot;
            this.eof = DFA2_eof;
            this.min = DFA2_min;
            this.max = DFA2_max;
            this.accept = DFA2_accept;
            this.special = DFA2_special;
            this.transition = DFA2_transition;

        }

        override public string Description
        {
            get { return "150:1: statement returns [Statement value] : ( emptyStatement | expressionStatement | blockStatement | variableDeclaration | ifStatement | functionDeclarationStatement | returnStatement | iterationStatement | continueStatement | breakStatement | switchStatement | throwStatement | tryStatement );"; }
        }

    }


    protected internal int DFA2_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA2_14 = input.LA(1);

                   	 
                   	int index2_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_JavaScript()) ) { s = 2; }

                   	else if ( (synpred7_JavaScript()) ) { s = 33; }

                   	 
                   	input.Seek(index2_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA2_15 = input.LA(1);

                   	 
                   	int index2_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_JavaScript()) ) { s = 2; }

                   	else if ( (synpred4_JavaScript()) ) { s = 34; }

                   	 
                   	input.Seek(index2_15);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae2 =
            new NoViableAltException(dfa.Description, 2, _s, input);
        dfa.Error(nvae2);
        throw nvae2;
    }
    const string DFA10_eotS =
        "\x0e\uffff";
    const string DFA10_eofS =
        "\x0e\uffff";
    const string DFA10_minS =
        "\x01\x22\x02\uffff\x01\x06\x01\uffff\x01\x04\x01\x0a\x03\x06\x01"+
        "\uffff\x03\x18";
    const string DFA10_maxS =
        "\x01\x24\x02\uffff\x01\x25\x01\uffff\x01\x51\x01\x26\x03\x50\x01"+
        "\uffff\x03\x26";
    const string DFA10_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x04\x05\uffff\x01\x03"+
        "\x03\uffff";
    const string DFA10_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x01\x01\x01\x02\x01\x03",
            "",
            "",
            "\x01\x05\x1e\uffff\x01\x04",
            "",
            "\x01\x0a\x01\uffff\x01\x0a\x01\uffff\x02\x0a\x01\x09\x03\x0a"+
            "\x0a\uffff\x01\x0a\x02\uffff\x01\x06\x04\uffff\x01\x0a\x04\uffff"+
            "\x01\x07\x01\x08\x1d\uffff\x02\x0a\x03\uffff\x06\x0a\x02\uffff"+
            "\x01\x0a",
            "\x01\x0d\x1a\uffff\x01\x0b\x01\x0c",
            "\x01\x0a\x11\uffff\x01\x0a\x03\uffff\x02\x0a\x08\uffff\x01"+
            "\x04\x08\uffff\x1c\x0a\x03\uffff\x01\x0a\x01\uffff\x01\x0a",
            "\x01\x0a\x11\uffff\x01\x0a\x03\uffff\x02\x0a\x08\uffff\x01"+
            "\x04\x08\uffff\x1c\x0a\x03\uffff\x01\x0a\x01\uffff\x01\x0a",
            "\x01\x0a\x11\uffff\x01\x0a\x03\uffff\x02\x0a\x08\uffff\x01"+
            "\x04\x08\uffff\x1c\x0a\x03\uffff\x01\x0a\x01\uffff\x01\x0a",
            "",
            "\x01\x0a\x03\uffff\x02\x0a\x08\uffff\x01\x04",
            "\x01\x0a\x03\uffff\x02\x0a\x08\uffff\x01\x04",
            "\x01\x0a\x03\uffff\x02\x0a\x08\uffff\x01\x04"
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "273:1: iterationStatement returns [Statement value] : ( doWhileStatement | whileStatement | forStatement | forEachInStatement );"; }
        }

    }

    const string DFA48_eotS =
        "\x27\uffff";
    const string DFA48_eofS =
        "\x01\x02\x26\uffff";
    const string DFA48_minS =
        "\x01\x05\x01\x00\x25\uffff";
    const string DFA48_maxS =
        "\x01\x50\x01\x00\x25\uffff";
    const string DFA48_acceptS =
        "\x02\uffff\x01\x02\x23\uffff\x01\x01";
    const string DFA48_specialS =
        "\x01\uffff\x01\x00\x25\uffff}>";
    static readonly string[] DFA48_transitionS = {
            "\x01\x02\x01\x01\x01\x02\x10\uffff\x01\x02\x03\uffff\x02\x02"+
            "\x0a\uffff\x01\x02\x06\uffff\x1c\x02\x03\uffff\x03\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA48_eot = DFA.UnpackEncodedString(DFA48_eotS);
    static readonly short[] DFA48_eof = DFA.UnpackEncodedString(DFA48_eofS);
    static readonly char[] DFA48_min = DFA.UnpackEncodedStringToUnsignedChars(DFA48_minS);
    static readonly char[] DFA48_max = DFA.UnpackEncodedStringToUnsignedChars(DFA48_maxS);
    static readonly short[] DFA48_accept = DFA.UnpackEncodedString(DFA48_acceptS);
    static readonly short[] DFA48_special = DFA.UnpackEncodedString(DFA48_specialS);
    static readonly short[][] DFA48_transition = DFA.UnpackEncodedStringArray(DFA48_transitionS);

    protected class DFA48 : DFA
    {
        public DFA48(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 48;
            this.eot = DFA48_eot;
            this.eof = DFA48_eof;
            this.min = DFA48_min;
            this.max = DFA48_max;
            this.accept = DFA48_accept;
            this.special = DFA48_special;
            this.transition = DFA48_transition;

        }

        override public string Description
        {
            get { return "521:52: ( arguments )?"; }
        }

    }


    protected internal int DFA48_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA48_1 = input.LA(1);

                   	 
                   	int index48_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred90_JavaScript()) ) { s = 38; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index48_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae48 =
            new NoViableAltException(dfa.Description, 48, _s, input);
        dfa.Error(nvae48);
        throw nvae48;
    }
    const string DFA52_eotS =
        "\x27\uffff";
    const string DFA52_eofS =
        "\x01\x02\x26\uffff";
    const string DFA52_minS =
        "\x01\x05\x01\x00\x25\uffff";
    const string DFA52_maxS =
        "\x01\x50\x01\x00\x25\uffff";
    const string DFA52_acceptS =
        "\x02\uffff\x01\x02\x23\uffff\x01\x01";
    const string DFA52_specialS =
        "\x01\uffff\x01\x00\x25\uffff}>";
    static readonly string[] DFA52_transitionS = {
            "\x01\x02\x01\x01\x01\x02\x10\uffff\x01\x02\x03\uffff\x02\x02"+
            "\x0a\uffff\x01\x02\x06\uffff\x1c\x02\x03\uffff\x03\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA52_eot = DFA.UnpackEncodedString(DFA52_eotS);
    static readonly short[] DFA52_eof = DFA.UnpackEncodedString(DFA52_eofS);
    static readonly char[] DFA52_min = DFA.UnpackEncodedStringToUnsignedChars(DFA52_minS);
    static readonly char[] DFA52_max = DFA.UnpackEncodedStringToUnsignedChars(DFA52_maxS);
    static readonly short[] DFA52_accept = DFA.UnpackEncodedString(DFA52_acceptS);
    static readonly short[] DFA52_special = DFA.UnpackEncodedString(DFA52_specialS);
    static readonly short[][] DFA52_transition = DFA.UnpackEncodedStringArray(DFA52_transitionS);

    protected class DFA52 : DFA
    {
        public DFA52(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 52;
            this.eot = DFA52_eot;
            this.eof = DFA52_eof;
            this.min = DFA52_min;
            this.max = DFA52_max;
            this.accept = DFA52_accept;
            this.special = DFA52_special;
            this.transition = DFA52_transition;

        }

        override public string Description
        {
            get { return "534:129: ( arguments )?"; }
        }

    }


    protected internal int DFA52_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA52_1 = input.LA(1);

                   	 
                   	int index52_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred94_JavaScript()) ) { s = 38; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index52_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae52 =
            new NoViableAltException(dfa.Description, 52, _s, input);
        dfa.Error(nvae52);
        throw nvae52;
    }
    const string DFA55_eotS =
        "\x27\uffff";
    const string DFA55_eofS =
        "\x01\x02\x26\uffff";
    const string DFA55_minS =
        "\x01\x05\x01\x00\x25\uffff";
    const string DFA55_maxS =
        "\x01\x50\x01\x00\x25\uffff";
    const string DFA55_acceptS =
        "\x02\uffff\x01\x02\x23\uffff\x01\x01";
    const string DFA55_specialS =
        "\x01\uffff\x01\x00\x25\uffff}>";
    static readonly string[] DFA55_transitionS = {
            "\x01\x02\x01\x01\x01\x02\x10\uffff\x01\x02\x03\uffff\x02\x02"+
            "\x0a\uffff\x01\x02\x06\uffff\x1c\x02\x03\uffff\x03\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA55_eot = DFA.UnpackEncodedString(DFA55_eotS);
    static readonly short[] DFA55_eof = DFA.UnpackEncodedString(DFA55_eofS);
    static readonly char[] DFA55_min = DFA.UnpackEncodedStringToUnsignedChars(DFA55_minS);
    static readonly char[] DFA55_max = DFA.UnpackEncodedStringToUnsignedChars(DFA55_maxS);
    static readonly short[] DFA55_accept = DFA.UnpackEncodedString(DFA55_acceptS);
    static readonly short[] DFA55_special = DFA.UnpackEncodedString(DFA55_specialS);
    static readonly short[][] DFA55_transition = DFA.UnpackEncodedStringArray(DFA55_transitionS);

    protected class DFA55 : DFA
    {
        public DFA55(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 55;
            this.eot = DFA55_eot;
            this.eof = DFA55_eof;
            this.min = DFA55_min;
            this.max = DFA55_max;
            this.accept = DFA55_accept;
            this.special = DFA55_special;
            this.transition = DFA55_transition;

        }

        override public string Description
        {
            get { return "545:64: (a= arguments )?"; }
        }

    }


    protected internal int DFA55_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA55_1 = input.LA(1);

                   	 
                   	int index55_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred97_JavaScript()) ) { s = 38; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index55_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae55 =
            new NoViableAltException(dfa.Description, 55, _s, input);
        dfa.Error(nvae55);
        throw nvae55;
    }
 

    public static readonly BitSet FOLLOW_statement_in_program78 = new BitSet(new ulong[]{0x00001A7F4F003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_EOF_in_program84 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_emptyStatement_in_statement102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionStatement_in_statement109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_blockStatement_in_statement116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_statement123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclarationStatement_in_statement137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_returnStatement_in_statement144 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_iterationStatement_in_statement151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_continueStatement_in_statement158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_breakStatement_in_statement165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_switchStatement_in_statement172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_throwStatement_in_statement179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tryStatement_in_statement186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_24_in_emptyStatement203 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_blockStatement229 = new BitSet(new ulong[]{0x00001A7F4F003F70UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_blockStatement232 = new BitSet(new ulong[]{0x00001A7F4F003F70UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_RBRACK_in_blockStatement238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_25_in_continueStatement261 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_continueStatement263 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_breakStatement285 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_breakStatement287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionStatement308 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_expressionStatement310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_variableDeclaration335 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_variableDeclarationStatement_in_variableDeclaration339 = new BitSet(new ulong[]{0x0000000011000000UL});
    public static readonly BitSet FOLLOW_28_in_variableDeclaration344 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_variableDeclarationStatement_in_variableDeclaration348 = new BitSet(new ulong[]{0x0000000011000000UL});
    public static readonly BitSet FOLLOW_24_in_variableDeclaration355 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_variableDeclarationStatement383 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_variableDeclarationStatement389 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclarationStatement391 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_ifStatement421 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_ifStatement425 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement427 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_ifStatement431 = new BitSet(new ulong[]{0x00001A7F4F003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement439 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_ifStatement444 = new BitSet(new ulong[]{0x00001A7F4F003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_functionDeclarationStatement475 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_identifier_in_functionDeclarationStatement479 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionDeclarationStatement488 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_blockStatement_in_functionDeclarationStatement496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_formalParameterList518 = new BitSet(new ulong[]{0x0000006000000480UL});
    public static readonly BitSet FOLLOW_identifier_in_formalParameterList523 = new BitSet(new ulong[]{0x0000000010000080UL});
    public static readonly BitSet FOLLOW_28_in_formalParameterList529 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_identifier_in_formalParameterList533 = new BitSet(new ulong[]{0x0000000010000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_formalParameterList544 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_returnStatement568 = new BitSet(new ulong[]{0x0000006101003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_returnStatement571 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_returnStatement578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doWhileStatement_in_iterationStatement595 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileStatement_in_iterationStatement602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStatement_in_iterationStatement609 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forEachInStatement_in_iterationStatement616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_doWhileStatement633 = new BitSet(new ulong[]{0x00001A7F4F003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_doWhileStatement635 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_doWhileStatement637 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_doWhileStatement639 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_doWhileStatement641 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_doWhileStatement643 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_whileStatement661 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_whileStatement663 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_whileStatement665 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_whileStatement667 = new BitSet(new ulong[]{0x00001A7F4F003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_whileStatement669 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_forStatement692 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_forStatement696 = new BitSet(new ulong[]{0x0000006109003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_forStatementInitialiserPart_in_forStatement701 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_forStatement710 = new BitSet(new ulong[]{0x0000006101003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_forStatement715 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_forStatement725 = new BitSet(new ulong[]{0x0000006100003FD0UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_forStatement730 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_forStatement737 = new BitSet(new ulong[]{0x00001A7F4F003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_forStatement745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_forStatementInitialiserPart769 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_variableDeclarationStatement_in_forStatementInitialiserPart778 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_forStatementInitialiserPart783 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_variableDeclarationStatement_in_forStatementInitialiserPart787 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_expression_in_forStatementInitialiserPart797 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_forEachInStatement820 = new BitSet(new ulong[]{0x0000002000000040UL});
    public static readonly BitSet FOLLOW_37_in_forEachInStatement824 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_forEachInStatement832 = new BitSet(new ulong[]{0x0000006008000400UL});
    public static readonly BitSet FOLLOW_27_in_forEachInStatement835 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_identifier_in_forEachInStatement842 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_forEachInStatement844 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_forEachInStatement846 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_forEachInStatement848 = new BitSet(new ulong[]{0x00001A7F4F003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_forEachInStatement850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_caseClause872 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_caseClause874 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_caseClause878 = new BitSet(new ulong[]{0x00001A7F4F003F52UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_caseClause881 = new BitSet(new ulong[]{0x00001A7F4F003F52UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_41_in_switchStatement909 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_switchStatement911 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_switchStatement913 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_switchStatement918 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_LBRACK_in_switchStatement924 = new BitSet(new ulong[]{0x0000048000000020UL});
    public static readonly BitSet FOLLOW_caseClause_in_switchStatement929 = new BitSet(new ulong[]{0x0000048000000020UL});
    public static readonly BitSet FOLLOW_defaultClause_in_switchStatement942 = new BitSet(new ulong[]{0x0000008000000020UL});
    public static readonly BitSet FOLLOW_caseClause_in_switchStatement949 = new BitSet(new ulong[]{0x0000008000000020UL});
    public static readonly BitSet FOLLOW_RBRACK_in_switchStatement957 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_defaultClause980 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_defaultClause982 = new BitSet(new ulong[]{0x00001A7F4F003F52UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_defaultClause985 = new BitSet(new ulong[]{0x00001A7F4F003F52UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_43_in_throwStatement1012 = new BitSet(new ulong[]{0x0000006101003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_throwStatement1015 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_throwStatement1022 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_tryStatement1043 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_blockStatement_in_tryStatement1045 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_catchClause_in_tryStatement1049 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_finallyClause_in_tryStatement1055 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_catchClause1089 = new BitSet(new ulong[]{0x0000000000000050UL});
    public static readonly BitSet FOLLOW_LPAREN_in_catchClause1092 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_identifier_in_catchClause1094 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_catchClause1096 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_blockStatement_in_catchClause1103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_finallyClause1121 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_blockStatement_in_finallyClause1123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_arguments1147 = new BitSet(new ulong[]{0x0000006100003FD0UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_arguments1152 = new BitSet(new ulong[]{0x0000000010000080UL});
    public static readonly BitSet FOLLOW_28_in_arguments1157 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_arguments1161 = new BitSet(new ulong[]{0x0000000010000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_arguments1170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ternaryExpression_in_expression1198 = new BitSet(new ulong[]{0x01FF800020000002UL});
    public static readonly BitSet FOLLOW_29_in_expression1222 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_expression1235 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_expression1248 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_expression1261 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1265 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_expression1274 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_expression1287 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_expression1300 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_expression1313 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_expression1326 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1330 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_expression1339 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1343 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_expression1352 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expression1356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanOrExpression_in_ternaryExpression1398 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_57_in_ternaryExpression1404 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_ternaryExpression_in_ternaryExpression1408 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_ternaryExpression1410 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_ternaryExpression_in_ternaryExpression1414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanAndExpression_in_booleanOrExpression1444 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_58_in_booleanOrExpression1453 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_booleanAndExpression_in_booleanOrExpression1463 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_booleanAndExpression1497 = new BitSet(new ulong[]{0x0800000000000002UL});
    public static readonly BitSet FOLLOW_59_in_booleanAndExpression1506 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_booleanAndExpression_in_booleanAndExpression1516 = new BitSet(new ulong[]{0x0800000000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1548 = new BitSet(new ulong[]{0xF000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression1563 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression1579 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1597 = new BitSet(new ulong[]{0xF000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1630 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_64_in_relationalExpression1641 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_65_in_relationalExpression1651 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_66_in_relationalExpression1662 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_67_in_relationalExpression1672 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_relationalExpression1684 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1716 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_68_in_additiveExpression1727 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_69_in_additiveExpression1737 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_additiveExpression1749 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1781 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_70_in_multiplicativeExpression1792 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_71_in_multiplicativeExpression1802 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_72_in_multiplicativeExpression1812 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_multiplicativeExpression1824 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_69_in_unaryExpression1854 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_unaryExpression1869 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_unaryExpression1884 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression1888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_unaryExpression1899 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression1903 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1914 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_unaryExpressionNotPlusMinus1943 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1947 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_unaryExpressionNotPlusMinus1958 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_unaryExpressionNotPlusMinus1973 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpressionNotPlusMinus1984 = new BitSet(new ulong[]{0x0000000000000042UL,0x0000000000014600UL});
    public static readonly BitSet FOLLOW_selector_in_unaryExpressionNotPlusMinus1993 = new BitSet(new ulong[]{0x0000000000000042UL,0x0000000000014600UL});
    public static readonly BitSet FOLLOW_74_in_unaryExpressionNotPlusMinus2010 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_unaryExpressionNotPlusMinus2020 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_primaryExpression2053 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_primaryExpression2055 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_primaryExpression2057 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_primaryExpression2067 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_value2085 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_value2093 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_boolean_in_value2101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionExpression_in_value2109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_json_in_value2116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_regexp_in_value2124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_newExpression_in_value2132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_value2139 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayDeclaration_in_value2146 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_selector2167 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_selector2170 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_selector2172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arguments_in_selector2182 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_selector2189 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_identifier_in_selector2191 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_arguments_in_selector2196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_identifier2216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_identifier2223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_identifier2231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_newExpression2252 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_identifier_in_newExpression2256 = new BitSet(new ulong[]{0x0000000000000042UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_newExpression2262 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_identifier_in_newExpression2266 = new BitSet(new ulong[]{0x0000000000000042UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_arguments_in_newExpression2274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_arrayDeclaration2298 = new BitSet(new ulong[]{0x0000006100003F50UL,0x000000000002FE30UL});
    public static readonly BitSet FOLLOW_expression_in_arrayDeclaration2303 = new BitSet(new ulong[]{0x0000000010000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_28_in_arrayDeclaration2308 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_arrayDeclaration2312 = new BitSet(new ulong[]{0x0000000010000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_arrayDeclaration2320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_methodCall2340 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_arguments_in_methodCall2347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_functionExpression2373 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionExpression2379 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_blockStatement_in_functionExpression2385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList2410 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_expressionList2417 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList2421 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_json2449 = new BitSet(new ulong[]{0x0000006000000620UL});
    public static readonly BitSet FOLLOW_jsonPair_in_json2455 = new BitSet(new ulong[]{0x0000000010000020UL});
    public static readonly BitSet FOLLOW_28_in_json2461 = new BitSet(new ulong[]{0x0000006000000600UL});
    public static readonly BitSet FOLLOW_jsonPair_in_json2465 = new BitSet(new ulong[]{0x0000000010000020UL});
    public static readonly BitSet FOLLOW_RBRACK_in_json2476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_jsonPair2501 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_identifier_in_jsonPair2509 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_jsonPair2515 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_expression_in_jsonPair2519 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REGEXP_in_regexp2537 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_boolean2554 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_boolean2561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionStatement_in_synpred3_JavaScript109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_blockStatement_in_synpred4_JavaScript116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclarationStatement_in_synpred7_JavaScript137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_synpred17_JavaScript444 = new BitSet(new ulong[]{0x00001A7F4F003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_statement_in_synpred17_JavaScript448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_synpred29_JavaScript769 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_variableDeclarationStatement_in_synpred29_JavaScript778 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_synpred29_JavaScript783 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_variableDeclarationStatement_in_synpred29_JavaScript787 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_59_in_synpred55_JavaScript1506 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_booleanAndExpression_in_synpred55_JavaScript1516 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred63_JavaScript1639 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_synpred63_JavaScript1684 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred65_JavaScript1725 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_synpred65_JavaScript1749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred68_JavaScript1790 = new BitSet(new ulong[]{0x0000006100003F50UL,0x0000000000027E30UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_synpred68_JavaScript1824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arguments_in_synpred90_JavaScript2196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_synpred93_JavaScript2262 = new BitSet(new ulong[]{0x0000006000000400UL});
    public static readonly BitSet FOLLOW_identifier_in_synpred93_JavaScript2266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arguments_in_synpred94_JavaScript2274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arguments_in_synpred97_JavaScript2347 = new BitSet(new ulong[]{0x0000000000000002UL});

}
