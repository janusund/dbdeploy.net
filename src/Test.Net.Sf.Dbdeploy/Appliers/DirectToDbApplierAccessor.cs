﻿using System.IO;
using Net.Sf.Dbdeploy.Database;
using Net.Sf.Dbdeploy.Scripts;

namespace Net.Sf.Dbdeploy.Appliers
{
    using System.Text;

    internal class DirectToDbApplierAccessor : DirectToDbApplier
    {
        public DirectToDbApplierAccessor(
            QueryExecuter queryExecuter, 
            DatabaseSchemaVersionManager schemaVersionManager, 
            QueryStatementSplitter splitter, 
            TextWriter infoTextWriter) 
            : base(queryExecuter, schemaVersionManager, splitter, infoTextWriter)
        {
        }
        
        public new void ApplyChangeScript(ChangeScript script, StringBuilder output)
        {
            base.ApplyChangeScript(script, output);
        }

        public new void RecordScriptStatus(ChangeScript changeScript, ScriptStatus status, string output)
        {
            base.RecordScriptStatus(changeScript, status, output);
        }
    }
}
