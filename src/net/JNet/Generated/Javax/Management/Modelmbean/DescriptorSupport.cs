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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Modelmbean
{
    #region DescriptorSupport
    public partial class DescriptorSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public DescriptorSupport(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public DescriptorSupport(params string[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.Modelmbean.XMLParseException"/>
        public DescriptorSupport(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#%3Cinit%3E(javax.management.modelmbean.DescriptorSupport)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Modelmbean.DescriptorSupport"/></param>
        public DescriptorSupport(Javax.Management.Modelmbean.DescriptorSupport arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.DescriptorSupport"/> to <see cref="Javax.Management.Descriptor"/>
        /// </summary>
        public static implicit operator Javax.Management.Descriptor(Javax.Management.Modelmbean.DescriptorSupport t) => t.Cast<Javax.Management.Descriptor>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#getFieldNames()"/> 
        /// </summary>
        public string[] FieldNames
        {
            get { return IExecuteArray<string>("getFieldNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#getFields()"/> 
        /// </summary>
        public string[] Fields
        {
            get { return IExecuteArray<string>("getFields"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#isValid()"/> 
        /// </summary>
        public bool IsValid
        {
            get { return IExecute<bool>("isValid"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#toXMLString()"/> 
        /// </summary>
        public string ToXMLString
        {
            get { return IExecute<string>("toXMLString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#getFieldValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public object GetFieldValue(string arg0)
        {
            return IExecute("getFieldValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#getFieldValues(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] GetFieldValues(params string[] arg0)
        {
            if (arg0.Length == 0) return IExecuteArray<object>("getFieldValues"); else return IExecuteArray<object>("getFieldValues", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#removeField(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void RemoveField(string arg0)
        {
            IExecute("removeField", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#setField(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetField(string arg0, object arg1)
        {
            IExecute("setField", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#setFields(java.lang.String[],java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetFields(string[] arg0, object[] arg1)
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