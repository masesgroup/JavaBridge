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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region OpenMBeanParameterInfoSupport
    public partial class OpenMBeanParameterInfoSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenType,java.lang.Object,java.lang.Comparable,java.lang.Comparable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Comparable"/></param>
        /// <param name="arg5"><see cref="Java.Lang.Comparable"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public OpenMBeanParameterInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenType arg2, object arg3, Java.Lang.Comparable arg4, Java.Lang.Comparable arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenType,java.lang.Object,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public OpenMBeanParameterInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenType arg2, object arg3, object[] arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public OpenMBeanParameterInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenType arg2, object arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenType,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg3"><see cref="Javax.Management.Descriptor"/></param>
        public OpenMBeanParameterInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenType<object> arg2, Javax.Management.Descriptor arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        public OpenMBeanParameterInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenType<object> arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.OpenMBeanParameterInfoSupport"/> to <see cref="Javax.Management.Openmbean.OpenMBeanParameterInfo"/>
        /// </summary>
        public static implicit operator Javax.Management.Openmbean.OpenMBeanParameterInfo(Javax.Management.Openmbean.OpenMBeanParameterInfoSupport t) => t.Cast<Javax.Management.Openmbean.OpenMBeanParameterInfo>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#getDefaultValue()"/> 
        /// </summary>
        public object DefaultValue
        {
            get { return IExecute("getDefaultValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#getLegalValues()"/> 
        /// </summary>
        public Java.Util.Set<object> LegalValues
        {
            get { return IExecute<Java.Util.Set<object>>("getLegalValues"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#getMaxValue()"/> 
        /// </summary>
        public Java.Lang.Comparable<object> MaxValue
        {
            get { return IExecute<Java.Lang.Comparable<object>>("getMaxValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#getMinValue()"/> 
        /// </summary>
        public Java.Lang.Comparable<object> MinValue
        {
            get { return IExecute<Java.Lang.Comparable<object>>("getMinValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#getOpenType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.OpenType<object> OpenType
        {
            get { return IExecute<Javax.Management.Openmbean.OpenType<object>>("getOpenType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#hasDefaultValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasDefaultValue()
        {
            return IExecute<bool>("hasDefaultValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#hasLegalValues()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasLegalValues()
        {
            return IExecute<bool>("hasLegalValues");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#hasMaxValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasMaxValue()
        {
            return IExecute<bool>("hasMaxValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#hasMinValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasMinValue()
        {
            return IExecute<bool>("hasMinValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#isValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValue(object arg0)
        {
            return IExecute<bool>("isValue", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}