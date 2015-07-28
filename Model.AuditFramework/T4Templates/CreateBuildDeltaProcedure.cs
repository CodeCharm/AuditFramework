﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeCharm.Model.AuditFramework.T4Templates
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\mcbeea\Desktop\AuditFramework\Model.AuditFramework\T4Templates\CreateBuildDeltaProcedure.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class CreateBuildDeltaProcedure : CreateBuildDeltaProcedureBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\nIF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N\'[");
            
            #line 3 "C:\Users\mcbeea\Desktop\AuditFramework\Model.AuditFramework\T4Templates\CreateBuildDeltaProcedure.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_params.AuditingSchema));
            
            #line default
            #line hidden
            this.Write("].[BuildDelta]\') AND type IN (N\'P\', N\'PC\'))\r\n    DROP PROCEDURE [");
            
            #line 4 "C:\Users\mcbeea\Desktop\AuditFramework\Model.AuditFramework\T4Templates\CreateBuildDeltaProcedure.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_params.AuditingSchema));
            
            #line default
            #line hidden
            this.Write("].[BuildDelta]\r\nGO\r\n\r\nCREATE PROCEDURE [");
            
            #line 7 "C:\Users\mcbeea\Desktop\AuditFramework\Model.AuditFramework\T4Templates\CreateBuildDeltaProcedure.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_params.AuditingSchema));
            
            #line default
            #line hidden
            this.Write("].[BuildDelta]\r\nAS\r\n\r\n/*\r\n    READ THIS BEFORE EDITING THIS CODE\r\n    -----------" +
                    "-----------------------\r\n    This code was automatically generated by the\r\n    H" +
                    "ealthNet.FederalServices.Model.AuditFramework\r\n    project.\r\n    \r\n    If you mo" +
                    "dify this code, and then execute \r\n    the AuditFramework tool, your modificatio" +
                    "ns\r\n    will be ignored and overwritten.\r\n    \r\n    Template: CreateBuildDeltaPr" +
                    "ocedure.tt\r\n    \r\n    REMARKS\r\n    -------\r\n    This procedure is meant to be ex" +
                    "ecuted sparsely.\r\n    It walks through the AuditMaster table, looking for Tracke" +
                    "d\r\n    records that have not had a corresponding Delta record built \r\n    to sho" +
                    "w which fields have changed. When it finds a record\r\n    without a Delta record," +
                    " it calls the Delta* procedure\r\n    to create the Delta record.\r\n    \r\n    The t" +
                    "ime to call this stored procedure is when you want\r\n    to make sure the AuditMa" +
                    "ster, Track, and Delta tables reflect\r\n    all recent changes. It is important t" +
                    "o call it just before\r\n    attempting to retrieve records, but it is not necessa" +
                    "ry to \r\n    call this procedure before every single attempt if those attempts\r\n " +
                    "   occur rapidly.\r\n    \r\n    As a maintenance note, it is very important that th" +
                    "e BuildDelta\r\n    procedure is executed prior to performing DDL that changes the" +
                    "\r\n    schema (followed by a new execution of the AuditFramework tool).\r\n    The " +
                    "Delta* procedures compare prior versions of the tracking tables\r\n    against onl" +
                    "y the current schema version (as of the time the \r\n    AuditFramework tool is ru" +
                    "n). The results of running BuildDelta on \r\n    records which have not been check" +
                    "ed prior to updating the schema \r\n    is not predictable, and is not expected to" +
                    " work.\r\n*/\r\n\tSET NOCOUNT ON;\r\n\r\n\tBEGIN TRY\r\n\t    BEGIN TRANSACTION;\r\n\t    SAVE T" +
                    "RANSACTION ");
            
            #line 52 "C:\Users\mcbeea\Desktop\AuditFramework\Model.AuditFramework\T4Templates\CreateBuildDeltaProcedure.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_params.AuditingSchema));
            
            #line default
            #line hidden
            this.Write(@"ºBuildDelta;

	    DECLARE @TrackId [BIGINT];
	    DECLARE @TrackingTableName [SYSNAME];
	    DECLARE @DeltaProcedureSql [NVARCHAR](max);

	    DECLARE masterCursor CURSOR LOCAL
	        FAST_FORWARD
	        FOR SELECT    [AuditMaster].[TrackºId]
	                    , [AuditMaster].[TrackTableVersionName]
	                FROM    [");
            
            #line 62 "C:\Users\mcbeea\Desktop\AuditFramework\Model.AuditFramework\T4Templates\CreateBuildDeltaProcedure.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_params.AuditingSchema));
            
            #line default
            #line hidden
            this.Write("].[AuditMaster]\r\n\t                    INNER JOIN  [");
            
            #line 63 "C:\Users\mcbeea\Desktop\AuditFramework\Model.AuditFramework\T4Templates\CreateBuildDeltaProcedure.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_params.AuditingSchema));
            
            #line default
            #line hidden
            this.Write(@"].[Catalog]
	                            ON  [Catalog].[AuditingTableName] = [AuditMaster].[TrackTableVersionName]
	                WHERE   [AuditMaster].[PriorTrackºId] IS NULL
	                    AND [Catalog].[Archived] = 0
	                ORDER BY  [AuditMaster].[TransactionSequence]
	                        , [AuditMaster].[TimestampUtc]
	                        , [AuditMaster].[TrackºId];

	    OPEN masterCursor;

	    FETCH NEXT FROM masterCursor
	        INTO    @TrackId, @TrackingTableName;

	    WHILE @@FETCH_STATUS = 0
	    BEGIN

	        SET @DeltaProcedureSql = '[");
            
            #line 79 "C:\Users\mcbeea\Desktop\AuditFramework\Model.AuditFramework\T4Templates\CreateBuildDeltaProcedure.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_params.AuditingSchema));
            
            #line default
            #line hidden
            this.Write(@"].[Deltaº' + @TrackingTableName + ']';
	        
	        EXECUTE @DeltaProcedureSql @TrackId;

	        FETCH NEXT FROM masterCursor
	            INTO    @TrackId, @TrackingTableName;
	    END;

	    CLOSE   masterCursor;
	    DEALLOCATE  masterCursor;

	    COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
	    DECLARE	  @ErrorMessage    NVARCHAR(4000)
			  	, @ErrorNumber     INT
				, @ErrorSeverity   INT
				, @ErrorState      INT
				, @ErrorLine       INT
				, @ErrorProcedure  NVARCHAR(200);

	    -- Assign variables to error-handling functions that 
	    -- capture information for RAISERROR.
	    SELECT	  @ErrorNumber = ERROR_NUMBER()
				, @ErrorSeverity = ERROR_SEVERITY()
				, @ErrorState = ERROR_STATE()
				, @ErrorLine = ERROR_LINE()
				, @ErrorProcedure = ISNULL(ERROR_PROCEDURE(), '-');

		IF XACT_STATE() = -1 -- uncommittable
		BEGIN
			ROLLBACK TRANSACTION ");
            
            #line 110 "C:\Users\mcbeea\Desktop\AuditFramework\Model.AuditFramework\T4Templates\CreateBuildDeltaProcedure.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_params.AuditingSchema));
            
            #line default
            #line hidden
            this.Write(@"ºBuildDelta;
		END;
		
		IF XACT_STATE() = 1 -- committable
		BEGIN
			COMMIT TRANSACTION;
		END;
		
	    -- Build the message string that will contain original
	    -- error information.
	    SELECT @ErrorMessage = N'Error %d, Level %d, State %d, Procedure %s, Line %d, Message: '+ ERROR_MESSAGE();
		
		IF @ErrorState = 0
			SET @ErrorState = 1;

	    -- Raise an error: msg_str parameter of RAISERROR will contain
	    -- the original error information.
	    RAISERROR 
	        (
	          @ErrorMessage 
	        , @ErrorSeverity 
	        , 1               
	        , @ErrorNumber    	-- parameter: original error number.
	        , @ErrorSeverity  	-- parameter: original error severity.
	        , @ErrorState     	-- parameter: original error state.
	        , @ErrorProcedure 	-- parameter: original error procedure name.
	        , @ErrorLine       	-- parameter: original error line number.
	        );

	END CATCH;

GO");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class CreateBuildDeltaProcedureBase
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
