﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace NSwag.CodeGeneration.CodeGenerators.CSharp.Templates
{
    using NJsonSchema;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\JsonExceptionConverterTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    internal partial class JsonExceptionConverterTemplate : JsonExceptionConverterTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("[GeneratedCode(\"NSwag\", \"");
            
            #line 3 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\JsonExceptionConverterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SwaggerService.ToolchainVersion));
            
            #line default
            #line hidden
            this.Write(@""")]
internal class JsonExceptionConverter : JsonConverter
{
    private readonly DefaultContractResolver _defaultContractResolver = new DefaultContractResolver();
    private readonly IDictionary<string, Assembly> _searchedNamespaces;
    private readonly bool _hideStackTrace = false;

    public JsonExceptionConverter()
    {
        _searchedNamespaces = new Dictionary<string, Assembly> { { typeof(");
            
            #line 12 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\JsonExceptionConverterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ExceptionModelClass));
            
            #line default
            #line hidden
            this.Write(").Namespace, typeof(");
            
            #line 12 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\JsonExceptionConverterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ExceptionModelClass));
            
            #line default
            #line hidden
            this.Write(").GetTypeInfo().Assembly } };\r\n    }\r\n\r\n    public override bool CanWrite => true" +
                    ";\r\n\r\n    public override void WriteJson(JsonWriter writer, object value, JsonSer" +
                    "ializer serializer)\r\n    {\r\n        var exception = value as Exception;\r\n       " +
                    " if (exception != null)\r\n        {\r\n            var resolver = serializer.Contra" +
                    "ctResolver as DefaultContractResolver ?? _defaultContractResolver;\r\n\r\n          " +
                    "  var jObject = new JObject();\r\n            jObject.Add(resolver.GetResolvedProp" +
                    "ertyName(\"discriminator\"), exception.GetType().Name);\r\n            jObject.Add(r" +
                    "esolver.GetResolvedPropertyName(\"Message\"), exception.Message);\r\n            jOb" +
                    "ject.Add(resolver.GetResolvedPropertyName(\"StackTrace\"), _hideStackTrace ? \"HIDD" +
                    "EN\" : exception.StackTrace);\r\n            jObject.Add(resolver.GetResolvedProper" +
                    "tyName(\"Source\"), exception.Source);\r\n            jObject.Add(resolver.GetResolv" +
                    "edPropertyName(\"InnerException\"),\r\n                exception.InnerException != n" +
                    "ull ? JToken.FromObject(exception.InnerException, serializer) : null);\r\n\r\n      " +
                    "      foreach (var property in GetExceptionProperties(value.GetType()))\r\n       " +
                    "     {\r\n                var propertyValue = property.Key.GetValue(exception);\r\n " +
                    "               if (propertyValue != null)\r\n                {\r\n                  " +
                    "  jObject.AddFirst(new JProperty(resolver.GetResolvedPropertyName(property.Value" +
                    "),\r\n                        JToken.FromObject(propertyValue, serializer)));\r\n   " +
                    "             }\r\n            }\r\n\r\n            value = jObject;\r\n        }\r\n\r\n    " +
                    "    serializer.Serialize(writer, value);\r\n    }\r\n\r\n    public override bool CanC" +
                    "onvert(Type objectType)\r\n    {\r\n        return typeof(Exception).GetTypeInfo().I" +
                    "sAssignableFrom(objectType.GetTypeInfo());\r\n    }\r\n\r\n    public override object " +
                    "ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerialize" +
                    "r serializer)\r\n    {\r\n        var jObject = serializer.Deserialize<JObject>(read" +
                    "er);\r\n        if (jObject == null)\r\n            return null;\r\n\r\n        var newS" +
                    "erializer = new JsonSerializer();\r\n        newSerializer.ContractResolver = (ICo" +
                    "ntractResolver)Activator.CreateInstance(serializer.ContractResolver.GetType());\r" +
                    "\n\r\n        GetField(typeof(DefaultContractResolver), \"_sharedCache\").SetValue(ne" +
                    "wSerializer.ContractResolver, false);\r\n\r\n        dynamic resolver = newSerialize" +
                    "r.ContractResolver;\r\n        if (newSerializer.ContractResolver.GetType().GetRun" +
                    "timeProperty(\"IgnoreSerializableAttribute\") != null)\r\n            resolver.Ignor" +
                    "eSerializableAttribute = true;\r\n        if (newSerializer.ContractResolver.GetTy" +
                    "pe().GetRuntimeProperty(\"IgnoreSerializableInterface\") != null)\r\n            res" +
                    "olver.IgnoreSerializableInterface = true;\r\n\r\n        JToken token;\r\n        if (" +
                    "jObject.TryGetValue(\"discriminator\", StringComparison.OrdinalIgnoreCase, out tok" +
                    "en))\r\n        {\r\n            var discriminator = token.Value<string>();\r\n       " +
                    "     if (objectType.Name.Equals(discriminator) == false)\r\n            {\r\n       " +
                    "         var exceptionType = Type.GetType(\"System.\" + discriminator, false);\r\n  " +
                    "              if (exceptionType != null)\r\n                    objectType = excep" +
                    "tionType;\r\n                else\r\n                {\r\n                    foreach " +
                    "(var pair in _searchedNamespaces)\r\n                    {\r\n                      " +
                    "  exceptionType = pair.Value.GetType(pair.Key + \".\" + discriminator);\r\n         " +
                    "               if (exceptionType != null)\r\n                        {\r\n          " +
                    "                  objectType = exceptionType;\r\n                            break" +
                    ";\r\n                        }\r\n                    }\r\n\r\n                }\r\n      " +
                    "      }\r\n        }\r\n\r\n        var value = jObject.ToObject(objectType, newSerial" +
                    "izer);\r\n        foreach (var property in GetExceptionProperties(value.GetType())" +
                    ")\r\n        {\r\n            var jValue = jObject.GetValue(resolver.GetResolvedProp" +
                    "ertyName(property.Value));\r\n            var propertyValue = (object)jValue?.ToOb" +
                    "ject(property.Key.PropertyType);\r\n            if (property.Key.SetMethod != null" +
                    ")\r\n                property.Key.SetValue(value, propertyValue);\r\n            els" +
                    "e\r\n            {\r\n                var field = GetField(objectType, \"m_\" + proper" +
                    "ty.Value.Substring(0, 1).ToLowerInvariant() + property.Value.Substring(1));\r\n   " +
                    "             if (field != null)\r\n                    field.SetValue(value, prope" +
                    "rtyValue);\r\n            }\r\n        }\r\n\r\n        SetExceptionFieldValue(jObject, " +
                    "\"Message\", value, \"_message\", resolver, newSerializer);\r\n        SetExceptionFie" +
                    "ldValue(jObject, \"StackTrace\", value, \"_stackTraceString\", resolver, newSerializ" +
                    "er);\r\n        SetExceptionFieldValue(jObject, \"Source\", value, \"_source\", resolv" +
                    "er, newSerializer);\r\n        SetExceptionFieldValue(jObject, \"InnerException\", v" +
                    "alue, \"_innerException\", resolver, serializer);\r\n\r\n        return value;\r\n    }\r" +
                    "\n\r\n    private FieldInfo GetField(Type type, string fieldName)\r\n    {\r\n        v" +
                    "ar field = type.GetTypeInfo().GetDeclaredField(fieldName);\r\n        if (field ==" +
                    " null && type.GetTypeInfo().BaseType != null)\r\n            return GetField(type." +
                    "GetTypeInfo().BaseType, fieldName);\r\n        return field;\r\n    }\r\n\r\n    private" +
                    " IDictionary<PropertyInfo, string> GetExceptionProperties(Type exceptionType)\r\n " +
                    "   {\r\n        var result = new Dictionary<PropertyInfo, string>();\r\n        fore" +
                    "ach (var property in exceptionType.GetRuntimeProperties().Where(p => p.GetMethod" +
                    "?.IsPublic == true))\r\n        {\r\n            var attribute = property.GetCustomA" +
                    "ttribute<JsonPropertyAttribute>();\r\n            var propertyName = attribute != " +
                    "null ? attribute.PropertyName : property.Name;\r\n\r\n            if (!new[] { \"Mess" +
                    "age\", \"StackTrace\", \"Source\", \"InnerException\", \"Data\", \"TargetSite\", \"HelpLink\"" +
                    ", \"HResult\" }.Contains(propertyName))\r\n                result[property] = proper" +
                    "tyName;\r\n        }\r\n        return result;\r\n    }\r\n\r\n    private void SetExcepti" +
                    "onFieldValue(JObject jObject, string propertyName, object value, string fieldNam" +
                    "e, IContractResolver resolver, JsonSerializer serializer)\r\n    {\r\n        var fi" +
                    "eld = typeof(Exception).GetTypeInfo().GetDeclaredField(fieldName);\r\n        var " +
                    "jsonPropertyName = resolver is DefaultContractResolver ? ((DefaultContractResolv" +
                    "er)resolver).GetResolvedPropertyName(propertyName) : propertyName;\r\n        if (" +
                    "jObject[jsonPropertyName] != null)\r\n        {\r\n            var fieldValue = jObj" +
                    "ect[jsonPropertyName].ToObject(field.FieldType, serializer);\r\n            field." +
                    "SetValue(value, fieldValue);\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    internal class JsonExceptionConverterTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
