//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthWindSystem.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class VersionDDLEventLog
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> EventTime { get; set; }
        public string EventType { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string SchemaName { get; set; }
        public string ObjectType { get; set; }
        public string ObjectName { get; set; }
        public string UserName { get; set; }
        public string CommandText { get; set; }
        public string XmlEvent { get; set; }
    }
}