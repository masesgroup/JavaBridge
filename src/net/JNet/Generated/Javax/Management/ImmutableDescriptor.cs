/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region ImmutableDescriptor
    public partial class ImmutableDescriptor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public ImmutableDescriptor(params Java.Lang.String[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public ImmutableDescriptor(Java.Util.Map<Java.Lang.String, object> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#EMPTY_DESCRIPTOR"/>
        /// </summary>
        public static Javax.Management.ImmutableDescriptor EMPTY_DESCRIPTOR { get { if (!_EMPTY_DESCRIPTORReady) { _EMPTY_DESCRIPTORContent = SGetField<Javax.Management.ImmutableDescriptor>(LocalBridgeClazz, "EMPTY_DESCRIPTOR"); _EMPTY_DESCRIPTORReady = true; } return _EMPTY_DESCRIPTORContent; } }
        private static Javax.Management.ImmutableDescriptor _EMPTY_DESCRIPTORContent = default;
        private static bool _EMPTY_DESCRIPTORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#union(javax.management.Descriptor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Descriptor"/></param>
        /// <returns><see cref="Javax.Management.ImmutableDescriptor"/></returns>
        public static Javax.Management.ImmutableDescriptor Union(params Javax.Management.Descriptor[] arg0)
        {
            if (arg0.Length == 0) return SExecuteWithSignature<Javax.Management.ImmutableDescriptor>(LocalBridgeClazz, "union", "([Ljavax/management/Descriptor;)Ljavax/management/ImmutableDescriptor;"); else return SExecuteWithSignature<Javax.Management.ImmutableDescriptor>(LocalBridgeClazz, "union", "([Ljavax/management/Descriptor;)Ljavax/management/ImmutableDescriptor;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#getFieldNames()"/> 
        /// </summary>
        public Java.Lang.String[] FieldNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getFieldNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#getFields()"/> 
        /// </summary>
        public Java.Lang.String[] Fields
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getFields", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#isValid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecuteWithSignature<bool>("isValid", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#getFieldValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetFieldValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getFieldValue", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#getFieldValues(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] GetFieldValues(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignatureArray<object>("getFieldValues", "([Ljava/lang/String;)[Ljava/lang/Object;"); else return IExecuteWithSignatureArray<object>("getFieldValues", "([Ljava/lang/String;)[Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#removeField(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveField(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeField", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#setField(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetField(Java.Lang.String arg0, object arg1)
        {
            IExecute("setField", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ImmutableDescriptor.html#setFields(java.lang.String[],java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetFields(Java.Lang.String[] arg0, object[] arg1)
        {
            IExecute("setFields", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}