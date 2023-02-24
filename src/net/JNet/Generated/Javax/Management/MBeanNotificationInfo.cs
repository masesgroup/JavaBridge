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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region MBeanNotificationInfo
    public partial class MBeanNotificationInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanNotificationInfo.html#%3Cinit%3E(java.lang.String[],java.lang.String,java.lang.String,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <param name="arg2"><see langword="string"/></param>
        /// <param name="arg3"><see cref="Javax.Management.Descriptor"/></param>
        public MBeanNotificationInfo(string[] arg0, string arg1, string arg2, Javax.Management.Descriptor arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanNotificationInfo.html#%3Cinit%3E(java.lang.String[],java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <param name="arg2"><see langword="string"/></param>
        public MBeanNotificationInfo(string[] arg0, string arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanNotificationInfo"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Management.MBeanNotificationInfo t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanNotificationInfo.html#getNotifTypes()"/> 
        /// </summary>
        public string[] NotifTypes
        {
            get { return IExecuteArray<string>("getNotifTypes"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}