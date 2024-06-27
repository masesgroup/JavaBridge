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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region FeatureDescriptor
    public partial class FeatureDescriptor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#getDisplayName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setDisplayName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String DisplayName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setDisplayName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#getShortDescription()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setShortDescription(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ShortDescription
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getShortDescription", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setShortDescription", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#isExpert()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsExpert()
        {
            return IExecuteWithSignature<bool>("isExpert", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#isHidden()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHidden()
        {
            return IExecuteWithSignature<bool>("isHidden", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#isPreferred()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPreferred()
        {
            return IExecuteWithSignature<bool>("isPreferred", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getValue", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#attributeNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Lang.String> AttributeNames()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>("attributeNames", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setExpert(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetExpert(bool arg0)
        {
            IExecuteWithSignature("setExpert", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setHidden(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetHidden(bool arg0)
        {
            IExecuteWithSignature("setHidden", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setPreferred(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPreferred(bool arg0)
        {
            IExecuteWithSignature("setPreferred", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetValue(Java.Lang.String arg0, object arg1)
        {
            IExecute("setValue", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}