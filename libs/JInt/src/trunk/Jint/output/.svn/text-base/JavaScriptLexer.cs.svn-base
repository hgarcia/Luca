// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g 2009-10-26 11:22:16


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class JavaScriptLexer : Lexer {
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__29 = 29;
    public const int T__64 = 64;
    public const int LBRACK = 4;
    public const int T__28 = 28;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__27 = 27;
    public const int T__63 = 63;
    public const int T__26 = 26;
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
    public const int T__46 = 46;
    public const int T__80 = 80;
    public const int T__47 = 47;
    public const int T__81 = 81;
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
    public const int T__33 = 33;
    public const int T__71 = 71;
    public const int WS = 21;
    public const int T__34 = 34;
    public const int T__72 = 72;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__70 = 70;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 19;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int FALSE = 13;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int STRING = 9;
    public const int T__77 = 77;

    private IToken last;

    public override IToken NextToken()
    {
    	IToken result = base.NextToken();
    	if (result.Channel == Token.DEFAULT_CHANNEL)
    	{
    		last = result;
    	}
    	return result;		
    }

    public bool areRegularExpressionsEnabled()
    {
    	if (last == null)
    	{
    		return true;
    	}
    	switch (last.Type)
    	{
    	// literals
    		case ID:
    		case STRING:
    		case TRUE:
    		case FALSE:
    		case NUMBER:
    	// member access ending 
    		case RBRACK:
    	// function call or nested expression ending
    		case RPAREN:
    			return false;
    	// otherwise OK
    		default:
    			return true;
    	}

    }



    // delegates
    // delegators

    public JavaScriptLexer() 
    {
		InitializeCyclicDFAs();
    }
    public JavaScriptLexer(ICharStream input)
		: this(input, null) {
    }
    public JavaScriptLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g";} 
    }

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:48:7: ( ';' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:48:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:49:7: ( 'continue' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:49:9: 'continue'
            {
            	Match("continue"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:50:7: ( 'break' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:50:9: 'break'
            {
            	Match("break"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:51:7: ( 'var' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:51:9: 'var'
            {
            	Match("var"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:52:7: ( ',' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:52:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:53:7: ( '=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:53:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:54:7: ( 'if' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:54:9: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:55:7: ( 'else' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:55:9: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:56:7: ( 'function' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:56:9: 'function'
            {
            	Match("function"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:57:7: ( 'return' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:57:9: 'return'
            {
            	Match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:58:7: ( 'do' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:58:9: 'do'
            {
            	Match("do"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:59:7: ( 'while' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:59:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:60:7: ( 'for' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:60:9: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:61:7: ( 'each' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:61:9: 'each'
            {
            	Match("each"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:62:7: ( 'in' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:62:9: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:63:7: ( 'case' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:63:9: 'case'
            {
            	Match("case"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:64:7: ( ':' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:64:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:65:7: ( 'switch' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:65:9: 'switch'
            {
            	Match("switch"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:66:7: ( 'default' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:66:9: 'default'
            {
            	Match("default"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:67:7: ( 'throw' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:67:9: 'throw'
            {
            	Match("throw"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:68:7: ( 'try' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:68:9: 'try'
            {
            	Match("try"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:69:7: ( 'catch' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:69:9: 'catch'
            {
            	Match("catch"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:70:7: ( 'finally' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:70:9: 'finally'
            {
            	Match("finally"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:71:7: ( '+=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:71:9: '+='
            {
            	Match("+="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:72:7: ( '-=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:72:9: '-='
            {
            	Match("-="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:73:7: ( '*=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:73:9: '*='
            {
            	Match("*="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:74:7: ( '/=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:74:9: '/='
            {
            	Match("/="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:75:7: ( '>>=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:75:9: '>>='
            {
            	Match(">>="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:76:7: ( '<<=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:76:9: '<<='
            {
            	Match("<<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:77:7: ( '>>>=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:77:9: '>>>='
            {
            	Match(">>>="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:78:7: ( '&=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:78:9: '&='
            {
            	Match("&="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:79:7: ( '|=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:79:9: '|='
            {
            	Match("|="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:80:7: ( '^=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:80:9: '^='
            {
            	Match("^="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:81:7: ( '?' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:81:9: '?'
            {
            	Match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:82:7: ( '||' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:82:9: '||'
            {
            	Match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:83:7: ( '&&' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:83:9: '&&'
            {
            	Match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:84:7: ( '==' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:84:9: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:85:7: ( '===' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:85:9: '==='
            {
            	Match("==="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:86:7: ( '!=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:86:9: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:87:7: ( '!==' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:87:9: '!=='
            {
            	Match("!=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:88:7: ( '<' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:88:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:89:7: ( '<=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:89:9: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:90:7: ( '>' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:90:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:91:7: ( '>=' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:91:9: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:92:7: ( '+' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:92:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:93:7: ( '-' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:93:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:94:7: ( '*' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:94:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:95:7: ( '/' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:95:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:96:7: ( '%' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:96:9: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:97:7: ( '--' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:97:9: '--'
            {
            	Match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:98:7: ( '++' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:98:9: '++'
            {
            	Match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:99:7: ( '!' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:99:9: '!'
            {
            	Match('!'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:100:7: ( 'typeof' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:100:9: 'typeof'
            {
            	Match("typeof"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:101:7: ( 'instanceof' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:101:9: 'instanceof'
            {
            	Match("instanceof"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:102:7: ( '[' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:102:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public void mT__79() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__79;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:103:7: ( ']' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:103:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public void mT__80() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__80;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:104:7: ( '.' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:104:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public void mT__81() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__81;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:105:7: ( 'new' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:105:9: 'new'
            {
            	Match("new"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__81"

    // $ANTLR start "TRUE"
    public void mTRUE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRUE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:586:6: ( 'true' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:586:8: 'true'
            {
            	Match("true"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRUE"

    // $ANTLR start "FALSE"
    public void mFALSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FALSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:587:7: ( 'false' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:587:9: 'false'
            {
            	Match("false"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FALSE"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:590:2: ( LETTER ( LETTER | DIGIT )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:590:5: LETTER ( LETTER | DIGIT )*
            {
            	mLETTER(); 
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:590:12: ( LETTER | DIGIT )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == '$' || (LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:
            			    {
            			    	if ( input.LA(1) == '$' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "NUMBER"
    public void mNUMBER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUMBER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:594:2: ( ( DIGIT )* '.' ( DIGIT )+ ( E )? | ( DIGIT )+ ( E )? )
            int alt7 = 2;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:594:4: ( DIGIT )* '.' ( DIGIT )+ ( E )?
                    {
                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:594:4: ( DIGIT )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:594:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

                    	Match('.'); 
                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:594:15: ( DIGIT )+
                    	int cnt3 = 0;
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:594:15: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt3 >= 1 ) goto loop3;
                    		            EarlyExitException eee3 =
                    		                new EarlyExitException(3, input);
                    		            throw eee3;
                    	    }
                    	    cnt3++;
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements

                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:594:22: ( E )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 'E' || LA4_0 == 'e') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:594:22: E
                    	        {
                    	        	mE(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:595:4: ( DIGIT )+ ( E )?
                    {
                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:595:4: ( DIGIT )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:595:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:595:11: ( E )?
                    	int alt6 = 2;
                    	int LA6_0 = input.LA(1);

                    	if ( (LA6_0 == 'E' || LA6_0 == 'e') )
                    	{
                    	    alt6 = 1;
                    	}
                    	switch (alt6) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:595:11: E
                    	        {
                    	        	mE(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "E"
    public void mE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = E;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:598:3: ( ( 'E' | 'e' ) ( '+' | '-' )? ( DIGIT )+ )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:598:5: ( 'E' | 'e' ) ( '+' | '-' )? ( DIGIT )+
            {
            	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:598:15: ( '+' | '-' )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == '+' || LA8_0 == '-') )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:598:26: ( DIGIT )+
            	int cnt9 = 0;
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= '0' && LA9_0 <= '9')) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:598:26: DIGIT
            			    {
            			    	mDIGIT(); 

            			    }
            			    break;

            			default:
            			    if ( cnt9 >= 1 ) goto loop9;
            		            EarlyExitException eee9 =
            		                new EarlyExitException(9, input);
            		            throw eee9;
            	    }
            	    cnt9++;
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "E"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:602:6: ( '\\'' ( EscapeSequenceSingle | ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\\'' ) ) )* '\\'' | '\"' ( EscapeSequenceDouble | ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\"' ) ) )* '\"' )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == '\'') )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == '\"') )
            {
                alt12 = 2;
            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:602:10: '\\'' ( EscapeSequenceSingle | ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\\'' ) ) )* '\\''
                    {
                    	Match('\''); 
                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:602:15: ( EscapeSequenceSingle | ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\\'' ) ) )*
                    	do 
                    	{
                    	    int alt10 = 3;
                    	    int LA10_0 = input.LA(1);

                    	    if ( (LA10_0 == '\\') )
                    	    {
                    	        alt10 = 1;
                    	    }
                    	    else if ( ((LA10_0 >= '\u0000' && LA10_0 <= '\t') || (LA10_0 >= '\u000B' && LA10_0 <= '\f') || (LA10_0 >= '\u000E' && LA10_0 <= '&') || (LA10_0 >= '(' && LA10_0 <= '[') || (LA10_0 >= ']' && LA10_0 <= '\uFFFF')) )
                    	    {
                    	        alt10 = 2;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:602:17: EscapeSequenceSingle
                    			    {
                    			    	mEscapeSequenceSingle(); 

                    			    }
                    			    break;
                    			case 2 :
                    			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:602:40: ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\\'' ) )
                    			    {
                    			    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:602:40: ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\\'' ) )
                    			    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:602:67: ~ ( '\\r' | '\\n' | '\\\\' | '\\'' )
                    			    	{
                    			    		if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
                    			    		{
                    			    		    input.Consume();

                    			    		}
                    			    		else 
                    			    		{
                    			    		    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    		    Recover(mse);
                    			    		    throw mse;}


                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop10;
                    	    }
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whining that label 'loop10' has no statements

                    	Match('\''); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:603:10: '\"' ( EscapeSequenceDouble | ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\"' ) ) )* '\"'
                    {
                    	Match('\"'); 
                    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:603:14: ( EscapeSequenceDouble | ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\"' ) ) )*
                    	do 
                    	{
                    	    int alt11 = 3;
                    	    int LA11_0 = input.LA(1);

                    	    if ( (LA11_0 == '\\') )
                    	    {
                    	        alt11 = 1;
                    	    }
                    	    else if ( ((LA11_0 >= '\u0000' && LA11_0 <= '\t') || (LA11_0 >= '\u000B' && LA11_0 <= '\f') || (LA11_0 >= '\u000E' && LA11_0 <= '!') || (LA11_0 >= '#' && LA11_0 <= '[') || (LA11_0 >= ']' && LA11_0 <= '\uFFFF')) )
                    	    {
                    	        alt11 = 2;
                    	    }


                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:603:16: EscapeSequenceDouble
                    			    {
                    			    	mEscapeSequenceDouble(); 

                    			    }
                    			    break;
                    			case 2 :
                    			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:603:39: ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\"' ) )
                    			    {
                    			    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:603:39: ( options {greedy=false; } : ~ ( '\\r' | '\\n' | '\\\\' | '\"' ) )
                    			    	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:603:66: ~ ( '\\r' | '\\n' | '\\\\' | '\"' )
                    			    	{
                    			    		if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
                    			    		{
                    			    		    input.Consume();

                    			    		}
                    			    		else 
                    			    		{
                    			    		    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    		    Recover(mse);
                    			    		    throw mse;}


                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop11;
                    	    }
                    	} while (true);

                    	loop11:
                    		;	// Stops C# compiler whining that label 'loop11' has no statements

                    	Match('\"'); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "REGEXP"
    public void mREGEXP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = REGEXP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:607:6: ({...}? => '/' ~ ( ' ' | '*' | '=' | '/' ) ( '\\\\/' | ~ ( '/' ) )* '/' ( 'g' | 'i' | 'm' )* )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:607:10: {...}? => '/' ~ ( ' ' | '*' | '=' | '/' ) ( '\\\\/' | ~ ( '/' ) )* '/' ( 'g' | 'i' | 'm' )*
            {
            	if ( !(( areRegularExpressionsEnabled() )) ) 
            	{
            	    throw new FailedPredicateException(input, "REGEXP", " areRegularExpressionsEnabled() ");
            	}
            	Match('/'); 
            	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\u001F') || (input.LA(1) >= '!' && input.LA(1) <= ')') || (input.LA(1) >= '+' && input.LA(1) <= '.') || (input.LA(1) >= '0' && input.LA(1) <= '<') || (input.LA(1) >= '>' && input.LA(1) <= '\uFFFF') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:607:77: ( '\\\\/' | ~ ( '/' ) )*
            	do 
            	{
            	    int alt13 = 3;
            	    alt13 = dfa13.Predict(input);
            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:607:79: '\\\\/'
            			    {
            			    	Match("\\/"); 


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:607:88: ~ ( '/' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '.') || (input.LA(1) >= '0' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	Match('/'); 
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:607:102: ( 'g' | 'i' | 'm' )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 'g' || LA14_0 == 'i' || LA14_0 == 'm') )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:
            			    {
            			    	if ( input.LA(1) == 'g' || input.LA(1) == 'i' || input.LA(1) == 'm' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "REGEXP"

    // $ANTLR start "LBRACK"
    public void mLBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:611:8: ( '{' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:611:10: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LBRACK"

    // $ANTLR start "RBRACK"
    public void mRBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:612:8: ( '}' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:612:10: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RBRACK"

    // $ANTLR start "LPAREN"
    public void mLPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:613:8: ( '(' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:613:10: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LPAREN"

    // $ANTLR start "RPAREN"
    public void mRPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:614:8: ( ')' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:614:10: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RPAREN"

    // $ANTLR start "LETTER"
    public void mLETTER() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:617:2: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '$' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:
            {
            	if ( input.LA(1) == '$' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "LETTER"

    // $ANTLR start "DIGIT"
    public void mDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:624:2: ( '0' .. '9' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:624:4: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIGIT"

    // $ANTLR start "EscapeSequenceSingle"
    public void mEscapeSequenceSingle() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:628:2: ( '\\\\' ( 'n' | 'r' | 't' | '\\'' | '\\\\' | UnicodeEscape ) )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:628:4: '\\\\' ( 'n' | 'r' | 't' | '\\'' | '\\\\' | UnicodeEscape )
            {
            	Match('\\'); 
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:629:4: ( 'n' | 'r' | 't' | '\\'' | '\\\\' | UnicodeEscape )
            	int alt15 = 6;
            	switch ( input.LA(1) ) 
            	{
            	case 'n':
            		{
            	    alt15 = 1;
            	    }
            	    break;
            	case 'r':
            		{
            	    alt15 = 2;
            	    }
            	    break;
            	case 't':
            		{
            	    alt15 = 3;
            	    }
            	    break;
            	case '\'':
            		{
            	    alt15 = 4;
            	    }
            	    break;
            	case '\\':
            		{
            	    alt15 = 5;
            	    }
            	    break;
            	case 'u':
            		{
            	    alt15 = 6;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d15s0 =
            		        new NoViableAltException("", 15, 0, input);

            		    throw nvae_d15s0;
            	}

            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:630:5: 'n'
            	        {
            	        	Match('n'); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:631:4: 'r'
            	        {
            	        	Match('r'); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:632:4: 't'
            	        {
            	        	Match('t'); 

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:633:4: '\\''
            	        {
            	        	Match('\''); 

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:634:4: '\\\\'
            	        {
            	        	Match('\\'); 

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:635:4: UnicodeEscape
            	        {
            	        	mUnicodeEscape(); 

            	        }
            	        break;

            	}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeSequenceSingle"

    // $ANTLR start "EscapeSequenceDouble"
    public void mEscapeSequenceDouble() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:640:2: ( '\\\\' ( 'n' | 'r' | 't' | '\"' | '\\\\' | UnicodeEscape ) )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:640:4: '\\\\' ( 'n' | 'r' | 't' | '\"' | '\\\\' | UnicodeEscape )
            {
            	Match('\\'); 
            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:641:4: ( 'n' | 'r' | 't' | '\"' | '\\\\' | UnicodeEscape )
            	int alt16 = 6;
            	switch ( input.LA(1) ) 
            	{
            	case 'n':
            		{
            	    alt16 = 1;
            	    }
            	    break;
            	case 'r':
            		{
            	    alt16 = 2;
            	    }
            	    break;
            	case 't':
            		{
            	    alt16 = 3;
            	    }
            	    break;
            	case '\"':
            		{
            	    alt16 = 4;
            	    }
            	    break;
            	case '\\':
            		{
            	    alt16 = 5;
            	    }
            	    break;
            	case 'u':
            		{
            	    alt16 = 6;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d16s0 =
            		        new NoViableAltException("", 16, 0, input);

            		    throw nvae_d16s0;
            	}

            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:642:5: 'n'
            	        {
            	        	Match('n'); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:643:4: 'r'
            	        {
            	        	Match('r'); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:644:4: 't'
            	        {
            	        	Match('t'); 

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:645:4: '\"'
            	        {
            	        	Match('\"'); 

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:646:4: '\\\\'
            	        {
            	        	Match('\\'); 

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:647:4: UnicodeEscape
            	        {
            	        	mUnicodeEscape(); 

            	        }
            	        break;

            	}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeSequenceDouble"

    // $ANTLR start "HexDigit"
    public void mHexDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:652:2: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:652:5: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HexDigit"

    // $ANTLR start "UnicodeEscape"
    public void mUnicodeEscape() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:656:6: ( 'u' HexDigit HexDigit HexDigit HexDigit )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:656:12: 'u' HexDigit HexDigit HexDigit HexDigit
            {
            	Match('u'); 
            	mHexDigit(); 
            	mHexDigit(); 
            	mHexDigit(); 
            	mHexDigit(); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnicodeEscape"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:660:4: ( ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' ) )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:660:7: ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:664:5: ( '/*' ( options {greedy=false; } : . )* '*/' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:664:9: '/*' ( options {greedy=false; } : . )* '*/'
            {
            	Match("/*"); 

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:664:14: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == '*') )
            	    {
            	        int LA17_1 = input.LA(2);

            	        if ( (LA17_1 == '/') )
            	        {
            	            alt17 = 2;
            	        }
            	        else if ( ((LA17_1 >= '\u0000' && LA17_1 <= '.') || (LA17_1 >= '0' && LA17_1 <= '\uFFFF')) )
            	        {
            	            alt17 = 1;
            	        }


            	    }
            	    else if ( ((LA17_0 >= '\u0000' && LA17_0 <= ')') || (LA17_0 >= '+' && LA17_0 <= '\uFFFF')) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:664:42: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

            	Match("*/"); 

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "LINE_COMMENT"
    public void mLINE_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LINE_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:668:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:668:7: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match("//"); 

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:668:12: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( ((LA18_0 >= '\u0000' && LA18_0 <= '\t') || (LA18_0 >= '\u000B' && LA18_0 <= '\f') || (LA18_0 >= '\u000E' && LA18_0 <= '\uFFFF')) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:668:12: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements

            	// C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:668:26: ( '\\r' )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == '\r') )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:668:26: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 
            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LINE_COMMENT"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:8: ( T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | TRUE | FALSE | ID | NUMBER | E | STRING | REGEXP | LBRACK | RBRACK | LPAREN | RPAREN | WS | COMMENT | LINE_COMMENT )
        int alt20 = 72;
        alt20 = dfa20.Predict(input);
        switch (alt20) 
        {
            case 1 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:10: T__24
                {
                	mT__24(); 

                }
                break;
            case 2 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:16: T__25
                {
                	mT__25(); 

                }
                break;
            case 3 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:22: T__26
                {
                	mT__26(); 

                }
                break;
            case 4 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:28: T__27
                {
                	mT__27(); 

                }
                break;
            case 5 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:34: T__28
                {
                	mT__28(); 

                }
                break;
            case 6 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:40: T__29
                {
                	mT__29(); 

                }
                break;
            case 7 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:46: T__30
                {
                	mT__30(); 

                }
                break;
            case 8 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:52: T__31
                {
                	mT__31(); 

                }
                break;
            case 9 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:58: T__32
                {
                	mT__32(); 

                }
                break;
            case 10 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:64: T__33
                {
                	mT__33(); 

                }
                break;
            case 11 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:70: T__34
                {
                	mT__34(); 

                }
                break;
            case 12 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:76: T__35
                {
                	mT__35(); 

                }
                break;
            case 13 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:82: T__36
                {
                	mT__36(); 

                }
                break;
            case 14 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:88: T__37
                {
                	mT__37(); 

                }
                break;
            case 15 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:94: T__38
                {
                	mT__38(); 

                }
                break;
            case 16 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:100: T__39
                {
                	mT__39(); 

                }
                break;
            case 17 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:106: T__40
                {
                	mT__40(); 

                }
                break;
            case 18 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:112: T__41
                {
                	mT__41(); 

                }
                break;
            case 19 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:118: T__42
                {
                	mT__42(); 

                }
                break;
            case 20 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:124: T__43
                {
                	mT__43(); 

                }
                break;
            case 21 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:130: T__44
                {
                	mT__44(); 

                }
                break;
            case 22 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:136: T__45
                {
                	mT__45(); 

                }
                break;
            case 23 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:142: T__46
                {
                	mT__46(); 

                }
                break;
            case 24 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:148: T__47
                {
                	mT__47(); 

                }
                break;
            case 25 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:154: T__48
                {
                	mT__48(); 

                }
                break;
            case 26 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:160: T__49
                {
                	mT__49(); 

                }
                break;
            case 27 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:166: T__50
                {
                	mT__50(); 

                }
                break;
            case 28 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:172: T__51
                {
                	mT__51(); 

                }
                break;
            case 29 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:178: T__52
                {
                	mT__52(); 

                }
                break;
            case 30 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:184: T__53
                {
                	mT__53(); 

                }
                break;
            case 31 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:190: T__54
                {
                	mT__54(); 

                }
                break;
            case 32 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:196: T__55
                {
                	mT__55(); 

                }
                break;
            case 33 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:202: T__56
                {
                	mT__56(); 

                }
                break;
            case 34 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:208: T__57
                {
                	mT__57(); 

                }
                break;
            case 35 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:214: T__58
                {
                	mT__58(); 

                }
                break;
            case 36 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:220: T__59
                {
                	mT__59(); 

                }
                break;
            case 37 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:226: T__60
                {
                	mT__60(); 

                }
                break;
            case 38 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:232: T__61
                {
                	mT__61(); 

                }
                break;
            case 39 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:238: T__62
                {
                	mT__62(); 

                }
                break;
            case 40 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:244: T__63
                {
                	mT__63(); 

                }
                break;
            case 41 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:250: T__64
                {
                	mT__64(); 

                }
                break;
            case 42 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:256: T__65
                {
                	mT__65(); 

                }
                break;
            case 43 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:262: T__66
                {
                	mT__66(); 

                }
                break;
            case 44 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:268: T__67
                {
                	mT__67(); 

                }
                break;
            case 45 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:274: T__68
                {
                	mT__68(); 

                }
                break;
            case 46 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:280: T__69
                {
                	mT__69(); 

                }
                break;
            case 47 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:286: T__70
                {
                	mT__70(); 

                }
                break;
            case 48 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:292: T__71
                {
                	mT__71(); 

                }
                break;
            case 49 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:298: T__72
                {
                	mT__72(); 

                }
                break;
            case 50 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:304: T__73
                {
                	mT__73(); 

                }
                break;
            case 51 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:310: T__74
                {
                	mT__74(); 

                }
                break;
            case 52 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:316: T__75
                {
                	mT__75(); 

                }
                break;
            case 53 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:322: T__76
                {
                	mT__76(); 

                }
                break;
            case 54 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:328: T__77
                {
                	mT__77(); 

                }
                break;
            case 55 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:334: T__78
                {
                	mT__78(); 

                }
                break;
            case 56 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:340: T__79
                {
                	mT__79(); 

                }
                break;
            case 57 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:346: T__80
                {
                	mT__80(); 

                }
                break;
            case 58 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:352: T__81
                {
                	mT__81(); 

                }
                break;
            case 59 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:358: TRUE
                {
                	mTRUE(); 

                }
                break;
            case 60 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:363: FALSE
                {
                	mFALSE(); 

                }
                break;
            case 61 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:369: ID
                {
                	mID(); 

                }
                break;
            case 62 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:372: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 63 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:379: E
                {
                	mE(); 

                }
                break;
            case 64 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:381: STRING
                {
                	mSTRING(); 

                }
                break;
            case 65 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:388: REGEXP
                {
                	mREGEXP(); 

                }
                break;
            case 66 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:395: LBRACK
                {
                	mLBRACK(); 

                }
                break;
            case 67 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:402: RBRACK
                {
                	mRBRACK(); 

                }
                break;
            case 68 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:409: LPAREN
                {
                	mLPAREN(); 

                }
                break;
            case 69 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:416: RPAREN
                {
                	mRPAREN(); 

                }
                break;
            case 70 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:423: WS
                {
                	mWS(); 

                }
                break;
            case 71 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:426: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 72 :
                // C:\\Users\\s.ros\\Documents\\Développement\\jint\\trunk\\Jint\\JavaScript.g:1:434: LINE_COMMENT
                {
                	mLINE_COMMENT(); 

                }
                break;

        }

    }


    protected DFA7 dfa7;
    protected DFA13 dfa13;
    protected DFA20 dfa20;
	private void InitializeCyclicDFAs()
	{
	    this.dfa7 = new DFA7(this);
	    this.dfa13 = new DFA13(this);
	    this.dfa20 = new DFA20(this);

	    this.dfa13.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA13_SpecialStateTransition);
	    this.dfa20.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA20_SpecialStateTransition);
	}

    const string DFA7_eotS =
        "\x01\uffff\x01\x03\x02\uffff";
    const string DFA7_eofS =
        "\x04\uffff";
    const string DFA7_minS =
        "\x02\x2e\x02\uffff";
    const string DFA7_maxS =
        "\x02\x39\x02\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA7_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x02\x01\uffff\x0a\x01",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "593:1: NUMBER : ( ( DIGIT )* '.' ( DIGIT )+ ( E )? | ( DIGIT )+ ( E )? );"; }
        }

    }

    const string DFA13_eotS =
        "\x04\uffff\x01\x03\x01\uffff\x01\x03";
    const string DFA13_eofS =
        "\x07\uffff";
    const string DFA13_minS =
        "\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x00";
    const string DFA13_maxS =
        "\x01\uffff\x01\uffff\x01\uffff\x01\uffff\x01\uffff\x01\uffff\x01"+
        "\uffff";
    const string DFA13_acceptS =
        "\x01\uffff\x01\x03\x01\uffff\x01\x02\x01\uffff\x01\x01\x01\uffff";
    const string DFA13_specialS =
        "\x01\x03\x01\uffff\x01\x02\x01\uffff\x01\x01\x01\uffff\x01\x00}>";
    static readonly string[] DFA13_transitionS = {
            "\x2f\x03\x01\x01\x2c\x03\x01\x02\uffa3\x03",
            "",
            "\x2f\x03\x01\x04\uffd0\x03",
            "",
            "\x67\x05\x01\x06\x01\x05\x01\x06\x03\x05\x01\x06\uff92\x05",
            "",
            "\x67\x05\x01\x06\x01\x05\x01\x06\x03\x05\x01\x06\uff92\x05"
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 607:77: ( '\\\\/' | ~ ( '/' ) )*"; }
        }

    }


    protected internal int DFA13_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA13_6 = input.LA(1);

                   	s = -1;
                   	if ( ((LA13_6 >= '\u0000' && LA13_6 <= 'f') || LA13_6 == 'h' || (LA13_6 >= 'j' && LA13_6 <= 'l') || (LA13_6 >= 'n' && LA13_6 <= '\uFFFF')) ) { s = 5; }

                   	else if ( (LA13_6 == 'g' || LA13_6 == 'i' || LA13_6 == 'm') ) { s = 6; }

                   	else s = 3;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA13_4 = input.LA(1);

                   	s = -1;
                   	if ( ((LA13_4 >= '\u0000' && LA13_4 <= 'f') || LA13_4 == 'h' || (LA13_4 >= 'j' && LA13_4 <= 'l') || (LA13_4 >= 'n' && LA13_4 <= '\uFFFF')) ) { s = 5; }

                   	else if ( (LA13_4 == 'g' || LA13_4 == 'i' || LA13_4 == 'm') ) { s = 6; }

                   	else s = 3;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA13_2 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_2 == '/') ) { s = 4; }

                   	else if ( ((LA13_2 >= '\u0000' && LA13_2 <= '.') || (LA13_2 >= '0' && LA13_2 <= '\uFFFF')) ) { s = 3; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA13_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_0 == '/') ) { s = 1; }

                   	else if ( (LA13_0 == '\\') ) { s = 2; }

                   	else if ( ((LA13_0 >= '\u0000' && LA13_0 <= '.') || (LA13_0 >= '0' && LA13_0 <= '[') || (LA13_0 >= ']' && LA13_0 <= '\uFFFF')) ) { s = 3; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae13 =
            new NoViableAltException(dfa.Description, 13, _s, input);
        dfa.Error(nvae13);
        throw nvae13;
    }
    const string DFA20_eotS =
        "\x02\uffff\x03\x22\x01\uffff\x01\x2e\x06\x22\x01\uffff\x02\x22"+
        "\x01\x43\x01\x46\x01\x48\x01\x4d\x01\x50\x01\x53\x04\uffff\x01\x59"+
        "\x03\uffff\x01\x5a\x02\x22\x08\uffff\x04\x22\x01\x62\x01\uffff\x01"+
        "\x63\x01\x65\x03\x22\x01\uffff\x05\x22\x01\x6d\x06\x22\x17\uffff"+
        "\x01\x78\x02\uffff\x05\x22\x01\x7e\x03\uffff\x01\x22\x01\uffff\x03"+
        "\x22\x01\u0083\x03\x22\x01\uffff\x04\x22\x01\u008b\x02\x22\x04\uffff"+
        "\x01\u008e\x01\x22\x01\u0090\x02\x22\x01\uffff\x01\x22\x01\u0094"+
        "\x01\u0095\x01\x22\x01\uffff\x07\x22\x01\uffff\x01\u009e\x01\x22"+
        "\x01\uffff\x01\x22\x01\uffff\x01\u00a1\x01\u00a2\x01\x22\x02\uffff"+
        "\x02\x22\x01\u00a6\x02\x22\x01\u00a9\x01\x22\x01\u00ab\x01\uffff"+
        "\x02\x22\x02\uffff\x03\x22\x01\uffff\x01\u00b1\x01\x22\x01\uffff"+
        "\x01\u00b3\x01\uffff\x01\u00b4\x03\x22\x01\u00b8\x01\uffff\x01\u00b9"+
        "\x02\uffff\x01\u00ba\x01\x22\x01\u00bc\x03\uffff\x01\x22\x01\uffff"+
        "\x01\u00be\x01\uffff";
    const string DFA20_eofS =
        "\u00bf\uffff";
    const string DFA20_minS =
        "\x01\x09\x01\uffff\x01\x61\x01\x72\x01\x61\x01\uffff\x01\x3d\x01"+
        "\x66\x01\x2b\x01\x61\x02\x65\x01\x68\x01\uffff\x01\x77\x01\x68\x01"+
        "\x2b\x01\x2d\x01\x3d\x01\x00\x01\x3d\x01\x3c\x01\x26\x01\x3d\x02"+
        "\uffff\x01\x3d\x03\uffff\x01\x30\x01\x65\x01\x2b\x08\uffff\x01\x6e"+
        "\x01\x73\x01\x65\x01\x72\x01\x3d\x01\uffff\x02\x24\x01\x73\x01\x63"+
        "\x01\x30\x01\uffff\x01\x6e\x01\x72\x01\x6e\x01\x6c\x01\x74\x01\x24"+
        "\x01\x66\x02\x69\x01\x72\x01\x75\x01\x70\x0d\uffff\x01\x3d\x09\uffff"+
        "\x01\x3d\x02\uffff\x01\x77\x01\x74\x01\x65\x01\x63\x01\x61\x01\x24"+
        "\x03\uffff\x01\x74\x01\uffff\x01\x65\x01\x68\x01\x63\x01\x24\x01"+
        "\x61\x01\x73\x01\x75\x01\uffff\x01\x61\x01\x6c\x01\x74\x01\x6f\x01"+
        "\x24\x02\x65\x04\uffff\x01\x24\x01\x69\x01\x24\x01\x68\x01\x6b\x01"+
        "\uffff\x01\x61\x02\x24\x01\x74\x01\uffff\x01\x6c\x01\x65\x01\x72"+
        "\x01\x75\x01\x65\x01\x63\x01\x77\x01\uffff\x01\x24\x01\x6f\x01\uffff"+
        "\x01\x6e\x01\uffff\x02\x24\x01\x6e\x02\uffff\x01\x69\x01\x6c\x01"+
        "\x24\x01\x6e\x01\x6c\x01\x24\x01\x68\x01\x24\x01\uffff\x01\x66\x01"+
        "\x75\x02\uffff\x01\x63\x01\x6f\x01\x79\x01\uffff\x01\x24\x01\x74"+
        "\x01\uffff\x01\x24\x01\uffff\x01\x24\x02\x65\x01\x6e\x01\x24\x01"+
        "\uffff\x01\x24\x02\uffff\x01\x24\x01\x6f\x01\x24\x03\uffff\x01\x66"+
        "\x01\uffff\x01\x24\x01\uffff";
    const string DFA20_maxS =
        "\x01\x7d\x01\uffff\x01\x6f\x01\x72\x01\x61\x01\uffff\x01\x3d\x01"+
        "\x6e\x01\x6c\x01\x75\x01\x65\x01\x6f\x01\x68\x01\uffff\x01\x77\x01"+
        "\x79\x03\x3d\x01\uffff\x01\x3e\x02\x3d\x01\x7c\x02\uffff\x01\x3d"+
        "\x03\uffff\x01\x39\x01\x65\x01\x39\x08\uffff\x01\x6e\x01\x74\x01"+
        "\x65\x01\x72\x01\x3d\x01\uffff\x02\x7a\x01\x73\x01\x63\x01\x39\x01"+
        "\uffff\x01\x6e\x01\x72\x01\x6e\x01\x6c\x01\x74\x01\x7a\x01\x66\x02"+
        "\x69\x01\x72\x01\x79\x01\x70\x0d\uffff\x01\x3e\x09\uffff\x01\x3d"+
        "\x02\uffff\x01\x77\x01\x74\x01\x65\x01\x63\x01\x61\x01\x7a\x03\uffff"+
        "\x01\x74\x01\uffff\x01\x65\x01\x68\x01\x63\x01\x7a\x01\x61\x01\x73"+
        "\x01\x75\x01\uffff\x01\x61\x01\x6c\x01\x74\x01\x6f\x01\x7a\x02\x65"+
        "\x04\uffff\x01\x7a\x01\x69\x01\x7a\x01\x68\x01\x6b\x01\uffff\x01"+
        "\x61\x02\x7a\x01\x74\x01\uffff\x01\x6c\x01\x65\x01\x72\x01\x75\x01"+
        "\x65\x01\x63\x01\x77\x01\uffff\x01\x7a\x01\x6f\x01\uffff\x01\x6e"+
        "\x01\uffff\x02\x7a\x01\x6e\x02\uffff\x01\x69\x01\x6c\x01\x7a\x01"+
        "\x6e\x01\x6c\x01\x7a\x01\x68\x01\x7a\x01\uffff\x01\x66\x01\x75\x02"+
        "\uffff\x01\x63\x01\x6f\x01\x79\x01\uffff\x01\x7a\x01\x74\x01\uffff"+
        "\x01\x7a\x01\uffff\x01\x7a\x02\x65\x01\x6e\x01\x7a\x01\uffff\x01"+
        "\x7a\x02\uffff\x01\x7a\x01\x6f\x01\x7a\x03\uffff\x01\x66\x01\uffff"+
        "\x01\x7a\x01\uffff";
    const string DFA20_acceptS =
        "\x01\uffff\x01\x01\x03\uffff\x01\x05\x07\uffff\x01\x11\x0a\uffff"+
        "\x01\x21\x01\x22\x01\uffff\x01\x31\x01\x37\x01\x38\x03\uffff\x01"+
        "\x3e\x01\x3d\x01\x40\x01\x42\x01\x43\x01\x44\x01\x45\x01\x46\x05"+
        "\uffff\x01\x06\x05\uffff\x01\x3f\x0c\uffff\x01\x18\x01\x33\x01\x2d"+
        "\x01\x19\x01\x32\x01\x2e\x01\x1a\x01\x2f\x01\x1b\x01\x41\x01\x47"+
        "\x01\x48\x01\x30\x01\uffff\x01\x2c\x01\x2b\x01\x1d\x01\x2a\x01\x29"+
        "\x01\x1f\x01\x24\x01\x20\x01\x23\x01\uffff\x01\x34\x01\x39\x06\uffff"+
        "\x01\x26\x01\x25\x01\x07\x01\uffff\x01\x0f\x07\uffff\x01\x0b\x07"+
        "\uffff\x01\x1c\x01\x1e\x01\x28\x01\x27\x05\uffff\x01\x04\x04\uffff"+
        "\x01\x0d\x07\uffff\x01\x15\x02\uffff\x01\x3a\x01\uffff\x01\x10\x03"+
        "\uffff\x01\x08\x01\x0e\x08\uffff\x01\x3b\x02\uffff\x01\x16\x01\x03"+
        "\x03\uffff\x01\x3c\x02\uffff\x01\x0c\x01\uffff\x01\x14\x05\uffff"+
        "\x01\x0a\x01\uffff\x01\x12\x01\x35\x03\uffff\x01\x17\x01\x13\x01"+
        "\x02\x01\uffff\x01\x09\x01\uffff\x01\x36";
    const string DFA20_specialS =
        "\x13\uffff\x01\x00\u00ab\uffff}>";
    static readonly string[] DFA20_transitionS = {
            "\x02\x28\x01\uffff\x02\x28\x12\uffff\x01\x28\x01\x1a\x01\x23"+
            "\x01\uffff\x01\x22\x01\x1b\x01\x16\x01\x23\x01\x26\x01\x27\x01"+
            "\x12\x01\x10\x01\x05\x01\x11\x01\x1e\x01\x13\x0a\x21\x01\x0d"+
            "\x01\x01\x01\x15\x01\x06\x01\x14\x01\x19\x01\uffff\x04\x22\x01"+
            "\x20\x15\x22\x01\x1c\x01\uffff\x01\x1d\x01\x18\x01\x22\x01\uffff"+
            "\x01\x22\x01\x03\x01\x02\x01\x0b\x01\x08\x01\x09\x02\x22\x01"+
            "\x07\x04\x22\x01\x1f\x03\x22\x01\x0a\x01\x0e\x01\x0f\x01\x22"+
            "\x01\x04\x01\x0c\x03\x22\x01\x24\x01\x17\x01\x25",
            "",
            "\x01\x2a\x0d\uffff\x01\x29",
            "\x01\x2b",
            "\x01\x2c",
            "",
            "\x01\x2d",
            "\x01\x2f\x07\uffff\x01\x30",
            "\x01\x34\x01\uffff\x01\x34\x02\uffff\x0a\x33\x27\uffff\x01"+
            "\x32\x0a\uffff\x01\x31",
            "\x01\x38\x07\uffff\x01\x37\x05\uffff\x01\x36\x05\uffff\x01"+
            "\x35",
            "\x01\x39",
            "\x01\x3b\x09\uffff\x01\x3a",
            "\x01\x3c",
            "",
            "\x01\x3d",
            "\x01\x3e\x09\uffff\x01\x3f\x06\uffff\x01\x40",
            "\x01\x42\x11\uffff\x01\x41",
            "\x01\x45\x0f\uffff\x01\x44",
            "\x01\x47",
            "\x20\x4a\x01\uffff\x09\x4a\x01\x4b\x04\x4a\x01\x4c\x0d\x4a"+
            "\x01\x49\uffc2\x4a",
            "\x01\x4f\x01\x4e",
            "\x01\x51\x01\x52",
            "\x01\x55\x16\uffff\x01\x54",
            "\x01\x56\x3e\uffff\x01\x57",
            "",
            "",
            "\x01\x58",
            "",
            "",
            "",
            "\x0a\x21",
            "\x01\x5b",
            "\x01\x34\x01\uffff\x01\x34\x02\uffff\x0a\x33",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x5c",
            "\x01\x5d\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x12\x22\x01\x64\x07\x22",
            "\x01\x66",
            "\x01\x67",
            "\x0a\x33",
            "",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x6b",
            "\x01\x6c",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "\x01\x71",
            "\x01\x73\x03\uffff\x01\x72",
            "\x01\x74",
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
            "\x01\x75\x01\x76",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x77",
            "",
            "",
            "\x01\x79",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x7c",
            "\x01\x7d",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "",
            "",
            "",
            "\x01\x7f",
            "",
            "\x01\u0080",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u0084",
            "\x01\u0085",
            "\x01\u0086",
            "",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u008c",
            "\x01\u008d",
            "",
            "",
            "",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u008f",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u0091",
            "\x01\u0092",
            "",
            "\x01\u0093",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u0096",
            "",
            "\x01\u0097",
            "\x01\u0098",
            "\x01\u0099",
            "\x01\u009a",
            "\x01\u009b",
            "\x01\u009c",
            "\x01\u009d",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u009f",
            "",
            "\x01\u00a0",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u00a3",
            "",
            "",
            "\x01\u00a4",
            "\x01\u00a5",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u00a7",
            "\x01\u00a8",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u00aa",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "",
            "\x01\u00ac",
            "\x01\u00ad",
            "",
            "",
            "\x01\u00ae",
            "\x01\u00af",
            "\x01\u00b0",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u00b2",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u00b5",
            "\x01\u00b6",
            "\x01\u00b7",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "\x01\u00bb",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            "",
            "",
            "",
            "\x01\u00bd",
            "",
            "\x01\x22\x0b\uffff\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01"+
            "\x22\x01\uffff\x1a\x22",
            ""
    };

    static readonly short[] DFA20_eot = DFA.UnpackEncodedString(DFA20_eotS);
    static readonly short[] DFA20_eof = DFA.UnpackEncodedString(DFA20_eofS);
    static readonly char[] DFA20_min = DFA.UnpackEncodedStringToUnsignedChars(DFA20_minS);
    static readonly char[] DFA20_max = DFA.UnpackEncodedStringToUnsignedChars(DFA20_maxS);
    static readonly short[] DFA20_accept = DFA.UnpackEncodedString(DFA20_acceptS);
    static readonly short[] DFA20_special = DFA.UnpackEncodedString(DFA20_specialS);
    static readonly short[][] DFA20_transition = DFA.UnpackEncodedStringArray(DFA20_transitionS);

    protected class DFA20 : DFA
    {
        public DFA20(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 20;
            this.eot = DFA20_eot;
            this.eof = DFA20_eof;
            this.min = DFA20_min;
            this.max = DFA20_max;
            this.accept = DFA20_accept;
            this.special = DFA20_special;
            this.transition = DFA20_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | TRUE | FALSE | ID | NUMBER | E | STRING | REGEXP | LBRACK | RBRACK | LPAREN | RPAREN | WS | COMMENT | LINE_COMMENT );"; }
        }

    }


    protected internal int DFA20_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA20_19 = input.LA(1);

                   	 
                   	int index20_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA20_19 == '=') ) { s = 73; }

                   	else if ( ((LA20_19 >= '\u0000' && LA20_19 <= '\u001F') || (LA20_19 >= '!' && LA20_19 <= ')') || (LA20_19 >= '+' && LA20_19 <= '.') || (LA20_19 >= '0' && LA20_19 <= '<') || (LA20_19 >= '>' && LA20_19 <= '\uFFFF')) && (( areRegularExpressionsEnabled() )) ) { s = 74; }

                   	else if ( (LA20_19 == '*') ) { s = 75; }

                   	else if ( (LA20_19 == '/') ) { s = 76; }

                   	else s = 77;

                   	 
                   	input.Seek(index20_19);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae20 =
            new NoViableAltException(dfa.Description, 20, _s, input);
        dfa.Error(nvae20);
        throw nvae20;
    }
 
    
}
