/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Instrument
{
    #region IClassFileTransformer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IClassFileTransformer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/ClassFileTransformer.html#transform(java.lang.ClassLoader,java.lang.String,java.lang.Class,java.security.ProtectionDomain,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Security.ProtectionDomain"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.Instrument.IllegalClassFormatException"/>
        byte[] Transform(Java.Lang.ClassLoader arg0, string arg1, Java.Lang.Class arg2, Java.Security.ProtectionDomain arg3, byte[] arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/ClassFileTransformer.html#transform(java.lang.Module,java.lang.ClassLoader,java.lang.String,java.lang.Class,java.security.ProtectionDomain,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg4"><see cref="Java.Security.ProtectionDomain"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.Instrument.IllegalClassFormatException"/>
        byte[] Transform(Java.Lang.Module arg0, Java.Lang.ClassLoader arg1, string arg2, Java.Lang.Class arg3, Java.Security.ProtectionDomain arg4, byte[] arg5);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ClassFileTransformer
    public partial class ClassFileTransformer : Java.Lang.Instrument.IClassFileTransformer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/ClassFileTransformer.html#transform(java.lang.ClassLoader,java.lang.String,java.lang.Class,java.security.ProtectionDomain,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Security.ProtectionDomain"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.Instrument.IllegalClassFormatException"/>
        public byte[] Transform(Java.Lang.ClassLoader arg0, string arg1, Java.Lang.Class arg2, Java.Security.ProtectionDomain arg3, byte[] arg4)
        {
            return IExecuteArray<byte>("transform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/ClassFileTransformer.html#transform(java.lang.Module,java.lang.ClassLoader,java.lang.String,java.lang.Class,java.security.ProtectionDomain,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg4"><see cref="Java.Security.ProtectionDomain"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.Instrument.IllegalClassFormatException"/>
        public byte[] Transform(Java.Lang.Module arg0, Java.Lang.ClassLoader arg1, string arg2, Java.Lang.Class arg3, Java.Security.ProtectionDomain arg4, byte[] arg5)
        {
            return IExecuteArray<byte>("transform", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}