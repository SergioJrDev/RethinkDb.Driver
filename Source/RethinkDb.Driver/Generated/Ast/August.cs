








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class August : ReqlQuery {
    
    
        public August (object arg) : this(new Arguments(arg), null) {
        }
        public August (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public August (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.AUGUST, args, optargs) {
        }

    protected August (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static August FromArgs(params object[] args){
         return new August (new Arguments(args), null);
        }


    

    


    
    }
}