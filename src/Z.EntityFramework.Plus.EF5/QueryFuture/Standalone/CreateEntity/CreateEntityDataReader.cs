﻿// Description: EF Bulk Operations & Utilities | Bulk Insert, Update, Delete, Merge from database.
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.


#if STANDALONE && EF7
using System;
using System.Collections;
using System.Data;
using System.Data.Common;

namespace Z.EntityFramework.Plus
{
    internal class CreateEntityDataReader : DbDataReader
    {
        public CreateEntityDataReader(DbDataReader originalDataReader)
        {
            OriginalDataReader = originalDataReader;
        }

        private DbDataReader OriginalDataReader { get; }

        public override object this[string name]
        {
            get { return OriginalDataReader[name]; }
        }

        public override object this[int ordinal]
        {
            get { return OriginalDataReader[ordinal]; }
        }

        public override int Depth
        {
            get { return OriginalDataReader.Depth; }
        }

        public override int FieldCount
        {
            get { return OriginalDataReader.FieldCount; }
        }

        public override bool HasRows
        {
            get { return OriginalDataReader.HasRows; }
        }

        public override bool IsClosed
        {
            get { return OriginalDataReader.IsClosed; }
        }

        public override int RecordsAffected
        {
            get { return OriginalDataReader.RecordsAffected; }
        }

        public override void Close()
        {
            // DO NOT close reader
        }

        public override bool GetBoolean(int ordinal)
        {
            return OriginalDataReader.GetBoolean(ordinal);
        }

        public override byte GetByte(int ordinal)
        {
            return OriginalDataReader.GetByte(ordinal);
        }

        public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
        {
            return OriginalDataReader.GetBytes(ordinal, dataOffset, buffer, bufferOffset, length);
        }

        public override char GetChar(int ordinal)
        {
            return OriginalDataReader.GetChar(ordinal);
        }

        public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
        {
            return OriginalDataReader.GetChars(ordinal, dataOffset, buffer, bufferOffset, length);
        }

        public override string GetDataTypeName(int ordinal)
        {
            return OriginalDataReader.GetDataTypeName(ordinal);
        }

        public override DateTime GetDateTime(int ordinal)
        {
            return OriginalDataReader.GetDateTime(ordinal);
        }

        public override decimal GetDecimal(int ordinal)
        {
            return OriginalDataReader.GetDecimal(ordinal);
        }

        public override double GetDouble(int ordinal)
        {
            return OriginalDataReader.GetDouble(ordinal);
        }

        public override IEnumerator GetEnumerator()
        {
            return OriginalDataReader.GetEnumerator();
        }

        public override Type GetFieldType(int ordinal)
        {
            return OriginalDataReader.GetFieldType(ordinal);
        }

        public override float GetFloat(int ordinal)
        {
            return OriginalDataReader.GetFloat(ordinal);
        }

        public override Guid GetGuid(int ordinal)
        {
            return OriginalDataReader.GetGuid(ordinal);
        }

        public override short GetInt16(int ordinal)
        {
            return OriginalDataReader.GetInt16(ordinal);
        }

        public override int GetInt32(int ordinal)
        {
            return OriginalDataReader.GetInt32(ordinal);
        }

        public override long GetInt64(int ordinal)
        {
            return OriginalDataReader.GetInt64(ordinal);
        }

        public override string GetName(int ordinal)
        {
            return OriginalDataReader.GetName(ordinal);
        }

        public override int GetOrdinal(string name)
        {
            return OriginalDataReader.GetOrdinal(name);
        }

        public override DataTable GetSchemaTable()
        {
            return OriginalDataReader.GetSchemaTable();
        }

        public override string GetString(int ordinal)
        {
            return OriginalDataReader.GetString(ordinal);
        }

        public override object GetValue(int ordinal)
        {
            return OriginalDataReader.GetValue(ordinal);
        }

        public override int GetValues(object[] values)
        {
            return OriginalDataReader.GetValues(values);
        }

        public override bool IsDBNull(int ordinal)
        {
            return OriginalDataReader.IsDBNull(ordinal);
        }

        public override bool NextResult()
        {
            return OriginalDataReader.NextResult();
        }

        public override bool Read()
        {
            return OriginalDataReader.Read();
        }
    }
}

#endif