﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CashFlow.Exceptions {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResourceErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public ResourceErrorMessages() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CashFlow.Exceptions.ResourceErrorMessages", typeof(ResourceErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The amount must be greater then zero..
        /// </summary>
        public static string AMOUNT_MUST_BE_GREATHER_THAN_ZERO {
            get {
                return ResourceManager.GetString("AMOUNT_MUST_BE_GREATHER_THAN_ZERO", resourceCulture);
            }
        }

        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Expenses cannot be for the future.
        /// </summary>
        public static string EXPENSES_CANNOT_FOR_THE_FUTURE {
            get {
                return ResourceManager.GetString("EXPENSES_CANNOT_FOR_THE_FUTURE", resourceCulture);
            }
        }

        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a You must choose a valid payment type..
        /// </summary>
        public static string PAYMENT_TYPE_VALID {
            get {
                return ResourceManager.GetString("PAYMENT_TYPE_VALID", resourceCulture);
            }
        }

        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The title is required..
        /// </summary>
        public static string TITLE_REQUIRED {
            get {
                return ResourceManager.GetString("TITLE_REQUIRED", resourceCulture);
            }
        }

        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a unknown error.
        /// </summary>
        public static string UNKNOW_ERROR {
            get {
                return ResourceManager.GetString("UNKNOW_ERROR", resourceCulture);
            }
        }
    }
}
