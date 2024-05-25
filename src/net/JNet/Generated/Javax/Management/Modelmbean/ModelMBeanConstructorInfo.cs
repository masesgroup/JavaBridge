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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Modelmbean
{
    #region ModelMBeanConstructorInfo
    public partial class ModelMBeanConstructorInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanConstructorInfo.html#%3Cinit%3E(java.lang.String,java.lang.reflect.Constructor,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Constructor"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Descriptor"/></param>
        public ModelMBeanConstructorInfo(Java.Lang.String arg0, Java.Lang.Reflect.Constructor<object> arg1, Javax.Management.Descriptor arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanConstructorInfo.html#%3Cinit%3E(java.lang.String,java.lang.reflect.Constructor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Constructor"/></param>
        public ModelMBeanConstructorInfo(Java.Lang.String arg0, Java.Lang.Reflect.Constructor<object> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanConstructorInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.MBeanParameterInfo[],javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanParameterInfo"/></param>
        /// <param name="arg3"><see cref="Javax.Management.Descriptor"/></param>
        public ModelMBeanConstructorInfo(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Management.MBeanParameterInfo[] arg2, Javax.Management.Descriptor arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanConstructorInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.MBeanParameterInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanParameterInfo"/></param>
        public ModelMBeanConstructorInfo(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Management.MBeanParameterInfo[] arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.ModelMBeanConstructorInfo"/> to <see cref="Javax.Management.DescriptorAccess"/>
        /// </summary>
        public static implicit operator Javax.Management.DescriptorAccess(Javax.Management.Modelmbean.ModelMBeanConstructorInfo t) => t.Cast<Javax.Management.DescriptorAccess>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanConstructorInfo.html#setDescriptor(javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Descriptor"/></param>
        public void SetDescriptor(Javax.Management.Descriptor arg0)
        {
            IExecuteWithSignature("setDescriptor", "(Ljavax/management/Descriptor;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}